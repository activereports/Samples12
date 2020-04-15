Partial Public Class MainPage
	Inherits UserControl
	Public Sub New()
		InitializeComponent()
		'Loading the Main.rdlx from the server
		ReportViewer.LoadFromService("Reports\RPX\MainReport.rpx")
	End Sub
	Private Sub Containerborder_MouseEnter(sender As System.Object, e As System.Windows.Input.MouseEventArgs)
		'Highlighting focused item
		DirectCast(sender, System.Windows.Controls.Border).BorderBrush = New SolidColorBrush(Color.FromArgb(255, 100, 149, 237))
	End Sub
	Private Sub Containerborder_MouseLeave(sender As System.Object, e As System.Windows.Input.MouseEventArgs)
		DirectCast(sender, System.Windows.Controls.Border).BorderBrush = New SolidColorBrush(Colors.Transparent)
	End Sub
	Private Sub Container_MouseLeftButtonDown(sender As System.Object, e As System.Windows.Input.MouseButtonEventArgs)
		DisplayReport(DirectCast(sender, StackPanel).Name)
	End Sub
	Private Sub DisplayReport(report As String)
		'Gets the Uri of the Hosting Application
		Select Case report
			Case "CodeContainer"
				If True Then
					'Proceesses the CodeReport.cs in the Silverlight Host application and shows in the viewer
					ReportViewer.LoadFromService("GrapeCity.ActiveReports.Samples.ActiveReportsSilverlightViewer.Web.CodeReport")
					Exit Select
				End If
			Case "RDFContainer"
				If True Then
					'Displays the EmployeeSales.rdf in the Host Application's folder inside the Silverlight Viewer
					ReportViewer.LoadFromService("Reports\RDF\EmployeeSales.rdf")
					Exit Select
				End If
			Case "RDLXContainer"
				If True Then
					'Processes the SalesReport.rdlx in the Host Application's folder and shows in the Silverlight Viewer
					ReportViewer.LoadFromService("Reports\RDLX\SalesReport.rdlx")
					Exit Select
				End If
			Case "RPXContainer"
				If True Then
					'Processes the Invoice.rpx in the Host Application's folder and shows in the Silverlight Viewer
					ReportViewer.LoadFromService("Reports\RPX\Invoice.rpx")
					Exit Select
				End If
		End Select
	End Sub
End Class
