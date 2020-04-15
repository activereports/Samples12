Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http
Imports Newtonsoft.Json.Serialization
Public Module WebApiConfig
	Public Sub Register(ByVal config As HttpConfiguration)
		'  Web API configuration and services 
		'  Web API routes 
		config.Routes.MapHttpRoute(
			name:="DefaultApi",
			routeTemplate:="api/{controller}/{id}",
			defaults:=New With {.id = RouteParameter.Optional}
		)
		Dim json = config.Formatters.JsonFormatter
		json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects
		json.SerializerSettings.ContractResolver = New DefaultContractResolver()
		config.Formatters.Remove(config.Formatters.XmlFormatter)
	End Sub
End Module
