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
		Me.exportHeaderSplitContainer = New System.Windows.Forms.SplitContainer()
		Me.lblSelectExporttxt = New System.Windows.Forms.Label()
		Me.lblExport = New System.Windows.Forms.Label()
		Me.exportSettingsSplitContainer = New System.Windows.Forms.SplitContainer()
		Me.middleRightPanel = New System.Windows.Forms.Panel()
		Me.cmbExportFormat = New System.Windows.Forms.ComboBox()
		Me.middleLeftPanel = New System.Windows.Forms.Panel()
		Me.lblExportFormat = New System.Windows.Forms.Label()
		Me.lowerRightPanel = New System.Windows.Forms.Panel()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.exportPropertyGrid = New System.Windows.Forms.PropertyGrid()
		Me.btnOk = New System.Windows.Forms.Button()
		Me.lowerLeftPanel = New System.Windows.Forms.Panel()
		Me.lblExportoptions = New System.Windows.Forms.Label()
		Me.exportSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
		Me.exportHeaderSplitContainer.Panel1.SuspendLayout()
		Me.exportHeaderSplitContainer.Panel2.SuspendLayout()
		Me.exportHeaderSplitContainer.SuspendLayout()
		Me.exportSettingsSplitContainer.Panel1.SuspendLayout()
		Me.exportSettingsSplitContainer.Panel2.SuspendLayout()
		Me.exportSettingsSplitContainer.SuspendLayout()
		Me.middleRightPanel.SuspendLayout()
		Me.middleLeftPanel.SuspendLayout()
		Me.lowerRightPanel.SuspendLayout()
		Me.lowerLeftPanel.SuspendLayout()
		Me.SuspendLayout()
		'
		'exportHeaderSplitContainer
		'
		resources.ApplyResources(Me.exportHeaderSplitContainer, "exportHeaderSplitContainer")
		Me.exportHeaderSplitContainer.Name = "exportHeaderSplitContainer"
		'
		'exportHeaderSplitContainer.Panel1
		'
		Me.exportHeaderSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.exportHeaderSplitContainer.Panel1.Controls.Add(Me.lblSelectExporttxt)
		Me.exportHeaderSplitContainer.Panel1.Controls.Add(Me.lblExport)
		'
		'exportHeaderSplitContainer.Panel2
		'
		Me.exportHeaderSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.exportHeaderSplitContainer.Panel2.Controls.Add(Me.exportSettingsSplitContainer)
		'
		'lblSelectExporttxt
		'
		resources.ApplyResources(Me.lblSelectExporttxt, "lblSelectExporttxt")
		Me.lblSelectExporttxt.Name = "lblSelectExporttxt"
		'
		'lblExport
		'
		resources.ApplyResources(Me.lblExport, "lblExport")
		Me.lblExport.Name = "lblExport"
		'
		'exportSettingsSplitContainer
		'
		Me.exportSettingsSplitContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		resources.ApplyResources(Me.exportSettingsSplitContainer, "exportSettingsSplitContainer")
		Me.exportSettingsSplitContainer.Name = "exportSettingsSplitContainer"
		'
		'exportSettingsSplitContainer.Panel1
		'
		Me.exportSettingsSplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.exportSettingsSplitContainer.Panel1.Controls.Add(Me.middleRightPanel)
		Me.exportSettingsSplitContainer.Panel1.Controls.Add(Me.middleLeftPanel)
		'
		'exportSettingsSplitContainer.Panel2
		'
		Me.exportSettingsSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.exportSettingsSplitContainer.Panel2.Controls.Add(Me.lowerRightPanel)
		Me.exportSettingsSplitContainer.Panel2.Controls.Add(Me.lowerLeftPanel)
		'
		'middleRightPanel
		'
		Me.middleRightPanel.Controls.Add(Me.cmbExportFormat)
		resources.ApplyResources(Me.middleRightPanel, "middleRightPanel")
		Me.middleRightPanel.Name = "middleRightPanel"
		'
		'cmbExportFormat
		'
		resources.ApplyResources(Me.cmbExportFormat, "cmbExportFormat")
		Me.cmbExportFormat.FormattingEnabled = True
		Me.cmbExportFormat.Name = "cmbExportFormat"
		'
		'middleLeftPanel
		'
		Me.middleLeftPanel.Controls.Add(Me.lblExportFormat)
		resources.ApplyResources(Me.middleLeftPanel, "middleLeftPanel")
		Me.middleLeftPanel.Name = "middleLeftPanel"
		'
		'lblExportFormat
		'
		resources.ApplyResources(Me.lblExportFormat, "lblExportFormat")
		Me.lblExportFormat.Name = "lblExportFormat"
		'
		'lowerRightPanel
		'
		Me.lowerRightPanel.Controls.Add(Me.btnCancel)
		Me.lowerRightPanel.Controls.Add(Me.exportPropertyGrid)
		Me.lowerRightPanel.Controls.Add(Me.btnOk)
		resources.ApplyResources(Me.lowerRightPanel, "lowerRightPanel")
		Me.lowerRightPanel.Name = "lowerRightPanel"
		'
		'btnCancel
		'
		resources.ApplyResources(Me.btnCancel, "btnCancel")
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'exportPropertyGrid
		'
		resources.ApplyResources(Me.exportPropertyGrid, "exportPropertyGrid")
		Me.exportPropertyGrid.Name = "exportPropertyGrid"
		'
		'btnOk
		'
		resources.ApplyResources(Me.btnOk, "btnOk")
		Me.btnOk.Name = "btnOk"
		Me.btnOk.UseVisualStyleBackColor = True
		'
		'lowerLeftPanel
		'
		Me.lowerLeftPanel.Controls.Add(Me.lblExportoptions)
		resources.ApplyResources(Me.lowerLeftPanel, "lowerLeftPanel")
		Me.lowerLeftPanel.Name = "lowerLeftPanel"
		'
		'lblExportoptions
		'
		resources.ApplyResources(Me.lblExportoptions, "lblExportoptions")
		Me.lblExportoptions.Name = "lblExportoptions"
		'
		'ExportForm
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.exportHeaderSplitContainer)
		Me.Name = "ExportForm"
		Me.exportHeaderSplitContainer.Panel1.ResumeLayout(False)
		Me.exportHeaderSplitContainer.Panel1.PerformLayout()
		Me.exportHeaderSplitContainer.Panel2.ResumeLayout(False)
		Me.exportHeaderSplitContainer.ResumeLayout(False)
		Me.exportSettingsSplitContainer.Panel1.ResumeLayout(False)
		Me.exportSettingsSplitContainer.Panel2.ResumeLayout(False)
		Me.exportSettingsSplitContainer.ResumeLayout(False)
		Me.middleRightPanel.ResumeLayout(False)
		Me.middleLeftPanel.ResumeLayout(False)
		Me.middleLeftPanel.PerformLayout()
		Me.lowerRightPanel.ResumeLayout(False)
		Me.lowerLeftPanel.ResumeLayout(False)
		Me.lowerLeftPanel.PerformLayout()
		Me.ResumeLayout(False)
	End Sub
	Private WithEvents exportPropertyGrid As System.Windows.Forms.PropertyGrid
	Private WithEvents exportHeaderSplitContainer As System.Windows.Forms.SplitContainer
	Private WithEvents lblSelectExporttxt As System.Windows.Forms.Label
	Private WithEvents lblExport As System.Windows.Forms.Label
	Private WithEvents exportSettingsSplitContainer As System.Windows.Forms.SplitContainer
	Friend WithEvents middleRightPanel As System.Windows.Forms.Panel
	Private WithEvents cmbExportFormat As System.Windows.Forms.ComboBox
	Friend WithEvents middleLeftPanel As System.Windows.Forms.Panel
	Private WithEvents lblExportFormat As System.Windows.Forms.Label
	Friend WithEvents lowerRightPanel As System.Windows.Forms.Panel
	Private WithEvents btnCancel As System.Windows.Forms.Button
	Private WithEvents btnOk As System.Windows.Forms.Button
	Friend WithEvents lowerLeftPanel As System.Windows.Forms.Panel
	Private WithEvents lblExportoptions As System.Windows.Forms.Label
	Private WithEvents exportSaveFileDialog As System.Windows.Forms.SaveFileDialog
End Class
