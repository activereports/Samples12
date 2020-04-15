 _
Partial Class CategorySelectForm
	Inherits System.Windows.Forms.Form
Private components As System.ComponentModel.IContainer
<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategorySelectForm))
		Me.pnlCategorySelect = New System.Windows.Forms.Panel()
		Me.lblSelect = New System.Windows.Forms.Label()
		Me.cbCategories = New System.Windows.Forms.ComboBox()
		Me.arvMain = New GrapeCity.ActiveReports.Viewer.Win.Viewer()
		Me.pnlCategorySelect.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlCategorySelect
		'
		Me.pnlCategorySelect.Controls.Add(Me.lblSelect)
		Me.pnlCategorySelect.Controls.Add(Me.cbCategories)
		resources.ApplyResources(Me.pnlCategorySelect, "pnlCategorySelect")
		Me.pnlCategorySelect.Name = "pnlCategorySelect"
		'
		'lblSelect
		'
		resources.ApplyResources(Me.lblSelect, "lblSelect")
		Me.lblSelect.Name = "lblSelect"
		'
		'cbCategories
		'
		resources.ApplyResources(Me.cbCategories, "cbCategories")
		Me.cbCategories.Name = "cbCategories"
		'
		'arvMain
		'
		Me.arvMain.BackColor = System.Drawing.SystemColors.Control
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
		'CategorySelectForm
		'
		resources.ApplyResources(Me, "$this")
		Me.Controls.Add(Me.arvMain)
		Me.Controls.Add(Me.pnlCategorySelect)
		Me.Name = "CategorySelectForm"
		Me.pnlCategorySelect.ResumeLayout(False)
		Me.pnlCategorySelect.PerformLayout()
		Me.ResumeLayout(False)
	End Sub
Private WithEvents arvMain As GrapeCity.ActiveReports.Viewer.Win.Viewer
Private WithEvents cbCategories As System.Windows.Forms.ComboBox
Private WithEvents lblSelect As System.Windows.Forms.Label
Private WithEvents pnlCategorySelect As System.Windows.Forms.Panel
End Class
