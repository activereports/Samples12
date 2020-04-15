using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Design;
using System.IO;
using GrapeCity.ActiveReports.Design;
using GrapeCity.ActiveReports.Design.Resources;
using System.ComponentModel.Design;
using GrapeCity.ActiveReports.PageReportModel;
using System.Xml.Linq;
using System.Linq;
using GrapeCity.ActiveReports.Export.Pdf.Page;
using GrapeCity.ActiveReports.Rendering.IO;
namespace GrapeCity.ActiveReports.Samples.Layer
{
	public partial class ReportsForm : Form
	{
		ToolStripDropDownItem _fileMenu;
		ToolStripMenuItem _exportMenuItem;
		ToolStripButton _exportButton;
		string _reportName;
		static readonly string FolderPath = "";
		static readonly List<string> ExcludeFilesList = new List<string>();
		static readonly List<string> ExcludeFoldersList = new List<string>();
		ToolStrip _item ;
		public ReportsForm()
		{
			InitializeComponent();
			//Set the ToolBox, ReportExplorer and PropertyGrid in the Designer.
			reportDesigner.Toolbox = reportToolbox;//Attaches the toolbox to the report designer
			reportExplorer.ReportDesigner = reportDesigner;//Attaches the report explorer to the report designer
			reportDesigner.LayoutChanged += new LayoutChangedEventHandler(OnLayoutChanged);
			layerList.ReportDesigner = reportDesigner;
			groupEditor.ReportDesigner = reportDesigner;
			reportsLibrary.ReportDesigner = reportDesigner;
			reportDesigner.PropertyGrid = reportPropertyGrid;//Attaches the Property Grid to the report designer
			//Populate the menu.
			ToolStrip toolstrip = reportDesigner.CreateToolStrips(new DesignerToolStrips[]
				{
					DesignerToolStrips.Menu
				})[0];
			_fileMenu = (ToolStripDropDownItem)toolstrip.Items[0];
			CreateFileMenu(_fileMenu);
			
			AppendToolStrips(0, new ToolStrip[]
				{
					toolstrip
				});
			AppendToolStrips(1, reportDesigner.CreateToolStrips(new DesignerToolStrips[]
				{
					DesignerToolStrips.Edit, 
					DesignerToolStrips.Undo, 
					DesignerToolStrips.Zoom
				}));
			_item = CreateReportToolbar();
			AppendToolStrips(1, new ToolStrip[]
				{
					_item
				});
			AppendToolStrips(2, reportDesigner.CreateToolStrips(new DesignerToolStrips[]
				{
					DesignerToolStrips.Format, 
					DesignerToolStrips.Layout
				}));
			
			LoadTools(reportToolbox);
			RefreshExportEnabled();
			CreateReportExplorer();
		}
		//Load Settings from Config File
		static ReportsForm()
		{
			XDocument loaded = XDocument.Load("TreeList.config");
			FolderPath = loaded.Descendants("FolderPath").Select(t => t.Value.ToString()).ToList()[0];
			DirectoryInfo reportbasefolder = new DirectoryInfo(FolderPath);
			ExcludeFilesList = loaded.Descendants("ExcludeFiles").ToList()[0].Descendants("File").Select(t => reportbasefolder.FullName + "\\" + t.Value.ToString()).ToList<string>();
			ExcludeFoldersList = loaded.Descendants("ExcludeFolders").ToList()[0].Descendants("Folder").Select(t => reportbasefolder.FullName + "\\" + t.Value.ToString()).ToList<string>();
		}
		private void OnLayoutChanged(object sender, LayoutChangedArgs e)
		{
			if (e.Type == LayoutChangeType.ReportLoad || e.Type == LayoutChangeType.ReportClear)
			{
			   reportToolbox.Reorder(reportDesigner);
			   reportToolbox.EnsureCategories();
			   reportToolbox.Refresh();
			   RefreshExportEnabled();
			   CreateReportExplorer();			   
			}
			if(e.Type==LayoutChangeType.ReportClear)
			{
				_reportName = null;
			}
			if(e.Type==LayoutChangeType.ReportLoad)
			{
				if (!string.IsNullOrEmpty(_reportName))
				{
					if (GetIsMaster())
					{
						_reportName = null;
					}
				}
			}
		}
		private void RefreshExportEnabled()
		{
			reportDesigner.ActiveTabChanged -= OnEnableExport;
			reportDesigner.ActiveTabChanged += OnEnableExport;
			OnEnableExport(this, EventArgs.Empty);
		}
		private void OnEnableExport(object sender, EventArgs eventArgs)
		{
			if (reportDesigner.ReportType != DesignerReportType.Section)
			{
				if (_exportMenuItem != null)
					_exportMenuItem.Enabled = reportDesigner.ActiveTab == DesignerTab.Preview;
				if (_exportButton != null)
					_exportButton.Enabled = reportDesigner.ActiveTab == DesignerTab.Preview;
			}
		}
		private static void LoadTools(IToolboxService toolbox)
		{
			//Add Data Providers.
			foreach (Type type in new Type[]
				{
					typeof (System.Data.DataSet),
					typeof (System.Data.DataView),
					typeof (System.Data.OleDb.OleDbConnection),
					typeof (System.Data.OleDb.OleDbDataAdapter),
					typeof (System.Data.Odbc.OdbcConnection),
					typeof (System.Data.Odbc.OdbcDataAdapter),
					typeof (System.Data.SqlClient.SqlConnection),
					typeof (System.Data.SqlClient.SqlDataAdapter)
				})
			{
				toolbox.AddToolboxItem(new ToolboxItem(type), Properties.Resources.ToolBoxData);
			}
		}
		//Adding DropDownItems to the ToolStripDropDownItem.
		private void CreateFileMenu(ToolStripDropDownItem fileMenu)
		{
			fileMenu.DropDownItems.Clear();
			fileMenu.DropDownItems.Add(new ToolStripMenuItem(Properties.Resources.NewText, Properties.Resources.CmdNewReport, new EventHandler(OnNew), (Keys.Control | Keys.N)));
			fileMenu.DropDownItems.Add(new ToolStripMenuItem(Properties.Resources.OpenText, Properties.Resources.CmdOpen, new EventHandler(OnOpen), (Keys.Control | Keys.O)));
			_exportMenuItem = new ToolStripMenuItem(Properties.Resources.ExportText, null, new EventHandler(OnExport), (Keys.Control | Keys.E));
			_exportMenuItem.Enabled = false;
			fileMenu.DropDownItems.Add(_exportMenuItem);
			fileMenu.DropDownItems.Add(new ToolStripMenuItem(Properties.Resources.SaveText, Properties.Resources.CmdSave, new EventHandler(OnSave), (Keys.Control | Keys.S)));
			fileMenu.DropDownItems.Add(new ToolStripMenuItem(Properties.Resources.SaveAsText, Properties.Resources.CmdSaveAs, new EventHandler(OnSaveAs)));
			fileMenu.DropDownItems.Add(new ToolStripSeparator());
			fileMenu.DropDownItems.Add(new ToolStripMenuItem(Properties.Resources.ExitText, null, new EventHandler(OnExit)));
			
		}
		private ToolStrip CreateReportToolbar()
		{
			_exportButton = CreateToolStripButton(Properties.Resources.ExportText, null, new EventHandler(OnExport), Properties.Resources.ExportText, ToolStripItemDisplayStyle.Text);
			_exportButton.Enabled = false;
			return new ToolStrip(new ToolStripButton[]
			{ 
				CreateToolStripButton(Properties.Resources.NewText,Properties.Resources.CmdNewReport,new EventHandler(OnNew),Properties.Resources.NewText,ToolStripItemDisplayStyle.Image),
				CreateToolStripButton(Properties.Resources.OpenText,Properties.Resources.CmdOpen,new EventHandler(OnOpen),Properties.Resources.OpenText,ToolStripItemDisplayStyle.Image),
				CreateToolStripButton(Properties.Resources.SaveText,Properties.Resources.CmdSave,new EventHandler(OnSave),Properties.Resources.SaveText,ToolStripItemDisplayStyle.Image),
				_exportButton
			});
		}
		private bool PerformSave()
		{
			if (string.IsNullOrEmpty(_reportName) || string.IsNullOrEmpty(Path.GetDirectoryName(_reportName)) || !File.Exists(_reportName))
			{
				return PerformSaveAs();
			}
			reportDesigner.SaveReport(new FileInfo(_reportName));
			return true;
		}
		private bool PerformSaveAs()
		{
			using (SaveFileDialog dlg = new SaveFileDialog())
			{
				dlg.Filter = GetSaveFilter(reportDesigner.ReportType, GetIsMaster());
				
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					_reportName = dlg.FileName;
					reportDesigner.SaveReport(new FileInfo(dlg.FileName));
					return true;
				}
			}
			return false;
		}
		private bool GetIsMaster()
		{
			bool isMaster = false;
			if (reportDesigner.ReportType == DesignerReportType.Rdl)
			{
				var report = (Component)reportDesigner.Report;
				var site = report == null ? null : report.Site;
				if (site != null)
				{
					var host = site.GetService(typeof(IDesignerHost)) as IDesignerHost;
					if (host != null)
					{
						var mcs = host.GetService(typeof(IMasterContentService)) as IMasterContentService;
						isMaster = mcs != null && mcs.IsMaster;
					}
				}
			}
			return isMaster;
		}
	  
