Public Class Orders
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	' ReportStart Event
	' Use this event to initialize any objects or variables needed while running a report. 
	' Also use this event to set any Subreport control objects to a new instance 
	' of the report assigned to the Subreport control.
	Private Sub Orders_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		srptItems.Report = New OrderItems()
	End Sub
	' Format Event
	' ActiveReports event that is called for every section (Page Header/Footer,
	' but before the section is rendered to a page.The Format event is the only event in which you can change
	' the section's height. Use this section to set or change the properties of any controls or the section itself.
	' Also use the Format event to pass information, such as an SQL String, to a Subreport.
	Private Sub Detail_Format_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles Detail.Format
		Dim xmlDS As New Data.XMLDataSource()
		xmlDS.NodeList = CType(CType(DataSource, Data.XMLDataSource).Field("ITEM", True), System.Xml.XmlNodeList)
		CType(srptItems.Report, OrderItems).DataSource = xmlDS
		lblItems.Text = "Item Count: " + xmlDS.NodeList.Count.ToString(Globalization.CultureInfo.CurrentCulture)
	End Sub
End Class
