 _
Partial Class ViewerForm
	Inherits System.Windows.Forms.Form
Private components As System.ComponentModel.IContainer
<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewerForm))
		Me.splitContainer = New System.Windows.Forms.SplitContainer()
		Me.lblStyle = New System.Windows.Forms.Label()
		Me.lblCustom = New System.Windows.Forms.Label()
		Me.cboCustom = New System.Windows.Forms.ComboBox()
		Me.cboStyle = New System.Windows.Forms.ComboBox()
		Me.btnReport = New System.Windows.Forms.Button()
		Me.arvMain = New GrapeCity.ActiveReports.Viewer.Win.Viewer()
		Me.splitContainer.Panel1.SuspendLayout()
		Me.splitContainer.Panel2.SuspendLayout()
		Me.splitContainer.SuspendLayout()
		Me.SuspendLayout()
		'
		'splitContainer
		'
		resources.ApplyResources(Me.splitContainer, "splitContainer")
		Me.splitContainer.Name = "splitContainer"
		'
		'splitContainer.Panel1
		'
		resources.ApplyResources(Me.splitContainer.Panel1, "splitContainer.Panel1")
		Me.splitContainer.Panel1.Controls.Add(Me.lblStyle)
		Me.splitContainer.Panel1.Controls.Add(Me.lblCustom)
		Me.splitContainer.Panel1.Controls.Add(Me.cboCustom)
		Me.splitContainer.Panel1.Controls.Add(Me.cboStyle)
		Me.splitContainer.Panel1.Controls.Add(Me.btnReport)
		'
		'splitContainer.Panel2
		'
		resources.ApplyResources(Me.splitContainer.Panel2, "splitContainer.Panel2")
		Me.splitContainer.Panel2.Controls.Add(Me.arvMain)
		'
		'lblStyle
		'
		resources.ApplyResources(Me.lblStyle, "lblStyle")
		Me.lblStyle.Name = "lblStyle"
		'
		'lblCustom
		'
		resources.ApplyResources(Me.lblCustom, "lblCustom")
		Me.lblCustom.Name = "lblCustom"
		'
		'cboCustom
		'
		resources.ApplyResources(Me.cboCustom, "cboCustom")
		Me.cboCustom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboCustom.FormattingEnabled = True
		Me.cboCustom.Name = "cboCustom"
		'
		'cboStyle
		'
		resources.ApplyResources(Me.cboStyle, "cboStyle")
		Me.cboStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboStyle.FormattingEnabled = True
		Me.cboStyle.Name = "cboStyle"
		'
		'btnReport
		'
		resources.ApplyResources(Me.btnReport, "btnReport")
		Me.btnReport.Name = "btnReport"
		Me.btnReport.UseVisualStyleBackColor = True
		'
		'arvMain
		'
		resources.ApplyResources(Me.arvMain, "arvMain")
		Me.arvMain.BackColor = System.Drawing.SystemColors.Control
		Me.arvMain.CurrentPage = 0
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
		'ViewerForm
		'
		resources.ApplyResources(Me, "$this")
		Me.Controls.Add(Me.splitContainer)
		Me.Name = "ViewerForm"
		Me.splitContainer.Panel1.ResumeLayout(False)
		Me.splitContainer.Panel1.PerformLayout()
		Me.splitContainer.Panel2.ResumeLayout(False)
		Me.splitContainer.ResumeLayout(False)
		Me.ResumeLayout(False)
	End Sub
	Friend WithEvents splitContainer As System.Windows.Forms.SplitContainer
	Friend WithEvents arvMain As GrapeCity.ActiveReports.Viewer.Win.Viewer
Friend WithEvents cboStyle As System.Windows.Forms.ComboBox
Friend WithEvents btnReport As System.Windows.Forms.Button
Friend WithEvents lblCustom As System.Windows.Forms.Label
Friend WithEvents cboCustom As System.Windows.Forms.ComboBox
Friend WithEvents lblStyle As System.Windows.Forms.Label
End Class
