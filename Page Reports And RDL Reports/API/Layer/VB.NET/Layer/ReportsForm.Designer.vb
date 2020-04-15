<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
	Inherits System.Windows.Forms.Form
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportsForm))
		Me.toolStripContainer = New System.Windows.Forms.ToolStripContainer()
		Me.mainContainer = New System.Windows.Forms.SplitContainer()
		Me.bodyContainer = New System.Windows.Forms.SplitContainer()
		Me.toolboxSplitContainer = New System.Windows.Forms.SplitContainer()
		Me.reportToolbox = New GrapeCity.ActiveReports.Design.Toolbox.Toolbox()
		Me.treeView = New System.Windows.Forms.TreeView()
		Me.designerExplorerPropertyGridContainer = New System.Windows.Forms.SplitContainer()
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.reportDesigner = New GrapeCity.ActiveReports.Design.Designer()
		Me.groupEditor = New GrapeCity.ActiveReports.Design.GroupEditor.GroupEditor()
		Me.explorerPropertyGridContainer = New System.Windows.Forms.SplitContainer()
		Me.reportExplorerTabControl = New System.Windows.Forms.TabControl()
		Me.reportExplorerTabPage = New System.Windows.Forms.TabPage()
		Me.reportExplorer = New GrapeCity.ActiveReports.Design.ReportExplorer.ReportExplorer()
		Me.layerListTabPage = New System.Windows.Forms.TabPage()
		Me.layerList = New GrapeCity.ActiveReports.Design.LayerList()
		Me.reportPropertyGrid = New System.Windows.Forms.PropertyGrid()
		Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
		Me.SplitContainerLibrary = New System.Windows.Forms.SplitContainer()
		Me.reportsLibrary = New GrapeCity.ActiveReports.Design.ReportsLibrary.ReportsLibrary()
		Me.toolStripContainer.SuspendLayout()
		Me.mainContainer.Panel1.SuspendLayout()
		Me.mainContainer.Panel2.SuspendLayout()
		Me.mainContainer.SuspendLayout()
		Me.bodyContainer.Panel1.SuspendLayout()
		Me.bodyContainer.Panel2.SuspendLayout()
		Me.bodyContainer.SuspendLayout()
		Me.toolboxSplitContainer.Panel1.SuspendLayout()
		Me.toolboxSplitContainer.Panel2.SuspendLayout()
		Me.toolboxSplitContainer.SuspendLayout()
		CType(Me.reportToolbox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.designerExplorerPropertyGridContainer.Panel1.SuspendLayout()
		Me.designerExplorerPropertyGridContainer.Panel2.SuspendLayout()
		Me.designerExplorerPropertyGridContainer.SuspendLayout()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.explorerPropertyGridContainer.Panel1.SuspendLayout()
		Me.explorerPropertyGridContainer.Panel2.SuspendLayout()
		Me.explorerPropertyGridContainer.SuspendLayout()
		Me.reportExplorerTabControl.SuspendLayout()
		Me.reportExplorerTabPage.SuspendLayout()
		Me.layerListTabPage.SuspendLayout()
		Me.SplitContainerLibrary.Panel1.SuspendLayout()
		Me.SplitContainerLibrary.Panel2.SuspendLayout()
		Me.SplitContainerLibrary.SuspendLayout()
		Me.SuspendLayout()
		'
		'toolStripContainer
		'
		'
		'toolStripContainer.ContentPanel
		'
		resources.ApplyResources(Me.toolStripContainer.ContentPanel, "toolStripContainer.ContentPanel")
		resources.ApplyResources(Me.toolStripContainer, "toolStripContainer")
		Me.toolStripContainer.Name = "toolStripContainer"
		'
		'mainContainer
		'
		resources.ApplyResources(Me.mainContainer, "mainContainer")
		Me.mainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.mainContainer.Name = "mainContainer"
		'
		'mainContainer.Panel1
		'
		Me.mainContainer.Panel1.Controls.Add(Me.toolStripContainer)
		'
		'mainContainer.Panel2
		'
		Me.mainContainer.Panel2.Controls.Add(Me.bodyContainer)
		'
		'bodyContainer
		'
		Me.bodyContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		resources.ApplyResources(Me.bodyContainer, "bodyContainer")
		Me.bodyContainer.Name = "bodyContainer"
		'
		'bodyContainer.Panel1
		'
		Me.bodyContainer.Panel1.Controls.Add(Me.SplitContainerLibrary)
		'
		'bodyContainer.Panel2
		'
		Me.bodyContainer.Panel2.Controls.Add(Me.designerExplorerPropertyGridContainer)
		'
		'toolboxSplitContainer
		'
		resources.ApplyResources(Me.toolboxSplitContainer, "toolboxSplitContainer")
		Me.toolboxSplitContainer.Name = "toolboxSplitContainer"
		'
		'toolboxSplitContainer.Panel1
		'
		Me.toolboxSplitContainer.Panel1.Controls.Add(Me.reportToolbox)
		'
		'toolboxSplitContainer.Panel2
		'
		Me.toolboxSplitContainer.Panel2.Controls.Add(Me.treeView)
		'
		'reportToolbox
		'
		Me.reportToolbox.DesignerHost = Nothing
		resources.ApplyResources(Me.reportToolbox, "reportToolbox")
		Me.reportToolbox.Name = "reportToolbox"
		'
		'treeView
		'
		resources.ApplyResources(Me.treeView, "treeView")
		Me.treeView.Name = "treeView"
		'
		'designerExplorerPropertyGridContainer
		'
		resources.ApplyResources(Me.designerExplorerPropertyGridContainer, "designerExplorerPropertyGridContainer")
		Me.designerExplorerPropertyGridContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
		Me.designerExplorerPropertyGridContainer.Name = "designerExplorerPropertyGridContainer"
		'
		'designerExplorerPropertyGridContainer.Panel1
		'
		Me.designerExplorerPropertyGridContainer.Panel1.Controls.Add(Me.SplitContainer1)
		'
		'designerExplorerPropertyGridContainer.Panel2
		'
		Me.designerExplorerPropertyGridContainer.Panel2.Controls.Add(Me.explorerPropertyGridContainer)
		'
		'SplitContainer1
		'
		Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		resources.ApplyResources(Me.SplitContainer1, "SplitContainer1")
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.reportDesigner)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.groupEditor)
		'
		'reportDesigner
		'
		resources.ApplyResources(Me.reportDesigner, "reportDesigner")
		Me.reportDesigner.IsDirty = False
		Me.reportDesigner.LockControls = False
		Me.reportDesigner.Name = "reportDesigner"
		Me.reportDesigner.PreviewPages = 10
		Me.reportDesigner.PromptUser = True
		Me.reportDesigner.PropertyGrid = Nothing
		Me.reportDesigner.ReportTabsVisible = True
		Me.reportDesigner.ShowDataSourceIcon = True
		Me.reportDesigner.Toolbox = Nothing
		Me.reportDesigner.ToolBoxItem = Nothing
		'
		'groupEditor
		'
		resources.ApplyResources(Me.groupEditor, "groupEditor")
		Me.groupEditor.Name = "groupEditor"
		Me.groupEditor.ReportDesigner = Nothing
		'
		'explorerPropertyGridContainer
		'
		resources.ApplyResources(Me.explorerPropertyGridContainer, "explorerPropertyGridContainer")
		Me.explorerPropertyGridContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.explorerPropertyGridContainer.Name = "explorerPropertyGridContainer"
		'
		'explorerPropertyGridContainer.Panel1
		'
		Me.explorerPropertyGridContainer.Panel1.Controls.Add(Me.reportExplorerTabControl)
		'
		'explorerPropertyGridContainer.Panel2
		'
		Me.explorerPropertyGridContainer.Panel2.Controls.Add(Me.reportPropertyGrid)
		'
		'reportExplorerTabControl
		'
		Me.reportExplorerTabControl.Controls.Add(Me.reportExplorerTabPage)
		Me.reportExplorerTabControl.Controls.Add(Me.layerListTabPage)
		resources.ApplyResources(Me.reportExplorerTabControl, "reportExplorerTabControl")
		Me.reportExplorerTabControl.Name = "reportExplorerTabControl"
		Me.reportExplorerTabControl.SelectedIndex = 0
		'
		'reportExplorerTabPage
		'
		Me.reportExplorerTabPage.Controls.Add(Me.reportExplorer)
		resources.ApplyResources(Me.reportExplorerTabPage, "reportExplorerTabPage")
		Me.reportExplorerTabPage.Name = "reportExplorerTabPage"
		Me.reportExplorerTabPage.UseVisualStyleBackColor = True
		'
		'reportExplorer
		'
		resources.ApplyResources(Me.reportExplorer, "reportExplorer")
		Me.reportExplorer.FieldsVisible = False
		Me.reportExplorer.Name = "reportExplorer"
		Me.reportExplorer.ParametersVisible = False
		Me.reportExplorer.ReportDesigner = Nothing
		Me.reportExplorer.ReportSettingsVisible = False
		'
		'layerListTabPage
		'
		Me.layerListTabPage.Controls.Add(Me.layerList)
		resources.ApplyResources(Me.layerListTabPage, "layerListTabPage")
		Me.layerListTabPage.Name = "layerListTabPage"
		Me.layerListTabPage.UseVisualStyleBackColor = True
		'
		'layerList
		'
		resources.ApplyResources(Me.layerList, "layerList")
		Me.layerList.Name = "layerList"
		Me.layerList.ReportDesigner = Nothing
		'
		'reportPropertyGrid
		'
		Me.reportPropertyGrid.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText
		resources.ApplyResources(Me.reportPropertyGrid, "reportPropertyGrid")
		Me.reportPropertyGrid.Name = "reportPropertyGrid"
		'
		'SplitContainerLibrary
		'
		resources.ApplyResources(Me.SplitContainerLibrary, "SplitContainerLibrary")
		Me.SplitContainerLibrary.Name = "SplitContainerLibrary"
		'
		'SplitContainerLibrary.Panel1
		'
		Me.SplitContainerLibrary.Panel1.Controls.Add(Me.toolboxSplitContainer)
		'
		'SplitContainerLibrary.Panel2
		'
		Me.SplitContainerLibrary.Panel2.Controls.Add(Me.reportsLibrary)
		'
		'reportsLibrary
		'
		resources.ApplyResources(Me.reportsLibrary, "reportsLibrary")
		Me.reportsLibrary.Name = "reportsLibrary"
		Me.reportsLibrary.ReportDesigner = Nothing
		'
		'ReportsForm
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.mainContainer)
		Me.Name = "ReportsForm"
		Me.toolStripContainer.ResumeLayout(False)
		Me.toolStripContainer.PerformLayout()
		Me.mainContainer.Panel1.ResumeLayout(False)
		Me.mainContainer.Panel2.ResumeLayout(False)
		Me.mainContainer.ResumeLayout(False)
		Me.bodyContainer.Panel1.ResumeLayout(False)
		Me.bodyContainer.Panel2.ResumeLayout(False)
		Me.bodyContainer.ResumeLayout(False)
		Me.toolboxSplitContainer.Panel1.ResumeLayout(False)
		Me.toolboxSplitContainer.Panel2.ResumeLayout(False)
		Me.toolboxSplitContainer.ResumeLayout(False)
		CType(Me.reportToolbox, System.ComponentModel.ISupportInitialize).EndInit()
		Me.designerExplorerPropertyGridContainer.Panel1.ResumeLayout(False)
		Me.designerExplorerPropertyGridContainer.Panel2.ResumeLayout(False)
		Me.designerExplorerPropertyGridContainer.ResumeLayout(False)
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.ResumeLayout(False)
		Me.explorerPropertyGridContainer.Panel1.ResumeLayout(False)
		Me.explorerPropertyGridContainer.Panel2.ResumeLayout(False)
		Me.explorerPropertyGridContainer.ResumeLayout(False)
		Me.reportExplorerTabControl.ResumeLayout(False)
		Me.reportExplorerTabPage.ResumeLayout(False)
		Me.layerListTabPage.ResumeLayout(False)
		Me.SplitContainerLibrary.Panel1.ResumeLayout(False)
		Me.SplitContainerLibrary.Panel2.ResumeLayout(False)
		Me.SplitContainerLibrary.ResumeLayout(False)
		Me.ResumeLayout(False)
	End Sub
	Friend WithEvents mainContainer As System.Windows.Forms.SplitContainer
	Friend WithEvents bodyContainer As System.Windows.Forms.SplitContainer
	Friend WithEvents designerExplorerPropertyGridContainer As System.Windows.Forms.SplitContainer
	Friend WithEvents explorerPropertyGridContainer As System.Windows.Forms.SplitContainer
	Friend WithEvents reportPropertyGrid As System.Windows.Forms.PropertyGrid
	Friend WithEvents toolStripContainer As System.Windows.Forms.ToolStripContainer
	Friend WithEvents reportExplorerTabControl As System.Windows.Forms.TabControl
	Friend WithEvents reportExplorerTabPage As System.Windows.Forms.TabPage
	Friend WithEvents reportExplorer As GrapeCity.ActiveReports.Design.ReportExplorer.ReportExplorer
	Friend WithEvents layerListTabPage As System.Windows.Forms.TabPage
	Friend WithEvents layerList As GrapeCity.ActiveReports.Design.LayerList
	Friend WithEvents toolboxSplitContainer As System.Windows.Forms.SplitContainer
	Friend WithEvents reportToolbox As GrapeCity.ActiveReports.Design.Toolbox.Toolbox
	Friend WithEvents treeView As System.Windows.Forms.TreeView
	Friend WithEvents saveFileDialog As System.Windows.Forms.SaveFileDialog
	Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
	Friend WithEvents reportDesigner As GrapeCity.ActiveReports.Design.Designer
	Friend WithEvents groupEditor As GrapeCity.ActiveReports.Design.GroupEditor.GroupEditor
	Friend WithEvents SplitContainerLibrary As System.Windows.Forms.SplitContainer
	Friend WithEvents reportsLibrary As GrapeCity.ActiveReports.Design.ReportsLibrary.ReportsLibrary
End Class
