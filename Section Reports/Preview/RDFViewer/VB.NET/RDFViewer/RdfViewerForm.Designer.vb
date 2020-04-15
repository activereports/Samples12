 _
Partial Class RdfViewerForm
	Inherits System.Windows.Forms.Form
Private components As System.ComponentModel.IContainer
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RdfViewerForm))
		Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog()
		Me.ViewerMenuStrip = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SeparatorToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TableOfContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.arvMain = New GrapeCity.ActiveReports.Viewer.Win.Viewer()
		Me.ViewerMenuStrip.SuspendLayout()
		Me.SuspendLayout()
		'
		'dlgOpenFile
		'
		'
		'ViewerMenuStrip
		'
		Me.ViewerMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
		resources.ApplyResources(Me.ViewerMenuStrip, "ViewerMenuStrip")
		Me.ViewerMenuStrip.Name = "ViewerMenuStrip"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExportToolStripMenuItem, Me.PrintToolStripMenuItem, Me.SeparatorToolStripMenuItem, Me.ExitToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		resources.ApplyResources(Me.FileToolStripMenuItem, "FileToolStripMenuItem")
		'
		'OpenToolStripMenuItem
		'
		Me.OpenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
		resources.ApplyResources(Me.OpenToolStripMenuItem, "OpenToolStripMenuItem")
		'
		'ExportToolStripMenuItem
		'
		Me.ExportToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
		resources.ApplyResources(Me.ExportToolStripMenuItem, "ExportToolStripMenuItem")
		'
		'PrintToolStripMenuItem
		'
		Me.PrintToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
		resources.ApplyResources(Me.PrintToolStripMenuItem, "PrintToolStripMenuItem")
		'
		'SeparatorToolStripMenuItem
		'
		Me.SeparatorToolStripMenuItem.Name = "SeparatorToolStripMenuItem"
		resources.ApplyResources(Me.SeparatorToolStripMenuItem, "SeparatorToolStripMenuItem")
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
		'
		'ViewToolStripMenuItem
		'
		Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TableOfContentsToolStripMenuItem, Me.ToolbarToolStripMenuItem})
		Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
		resources.ApplyResources(Me.ViewToolStripMenuItem, "ViewToolStripMenuItem")
		'
		'TableOfContentsToolStripMenuItem
		'
		Me.TableOfContentsToolStripMenuItem.CheckOnClick = True
		Me.TableOfContentsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.TableOfContentsToolStripMenuItem.Name = "TableOfContentsToolStripMenuItem"
		resources.ApplyResources(Me.TableOfContentsToolStripMenuItem, "TableOfContentsToolStripMenuItem")
		'
		'ToolbarToolStripMenuItem
		'
		Me.ToolbarToolStripMenuItem.Checked = True
		Me.ToolbarToolStripMenuItem.CheckOnClick = True
		Me.ToolbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ToolbarToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.ToolbarToolStripMenuItem.Name = "ToolbarToolStripMenuItem"
		resources.ApplyResources(Me.ToolbarToolStripMenuItem, "ToolbarToolStripMenuItem")
		'
		'arvMain
		'
		Me.arvMain.CurrentPage = 0
		resources.ApplyResources(Me.arvMain, "arvMain")
		Me.arvMain.HyperlinkBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.arvMain.HyperlinkForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.arvMain.Name = "arvMain"
		Me.arvMain.PagesBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.arvMain.PreviewPages = 0
		Me.arvMain.SearchResultsBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.arvMain.SearchResultsForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(139, Byte), Integer))
		'
		'
		'
		'
		'
		'
		Me.arvMain.Sidebar.ParametersPanel.ContextMenu = Nothing
		Me.arvMain.Sidebar.ParametersPanel.Width = 180
		'
		'
		'
		Me.arvMain.Sidebar.SearchPanel.ContextMenu = Nothing
		Me.arvMain.Sidebar.SearchPanel.Width = 180
		Me.arvMain.Sidebar.SelectedIndex = 0
		'
		'
		'
		Me.arvMain.Sidebar.ThumbnailsPanel.ContextMenu = Nothing
		Me.arvMain.Sidebar.ThumbnailsPanel.Width = 180
		'
		'
		'
		Me.arvMain.Sidebar.TocPanel.ContextMenu = Nothing
		Me.arvMain.Sidebar.TocPanel.Width = 180
		Me.arvMain.Sidebar.Width = 180
		Me.arvMain.SplitView = False
		Me.arvMain.ViewType = GrapeCity.Viewer.Common.Model.ViewType.SinglePage
		Me.arvMain.Zoom = 1.0!
		'
		'RdfViewerForm
		'
		resources.ApplyResources(Me, "$this")
		Me.Controls.Add(Me.arvMain)
		Me.Controls.Add(Me.ViewerMenuStrip)
		Me.MainMenuStrip = Me.ViewerMenuStrip
		Me.Name = "RdfViewerForm"
		Me.ViewerMenuStrip.ResumeLayout(False)
		Me.ViewerMenuStrip.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
Private WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
Friend WithEvents ViewerMenuStrip As System.Windows.Forms.MenuStrip
Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
Friend WithEvents SeparatorToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
Friend WithEvents TableOfContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
Friend WithEvents ToolbarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
Friend WithEvents arvMain As GrapeCity.ActiveReports.Viewer.Win.Viewer
End Class
