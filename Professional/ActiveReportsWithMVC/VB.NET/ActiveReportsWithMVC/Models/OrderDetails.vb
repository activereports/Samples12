Imports System
Namespace Models
	''' <summary>
	''' Container for the Rows in the Order Details Table of NWind.mdb
	''' </summary>
	Public Class OrderDetails
		Public Property OrderId() As Int64
			Get
				Return m_OrderId
			End Get
			Set(ByVal value As Int64)
				m_OrderId = value
			End Set
		End Property
		Private m_OrderId As Int64
		Public Property ProductId() As Integer
			Get
				Return m_ProductId
			End Get
			Set(ByVal value As Integer)
				m_ProductId = value
			End Set
		End Property
		Private m_ProductId As Integer
		Public Property UnitPrice() As Decimal
			Get
				Return m_UnitPrice
			End Get
			Set(ByVal value As Decimal)
				m_UnitPrice = value
			End Set
		End Property
		Private m_UnitPrice As Decimal
		Public Property Quantity() As Integer
			Get
				Return m_Quantity
			End Get
			Set(ByVal value As Integer)
				m_Quantity = value
			End Set
		End Property
		Private m_Quantity As Integer
		Public Property Discount() As Integer
			Get
				Return m_Discount
			End Get
			Set(ByVal value As Integer)
				m_Discount = value
			End Set
		End Property
		Private m_Discount As Integer
	End Class
End Namespace
