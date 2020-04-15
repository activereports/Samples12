Public Class StartupForm
	Inherits System.Windows.Forms.Form
	Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		'Add any initialization after the InitializeComponent() call
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If Not (components Is Nothing) Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	'Loads up the report into the arvMain viewer control on the StartupForm.
	'The Load event will fire when the StartupForm is loaded on the instance.
	Private Sub StartupForm_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
		Try
			'Setup a new instance of the AnnualReport
			Dim rpt As New AnnualReport()
			'Run the report, and set it to the viewer control on the form
			arvMain.LoadDocument(rpt)
		Catch ex As ReportDataException
			MessageBox.Show(ex.Message, Text)
		End Try
	End Sub
End Class
