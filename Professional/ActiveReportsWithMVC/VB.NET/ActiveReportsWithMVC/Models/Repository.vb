Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.DBContext
Namespace Models
	'Container for data required by application
	Public NotInheritable Class Repository
		Private Sub New()
		End Sub
		'Gets the Orders for a particular CustomerID
		Public Shared Function GetOrders(ByVal id As String) As IEnumerable(Of Order)
			Return NWindData.GetNWindOrders().FindAll(Function(s) s.CustomerId = id)
		End Function
		'Gets Order details for a particular CustomerID
		Public Shared Function GetDetails(ByVal customerid As String) As IEnumerable(Of OrderDetails)
			Dim ordersofcustomer = GetOrders(customerid)
			Dim orderdetails As New List(Of OrderDetails)()
			For Each order As Order In ordersofcustomer
				Dim od As String
				od = CType(order.OrderId, String)
				orderdetails.AddRange(NWindData.GetOrderDetails().FindAll(Function(s) s.OrderId = Convert.ToDouble(od)))
			Next
			Return orderdetails
		End Function
		'Gets the details of Customer
		Public Shared Function GetCustomer(ByVal id As String) As Customer
			Return NWindData.GetNWindCustomers().FirstOrDefault(Function(s) s.CustomerId = id)
		End Function
		'Gets Customers ordered by ContactName
		Public Shared Function GetCustomers() As List(Of Customer)
			Return NWindData.GetNWindCustomers().OrderBy(Function(x) x.ContactName).ToList()
		End Function
	End Class
End Namespace
