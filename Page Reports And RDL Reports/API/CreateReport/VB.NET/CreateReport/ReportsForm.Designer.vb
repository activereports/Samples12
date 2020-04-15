Imports GrapeCity.ActiveReports.Design
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
	Inherits System.Windows.Forms.Form
	'Form overrides dispose to clean up the component list.
	'
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
	'Required designer variable.
	Private components As System.ComponentModel.IContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer. 
	'Do not modify it using the code editor.
	
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportsForm))
		Me.toolStripContainer = New System.Windows.Forms.ToolStripContainer()
		Me.bodyContainer = New System.Windows.Forms.SplitContainer()
		Me.reportToolbox = New GrapeCity.ActiveReports.Design.Toolbox.Toolbox()
		Me.designerexplorerpropertygridContainer = New System.Windows.Forms.SplitContainer()
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.reportDesigner = New GrapeCity.ActiveReports.Design.Designer()
		Me.groupEditor = New GrapeCity.ActiveReports.Design.GroupEditor.GroupEditor()
		Me.explorerpropertygridContainer = New System.Windows.Forms.SplitContainer()
		Me.reportExplorerTabControl = New System.Windows.Forms.TabControl()
		Me.tabReportExplorer = New System.Windows.Forms.TabPage()
		Me.reportExplorer = New GrapeCity.ActiveReports.Design.ReportExplorer.ReportExplorer()
		Me.tabLayers = New System.Windows.Forms.TabPage()
		Me.layerList = New GrapeCity.ActiveReports.Design.LayerList()
		Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
		Me.mainContainer = New System.Windows.Forms.SplitContainer()
		Me.bottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
		Me.topToolStripPanel = New System.Windows.Forms.ToolStripPanel()
		Me.rightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
		Me.leftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
		Me.contentPanel = New System.Windows.Forms.ToolStripContentPanel()
		Me.SplitContainerLeft = New System.Windows.Forms.SplitContainer()
		Me.reportsLibrary = New GrapeCity.ActiveReports.Design.ReportsLibrary.ReportsLibrary()
		Me.toolStripContainer.SuspendLayout()
		Me.bodyContainer.Panel1.SuspendLayout()
		Me.bodyContainer.Panel2.SuspendLayout()
		Me.bodyContainer.SuspendLayout()
		CType(Me.reportToolbox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.designerexplorerpropertygridContainer.Panel1.SuspendLayout()
		Me.designerexplorerpropertygridContainer.Panel2.SuspendLayout()
		Me.designerexplorerpropertygridContainer.SuspendLayout()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.explorerpropertygridContainer.Panel1.SuspendLayout()
		Me.explorerpropertygridContainer.Panel2.SuspendLayout()
		Me.explorerpropertygridContainer.SuspendLayout()
		Me.mainContainer.Panel1.SuspendLayout()
		Me.mainContainer.Panel2.SuspendLayout()
		Me.mainContainer.SuspendLayout()
		Me.reportExplorerTabControl.SuspendLayout()
		Me.tabReportExplorer.SuspendLayout()
		Me.tabLayers.SuspendLayout()
		Me.SplitContainerLeft.Panel1.SuspendLayout()
		Me.SplitContainerLeft.Panel2.SuspendLayout()
		Me.SplitContainerLeft.SuspendLayout()
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
		'bodyContainer
		'
		resources.ApplyResources(Me.bodyContainer, "bodyContainer")
		Me.bodyContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.bodyContainer.Name = "bodyContainer"
		'
		'bodyContainer.Panel1
		'
		Me.bodyContainer.Panel1.Controls.Add(Me.SplitContainerLeft)
		'
		'bodyContainer.Panel2
		'
		Me.bodyContainer.Panel2.Controls.Add(Me.designerexplorerpropertygridContainer)
		'
		'reportToolbox
		'
		Me.reportToolbox.DesignerHost = Nothing
		resources.ApplyResources(Me.reportToolbox, "reportToolbox")
		Me.reportToolbox.Name = "reportToolbox"
		'
		'designerexplorerpropertygridContainer
		'
		resources.ApplyResources(Me.designerexplorerpropertygridContainer, "designerexplorerpropertygridContainer")
		Me.designerexplorerpropertygridContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
		Me.designerexplorerpropertygridContainer.Name = "designerexplorerpropertygridContainer"
		'
		'designerexplorerpropertygridContainer.Panel1
		'
		Me.designerexplorerpropertygridContainer.Panel1.Controls.Add(Me.SplitContainer1)
		'
		'designerexplorerpropertygridContainer.Panel2
		'
		Me.designerexplorerpropertygridContainer.Panel2.Controls.Add(Me.explorerpropertygridContainer)
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
		'explorerpropertygridContainer
		'
		resources.ApplyResources(Me.explorerpropertygridContainer, "explorerpropertygridContainer")
		Me.explorerpropertygridContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.explorerpropertygridContainer.Name = "explorerpropertygridContainer"
		'
		'explorerpropertygridContainer.Panel1
		'
		Me.explorerpropertygridContainer.Panel1.Controls.Add(Me.reportExplorerTabControl)
		'
		'explorerpropertygridContainer.Panel2
		'
		Me.explorerpropertygridContainer.Panel2.Controls.Add(Me.propertyGrid)
		'
		'reportExplorerTabControl
		' 
		Me.reportExplorerTabControl.Controls.Add(Me.tabReportExplorer)
		Me.reportExplorerTabControl.Controls.Add(Me.tabLayers)
		resources.ApplyResources(Me.reportExplorerTabControl, "reportExplorerTabControl")
		Me.reportExplorerTabControl.Name = "reportExplorerTabControl"
		Me.reportExplorerTabControl.SelectedIndex = 0
		' 
		' tabReportExplorer
		' 
		Me.tabReportExplorer.Controls.Add(Me.reportExplorer)
		resources.ApplyResources(Me.tabReportExplorer, "tabReportExplorer")
		Me.tabReportExplorer.Name = "tabReportExplorer"
		Me.tabReportExplorer.UseVisualStyleBackColor = True
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
		' tabLayers
		' 
		Me.tabLayers.Controls.Add(Me.layerList)
		resources.ApplyResources(Me.tabLayers, "tabLayers")
		Me.tabLayers.Name = "tabLayers"
		Me.tabLayers.UseVisualStyleBackColor = True
		' 
		' layerList
		' 
		resources.ApplyResources(Me.layerList, "layerList")
		Me.layerList.Name = "layerList"
		Me.layerList.ReportDesigner = Nothing
		' 
		'propertyGrid
		'
		Me.propertyGrid.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText
		resources.ApplyResources(Me.propertyGrid, "propertyGrid")
		Me.propertyGrid.Name = "propertyGrid"
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
		'bottomToolStripPanel
		'
		resources.ApplyResources(Me.bottomToolStripPanel, "bottomToolStripPanel")
		Me.bottomToolStripPanel.Name = "bottomToolStripPanel"
		Me.bottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
		Me.bottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		'
		'topToolStripPanel
		'
		resources.ApplyResources(Me.topToolStripPanel, "topToolStripPanel")
		Me.topToolStripPanel.Name = "topToolStripPanel"
		Me.topToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
		Me.topToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		'
		'rightToolStripPanel
		'
		resources.ApplyResources(Me.rightToolStripPanel, "rightToolStripPanel")
		Me.rightToolStripPanel.Name = "rightToolStripPanel"
		Me.rightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
		Me.rightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		'
		'leftToolStripPanel
		'
		resources.ApplyResources(Me.leftToolStripPanel, "leftToolStripPanel")
		Me.leftToolStripPanel.Name = "leftToolStripPanel"
		Me.leftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
		Me.leftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		'
		'contentPanel
		'
		resources.ApplyResources(Me.contentPanel, "contentPanel")
		'
		'SplitContainerLeft
		'
		resources.ApplyResources(Me.SplitContainerLeft, "SplitContainerLeft")
		Me.SplitContainerLeft.Name = "SplitContainerLeft"
		'
		'SplitContainerLeft.Panel1
		'
		Me.SplitContainerLeft.Panel1.Controls.Add(Me.reportToolbox)
		'
		'SplitContainerLeft.Panel2
		'
		Me.SplitContainerLeft.Panel2.Controls.Add(Me.reportsLibrary)
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
		Me.bodyContainer.Panel1.ResumeLayout(False)
		Me.bodyContainer.Panel2.ResumeLayout(False)
		Me.bodyContainer.ResumeLayout(False)
		CType(Me.reportToolbox, System.ComponentModel.ISupportInitialize).EndInit()
		Me.designerexplorerpropertygridContainer.Panel1.ResumeLayout(False)
		Me.designerexplorerpropertygridContainer.Panel2.ResumeLayout(False)
		Me.designerexplorerpropertygridContainer.ResumeLayout(False)
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.ResumeLayout(False)
		Me.explorerpropertygridContainer.Panel1.ResumeLayout(False)
		Me.explorerpropertygridContainer.Panel2.ResumeLayout(False)
		Me.explorerpropertygridContainer.ResumeLayout(False)
		Me.mainContainer.Panel1.ResumeLayout(False)
		Me.mainContainer.Panel2.ResumeLayout(False)
		Me.mainContainer.ResumeLayout(False)
		Me.reportExplorerTabControl.ResumeLayout(False)
		Me.tabReportExplorer.ResumeLayout(False)
		Me.tabLayers.ResumeLayout(False)
		Me.SplitContainerLeft.Panel1.ResumeLayout(False)
		Me.SplitContainerLeft.Panel2.ResumeLayout(False)
		Me.SplitContainerLeft.ResumeLayout(False)
		Me.ResumeLayout(False)
	End Sub
	
	'
	'
	'
	'
	'
	'
	'
	'
	'	 
	'
	'
	'	  
	'
	'
	'
	'
	'
	'	  
	'  
	'
	'
	'
	'
	'
	'
	'
	'
	'
	'
	'
	
	Friend WithEvents bodyContainer As System.Windows.Forms.SplitContainer
	Friend WithEvents reportToolbox As GrapeCity.ActiveReports.Design.Toolbox.Toolbox
	Friend WithEvents designerexplorerpropertygridContainer As System.Windows.Forms.SplitContainer
	Friend WithEvents explorerpropertygridContainer As System.Windows.Forms.SplitContainer
	Friend WithEvents reportExplorer As GrapeCity.ActiveReports.Design.ReportExplorer.ReportExplorer
	Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
	Friend WithEvents mainContainer As System.Windows.Forms.SplitContainer
	Friend WithEvents toolStripContainer As System.Windows.Forms.ToolStripContainer
	Friend WithEvents bottomToolStripPanel As System.Windows.Forms.ToolStripPanel
	Friend WithEvents topToolStripPanel As System.Windows.Forms.ToolStripPanel
	Friend WithEvents rightToolStripPanel As System.Windows.Forms.ToolStripPanel
	Friend WithEvents leftToolStripPanel As System.Windows.Forms.ToolStripPanel
	Friend WithEvents contentPanel As System.Windows.Forms.ToolStripContentPanel
	Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
	Friend WithEvents reportDesigner As GrapeCity.ActiveReports.Design.Designer
	Friend WithEvents groupEditor As GrapeCity.ActiveReports.Design.GroupEditor.GroupEditor
	Friend WithEvents SplitContainerLeft As System.Windows.Forms.SplitContainer
	Friend WithEvents reportsLibrary As GrapeCity.ActiveReports.Design.ReportsLibrary.ReportsLibrary
	Friend WithEvents reportExplorerTabControl As System.Windows.Forms.TabControl
	Friend WithEvents tabReportExplorer As System.Windows.Forms.TabPage
	Friend WithEvents tabLayers As System.Windows.Forms.TabPage
	Friend WithEvents layerList As Design.LayerList
	
	'
End Class
