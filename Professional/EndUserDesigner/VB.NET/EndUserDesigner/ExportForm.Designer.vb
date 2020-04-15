<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportForm
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExportForm))
		Me.exportSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
		Me.pBanner = New System.Windows.Forms.Panel()
		Me.lblExport = New System.Windows.Forms.Label()
		Me.lblSelectExportTxt = New System.Windows.Forms.Label()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnOk = New System.Windows.Forms.Button()
		Me.exportPropertyGrid = New System.Windows.Forms.PropertyGrid()
		Me.lblExportOptions = New System.Windows.Forms.Label()
		Me.lblExportFormat = New System.Windows.Forms.Label()
		Me.cmbExportFormat = New System.Windows.Forms.ComboBox()
		Me.pBanner.SuspendLayout()
		Me.SuspendLayout()
		'
		'pBanner
		'
		resources.ApplyResources(Me.pBanner, "pBanner")
		Me.pBanner.BackColor = System.Drawing.Color.White
		Me.pBanner.Controls.Add(Me.lblExport)
		Me.pBanner.Controls.Add(Me.lblSelectExportTxt)
		Me.pBanner.Name = "pBanner"
		'
		'lblExport
		'
		resources.ApplyResources(Me.lblExport, "lblExport")
		Me.lblExport.Name = "lblExport"
		'
		'lblSelectExportTxt
		'
		resources.ApplyResources(Me.lblSelectExportTxt, "lblSelectExportTxt")
		Me.lblSelectExportTxt.Name = "lblSelectExportTxt"
		'
		'btnCancel
		'
		resources.ApplyResources(Me.btnCancel, "btnCancel")
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnOk
		'
		resources.ApplyResources(Me.btnOk, "btnOk")
		Me.btnOk.Name = "btnOk"
		Me.btnOk.UseVisualStyleBackColor = True
		'
		'exportPropertyGrid
		'
		resources.ApplyResources(Me.exportPropertyGrid, "exportPropertyGrid")
		Me.exportPropertyGrid.LineColor = System.Drawing.SystemColors.ScrollBar
		Me.exportPropertyGrid.Name = "exportPropertyGrid"
		'
		'lblExportOptions
		'
		resources.ApplyResources(Me.lblExportOptions, "lblExportOptions")
		Me.lblExportOptions.Name = "lblExportOptions"
		'
		'lblExportFormat
		'
		resources.ApplyResources(Me.lblExportFormat, "lblExportFormat")
		Me.lblExportFormat.Name = "lblExportFormat"
		'
		'cmbExportFormat
		'
		resources.ApplyResources(Me.cmbExportFormat, "cmbExportFormat")
		Me.cmbExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbExportFormat.Name = "cmbExportFormat"
		'
		'ExportForm
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnOk)
		Me.Controls.Add(Me.exportPropertyGrid)
		Me.Controls.Add(Me.lblExportOptions)
		Me.Controls.Add(Me.lblExportFormat)
		Me.Controls.Add(Me.cmbExportFormat)
		Me.Controls.Add(Me.pBanner)
		Me.Name = "ExportForm"
		Me.pBanner.ResumeLayout(False)
		Me.pBanner.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()
End Sub
	Private exportSaveFileDialog As System.Windows.Forms.SaveFileDialog
	Private WithEvents pBanner As System.Windows.Forms.Panel
	Private WithEvents lblExport As System.Windows.Forms.Label
	Private WithEvents lblSelectExportTxt As System.Windows.Forms.Label
	Private WithEvents btnCancel As System.Windows.Forms.Button
	Private WithEvents btnOk As System.Windows.Forms.Button
	Private WithEvents exportPropertyGrid As System.Windows.Forms.PropertyGrid
	Private WithEvents lblExportOptions As System.Windows.Forms.Label
	Private WithEvents lblExportFormat As System.Windows.Forms.Label
	Private WithEvents cmbExportFormat As System.Windows.Forms.ComboBox
End Class
