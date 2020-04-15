Namespace Models
	''' <summary>
	''' Container for the Rows in the Customers Table of NWind.mdb
	''' </summary>
	Public Class Customer
		Public Property CustomerId() As String
			Get
				Return m_CustomerId
			End Get
			Set(ByVal value As String)
				m_CustomerId = value
			End Set
		End Property
		Private m_CustomerId As String
		Public Property CompanyName() As String
			Get
				Return m_CompanyName
			End Get
			Set(ByVal value As String)
				m_CompanyName = value
			End Set
		End Property
		Private m_CompanyName As String
		Public Property ContactName() As String
			Get
				Return m_ContactName
			End Get
			Set(ByVal value As String)
				m_ContactName = value
			End Set
		End Property
		Private m_ContactName As String
		Public Property ContactTitle() As String
			Get
				Return m_ContactTitle
			End Get
			Set(ByVal value As String)
				m_ContactTitle = value
			End Set
		End Property
		Private m_ContactTitle As String
		Public Property Address() As String
			Get
				Return m_Address
			End Get
			Set(ByVal value As String)
				m_Address = value
			End Set
		End Property
		Private m_Address As String
		Public Property City() As String
			Get
				Return m_City
			End Get
			Set(ByVal value As String)
				m_City = value
			End Set
		End Property
		Private m_City As String
		Public Property Region() As String
			Get
				Return m_Region
			End Get
			Set(ByVal value As String)
				m_Region = value
			End Set
		End Property
		Private m_Region As String
		Public Property PostalCode() As String
			Get
				Return m_PostalCode
			End Get
			Set(ByVal value As String)
				m_PostalCode = value
			End Set
		End Property
		Private m_PostalCode As String
		Public Property Country() As String
			Get
				Return m_Country
			End Get
			Set(ByVal value As String)
				m_Country = value
			End Set
		End Property
		Private m_Country As String
		Public Property Phone() As String
			Get
				Return m_Phone
			End Get
			Set(ByVal value As String)
				m_Phone = value
			End Set
		End Property
		Private m_Phone As String
		Public Property Fax() As String
			Get
				Return m_Fax
			End Get
			Set(ByVal value As String)
				m_Fax = value
			End Set
		End Property
		Private m_Fax As String
	End Class
End Namespace
