Imports System
Imports System.Windows.Forms
'CalculatedFields sample shows how to create a new Calculated Field in an ActiveReport and use it with the built in summary features.
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
	'StartForm_Load - Creates the ActiveReport document and loads it into
	' the viewer control.  
	' 
	Private Sub StartForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		Dim rpt As New OrdersReport()
		arvMain.LoadDocument(rpt)
	End Sub	'StartForm_Load
End Class 'StartForm'
