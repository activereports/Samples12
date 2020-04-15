Imports System
Class OrderDetail
	Public Sub New(ByVal productName As String, ByVal unitPrice As Double, ByVal quantity As Integer)
		Me.productName = productName
		Me.unitPrice = unitPrice
		Me.quantity = quantity
	End Sub
	Public productName As String
	Public unitPrice As Double
	Public quantity As Integer
End Class
