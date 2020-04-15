Imports System
Imports System.Collections.Generic
Imports System.Data.OleDb
Imports GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Models
Namespace DBContext
	'Gets the entire Customer,Orders,Order Details table of the NWIND.mdb
	'Populates them into in-memory objects
	'Analogous to how you would fetch data via Ado.net entity framework 
	Public NotInheritable Class NWindData
		Private Sub New()
		End Sub
		Public Shared Customers As List(Of Customer)
		Public Shared Orders As List(Of Order)
		Public Shared OrderDetails As List(Of OrderDetails)
		'Gets customers from Customers table of NWind.mdb
		Public Shared Function GetNWindCustomers() As List(Of Customer)
			If Customers Is Nothing Then
				Dim allcustomers As New List(Of Customer)()
				Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\NWIND.mdb;Persist Security Info=False")
				conn.Open()
				Dim command As New OleDbCommand("Select Top 20 * from Customers", conn)
				Dim dr As OleDbDataReader = command.ExecuteReader()
				While dr.Read()
					allcustomers.Add(New Customer() With { _
					 .Address = dr("Address").ToString(), _
					 .City = dr("City").ToString(), _
					 .CompanyName = dr("CompanyName").ToString(), _
					 .ContactName = dr("ContactName").ToString(), _
					 .ContactTitle = dr("ContactTitle").ToString(), _
					 .Country = dr("Country").ToString(), _
					 .CustomerId = dr("CustomerID").ToString(), _
					 .Fax = dr("Fax").ToString(), _
					 .Phone = dr("Phone").ToString(), _
					 .PostalCode = dr("PostalCode").ToString(), _
					 .Region = dr("Region").ToString() _
					})
				End While
				conn.Close()
				Customers = allcustomers
			End If
			Return Customers
		End Function
		'Gets Orders from Nwind.mdb
		Public Shared Function GetNWindOrders() As List(Of Order)
			If Orders Is Nothing Then
				Dim allorders As New List(Of Order)()
				Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\NWIND.mdb;Persist Security Info=False")
				conn.Open()
				Dim command As New OleDbCommand("Select * from Orders", conn)
				Dim dr As OleDbDataReader = command.ExecuteReader()
				While dr.Read()
					allorders.Add(New Order() With { _
					 .CustomerId = dr("CustomerID").ToString(), _
					 .EmployeeId = Convert.ToInt64(dr("EmployeeID")), _
					 .Freight = Convert.ToDecimal(dr("Freight")), _
					 .OrderDate = If(dr("OrderDate") Is DBNull.Value, DateTime.Now.ToShortDateString(), Convert.ToDateTime(dr("OrderDate")).ToShortDateString()), _
					 .OrderId = Convert.ToInt64(dr("OrderID")), _
					 .RequiredDate = If(dr("RequiredDate") Is DBNull.Value, DateTime.Now.ToShortDateString(), Convert.ToDateTime(dr("RequiredDate")).ToShortDateString()), _
					 .ShipAddress = dr("ShipAddress").ToString(), _
					 .ShipCity = dr("ShipCity").ToString(), _
					 .ShipCountry = dr("ShipCountry").ToString(), _
					 .ShipName = dr("ShipName").ToString(), _
					 .ShippedDate = If(dr("ShippedDate") Is DBNull.Value, DateTime.Now.ToShortDateString(), Convert.ToDateTime(dr("ShippedDate")).ToShortDateString()), _
					 .ShipPostalCode = dr("ShipPostalCode").ToString(), _
					 .ShipRegion = dr("ShipRegion").ToString(), _
					 .ShipVia = Convert.ToInt64(dr("ShipVia")) _
					})
				End While
				conn.Close()
				Orders = allorders
			End If
			Return Orders
		End Function
		'Gets OrdersDetails from Order Details table of NWind.mdb
		Public Shared Function GetOrderDetails() As List(Of OrderDetails)
			If OrderDetails Is Nothing Then
				Dim allorderdetails As New List(Of OrderDetails)()
				Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\NWIND.mdb;Persist Security Info=False")
				conn.Open()
				Dim command As New OleDbCommand("Select * from [Order Details]", conn)
				Dim dr As OleDbDataReader = command.ExecuteReader()
				While dr.Read()
					allorderdetails.Add(New OrderDetails() With { _
					 .Discount = Convert.ToInt32(dr("Discount")), _
					 .OrderId = Convert.ToInt64(dr("OrderID")), _
					 .ProductId = Convert.ToInt32(dr("ProductID")), _
					 .Quantity = Convert.ToInt32(dr("Quantity")), _
					 .UnitPrice = Convert.ToDecimal(dr("UnitPrice")) _
					})
				End While
				conn.Close()
				OrderDetails = allorderdetails
			End If
			Return OrderDetails
		End Function
	End Class
End Namespace
