Imports GrapeCity.ActiveReports.Design
Namespace UI
	Partial Class ReportsForm
		' <summary>
		'Required designer variable.
		' </summary>
		Private components As System.ComponentModel.IContainer = Nothing
		' <summary>
		'Clean up any resources being used.
		' </summary>
		'<param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso Not ((components) Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub
		' <summary>
		'Required method for Designer support - do not modify
		'the contents of this method with the code editor.
		' </summary>
		
		Private Sub InitializeComponent()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportsForm))
			Me.toolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
			Me.MainContainer = New System.Windows.Forms.SplitContainer()
			Me.bodyContainer = New System.Windows.Forms.SplitContainer()
			Me.designerexplorerpropertygridContainer = New System.Windows.Forms.SplitContainer()
			Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
			Me.userDesignerControl1 = New GrapeCity.ActiveReports.Design.Designer()
			Me.groupEditor = New GrapeCity.ActiveReports.Design.GroupEditor.GroupEditor()
			Me.explorerpropertygridContainer = New System.Windows.Forms.SplitContainer()
			Me.reportExplorerTabControl = New System.Windows.Forms.TabControl()
			Me.tabReportExplorer = New System.Windows.Forms.TabPage()
			Me.reportExplorer = New GrapeCity.ActiveReports.Design.ReportExplorer.ReportExplorer()
			Me.tabLayers = New System.Windows.Forms.TabPage()
			Me.layerList = New GrapeCity.ActiveReports.Design.LayerList()
			Me.reportpropertyGrid = New System.Windows.Forms.PropertyGrid()
			Me.splitContainerLeft = New System.Windows.Forms.SplitContainer()
			Me.reportToolbox = New GrapeCity.ActiveReports.Design.Toolbox.Toolbox()
			Me.reportsLibrary = New GrapeCity.ActiveReports.Design.ReportsLibrary.ReportsLibrary()
			Me.toolStripContainer1.SuspendLayout()
			Me.MainContainer.Panel1.SuspendLayout()
			Me.MainContainer.Panel2.SuspendLayout()
			Me.MainContainer.SuspendLayout()
			Me.bodyContainer.Panel1.SuspendLayout()
			Me.bodyContainer.Panel2.SuspendLayout()
			Me.bodyContainer.SuspendLayout()
			Me.designerexplorerpropertygridContainer.Panel1.SuspendLayout()
			Me.designerexplorerpropertygridContainer.Panel2.SuspendLayout()
			Me.designerexplorerpropertygridContainer.SuspendLayout()
			Me.SplitContainer1.Panel1.SuspendLayout()
			Me.SplitContainer1.Panel2.SuspendLayout()
			Me.SplitContainer1.SuspendLayout()
			Me.explorerpropertygridContainer.Panel1.SuspendLayout()
			Me.explorerpropertygridContainer.Panel2.SuspendLayout()
			Me.explorerpropertygridContainer.SuspendLayout()
			Me.reportExplorerTabControl.SuspendLayout()
			Me.tabReportExplorer.SuspendLayout()
			Me.tabLayers.SuspendLayout()
			Me.splitContainerLeft.Panel1.SuspendLayout()
			Me.splitContainerLeft.Panel2.SuspendLayout()
			Me.splitContainerLeft.SuspendLayout()
			CType(Me.reportToolbox, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			'
			'toolStripContainer1
			'
			'
			'toolStripContainer1.ContentPanel
			'
			resources.ApplyResources(Me.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel")
			resources.ApplyResources(Me.toolStripContainer1, "toolStripContainer1")
			Me.toolStripContainer1.Name = "toolStripContainer1"
			'
			'MainContainer
			'
			resources.ApplyResources(Me.MainContainer, "MainContainer")
			Me.MainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
			Me.MainContainer.Name = "MainContainer"
			'
			'MainContainer.Panel1
			'
			Me.MainContainer.Panel1.Controls.Add(Me.toolStripContainer1)
			'
			'MainContainer.Panel2
			'
			Me.MainContainer.Panel2.Controls.Add(Me.bodyContainer)
			'
			'bodyContainer
			'
			resources.ApplyResources(Me.bodyContainer, "bodyContainer")
			Me.bodyContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
			Me.bodyContainer.Name = "bodyContainer"
			'
			'bodyContainer.Panel1
			'
			Me.bodyContainer.Panel1.Controls.Add(Me.splitContainerLeft)
			'
			'bodyContainer.Panel2
			'
			Me.bodyContainer.Panel2.Controls.Add(Me.designerexplorerpropertygridContainer)
			'
			'designerexplorerpropertygridContainer
			'
			resources.ApplyResources(Me.designerexplorerpropertygridContainer, "designerexplorerpropertygridContainer")
			Me.designerexplorerpropertygridContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
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
			Me.SplitContainer1.Panel1.Controls.Add(Me.userDesignerControl1)
			'
			'SplitContainer1.Panel2
			'
			Me.SplitContainer1.Panel2.Controls.Add(Me.groupEditor)
			'
			'userDesignerControl1
			'
			resources.ApplyResources(Me.userDesignerControl1, "userDesignerControl1")
			Me.userDesignerControl1.IsDirty = False
			Me.userDesignerControl1.LockControls = False
			Me.userDesignerControl1.Name = "userDesignerControl1"
			Me.userDesignerControl1.PreviewPages = 10
			Me.userDesignerControl1.PromptUser = True
			Me.userDesignerControl1.PropertyGrid = Nothing
			Me.userDesignerControl1.ReportTabsVisible = True
			Me.userDesignerControl1.ShowDataSourceIcon = True
			Me.userDesignerControl1.Toolbox = Nothing
			Me.userDesignerControl1.ToolBoxItem = Nothing
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
			Me.explorerpropertygridContainer.Panel2.Controls.Add(Me.reportpropertyGrid)
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
			'reportpropertyGrid
			'
			Me.reportpropertyGrid.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText
			resources.ApplyResources(Me.reportpropertyGrid, "reportpropertyGrid")
			Me.reportpropertyGrid.Name = "reportpropertyGrid"
			'
			'splitContainerLeft
			'
			resources.ApplyResources(Me.splitContainerLeft, "splitContainerLeft")
			Me.splitContainerLeft.Name = "splitContainerLeft"
			'
			'splitContainerLeft.Panel1
			'
			Me.splitContainerLeft.Panel1.Controls.Add(Me.reportToolbox)
			'
			'splitContainerLeft.Panel2
			'
			Me.splitContainerLeft.Panel2.Controls.Add(Me.reportsLibrary)
			'
			'reportToolbox
			'
			Me.reportToolbox.DesignerHost = Nothing
			resources.ApplyResources(Me.reportToolbox, "reportToolbox")
			Me.reportToolbox.Name = "reportToolbox"
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
			Me.Controls.Add(Me.MainContainer)
			Me.Name = "ReportsForm"
			Me.toolStripContainer1.ResumeLayout(False)
			Me.toolStripContainer1.PerformLayout()
			Me.MainContainer.Panel1.ResumeLayout(False)
			Me.MainContainer.Panel2.ResumeLayout(False)
			Me.MainContainer.ResumeLayout(False)
			Me.bodyContainer.Panel1.ResumeLayout(False)
			Me.bodyContainer.Panel2.ResumeLayout(False)
			Me.bodyContainer.ResumeLayout(False)
			Me.designerexplorerpropertygridContainer.Panel1.ResumeLayout(False)
			Me.designerexplorerpropertygridContainer.Panel2.ResumeLayout(False)
			Me.designerexplorerpropertygridContainer.ResumeLayout(False)
			Me.SplitContainer1.Panel1.ResumeLayout(False)
			Me.SplitContainer1.Panel2.ResumeLayout(False)
			Me.SplitContainer1.ResumeLayout(False)
			Me.explorerpropertygridContainer.Panel1.ResumeLayout(False)
			Me.explorerpropertygridContainer.Panel2.ResumeLayout(False)
			Me.explorerpropertygridContainer.ResumeLayout(False)
			Me.reportExplorerTabControl.ResumeLayout(False)
			Me.tabReportExplorer.ResumeLayout(False)
			Me.tabLayers.ResumeLayout(False)
			Me.splitContainerLeft.Panel1.ResumeLayout(False)
			Me.splitContainerLeft.Panel2.ResumeLayout(False)
			Me.splitContainerLeft.ResumeLayout(False)
			CType(Me.reportToolbox, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub
		Private MainContainer As System.Windows.Forms.SplitContainer
		Private WithEvents toolStripContainer1 As System.Windows.Forms.ToolStripContainer
		Private bodyContainer As System.Windows.Forms.SplitContainer
		Private designerexplorerpropertygridContainer As System.Windows.Forms.SplitContainer
		Private explorerpropertygridContainer As System.Windows.Forms.SplitContainer
		Private reportExplorer As GrapeCity.ActiveReports.Design.ReportExplorer.ReportExplorer
		Private reportpropertyGrid As System.Windows.Forms.PropertyGrid
		Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
		Private WithEvents userDesignerControl1 As GrapeCity.ActiveReports.Design.Designer
		Friend WithEvents groupEditor As GrapeCity.ActiveReports.Design.GroupEditor.GroupEditor
		Private WithEvents splitContainerLeft As System.Windows.Forms.SplitContainer
		Private WithEvents reportToolbox As GrapeCity.ActiveReports.Design.Toolbox.Toolbox
		Private WithEvents reportsLibrary As GrapeCity.ActiveReports.Design.ReportsLibrary.ReportsLibrary
		Friend WithEvents reportExplorerTabControl As System.Windows.Forms.TabControl
		Friend WithEvents tabReportExplorer As System.Windows.Forms.TabPage
		Friend WithEvents tabLayers As System.Windows.Forms.TabPage
		Friend WithEvents layerList As Design.LayerList
		
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
		'
		'
		'
	End Class
End Namespace
