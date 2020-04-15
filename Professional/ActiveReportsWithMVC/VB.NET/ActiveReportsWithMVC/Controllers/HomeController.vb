Imports System.Web.Mvc
Imports GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Models
Namespace Controllers
	Public Class HomeController
		Inherits Controller
		''' <summary>
		''' Returns view Index.cshtml
		''' Passes the Entire Customers list to its model
		''' </summary>
		''' <returns>Index.cshtml</returns>
		Public Function Index() As ActionResult
			Return View("Index", Repository.GetCustomers())
		End Function
		''' <summary>
		''' Start method
		''' </summary>
		''' <returns></returns>
		Public Function Start() As ActionResult
			Return Index()
		End Function
		''' <summary>
		''' Returns View Details.cshtml
		''' </summary>
		''' <param name="id">Customer ID</param>
		''' <returns>Details.cshtml</returns>
		Public Function Details(ByVal id As String) As ActionResult
			Return View("Details", Repository.GetCustomer(id))
		End Function
		''' <summary>
		''' Returns View Viewer.cshtml
		''' </summary>
		''' <param name="id">Customer id</param>
		''' <param name="reporttype">Section/Page</param>
		''' <returns>Viewer.cshtml</returns>
		Public Function ViewReport(ByVal id As String, ByVal reporttype As String) As ActionResult
			Return View("Viewer", New ReportDescriptor() With { _
			 .Id = id, _
			 .Type = reporttype _
			})
		End Function
	End Class
End Namespace
