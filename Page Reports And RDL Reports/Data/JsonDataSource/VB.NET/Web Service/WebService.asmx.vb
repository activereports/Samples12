Imports System.Web.Services
Imports System.IO
Imports System.Web.Script.Services
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<ComponentModel.ToolboxItem(False)> _
<Script.Services.ScriptService()> _
Public Class WebService
	Inherits System.Web.Services.WebService
	<WebMethod()> _
	<ScriptMethod(UseHttpGet:=True, ResponseFormat:=ResponseFormat.Json)>
	Public Function GetJson() As String
		Dim result As String
		Try
			Using streamReader As System.IO.TextReader = New StreamReader(Web_Service.My.Resources.Resource.JsonFilePath, Encoding.UTF8)
				result = streamReader.ReadToEnd()
			End Using
		Catch ex As FileNotFoundException
			Dim errorMessage = String.Format(Web_Service.My.Resources.Resource.FormatErrorMessage, ex.Message, ex.StackTrace)
			result = "{'error': '" + errorMessage + "'}"
		End Try
		Return result
	End Function
End Class
