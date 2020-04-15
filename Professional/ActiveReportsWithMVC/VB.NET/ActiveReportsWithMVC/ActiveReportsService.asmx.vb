Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Web.Services
Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Models
<WebService([Namespace]:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class ActiveReportsService
	Inherits Web.ReportService
	Private _reportDataId As String = Nothing
	Protected Overrides Function OnCreateReportHandler(reportPath As String) As Object
		Dim data = reportPath.Split(";")
		If data.Length <> 2 Then
			Return MyBase.OnCreateReportHandler(reportPath)
		End If
		Select Case data(0)
			Case "Section"
				Dim report = New SectionReport
				report.LoadLayout(Server.MapPath("~/Reports/OrderReport.rpx"))
				report.DataSource = Repository.GetOrders(data(1))
				Dim xvalues As New List(Of String)()
				Dim yvalues As New List(Of Double)()
				For Each order As Order In Repository.GetOrders(data(1))
					xvalues.Add(order.ShippedDate)
					yvalues.Add(Convert.ToDouble(order.Freight))
				Next
				DirectCast(report.Sections("reportFooter1").Controls(0), SectionReportModel.ChartControl).Series(0).Points.DataBindXY(xvalues.ToArray(), yvalues.ToArray())
				Return report
			Case "Page"
				Dim report = New PageReport(New FileInfo(Server.MapPath("~/Reports/OrderDetailsReport.rdlx")))
				_reportDataId = data(1)
				AddHandler DirectCast(report.Document, PageDocument).LocateDataSource, AddressOf OnLocateDataSource
				Return report
		End Select
		Return MyBase.OnCreateReportHandler(reportPath)
	End Function
	Private Sub OnLocateDataSource(ByVal sender As Object, ByVal args As LocateDataSourceEventArgs)
		args.Data = Repository.GetDetails(_reportDataId)
	End Sub
End Class
