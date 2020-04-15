Imports System
Namespace Models
	''' <summary>
	''' Container for the Rows in the Orders Table of NWind.mdb
	''' </summary>
	Public Class Order
		Public Property OrderId() As Int64
			Get
				Return m_OrderId
			End Get
			Set(ByVal value As Int64)
				m_OrderId = value
			End Set
		End Property
		Private m_OrderId As Int64
		Public Property CustomerId() As String
			Get
				Return m_CustomerId
			End Get
			Set(ByVal value As String)
				m_CustomerId = value
			End Set
		End Property
		Private m_CustomerId As String
		Public Property EmployeeId() As Int64
			Get
				Return m_EmployeeId
			End Get
			Set(ByVal value As Int64)
				m_EmployeeId = value
			End Set
		End Property
		Private m_EmployeeId As Int64
		Public Property OrderDate() As String
			Get
				Return m_OrderDate
			End Get
			Set(ByVal value As String)
				m_OrderDate = value
			End Set
		End Property
		Private m_OrderDate As String
		Public Property RequiredDate() As String
			Get
				Return m_RequiredDate
			End Get
			Set(ByVal value As String)
				m_RequiredDate = value
			End Set
		End Property
		Private m_RequiredDate As String
		Public Property ShippedDate() As String
			Get
				Return m_ShippedDate
			End Get
			Set(ByVal value As String)
				m_ShippedDate = value
			End Set
		End Property
		Private m_ShippedDate As String
		Public Property ShipVia() As Int64
			Get
				Return m_ShipVia
			End Get
			Set(ByVal value As Int64)
				m_ShipVia = value
			End Set
		End Property
		Private m_ShipVia As Int64
		Public Property Freight() As Decimal
			Get
				Return m_Freight
			End Get
			Set(ByVal value As Decimal)
				m_Freight = value
			End Set
		End Property
		Private m_Freight As Decimal
		Public Property ShipName() As String
			Get
				Return m_ShipName
			End Get
			Set(ByVal value As String)
				m_ShipName = value
			End Set
		End Property
		Private m_ShipName As String
		Public Property ShipAddress() As String
			Get
				Return m_ShipAddress
			End Get
			Set(ByVal value As String)
				m_ShipAddress = value
			End Set
		End Property
		Private m_ShipAddress As String
		Public Property ShipCity() As String
			Get
				Return m_ShipCity
			End Get
			Set(ByVal value As String)
				m_ShipCity = value
			End Set
		End Property
		Private m_ShipCity As String
		Public Property ShipRegion() As String
			Get
				Return m_ShipRegion
			End Get
			Set(ByVal value As String)
				m_ShipRegion = value
			End Set
		End Property
		Private m_ShipRegion As String
		Public Property ShipPostalCode() As String
			Get
				Return m_ShipPostalCode
			End Get
			Set(ByVal value As String)
				m_ShipPostalCode = value
			End Set
		End Property
		Private m_ShipPostalCode As String
		Public Property ShipCountry() As String
			Get
				Return m_ShipCountry
			End Get
			Set(ByVal value As String)
				m_ShipCountry = value
			End Set
		End Property
		Private m_ShipCountry As String
	End Class
End Namespace
