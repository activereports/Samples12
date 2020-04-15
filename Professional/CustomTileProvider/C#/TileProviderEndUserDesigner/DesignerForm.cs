using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using GrapeCity.ActiveReports.Design;
using GrapeCity.ActiveReports.Design.Resources;
namespace GrapeCity.ActiveReports.Samples.EndUserDesigner
{
	public partial class DesignerForm : Form
	{
		readonly HelperForm _helperForm = new HelperForm();
		readonly ToolStripButton _helpButton = new ToolStripButton();
		public DesignerForm()
		{
			InitializeComponent();
			reportDesigner.NewReport(DesignerReportType.Page);//Sets the designer to create a blank page based report
			//Populating the ToolBox,reportExplorer and Propertygrid
			reportDesigner.Toolbox = reportToolbox;//Attaches the toolbox to the report designer
			reportExplorer.ReportDesigner = reportDesigner;//Attaches the report explorer to the report designer
			layerList.ReportDesigner = reportDesigner;
			reportDesigner.PropertyGrid = propertyGrid;//Attaches the Property Grid to the report designer
			groupEditor.ReportDesigner = reportDesigner;
			reportsLibrary.ReportDesigner = reportDesigner;
			//Populating the Menu
			ToolStrip toolstrip = reportDesigner.CreateToolStrips(new DesignerToolStrips[]
				{
				   DesignerToolStrips.Menu
				})[0];
			
			_helpButton.Text = "Help";
			
			
			_helpButton.Click += _helpButton_Click;
			toolstrip.Items.Add(_helpButton);
			ToolStripDropDownItem filemenu = (ToolStripDropDownItem)toolstrip.Items[0];
			CreateFileMenu(filemenu);
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
		}
		void _helpButton_Click(object sender, EventArgs e)
		{
			_helperForm.Show();
			
		}
		//Adding DropDownItems to the ToolStripDropDownItem
		private void CreateFileMenu(ToolStripDropDownItem fileMenu)
		{
			fileMenu.DropDownItems.Clear();
			
			fileMenu.DropDownItems.Add(new ToolStripMenuItem("New", Properties.Resources.CmdNewReport, new EventHandler(OnNew), (Keys.Control | Keys.N)));
			fileMenu.DropDownItems.Add(new ToolStripMenuItem("Open", Properties.Resources.CmdOpen, new EventHandler(OnOpen), (Keys.Control | Keys.O)));
			fileMenu.DropDownItems.Add(new ToolStripMenuItem("Save", Properties.Resources.CmdSave, new EventHandler(OnSave), (Keys.Control | Keys.S)));
			fileMenu.DropDownItems.Add(new ToolStripMenuItem("Save As", Properties.Resources.CmdSaveAs, new EventHandler(OnSaveAs)));
			fileMenu.DropDownItems.Add(new ToolStripSeparator());
			fileMenu.DropDownItems.Add(new ToolStripMenuItem("Exit", null, new EventHandler(OnExit)));
			
			
		}
		private ToolStrip CreateReportToolbar()
		{
			return new ToolStrip(new ToolStripButton[]
			{
				
				CreateToolStripButton("New", Properties.Resources.CmdNewReport, new EventHandler(OnNew), "New"),
				CreateToolStripButton("Open", Properties.Resources.CmdOpen, new EventHandler(OnOpen), "Open"),
				CreateToolStripButton("Save", Properties.Resources.CmdSave, new EventHandler(OnSave), "Save")
				
				
			});
		}
		//Getting the Designer to open a new Report on Menu Item "New" click
		private void OnNew(object sender, EventArgs e)
		{
			if (ConfirmSaveChanges())
			{
				reportDesigner.ExecuteAction(DesignerAction.NewReport);
			}
		}
		//Getting the Designer to open a Report on Menu Item "Open" click
		private void OnOpen(object sender, EventArgs e)
		{
			if (ConfirmSaveChanges())
			{
				reportDesigner.ExecuteAction(DesignerAction.FileOpen);
			}
		}
		//Getting the Designer to Save the Report on Menu Item "Save" click
		private void OnSave(object sender, EventArgs e)
		{
			reportDesigner.ExecuteAction(DesignerAction.FileSave);
		}
		//Getting the Designer to Save the Report on Menu Item "Save As" click
		private void OnSaveAs(object sender, EventArgs e)
		{
			reportDesigner.ExecuteAction(DesignerAction.FileSave);
		}
		private void OnExit(object sender, EventArgs e)
		{
			Close();
		}
		//Checking whether modifications have been made to the report loaded to the designer
		private bool ConfirmSaveChanges()
		{
			if (reportDesigner.IsDirty)
			{
				
				DialogResult result = MessageBox.Show("Report has been changed. Do you wish to save it?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				
				
				if (result == DialogResult.Cancel)
				{
					return false;
				}
				if (result == DialogResult.Yes)
				{
					using (SaveFileDialog saveDialog = new SaveFileDialog())
					{
						
						saveDialog.Filter = "rdlx files|*.rdlx";
						
						
						saveDialog.DefaultExt = ".rdlx";
						saveDialog.InitialDirectory = new DirectoryInfo(Application.ExecutablePath).Parent.Parent.Parent.FullName;
						if (saveDialog.ShowDialog() == DialogResult.OK)
						{
							reportDesigner.SaveReport(new FileInfo(saveDialog.FileName));
							reportDesigner.IsDirty = false;
						}
					}
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
		private static ToolStripButton CreateToolStripButton(string text, Image image, EventHandler handler, string toolTip)
		{
			return new ToolStripButton(text, image, handler)
			{
				DisplayStyle = ToolStripItemDisplayStyle.Image,
				ToolTipText = toolTip,
				DoubleClickEnabled = true
			};
		}
		private void UnifiedDesignerForm_Load(object sender, EventArgs e)
		{
			reportDesigner.LoadReport(new FileInfo("CustomTileProvider.rdlx"));
			_helpButton.PerformClick();
		}
		private void CreateReportExplorer()
		{
			if (reportDesigner.ReportType == DesignerReportType.Section)
			{
				if (explorerpropertygridContainer.Panel1.Controls.Contains(reportExplorerTabControl))
				{
					reportExplorerTabControl.TabPages[0].SuspendLayout();
					explorerpropertygridContainer.Panel1.SuspendLayout();
					explorerpropertygridContainer.Panel1.Controls.Remove(reportExplorerTabControl);
					explorerpropertygridContainer.Panel1.Controls.Add(reportExplorer);
					reportExplorerTabControl.TabPages[0].ResumeLayout();
					explorerpropertygridContainer.Panel1.ResumeLayout();
				}
			}
			else if (!explorerpropertygridContainer.Panel1.Controls.Contains(reportExplorerTabControl))
			{
				
				reportExplorerTabControl.TabPages[0].SuspendLayout();
				explorerpropertygridContainer.Panel1.SuspendLayout();
				explorerpropertygridContainer.Panel1.Controls.Remove(reportExplorer);
				reportExplorerTabControl.TabPages[0].Controls.Add(reportExplorer);
				explorerpropertygridContainer.Panel1.Controls.Add(reportExplorerTabControl);
				reportExplorerTabControl.TabPages[0].ResumeLayout();
				explorerpropertygridContainer.Panel1.ResumeLayout();
			}
		}
		private void reportDesigner_LayoutChanged(object sender, LayoutChangedArgs e)
		{
			CreateReportExplorer();
		}
	}
}
