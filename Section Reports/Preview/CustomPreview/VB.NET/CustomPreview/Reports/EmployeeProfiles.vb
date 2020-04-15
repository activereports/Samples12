Public Class EmployeeProfiles
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		
		Document.Name = "Employee Profiles Report"
		
		'
	End Sub
	
	'ReportStart Event
	' Use this event to initialize any objects or variables needed while running a report. 
	' Also use this event to set any Subreport control objects to a new instance 
	' of the report assigned to the Subreport control.
	Private Sub EmployeeProfiles_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		
		txtDescription.Text = String.Format(Globalization.CultureInfo.CurrentCulture, "{0}" + vbCrLf + "{2}" + vbCrLf + "{3}", "* Unbound fields", "* Detail section Keeptogether", "* Table of Contents Bookmarks", "* Detail.BeforePrint Event")
		
		'
	End Sub
	'DataInitialize Event
	' ActiveReports event that is called during the report initalization
	' procedure. (after .Run is called on your report object)  Normally used
	' with unbound reporting to establish an active connection to your data
	' to be used with the FetchData event, or to setup a bound report with a
	' dynamic database connection at runtime.
	' This is also where you should include any Fields values that you need to
	' add for unbound reporting.
	Private Sub EmployeeProfiles_DataInitialize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataInitialize
		' create a custom unbound field in the Fields collection.
		Fields.Add("Name")
	End Sub
	' FetchData Event
	'ActiveReports event that is called during the report run once per
	' row from the dataset.  This event is usually only used in unbound reporting,
	' you would set the Fields collection value to the value from your dataset and
	' advance the next row.  When you run out of data, you should set the
	' FetchEventArgs argument's EOF field to true to tell the report that the report
	' is done with the data.
	' </summary>
	Private Sub EmployeeProfiles_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles MyBase.FetchData
		' The unbound custom field "Name" was created in DataInitialize.
		' We use FetchData to set its value, to "TitleOfCourtest LastName, FirstName"
		' TitleOfCourtesy, LastName and FirstName were added by ActiveReports from the data source.
		Fields("Name").Value = String.Format(Globalization.CultureInfo.CurrentCulture, "{0} {1}, {2}", Fields("TitleOfCourtesy").Value, Fields("LastName").Value, Fields("FirstName").Value)
	End Sub
	' BeforePrint Event
	'  ActiveReports raises this event before the section is rendered to a page.
	'  Use this event to modify the control's values before printing.
	'  The changes made here do not effect the height of the section.
	Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As EventArgs) Handles Detail.BeforePrint
		' Use the name unbound field that we created in DataInitialize
		' as the caption of the bookmark.
		Detail.AddBookmark(txtName.Text)
	End Sub
	Public ds As Data.OleDBDataSource
End Class
