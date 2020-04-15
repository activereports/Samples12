Imports GrapeCity.ActiveReports.Document
Public Class ViewerForm
	Inherits System.Windows.Forms.Form
	Public Sub New()
		MyBase.New()
		'Required designer variable. 
		InitializeComponent()
		' TODO: InitializeComponent After a call, it is a constructor. Please add a code.
		'
	End Sub
	' Required for Windows Form Designer support
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If Not (components Is Nothing) Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	Private Sub ViewerForm_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
		
		cboStyle.Items.Add("2D bar chart")
		cboStyle.Items.Add("3D pie chart")
		cboStyle.Items.Add("3D bar chart")
		cboStyle.Items.Add("Finance chart")
		cboStyle.Items.Add("Stacked area chart")
		
		'
		'
		'
		'
		'
		' Sets the state of the initial selection of the combo box "chart type".
		cboStyle.SelectedIndex = 0
	End Sub
	Private Sub cboList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cboStyle.SelectedIndexChanged
		' Enable the custom property combo only when you select "line graph".
		Call SetCustomProperties(Me.cboStyle.SelectedIndex)
	End Sub
	Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReport.Click
		Dim rpt As Object = Nothing
		Try
			' Display the preview according to the "chart type" combobox.
			Select Case cboStyle.SelectedIndex
				Case 0  '2D bar chart 
					rpt = New rpt2DBar
				Case 1  '3D pie chart 
					rpt = New rpt3DPie
					If cboCustom.SelectedIndex = 0 Then
						DirectCast(rpt, rpt3DPie).boClockWise = True
					Else
						DirectCast(rpt, rpt3DPie).boClockWise = False
					End If
				Case 2  ' 3D bar chart 
					rpt = New rpt3DBar
				Case 3  ' Finance chart 
					rpt = New rptCandle
				Case 4  ' Stacked area chart 
					rpt = New rptStackedArea
			End Select
			arvMain.LoadDocument(DirectCast(rpt, SectionReport))
		Catch ex As Exception
			MessageBox.Show(ex.ToString)
		End Try
	End Sub
	Private Sub SetCustomProperties(ByVal iGraphStype As Integer)
		' To clear the selected candidate.
		cboCustom.Items.Clear()
		' Add a selection candidate and set it in the selected state.
		Select Case iGraphStype
			Case 1	  ' 2D pie chart 
				' Change the Visible State
				'
				cboCustom.Visible = True
				lblCustom.Visible = True
				
				cboCustom.Items.Add("Clockwise")
				cboCustom.Items.Add("Counterclockwise")
				
				'
				'
				cboCustom.SelectedIndex = 1
				'To set a label
				'
				
				lblCustom.Text = "Direction of rotation"
				
				'
			Case Else   ' Other 
				'To make invisible
				cboCustom.Visible = False
				lblCustom.Visible = False
		End Select
		Application.DoEvents()
	End Sub
End Class
