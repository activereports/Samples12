 _
Partial Class CustomPreviewForm
	Inherits System.Windows.Forms.Form
Private components As System.ComponentModel.IContainer
Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomPreviewForm))
		Me.mnuMain = New System.Windows.Forms.MainMenu(Me.components)
		Me.mnuFile = New System.Windows.Forms.MenuItem()
		Me.mnuFileOpen = New System.Windows.Forms.MenuItem()
		Me.MenuSpreadBuilderitem = New System.Windows.Forms.MenuItem()
		Me.mnuFileExit = New System.Windows.Forms.MenuItem()
		Me.mnuReports = New System.Windows.Forms.MenuItem()
		Me.mnuRCatalog = New System.Windows.Forms.MenuItem()
		Me.mnuRCustomerLabels = New System.Windows.Forms.MenuItem()
		Me.mnuREmployeeProfiles = New System.Windows.Forms.MenuItem()
		Me.mnuEmpSales = New System.Windows.Forms.MenuItem()
		Me.mnuRInvoice = New System.Windows.Forms.MenuItem()
		Me.mnuRLetter = New System.Windows.Forms.MenuItem()
		Me.mnuWindow = New System.Windows.Forms.MenuItem()
		Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog()
		Me.SuspendLayout()
		'
		'mnuMain
		'
		Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuReports, Me.mnuWindow})
		resources.ApplyResources(Me.mnuMain, "mnuMain")
		'
		'mnuFile
		'
		resources.ApplyResources(Me.mnuFile, "mnuFile")
		Me.mnuFile.Index = 0
		Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileOpen, Me.MenuSpreadBuilderitem, Me.mnuFileExit})
		Me.mnuFile.MergeType = System.Windows.Forms.MenuMerge.MergeItems
		'
		'mnuFileOpen
		'
		resources.ApplyResources(Me.mnuFileOpen, "mnuFileOpen")
		Me.mnuFileOpen.Index = 0
		'
		'MenuSpreadBuilderitem
		'
		resources.ApplyResources(Me.MenuSpreadBuilderitem, "MenuSpreadBuilderitem")
		Me.MenuSpreadBuilderitem.Index = 1
		'
		'mnuFileExit
		'
		resources.ApplyResources(Me.mnuFileExit, "mnuFileExit")
		Me.mnuFileExit.Index = 2
		Me.mnuFileExit.MergeOrder = 1
		'
		'mnuReports
		'
		resources.ApplyResources(Me.mnuReports, "mnuReports")
		Me.mnuReports.Index = 1
		Me.mnuReports.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRCatalog, Me.mnuRCustomerLabels, Me.mnuREmployeeProfiles, Me.mnuEmpSales, Me.mnuRInvoice, Me.mnuRLetter})
		'
		'mnuRCatalog
		'
		resources.ApplyResources(Me.mnuRCatalog, "mnuRCatalog")
		Me.mnuRCatalog.Index = 0
		'
		'mnuRCustomerLabels
		'
		resources.ApplyResources(Me.mnuRCustomerLabels, "mnuRCustomerLabels")
		Me.mnuRCustomerLabels.Index = 1
		'
		'mnuREmployeeProfiles
		'
		resources.ApplyResources(Me.mnuREmployeeProfiles, "mnuREmployeeProfiles")
		Me.mnuREmployeeProfiles.Index = 2
		'
		'mnuEmpSales
		'
		resources.ApplyResources(Me.mnuEmpSales, "mnuEmpSales")
		Me.mnuEmpSales.Index = 3
		'
		'mnuRInvoice
		'
		resources.ApplyResources(Me.mnuRInvoice, "mnuRInvoice")
		Me.mnuRInvoice.Index = 4
		'
		'mnuRLetter
		'
		resources.ApplyResources(Me.mnuRLetter, "mnuRLetter")
		Me.mnuRLetter.Index = 5
		'
		'mnuWindow
		'
		resources.ApplyResources(Me.mnuWindow, "mnuWindow")
		Me.mnuWindow.Index = 2
		Me.mnuWindow.MdiList = True
		'
		'dlgOpenFile
		'
		resources.ApplyResources(Me.dlgOpenFile, "dlgOpenFile")
		'
		'CustomPreviewForm
		'
		resources.ApplyResources(Me, "$this")
		Me.IsMdiContainer = True
		Me.Menu = Me.mnuMain
		Me.Name = "CustomPreviewForm"
		Me.ResumeLayout(False)
	End Sub 
Private mnuMain As System.Windows.Forms.MainMenu
Private dlgOpenFile As System.Windows.Forms.OpenFileDialog
Private mnuFile As System.Windows.Forms.MenuItem
Private WithEvents mnuFileOpen As System.Windows.Forms.MenuItem
Private WithEvents mnuFileExit As System.Windows.Forms.MenuItem
Private mnuReports As System.Windows.Forms.MenuItem
Private WithEvents mnuRCatalog As System.Windows.Forms.MenuItem
Private WithEvents mnuRCustomerLabels As System.Windows.Forms.MenuItem
Private WithEvents mnuREmployeeProfiles As System.Windows.Forms.MenuItem
Private WithEvents mnuRInvoice As System.Windows.Forms.MenuItem
Private WithEvents mnuRLetter As System.Windows.Forms.MenuItem
Private mnuWindow As System.Windows.Forms.MenuItem
Friend WithEvents MenuSpreadBuilderitem As System.Windows.Forms.MenuItem
Friend WithEvents mnuEmpSales As System.Windows.Forms.MenuItem
End Class
