using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Design;
using System.IO;
using GrapeCity.ActiveReports.Design;
using GrapeCity.ActiveReports.Design.Resources;
using System.Xml.Linq;
using System.Linq;
using System.Collections;
using System.Xml;
namespace GrapeCity.ActiveReports.Samples.MapGallery
{
	public partial class ReportsForm : Form
	{
		static readonly string FolderPath = "";
		static readonly List<string> ExcludeFilesList = new List<string>();
		static readonly List<string> ExcludeFoldersList = new List<string>();
	   
		public ReportsForm()
		{
			InitializeComponent();
			reportDesigner.NewReport(DesignerReportType.Page);
			//Populate the ToolBox, ReportExplorer and PropertyGrid
			reportDesigner.Toolbox = reportToolbox;//Attach the Toolbox to the report designer
			reportExplorer.ReportDesigner = reportDesigner;//Attach the Report Explorer to the report designer
			reportDesigner.PropertyGrid = reportPropertyGrid;//Attach the Property Grid to the report designer
			layerList.ReportDesigner = reportDesigner;
			reportsLibrary.ReportDesigner = reportDesigner;
			groupEditor.ReportDesigner = reportDesigner;
			CreateReportExplorer();
			//Create a toolstrip to be used as a menu.
			ToolStrip toolstrip = reportDesigner.CreateToolStrips(new DesignerToolStrips[]
				{
					DesignerToolStrips.Menu
				})[0];
			ToolStripDropDownItem fileMenu = (ToolStripDropDownItem)toolstrip.Items[0];
			CreateFileMenu(fileMenu);
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
			AppendToolStrips(1, new ToolStrip[]
				{
					CreateReportToolbar()
				});
			AppendToolStrips(2, reportDesigner.CreateToolStrips(new DesignerToolStrips[]
				{
					DesignerToolStrips.Format, 
					DesignerToolStrips.Layout
				}));
			LoadTools(reportToolbox);
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
		//Adding DropDownItems to the ToolStripDropDownItem
		private void CreateFileMenu(ToolStripDropDownItem fileMenu)
		{
			fileMenu.DropDownItems.Clear();
			fileMenu.DropDownItems.Add(new ToolStripMenuItem(Properties.Resources.NewText, Properties.Resources.CmdNewReport, new EventHandler(OnNew), (Keys.Control | Keys.N)));
			fileMenu.DropDownItems.Add(new ToolStripMenuItem(Properties.Resources.OpenText, Properties.Resources.CmdOpen, new EventHandler(OnOpen), (Keys.Control | Keys.O)));
			fileMenu.DropDownItems.Add(new ToolStripMenuItem(Properties.Resources.SaveText, Properties.Resources.CmdSave, new EventHandler(OnSave), (Keys.Control | Keys.S)));
			fileMenu.DropDownItems.Add(new ToolStripMenuItem(Properties.Resources.SaveAsText, Properties.Resources.CmdSaveAs, new EventHandler(OnSaveAs)));
			fileMenu.DropDownItems.Add(new ToolStripSeparator());
			fileMenu.DropDownItems.Add(new ToolStripMenuItem(Properties.Resources.ExitText, null, new EventHandler(OnExit)));
		}
		private ToolStrip CreateReportToolbar()
		{
			return new ToolStrip(new ToolStripButton[]
			{
				 CreateToolStripButton(Properties.Resources.NewText,Properties.Resources.CmdNewReport,new EventHandler(OnNew),Properties.Resources.NewText),
				 CreateToolStripButton(Properties.Resources.OpenText,Properties.Resources.CmdOpen,new EventHandler(OnOpen),Properties.Resources.OpenText),
				 CreateToolStripButton(Properties.Resources.SaveText,Properties.Resources.CmdSave,new EventHandler(OnSave),Properties.Resources.SaveText)
			});
		}
		//Click the "New" button to open a new report.
		private void OnNew(object sender, EventArgs e)
		{
			if (ConfirmSaveChanges())
			{
				reportDesigner.ExecuteAction(DesignerAction.NewReport);
			}
		}
		//Click the "Open" button to open an existing report.
		private void OnOpen(object sender, EventArgs e)
		{
			if (ConfirmSaveChanges())
			{
				reportDesigner.ExecuteAction(DesignerAction.FileOpen);
			}
		}
		//Click the "Save" button to save your report.
		private void OnSave(object sender, EventArgs e)
		{
			reportDesigner.ExecuteAction(DesignerAction.FileSave);
		}
		//Click the "Save As" button to open the Save As dialog.
		private void OnSaveAs(object sender, EventArgs e)
		{
			reportDesigner.ExecuteAction(DesignerAction.FileSave);
		}
		private void OnExit(object sender, EventArgs e)
		{
			Close();
		}
		//Check whether modifications have been made to the report loaded in the designer
		private bool ConfirmSaveChanges()
		{
			if (reportDesigner.IsDirty)
			{
				DialogResult result = MessageBox.Show(Properties.Resources.ReportDirtyMessage, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (result == DialogResult.Cancel)
				{
					return false;
				}
				if (result == DialogResult.Yes)
				{
					reportDesigner.ExecuteAction(DesignerAction.FileSave);
				}
			}
			return true; 
		}
		// Append toolstrips to the ToolStrip Panel
		private void AppendToolStrips(int row, IList<ToolStrip> toolStrips)
		{
			ToolStripPanel topToolStripPanel = toolStripContainer.TopToolStripPanel;
			int num = toolStrips.Count;
			while (--num >= 0)
			{
				topToolStripPanel.Join(toolStrips[num], row);
			}
		}
		// Create a ToolStrip Button
		private static ToolStripButton CreateToolStripButton(string text, Image image, EventHandler handler, string toolTip)
		{
			return new ToolStripButton(text, image, handler)
			{
				DisplayStyle = ToolStripItemDisplayStyle.Image,
				ToolTipText = toolTip,
				DoubleClickEnabled = true
			};
		}
		//Load Settings from Config File
		static ReportsForm()
		{
			XDocument loaded = XDocument.Load("MapGallery.config");
			FolderPath = loaded.Descendants("FolderPath").Select(t => t.Value.ToString()).ToList()[0];
			DirectoryInfo reportbasefolder = new DirectoryInfo(FolderPath);
			ExcludeFilesList = loaded.Descendants("ExcludeFiles").ToList()[0].Descendants("File").Select(t => reportbasefolder.FullName + "\\" + t.Value.ToString()).ToList<string>();
			ExcludeFoldersList = loaded.Descendants("ExcludeFolders").ToList()[0].Descendants("Folder").Select(t => reportbasefolder.FullName + "\\" + t.Value.ToString()).ToList<string>();
		}
		
		// Form Load Event
		private void ReportsForm_Load(object sender, EventArgs e)
		{
			
			treeView.Font = new Font("Arial", 10, FontStyle.Bold);
			
			
			if (!string.IsNullOrEmpty(FolderPath))
			{
				ListDirectory(treeView, FolderPath);
			}
			FolderLocalization();
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
		//Folder Localization
		private void FolderLocalization()
		{
			Hashtable strReplace = new Hashtable();
			StreamReader reader = new StreamReader(new FileStream(@"..\..\MapGallery.config", FileMode.Open, FileAccess.Read, FileShare.Read));
			XmlDocument doc = new XmlDocument();
			string xmlIn = reader.ReadToEnd();
			reader.Close();
			doc.LoadXml(xmlIn);
			foreach (XmlNode child in doc.ChildNodes[1].ChildNodes)
				if (child.Name.Equals("Localization"))
					foreach (XmlNode node in child.ChildNodes)
						if (node.Name.Equals("ReplaceName"))
							strReplace.Add
							(
								node.Attributes["OriginalName"].Value,
								node.Attributes["ReplaceWith"].Value
							);
			for (int i = 0; i < treeView.Nodes.Count; i++)
			{
				foreach (DictionaryEntry entry in strReplace)
				{
					if (treeView.Nodes[i].Text.Equals(entry.Key.ToString()))
					{
						treeView.Nodes[i].Text = entry.Value.ToString();
					}
				}
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
		private void reportdesigner_LayoutChanged(object sender, LayoutChangedArgs e)
		{
			CreateReportExplorer();
		}
	}
}