		private string GetSaveFilter(DesignerReportType type, bool isMaster)
		{
			switch (type)
			{   
				case DesignerReportType.Section:
					return Properties.Resources.SectionReportFilter;
				case DesignerReportType.Page:
					return Properties.Resources.PageReportFilter;
				case DesignerReportType.Rdl:
					return isMaster ? Properties.Resources.RDLReportFilterMaster : Properties.Resources.RDLReportFilter;
				default:
					return Properties.Resources.SectionReportFilter;
			}
		}
	  
		//Click "New" to open a new report.
		private void OnNew(object sender, EventArgs e)
		{
			if (ConfirmSaveChanges())
			{
				reportDesigner.ExecuteAction(DesignerAction.NewReport);
				EnableTabs();	
			}
		}
		//Click "Open" to open an existing report.
		private void OnOpen(object sender, EventArgs e)
		{
			if (!ConfirmSaveChanges())
			{
				return;
			}
			using (OpenFileDialog dlg = new OpenFileDialog())
			{
				dlg.Filter = Properties.Resources.OpenFileFilter;
			  
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					_reportName = dlg.FileName;
					reportDesigner.LoadReport(new FileInfo(dlg.FileName));
					EnableTabs();
				}
			}
		}
		private void OnExport(object sender, EventArgs e)
		{
			if (((PageReport)reportDesigner.Report).Document != null)
			{
				Settings settings = new Settings();
				settings.HideToolbar = true;
				settings.HideMenubar = true;
				settings.HideWindowUI = true;
				saveFileDialog.Filter = Properties.Resources.PDFFilter;
				PdfRenderingExtension _renderingExtension = new PdfRenderingExtension();
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					if (File.Exists(saveFileDialog.FileName))
					{
						File.Delete(saveFileDialog.FileName);
					}
					FileStreamProvider _exportfile = new FileStreamProvider(new DirectoryInfo(Path.GetDirectoryName(saveFileDialog.FileName)), Path.GetFileNameWithoutExtension(saveFileDialog.FileName));
					((PageReport)reportDesigner.Report).Document.Render(_renderingExtension, _exportfile, settings);
					MessageBox.Show(Properties.Resources.ExportCompleteString);
				}
			}
		}
		//Click "Save" to save a report.
		private void OnSave(object sender, EventArgs e)
		{
			PerformSave();
		}
		//Click "Save as" to save a report with a name.
		private void OnSaveAs(object sender, EventArgs e)
		{
			PerformSaveAs();
		}
		private void OnExit(object sender, EventArgs e)
		{
			Close();
		}
		//Checking whether modifications have been made to the report loaded to the designer.
		private bool ConfirmSaveChanges()
		{
			if (reportDesigner.IsDirty)
			{
				DialogResult dialogresult = MessageBox.Show(Properties.Resources.ReportDirtyMessage, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (dialogresult == DialogResult.Cancel)
				{
					return false;
				}
				if (dialogresult == DialogResult.Yes)
				{
					return PerformSave();
				}
			}
			return true;
		}
	   
		private void AppendToolStrips(int row, IList<ToolStrip> toolStrips)
		{
			ToolStripPanel topToolStripPanel = this.toolStripContainer.TopToolStripPanel;
			int num = toolStrips.Count;
			while (--num >= 0)
			{
				topToolStripPanel.Join(toolStrips[num], row);
			}
		}
		private static ToolStripButton CreateToolStripButton(string text, System.Drawing.Image image, EventHandler handler, string toolTip,ToolStripItemDisplayStyle toolStripDisplayStyle)
		{
			return new ToolStripButton(text, image, handler)
			{
				DisplayStyle = toolStripDisplayStyle,
				ToolTipText = toolTip,
				DoubleClickEnabled = true,
				Text=text
			};
		}
		// Add nodes to tree view
		private void ListDirectory(TreeView treeView, string path)
		{
			treeView.Nodes.Clear();
			var rootDirectoryInfo = new DirectoryInfo(path);
			foreach (var directory in rootDirectoryInfo.GetDirectories())
			{
				treeView.Nodes.Add(CreateDirectoryNode(directory));
			}
		}
		// Traverse Samples Folder and create tree
		private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
		{
			var directoryNode = new TreeNode(directoryInfo.Name);
			foreach (var directory in directoryInfo.GetDirectories())
			{
				if (!ExcludeFoldersList.Exists(t => t.ToString() == directory.FullName))
				{
					directoryNode.Nodes.Add(CreateDirectoryNode(directory));
				}
			}
			foreach (var file in directoryInfo.GetFiles("*.rpx").Concat(directoryInfo.GetFiles("*.rdlx")))
			{
				if (!ExcludeFilesList.Exists(t => t.ToString() == file.FullName))
				{
					TreeNode reportFileNode = new TreeNode(file.Name);
					reportFileNode.ImageIndex = 2;
					reportFileNode.SelectedImageIndex = 2;
					reportFileNode.ForeColor = Color.Brown;
					reportFileNode.Tag = file.FullName;
					directoryNode.Nodes.Add(reportFileNode);
				}
			}
			return directoryNode;
		}
		private void CreateReportExplorer()
		{
			if (reportDesigner.ReportType == DesignerReportType.Section)
			{
				if (explorerPropertyGridContainer.Panel1.Controls.Contains(reportExplorerTabControl))
				{
					reportExplorerTabControl.TabPages[0].SuspendLayout();
					explorerPropertyGridContainer.Panel1.SuspendLayout();
					explorerPropertyGridContainer.Panel1.Controls.Remove(reportExplorerTabControl);
					explorerPropertyGridContainer.Panel1.Controls.Add(reportExplorer);
					reportExplorerTabControl.TabPages[0].ResumeLayout();
					explorerPropertyGridContainer.Panel1.ResumeLayout();
				}
			}
			else if (!explorerPropertyGridContainer.Panel1.Controls.Contains(reportExplorerTabControl))
			{
				reportExplorerTabControl.TabPages[0].SuspendLayout();
				explorerPropertyGridContainer.Panel1.SuspendLayout();
				explorerPropertyGridContainer.Panel1.Controls.Remove(reportExplorer);
				reportExplorerTabControl.TabPages[0].Controls.Add(reportExplorer);
				explorerPropertyGridContainer.Panel1.Controls.Add(reportExplorerTabControl);
				reportExplorerTabControl.TabPages[0].ResumeLayout();
				explorerPropertyGridContainer.Panel1.ResumeLayout();
			}
		}
		private void EnableTabs()
		{
			reportToolbox.Reorder(reportDesigner);
			reportToolbox.EnsureCategories();
			reportToolbox.Refresh();
		}
		private void ReportsForm_Load(object sender, EventArgs e)
		{
			
			treeView.Font = new Font("Arial", 10, FontStyle.Bold);
			
			
			if (!string.IsNullOrEmpty(FolderPath))
			{
				ListDirectory(treeView, FolderPath);
			}
		}
		// Handle Tree View collapse.
		private void treeView_AfterCollapse(object sender, TreeViewEventArgs e)
		{
			e.Node.ImageIndex = 0;
			e.Node.SelectedImageIndex = 0;
		}
		//Handle expansion of Tree View
		private void treeView_AfterExpand(object sender, TreeViewEventArgs e)
		{
			e.Node.ImageIndex = 1;
			e.Node.SelectedImageIndex = 1;
		}
		//Handle click on Tree Node
		private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if ((e.Node.Text.ToLower().EndsWith(".rdlx")) || (e.Node.Text.ToLower().EndsWith(".rpx")))
			{
				e.Node.ImageIndex = 2;
				treeView.SelectedNode = e.Node;
				FileInfo reportFile = new FileInfo(e.Node.Tag.ToString());
				reportDesigner.LoadReport(reportFile);
			}
			else
			{
				if (e.Node.Parent != null)
				{
					MessageBox.Show(Properties.Resources.InvalidFileText);
				}
			}
		}
	}
}
