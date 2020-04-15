 _
Partial Class PreviewForm
	Inherits System.Windows.Forms.Form
Private components As System.ComponentModel.IContainer
Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreviewForm))
		Me.arvMain = New GrapeCity.ActiveReports.Viewer.Win.Viewer()
		Me.mnuMain = New System.Windows.Forms.MainMenu(Me.components)
		Me.mnuFile = New System.Windows.Forms.MenuItem()
		Me.mnuExport = New System.Windows.Forms.MenuItem()
		Me.mnuSaveDocument = New System.Windows.Forms.MenuItem()
		Me.dlgPrint = New System.Windows.Forms.PrintDialog()
		Me.SuspendLayout()
		'
		'arvMain
		'
		Me.arvMain.BackColor = System.Drawing.SystemColors.Control
		Me.arvMain.CurrentPage = 0
		resources.ApplyResources(Me.arvMain, "arvMain")
		Me.arvMain.Name = "arvMain"
		Me.arvMain.PreviewPages = 0
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
		'
		'mnuMain
		'
		Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile})
		'
		'mnuFile
		'
		Me.mnuFile.Index = 0
		Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuExport, Me.mnuSaveDocument})
		Me.mnuFile.MergeType = System.Windows.Forms.MenuMerge.MergeItems
		resources.ApplyResources(Me.mnuFile, "mnuFile")
		'
		'mnuExport
		'
		Me.mnuExport.Index = 0
		resources.ApplyResources(Me.mnuExport, "mnuExport")
		'
		'mnuSaveDocument
		'
		Me.mnuSaveDocument.Index = 1
		resources.ApplyResources(Me.mnuSaveDocument, "mnuSaveDocument")
		'
		'dlgPrint
		'
		Me.dlgPrint.AllowSomePages = True
		'
		'PreviewForm
		'
		resources.ApplyResources(Me, "$this")
		Me.Controls.Add(Me.arvMain)
		Me.Menu = Me.mnuMain
		Me.Name = "PreviewForm"
		Me.ShowIcon = False
		Me.ResumeLayout(False)
	End Sub
Private WithEvents arvMain As GrapeCity.ActiveReports.Viewer.Win.Viewer
Private mnuMain As System.Windows.Forms.MainMenu
Private mnuFile As System.Windows.Forms.MenuItem
Private WithEvents mnuExport As System.Windows.Forms.MenuItem
Private WithEvents mnuSaveDocument As System.Windows.Forms.MenuItem
Private dlgPrint As System.Windows.Forms.PrintDialog
End Class
