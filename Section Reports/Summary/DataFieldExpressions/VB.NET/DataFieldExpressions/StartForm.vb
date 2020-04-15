Imports System
Imports System.Windows.Forms
'DataField expressions can be helpful in cases where there is a simple piece of data that can be calculated from other Fields.
'Keep in mind however that they cannot be used for summarized fields in grouping or page sections,
'you will need to add a field to the Fields collection value and update this value in the Fetch Data event to do this.
Public Class StartForm
	Inherits System.Windows.Forms.Form
	
	Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
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
	'The main entry point for the application.
	<STAThread()> _
	Shared Sub Main()
		Application.Run(New StartForm())
	End Sub 'Main
	Private Sub StartForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		Cursor = Cursors.WaitCursor
		Dim rpt As New DataFieldExpressionsReport()
		arvMain.LoadDocument(rpt)
		Cursor = Cursors.Default
	End Sub
End Class
