using GrapeCity.ActiveReports.Design;
namespace GrapeCity.ActiveReports.Samples.CustomDataProviderUITest
{
	partial class DesignerForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
	  
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		#region Windows Form Designer generated code
		
		
	 
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignerForm));
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.mainContainer = new System.Windows.Forms.SplitContainer();
			this.bodyContainer = new System.Windows.Forms.SplitContainer();
			this.reportToolbox = new GrapeCity.ActiveReports.Design.Toolbox.Toolbox();
			this.designerexplorerpropertygridContainer = new System.Windows.Forms.SplitContainer();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.reportDesigner = new GrapeCity.ActiveReports.Design.Designer();
			this.groupEditor = new GrapeCity.ActiveReports.Design.GroupEditor.GroupEditor();
			this.explorerpropertygridContainer = new System.Windows.Forms.SplitContainer();
			this.reportExplorerTabControl = new System.Windows.Forms.TabControl();
			this.tabReportExplorer = new System.Windows.Forms.TabPage();
			this.reportExplorer = new GrapeCity.ActiveReports.Design.ReportExplorer.ReportExplorer();
			this.tabLayers = new System.Windows.Forms.TabPage();
			this.layerList = new GrapeCity.ActiveReports.Design.LayerList();
			this.propertyGrid = new System.Windows.Forms.PropertyGrid();
			this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
			this.reportsLibrary = new GrapeCity.ActiveReports.Design.ReportsLibrary.ReportsLibrary();
			this.toolStripContainer.SuspendLayout();
			this.mainContainer.Panel1.SuspendLayout();
			this.mainContainer.Panel2.SuspendLayout();
			this.mainContainer.SuspendLayout();
			this.bodyContainer.Panel1.SuspendLayout();
			this.bodyContainer.Panel2.SuspendLayout();
			this.bodyContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.reportToolbox)).BeginInit();
			this.designerexplorerpropertygridContainer.Panel1.SuspendLayout();
			this.designerexplorerpropertygridContainer.Panel2.SuspendLayout();
			this.designerexplorerpropertygridContainer.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.explorerpropertygridContainer.Panel1.SuspendLayout();
			this.explorerpropertygridContainer.Panel2.SuspendLayout();
			this.explorerpropertygridContainer.SuspendLayout();
			this.reportExplorerTabControl.SuspendLayout();
			this.tabReportExplorer.SuspendLayout();
			this.tabLayers.SuspendLayout();
			this.splitContainerLeft.Panel1.SuspendLayout();
			this.splitContainerLeft.Panel2.SuspendLayout();
			this.splitContainerLeft.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.ContentPanel
			// 
			resources.ApplyResources(this.toolStripContainer.ContentPanel, "toolStripContainer.ContentPanel");
			resources.ApplyResources(this.toolStripContainer, "toolStripContainer");
			this.toolStripContainer.Name = "toolStripContainer";
			// 
			// mainContainer
			// 
			resources.ApplyResources(this.mainContainer, "mainContainer");
			this.mainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.mainContainer.Name = "mainContainer";
			// 
			// mainContainer.Panel1
			// 
			this.mainContainer.Panel1.Controls.Add(this.toolStripContainer);
			// 
			// mainContainer.Panel2
			// 
			this.mainContainer.Panel2.Controls.Add(this.bodyContainer);
			// 
			// bodyContainer
			// 
			resources.ApplyResources(this.bodyContainer, "bodyContainer");
			this.bodyContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.bodyContainer.Name = "bodyContainer";
			// 
			// bodyContainer.Panel1
			// 
			this.bodyContainer.Panel1.Controls.Add(this.splitContainerLeft);
			// 
			// bodyContainer.Panel2
			// 
			this.bodyContainer.Panel2.Controls.Add(this.designerexplorerpropertygridContainer);
			// 
			// reportToolbox
			// 
			this.reportToolbox.DesignerHost = null;
			resources.ApplyResources(this.reportToolbox, "reportToolbox");
			this.reportToolbox.Name = "reportToolbox";
			// 
			// designerexplorerpropertygridContainer
			// 
			resources.ApplyResources(this.designerexplorerpropertygridContainer, "designerexplorerpropertygridContainer");
			this.designerexplorerpropertygridContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.designerexplorerpropertygridContainer.Name = "designerexplorerpropertygridContainer";
			// 
			// designerexplorerpropertygridContainer.Panel1
			// 
			this.designerexplorerpropertygridContainer.Panel1.Controls.Add(this.splitContainer1);
			// 
			// designerexplorerpropertygridContainer.Panel2
			// 
			this.designerexplorerpropertygridContainer.Panel2.Controls.Add(this.explorerpropertygridContainer);
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.splitContainer1, "splitContainer1");
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.reportDesigner);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupEditor);
			// 
			// reportDesigner
			// 
			resources.ApplyResources(this.reportDesigner, "reportDesigner");
			this.reportDesigner.IsDirty = false;
			this.reportDesigner.LockControls = false;
			this.reportDesigner.Name = "reportDesigner";
			this.reportDesigner.PreviewPages = 10;
			this.reportDesigner.PromptUser = true;
			this.reportDesigner.PropertyGrid = null;
			this.reportDesigner.ReportTabsVisible = true;
			this.reportDesigner.ShowDataSourceIcon = true;
			this.reportDesigner.Toolbox = null;
			this.reportDesigner.ToolBoxItem = null;
			this.reportDesigner.LayoutChanged += new LayoutChangedEventHandler(reportDesigner_LayoutChanged);
			// 
			// groupEditor
			// 
			resources.ApplyResources(this.groupEditor, "groupEditor");
			this.groupEditor.Name = "groupEditor";
			this.groupEditor.ReportDesigner = null;
			// 
			// explorerpropertygridContainer
			// 
			resources.ApplyResources(this.explorerpropertygridContainer, "explorerpropertygridContainer");
			this.explorerpropertygridContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.explorerpropertygridContainer.Name = "explorerpropertygridContainer";
			// 
			// explorerpropertygridContainer.Panel1
			// 
			this.explorerpropertygridContainer.Panel1.Controls.Add(this.reportExplorerTabControl);
			// 
			// explorerpropertygridContainer.Panel2
			// 
			this.explorerpropertygridContainer.Panel2.Controls.Add(this.propertyGrid);
			// 
			// reportExplorerTabControl
			// 
			this.reportExplorerTabControl.Controls.Add(this.tabReportExplorer);
			this.reportExplorerTabControl.Controls.Add(this.tabLayers);
			resources.ApplyResources(this.reportExplorerTabControl, "reportExplorerTabControl");
			this.reportExplorerTabControl.Name = "reportExplorerTabControl";
			this.reportExplorerTabControl.SelectedIndex = 0;
			// 
			// tabReportExplorer
			// 
			this.tabReportExplorer.Controls.Add(this.reportExplorer);
			resources.ApplyResources(this.tabReportExplorer, "tabReportExplorer");
			this.tabReportExplorer.Name = "tabReportExplorer";
			this.tabReportExplorer.UseVisualStyleBackColor = true;
			// 
			// reportExplorer
			// 
			resources.ApplyResources(this.reportExplorer, "reportExplorer");
			this.reportExplorer.FieldsVisible = false;
			this.reportExplorer.Name = "reportExplorer";
			this.reportExplorer.ParametersVisible = false;
			this.reportExplorer.ReportDesigner = null;
			this.reportExplorer.ReportSettingsVisible = false;
			// 
			// tabLayers
			// 
			this.tabLayers.Controls.Add(this.layerList);
			resources.ApplyResources(this.tabLayers, "tabLayers");
			this.tabLayers.Name = "tabLayers";
			this.tabLayers.UseVisualStyleBackColor = true;
			// 
			// layerList
			// 
			resources.ApplyResources(this.layerList, "layerList");
			this.layerList.Name = "layerList";
			this.layerList.ReportDesigner = null;
			// 
			// propertyGrid
			// 
			this.propertyGrid.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			resources.ApplyResources(this.propertyGrid, "propertyGrid");
			this.propertyGrid.Name = "propertyGrid";
			// 
			// splitContainerLeft
			// 
			resources.ApplyResources(this.splitContainerLeft, "splitContainerLeft");
			this.splitContainerLeft.Name = "splitContainerLeft";
			// 
			// splitContainerLeft.Panel1
			// 
			this.splitContainerLeft.Panel1.Controls.Add(this.reportToolbox);
			// 
			// splitContainerLeft.Panel2
			// 
			this.splitContainerLeft.Panel2.Controls.Add(this.reportsLibrary);
			// 
			// reportsLibrary
			// 
			resources.ApplyResources(this.reportsLibrary, "reportsLibrary");
			this.reportsLibrary.Name = "reportsLibrary";
			this.reportsLibrary.ReportDesigner = null;
			// 
			// DesignerForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainContainer);
			this.Name = "DesignerForm";
			this.Load += new System.EventHandler(this.UnifiedDesignerForm_Load);
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.mainContainer.Panel1.ResumeLayout(false);
			this.mainContainer.Panel2.ResumeLayout(false);
			this.mainContainer.ResumeLayout(false);
			this.bodyContainer.Panel1.ResumeLayout(false);
			this.bodyContainer.Panel2.ResumeLayout(false);
			this.bodyContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.reportToolbox)).EndInit();
			this.designerexplorerpropertygridContainer.Panel1.ResumeLayout(false);
			this.designerexplorerpropertygridContainer.Panel2.ResumeLayout(false);
			this.designerexplorerpropertygridContainer.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.explorerpropertygridContainer.Panel1.ResumeLayout(false);
			this.explorerpropertygridContainer.Panel2.ResumeLayout(false);
			this.explorerpropertygridContainer.ResumeLayout(false);
			this.reportExplorerTabControl.ResumeLayout(false);
			this.tabReportExplorer.ResumeLayout(false);
			this.tabLayers.ResumeLayout(false);
			this.splitContainerLeft.Panel1.ResumeLayout(false);
			this.splitContainerLeft.Panel2.ResumeLayout(false);
			this.splitContainerLeft.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		#endregion
		private System.Windows.Forms.SplitContainer mainContainer;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.SplitContainer bodyContainer;
		private GrapeCity.ActiveReports.Design.Toolbox.Toolbox reportToolbox;
		private System.Windows.Forms.SplitContainer designerexplorerpropertygridContainer;
		private System.Windows.Forms.SplitContainer explorerpropertygridContainer;
		private GrapeCity.ActiveReports.Design.ReportExplorer.ReportExplorer reportExplorer;
		private System.Windows.Forms.TabControl reportExplorerTabControl;
		private System.Windows.Forms.TabPage tabReportExplorer;
		private System.Windows.Forms.TabPage tabLayers;
		private Design.LayerList layerList;
		private System.Windows.Forms.PropertyGrid propertyGrid;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private Design.Designer reportDesigner;
		private Design.GroupEditor.GroupEditor groupEditor;
		private System.Windows.Forms.SplitContainer splitContainerLeft;
		private Design.ReportsLibrary.ReportsLibrary reportsLibrary;
	}
}
