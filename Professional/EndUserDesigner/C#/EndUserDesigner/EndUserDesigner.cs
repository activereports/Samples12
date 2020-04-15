using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing.Design;
using System.IO;
using GrapeCity.ActiveReports.Design;
using GrapeCity.ActiveReports.Design.Resources;
using System.ComponentModel.Design;
using GrapeCity.ActiveReports.Design.Toolbox;
using GrapeCity.ActiveReports.PageReportModel;
namespace GrapeCity.ActiveReports.Samples.EndUserDesigner
{
	public partial class EndUserDesigner : Form
	{
		ToolStripDropDownItem _fileMenu;
		private ToolStripMenuItem _exportMenuItem;
		string _reportName;
		IMessageFilter _filter;
		ToolStripMenuItem _toogleFilterMenu;
		public EndUserDesigner()
		{
			InitializeComponent();
			//Set the ToolBox, ReportExplorer and PropertyGrid in the Designer.
			reportDesigner.Toolbox = reportToolbox;//Attaches the toolbox to the report designer
			reportExplorer.ReportDesigner = reportDesigner;//Attaches the report explorer to the report designer
			reportDesigner.LayoutChanged += new LayoutChangedEventHandler(OnLayoutChanged);
			reportDesigner.ReportChanged += OnReportChanged;
			layerList.ReportDesigner = reportDesigner;
			reportDesigner.PropertyGrid = reportPropertyGrid;//Attaches the Property Grid to the report designer
			//Populate the menu.
			groupEditor.ReportDesigner = reportDesigner;
			reportsLibrary.ReportDesigner = reportDesigner;
			ToolStrip toolstrip = reportDesigner.CreateToolStrips(new DesignerToolStrips[]
				{
					DesignerToolStrips.Menu
				})[0];
			_fileMenu = (ToolStripDropDownItem)toolstrip.Items[0];
			CreateFileMenu(_fileMenu);
			_toogleFilterMenu = new ToolStripMenuItem(Properties.Resources.DisableShortcutsText, null, new EventHandler(ToggleMessageFilter));
			((ToolStripDropDownItem)toolstrip.Items[2]).DropDownItems.Add(new ToolStripSeparator());
			((ToolStripDropDownItem)toolstrip.Items[2]).DropDownItems.Add(_toogleFilterMenu);
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
			ToolStrip item = CreateReportToolbar();
			AppendToolStrips(1, new ToolStrip[]
				{
					item
				});
			AppendToolStrips(2, reportDesigner.CreateToolStrips(new DesignerToolStrips[]
				{
					DesignerToolStrips.Format, 
					DesignerToolStrips.Layout
				}));
			LoadTools(reportToolbox, reportDesigner.ReportType);
			RefreshExportEnabled();
			CreateReportExplorer();
			splitContainerMiddle.Panel2Collapsed = reportDesigner.ReportType == DesignerReportType.Section;
			FormClosing += EndUserDesigner_FormClosing;
		}
		private void EndUserDesigner_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = !ConfirmSaveChanges();
		}
		private void OnReportChanged(object sender, EventArgs e)
		{
			SetTitle();
		}
		private void SetTitle()
		{
			Text = string.Format("{0}{1} - {2}", string.IsNullOrEmpty(_reportName)
									? GetDefaultReportName(reportDesigner.ReportType)
									: Path.GetFileName(_reportName),
								 reportDesigner.IsDirty ? Properties.Resources.DirtySign : string.Empty,
								 Properties.Resources.Title);
		}
		private string GetDefaultReportName(DesignerReportType reportType)
		{
			switch (reportType)
			{
				case DesignerReportType.Section:
					return Properties.Resources.DefaultReportNameRpx;
				default:
					return Properties.Resources.DefaultReportNameRdlx;
			}
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
				splitContainerMiddle.Panel2Collapsed = reportDesigner.ReportType == DesignerReportType.Section;
			}
			if (e.Type == LayoutChangeType.ReportClear)
			{
				_reportName = null;
			}
			if (e.Type == LayoutChangeType.ReportLoad)
			{
				if (!string.IsNullOrEmpty(_reportName))
				{
					if (GetIsMaster())
					{
						_reportName = null;
					}
				}
			}
			SetTitle();
		}
		private void RefreshExportEnabled()
		{
			reportDesigner.ActiveTabChanged -= OnEnableExport;
			reportDesigner.ActiveTabChanged += OnEnableExport;
			OnEnableExport(this, EventArgs.Empty);
		}
		private void OnEnableExport(object sender, EventArgs eventArgs)
		{
			if (_exportMenuItem != null)
				_exportMenuItem.Enabled = reportDesigner.ActiveTab == DesignerTab.Preview;
		  
		}
		private static void LoadTools(IToolboxService toolbox,  DesignerReportType reportType)
		{
			if (reportType == DesignerReportType.Section)
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
		}
		//Adding DropDownItems to the ToolStripDropDownItem.
		private void CreateFileMenu(ToolStripDropDownItem fileMenu)
		{
			fileMenu.DropDownItems.Clear();
			fileMenu.DropDownItems.Add(new ToolStripMenuItem(Properties.Resources.NewText, Properties.Resources.CmdNewReport, new EventHandler(OnNew), (Keys.Control | Keys.N)));
			fileMenu.DropDownItems.Add(new ToolStripMenuItem(Properties.Resources.OpenText, Properties.Resources.CmdOpen, new EventHandler(OnOpen), (Keys.Control | Keys.O)));
			
			fileMenu.DropDownItems.Add(new ToolStripMenuItem(Properties.Resources.LoadFromServer, Properties.Resources.CmdOpenFromServer, new EventHandler(OnLoadFromServer)));
			
			fileMenu.DropDownItems.Add(new ToolStripMenuItem(Properties.Resources.SaveText, Properties.Resources.CmdSave, new EventHandler(OnSave), (Keys.Control | Keys.S)));
			fileMenu.DropDownItems.Add(new ToolStripMenuItem(Properties.Resources.SaveAsText, Properties.Resources.CmdSaveAs, new EventHandler(OnSaveAs)));
			
			fileMenu.DropDownItems.Add(new ToolStripMenuItem(Properties.Resources.SaveToServer, Properties.Resources.CmdSaveToServer, new EventHandler(OnSaveToServer)));
			
			_exportMenuItem = new ToolStripMenuItem(Properties.Resources.ExportText, Properties.Resources.export, new EventHandler(OnExport), (Keys.Control | Keys.E));
			_exportMenuItem.Enabled = false;
			fileMenu.DropDownItems.Add(_exportMenuItem);
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
			ExportForm exportForm = new ExportForm(reportDesigner.ReportType, reportDesigner.Report, reportDesigner.ReportViewer);
			exportForm.ShowDialog();
		}
		//Click "Save" to save a report.
		private void OnSave(object sender, EventArgs e)
		{
			if (PerformSave())
				SetTitle();
		}
		//Click "Save as" to save a report with a name.
		private void OnSaveAs(object sender, EventArgs e)
		{
			if (PerformSaveAs())
				SetTitle();
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
			ToolStripPanel topToolStripPanel = toolStripContainer.TopToolStripPanel;
			int num = toolStrips.Count;
			while (--num >= 0)
			{
				topToolStripPanel.Join(toolStrips[num], row);
			}
		}
		private static ToolStripButton CreateToolStripButton(string text, System.Drawing.Image image, EventHandler handler, string toolTip)
		{
			return new ToolStripButton(text, image, handler)
			{
				DisplayStyle = ToolStripItemDisplayStyle.Image,
				ToolTipText = toolTip,
				DoubleClickEnabled = true
			};
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
			LoadTools(reportToolbox, reportDesigner.ReportType);
			reportToolbox.Reorder(reportDesigner);
			reportToolbox.EnsureCategories();
			if (reportDesigner.ReportType == DesignerReportType.Section)
			{
				reportToolbox.ChangeVisibilityCategory(Properties.Resources.ToolBoxData, true);
				reportToolbox.EnableCategory(Properties.Resources.ToolBoxData, true);
			}
			reportToolbox.Refresh();
		}
		
		//Click "Save to Server" to save a report to the server.
		private void OnSaveToServer(object sender, EventArgs e)
		{
			reportDesigner.SaveReportToServer();
		}
		//Click "Open from Server" to open a report from the server.
		private void OnLoadFromServer(object sender, EventArgs e)
		{
			var reportname = "";
			if (reportDesigner.LoadReportFromServer(out reportname) == DialogResult.OK)
			{
				_reportName = reportname;
				SetTitle();
			}
		}
		
		private void ToggleMessageFilter(object sender, EventArgs eventArgs)
		{
			if (_filter != null)
			{
				Application.RemoveMessageFilter(_filter);
				_filter = null;
				_toogleFilterMenu.CheckState = CheckState.Unchecked;
				return;
			}
			_filter = new DesignerMessageFilter(reportDesigner);
			Application.AddMessageFilter(_filter);
			_toogleFilterMenu.CheckState = CheckState.Checked;
		}
		private sealed class DesignerMessageFilter : IMessageFilter
		{
			private const int WM_KEYDOWN = 0x100;
			private const int WM_SYSKEYDOWN = 0x104;
			private readonly Designer _designer;
			public DesignerMessageFilter(Designer designer)
			{
				_designer = designer;
			}
			public bool PreFilterMessage(ref Message m)
			{
				if ((m.Msg == WM_KEYDOWN || m.Msg == WM_SYSKEYDOWN) && IsControlMatch(m.HWnd))
				{
					var keyData = ((Keys)((int)((long)m.WParam))) | ModifierKeys;
					if ((keyData & Keys.Control) == Keys.Control)
						return true;
				}
				return false;
			}
			private bool IsControlMatch(IntPtr handle)
			{
				if (handle == _designer.Handle)
					return true;
				if (_designer.Controls.Count == 0)
					return false;
				return IsChildControlMatch(handle, _designer.Controls);
			}
			/// <summary>
			/// Loops through the child controls to see if it's a child control that is sending the message.
			/// </summary>
			/// <remarks>The TypedValueEditor has controls made up of child controls so we need to see if the message is coming from a possible child control</remarks>
			private static bool IsChildControlMatch(IntPtr handle, Control.ControlCollection controls)
			{
				foreach (Control child in controls)
				{
					if (child.Handle == handle)
						return true;
					if (child.Controls.Count > 0 && IsChildControlMatch(handle, child.Controls))
						return true;
				}
				return false;
			}
		}
	}
}
