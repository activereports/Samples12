namespace GrapeCity.ActiveReports.Samples.Layer
{
	partial class ReportsForm
	{
		/// <summary>
		///Required designer variable. 
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		/// <summary>
		///Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		#region Windows Form Designer generated code
		
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.mainContainer = new System.Windows.Forms.SplitContainer();
			this.bodyContainer = new System.Windows.Forms.SplitContainer();
			this.toolboxSplitContainer = new System.Windows.Forms.SplitContainer();
			this.reportToolbox = new GrapeCity.ActiveReports.Design.Toolbox.Toolbox();
			this.treeView = new System.Windows.Forms.TreeView();
			this.designerExplorerPropertyGridContainer = new System.Windows.Forms.SplitContainer();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.reportDesigner = new GrapeCity.ActiveReports.Design.Designer();
			this.groupEditor = new GrapeCity.ActiveReports.Design.GroupEditor.GroupEditor();
			this.explorerPropertyGridContainer = new System.Windows.Forms.SplitContainer();
			this.reportExplorerTabControl = new System.Windows.Forms.TabControl();
			this.reportExplorerTabPage = new System.Windows.Forms.TabPage();
			this.reportExplorer = new GrapeCity.ActiveReports.Design.ReportExplorer.ReportExplorer();
			this.layersTabPage = new System.Windows.Forms.TabPage();
			this.layerList = new GrapeCity.ActiveReports.Design.LayerList();
			this.reportPropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.splitContainerLibrary = new System.Windows.Forms.SplitContainer();
			this.reportsLibrary = new GrapeCity.ActiveReports.Design.ReportsLibrary.ReportsLibrary();
			this.toolStripContainer.SuspendLayout();
			this.mainContainer.Panel1.SuspendLayout();
			this.mainContainer.Panel2.SuspendLayout();
			this.mainContainer.SuspendLayout();
			this.bodyContainer.Panel1.SuspendLayout();
			this.bodyContainer.Panel2.SuspendLayout();
			this.bodyContainer.SuspendLayout();
			this.toolboxSplitContainer.Panel1.SuspendLayout();
			this.toolboxSplitContainer.Panel2.SuspendLayout();
			this.toolboxSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.reportToolbox)).BeginInit();
			this.designerExplorerPropertyGridContainer.Panel1.SuspendLayout();
			this.designerExplorerPropertyGridContainer.Panel2.SuspendLayout();
			this.designerExplorerPropertyGridContainer.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.explorerPropertyGridContainer.Panel1.SuspendLayout();
			this.explorerPropertyGridContainer.Panel2.SuspendLayout();
			this.explorerPropertyGridContainer.SuspendLayout();
			this.reportExplorerTabControl.SuspendLayout();
			this.reportExplorerTabPage.SuspendLayout();
			this.layersTabPage.SuspendLayout();
			this.splitContainerLibrary.Panel1.SuspendLayout();
			this.splitContainerLibrary.Panel2.SuspendLayout();
			this.splitContainerLibrary.SuspendLayout();
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
			this.bodyContainer.Panel1.Controls.Add(this.splitContainerLibrary);
			// 
			// bodyContainer.Panel2
			// 
			this.bodyContainer.Panel2.Controls.Add(this.designerExplorerPropertyGridContainer);
			// 
			// toolboxSplitContainer
			// 
			resources.ApplyResources(this.toolboxSplitContainer, "toolboxSplitContainer");
			this.toolboxSplitContainer.Name = "toolboxSplitContainer";
			// 
			// toolboxSplitContainer.Panel1
			// 
			this.toolboxSplitContainer.Panel1.Controls.Add(this.reportToolbox);
			// 
			// toolboxSplitContainer.Panel2
			// 
			this.toolboxSplitContainer.Panel2.Controls.Add(this.treeView);
			// 
			// reportToolbox
			// 
			this.reportToolbox.DesignerHost = null;
			resources.ApplyResources(this.reportToolbox, "reportToolbox");
			this.reportToolbox.Name = "reportToolbox";
			// 
			// treeView
			// 
			resources.ApplyResources(this.treeView, "treeView");
			this.treeView.Name = "treeView";
			this.treeView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterCollapse);
			this.treeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterExpand);
			this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
			// 
			// designerExplorerPropertyGridContainer
			// 
			resources.ApplyResources(this.designerExplorerPropertyGridContainer, "designerExplorerPropertyGridContainer");
			this.designerExplorerPropertyGridContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.designerExplorerPropertyGridContainer.Name = "designerExplorerPropertyGridContainer";
			// 
			// designerExplorerPropertyGridContainer.Panel1
			// 
			this.designerExplorerPropertyGridContainer.Panel1.Controls.Add(this.splitContainer1);
			// 
			// designerExplorerPropertyGridContainer.Panel2
			// 
			this.designerExplorerPropertyGridContainer.Panel2.Controls.Add(this.explorerPropertyGridContainer);
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
			// 
			// groupEditor
			// 
			resources.ApplyResources(this.groupEditor, "groupEditor");
			this.groupEditor.Name = "groupEditor";
			this.groupEditor.ReportDesigner = null;
			// 
			// explorerPropertyGridContainer
			// 
			resources.ApplyResources(this.explorerPropertyGridContainer, "explorerPropertyGridContainer");
			this.explorerPropertyGridContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.explorerPropertyGridContainer.Name = "explorerPropertyGridContainer";
			// 
			// explorerPropertyGridContainer.Panel1
			// 
			this.explorerPropertyGridContainer.Panel1.Controls.Add(this.reportExplorerTabControl);
			// 
			// explorerPropertyGridContainer.Panel2
			// 
			this.explorerPropertyGridContainer.Panel2.Controls.Add(this.reportPropertyGrid);
			// 
			// reportExplorerTabControl
			// 
			this.reportExplorerTabControl.Controls.Add(this.reportExplorerTabPage);
			this.reportExplorerTabControl.Controls.Add(this.layersTabPage);
			resources.ApplyResources(this.reportExplorerTabControl, "reportExplorerTabControl");
			this.reportExplorerTabControl.Name = "reportExplorerTabControl";
			this.reportExplorerTabControl.SelectedIndex = 0;
			// 
			// reportExplorerTabPage
			// 
			this.reportExplorerTabPage.Controls.Add(this.reportExplorer);
			resources.ApplyResources(this.reportExplorerTabPage, "reportExplorerTabPage");
			this.reportExplorerTabPage.Name = "reportExplorerTabPage";
			this.reportExplorerTabPage.UseVisualStyleBackColor = true;
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
			// layersTabPage
			// 
			this.layersTabPage.Controls.Add(this.layerList);
			resources.ApplyResources(this.layersTabPage, "layersTabPage");
			this.layersTabPage.Name = "layersTabPage";
			this.layersTabPage.UseVisualStyleBackColor = true;
			// 
			// layerList
			// 
			resources.ApplyResources(this.layerList, "layerList");
			this.layerList.Name = "layerList";
			this.layerList.ReportDesigner = null;
			// 
			// reportPropertyGrid
			// 
			this.reportPropertyGrid.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			resources.ApplyResources(this.reportPropertyGrid, "reportPropertyGrid");
			this.reportPropertyGrid.Name = "reportPropertyGrid";
			// 
			// splitContainerLibrary
			// 
			resources.ApplyResources(this.splitContainerLibrary, "splitContainerLibrary");
			this.splitContainerLibrary.Name = "splitContainerLibrary";
			// 
			// splitContainerLibrary.Panel1
			// 
			this.splitContainerLibrary.Panel1.Controls.Add(this.toolboxSplitContainer);
			// 
			// splitContainerLibrary.Panel2
			// 
			this.splitContainerLibrary.Panel2.Controls.Add(this.reportsLibrary);
			// 
			// reportsLibrary
			// 
			resources.ApplyResources(this.reportsLibrary, "reportsLibrary");
			this.reportsLibrary.Name = "reportsLibrary";
			this.reportsLibrary.ReportDesigner = null;
			// 
			// ReportsForm
			// 
			this.AllowDrop = true;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainContainer);
			this.Name = "ReportsForm";
			this.Load += new System.EventHandler(this.ReportsForm_Load);
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.mainContainer.Panel1.ResumeLayout(false);
			this.mainContainer.Panel2.ResumeLayout(false);
			this.mainContainer.ResumeLayout(false);
			this.bodyContainer.Panel1.ResumeLayout(false);
			this.bodyContainer.Panel2.ResumeLayout(false);
			this.bodyContainer.ResumeLayout(false);
			this.toolboxSplitContainer.Panel1.ResumeLayout(false);
			this.toolboxSplitContainer.Panel2.ResumeLayout(false);
			this.toolboxSplitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.reportToolbox)).EndInit();
			this.designerExplorerPropertyGridContainer.Panel1.ResumeLayout(false);
			this.designerExplorerPropertyGridContainer.Panel2.ResumeLayout(false);
			this.designerExplorerPropertyGridContainer.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.explorerPropertyGridContainer.Panel1.ResumeLayout(false);
			this.explorerPropertyGridContainer.Panel2.ResumeLayout(false);
			this.explorerPropertyGridContainer.ResumeLayout(false);
			this.reportExplorerTabControl.ResumeLayout(false);
			this.reportExplorerTabPage.ResumeLayout(false);
			this.layersTabPage.ResumeLayout(false);
			this.splitContainerLibrary.Panel1.ResumeLayout(false);
			this.splitContainerLibrary.Panel2.ResumeLayout(false);
			this.splitContainerLibrary.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		#endregion
		private System.Windows.Forms.SplitContainer mainContainer;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.SplitContainer bodyContainer;
		private System.Windows.Forms.SplitContainer designerExplorerPropertyGridContainer;
		private System.Windows.Forms.SplitContainer explorerPropertyGridContainer;
		private System.Windows.Forms.PropertyGrid reportPropertyGrid;
		private System.Windows.Forms.TabControl reportExplorerTabControl;
		private System.Windows.Forms.TabPage reportExplorerTabPage;
		private System.Windows.Forms.TabPage layersTabPage;
		private Design.ReportExplorer.ReportExplorer reportExplorer;
		private Design.LayerList layerList;
		private System.Windows.Forms.SplitContainer toolboxSplitContainer;
		private Design.Toolbox.Toolbox reportToolbox;
		private System.Windows.Forms.TreeView treeView;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private Design.Designer reportDesigner;
		private Design.GroupEditor.GroupEditor groupEditor;
		private System.Windows.Forms.SplitContainer splitContainerLibrary;
		private Design.ReportsLibrary.ReportsLibrary reportsLibrary;
	}
}
