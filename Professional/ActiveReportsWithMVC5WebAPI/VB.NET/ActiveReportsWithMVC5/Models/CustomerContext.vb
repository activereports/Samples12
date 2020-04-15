Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data.OleDb
Public Class CustomerContext
	Public Shared Customers As List(Of Customer)
	Public Shared customer As Customer
	''' <summary>
	''' Gets customers from CustomerOrders table of Reels.mdb
	''' <returns>list of Customers</returns>
	''' </summary>
	Public Shared Function GetCustomers() As List(Of Customer)
		If Customers Is Nothing Then
			Dim allcustomers As New List(Of Customer)
			Dim conn As New OleDbConnection(ConnectString())
			conn.Open()
			Dim command As New OleDbCommand("select Distinct Top 30 CustomerID, FirstName,LastName,MiddleInitial from CustomerOrders", conn)
			Dim dr As OleDbDataReader = command.ExecuteReader()
			While dr IsNot Nothing AndAlso dr.Read
				allcustomers.Add(New Customer With _
				{
					.ContactName = dr("FirstName").ToString() & " " & dr("MiddleInitial").ToString() & " " & dr("LastName").ToString(),
					.CustomerId = Convert.ToInt32(dr("CustomerID").ToString())
				})
			End While
			conn.Close()
			Customers = allcustomers
		End If
		Return Customers
	End Function
	''' <summary>
	''' Reads the ConnectionString for the Reels.mdb from the web.config file 
	''' <returns>connectionstring:-"ConnectionString" from web.config</returns>
	''' </summary>
	Private Shared Function ConnectString() As String
		Return ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
	End Function
	''' <summary>
	''' Gets customerdetail from CustomerOrders table of based on CustomerID 
	''' <returns>Customer object</returns>
	''' </summary>
	Friend Shared Function GetCustomersDetail(id As Integer) As Customer
		Dim conn As New OleDbConnection(ConnectString())
		conn.Open()
		Dim command As New OleDbCommand("Select * from CustomerOrders where CustomerID=" & id, conn)
		Dim dr As OleDbDataReader = command.ExecuteReader()
		While dr IsNot Nothing AndAlso dr.Read
			customer = New Customer With _
			{
				.Address = dr("Address1").ToString(),
				.City = dr("City").ToString(),
				.ContactName = dr("FirstName").ToString() & " " & dr("MiddleInitial").ToString() & " " & dr("LastName").ToString(),
				.CustomerId = Convert.ToInt32(dr("CustomerID").ToString()),
				.Country = dr("Country").ToString(),
				.PostalCode = dr("PostalCode").ToString(),
				.Region = dr("Region").ToString()
			}
		End While
		conn.Close()
		Return customer
	End Function
End Class
