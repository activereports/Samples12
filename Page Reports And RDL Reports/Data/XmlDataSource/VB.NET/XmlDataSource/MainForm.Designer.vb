<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	'Form overrides dispose to clean up the component list.
	'
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso components IsNot Nothing Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub
	'Required designer variable.
	Private components As System.ComponentModel.IContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer. 
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.ReportPreview1 = New GrapeCity.ActiveReports.Viewer.Win.Viewer()
		Me.SuspendLayout()
		'
		'ReportPreview1
		'
		Me.ReportPreview1.AnnotationDropDownVisible = False
		Me.ReportPreview1.CurrentPage = 0
		Me.ReportPreview1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ReportPreview1.HyperlinkBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.ReportPreview1.HyperlinkForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ReportPreview1.Location = New System.Drawing.Point(0, 0)
		Me.ReportPreview1.Name = "ReportPreview1"
		Me.ReportPreview1.PagesBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.ReportPreview1.PreviewPages = 0
		Me.ReportPreview1.SearchResultsBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ReportPreview1.SearchResultsForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(139, Byte), Integer))
		Me.ReportPreview1.Size = New System.Drawing.Size(660, 467)
		Me.ReportPreview1.SplitView = False
		Me.ReportPreview1.TabIndex = 0
		Me.ReportPreview1.ViewType = GrapeCity.Viewer.Common.Model.ViewType.SinglePage
		Me.ReportPreview1.Zoom = 1.0!
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(660, 467)
		Me.Controls.Add(Me.ReportPreview1)
		Me.Name = "MainForm"
		
		Me.Text = "Xml Data Source sample"
		
		'
		Me.ResumeLayout(False)
	End Sub
	Friend WithEvents ReportPreview1 As GrapeCity.ActiveReports.Viewer.Win.Viewer
End Class
