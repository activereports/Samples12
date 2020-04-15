Namespace Models
	''' <summary>
	''' Class Representation of the ReportType(section/page) and the CustomerID
	''' </summary>
	Public Class ReportDescriptor
		Public Property Type() As String
			Get
				Return m_Type
			End Get
			Set(ByVal value As String)
				m_Type = value
			End Set
		End Property
		Private m_Type As String
		Public Property Id() As String
			Get
				Return m_Id
			End Get
			Set(ByVal value As String)
				m_Id = value
			End Set
		End Property
		Private m_Id As String
	End Class
End Namespace
