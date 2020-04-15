Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Public Class CustomersController
	Inherits ApiController
	' Return customers
	Public Function GetCustomer() As IEnumerable(Of Customer)
		Return CustomerContext.GetCustomers().AsEnumerable()
	End Function
	' Return customer based on CustomerID
	Public Function GetCustomer(id As Integer) As Customer
		Dim customer As Customer = CustomerContext.GetCustomersDetail(id)
		If customer Is Nothing Then
			Throw New HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound))
		End If
		Return customer
	End Function
End Class
