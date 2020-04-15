using System;
namespace GrapeCity.ActiveReports.Samples.CustomPreview
{
	partial class EmployeeProfiles : GrapeCity.ActiveReports.SectionReport
	{
		public EmployeeProfiles()
		{
			InitializeComponent();
			
			Document.Name = "Employee Profiles Report";
			
			
		}
	
		private void EmployeeProfiles_ReportStart(object sender, EventArgs eArgs)
		{
			//entext>ReportStart Event
			//Use this event to initialize any objects or variables needed while running a report. 
			//Also use this event to set any Subreport control objects to a new instance 
			//of the report assigned to the Subreport control.
			
			txtDescription.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture,
				"{0}\r\n{2}\r\n{3}", "* Unbound fields",
				"* Detail section Keeptogether",
				"* Table of Contents Bookmarks",
				"* Detail.BeforePrint Event");
			
			
			
			Document.Name = "Employee Profiles Report";
			
			
		}
		/// <summary>
		/// DataInitialize Event
		/// Use it to add custom fields to the report's Fields collection. 
		/// Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
		/// or an unbound report (one that does not depend on a data control to get its records).
		/// </summary>
		private void EmployeeProfiles_DataInitialize(object sender, EventArgs eArgs)
		{
			// Create a custom unbound field in the Fields collection.
			Fields.Add("Name");
		}
		/// <summary>
		/// FetchData Event
		/// This event is raised every time a new record is processed. The FetchData has an EOF parameter
		/// indicating whether the FetchData event should be raised.  When working with bound 
		/// reports (reports using a DataControl), the EOF parameter is automatically set by the report;
		/// however, when working with unbound reports this parameter needs to be controlled manually.
		/// </summary>
		private void EmployeeProfiles_FetchData(object sender, FetchEventArgs eArgs)
		{
			// The unbound custom field "Name" was created in DataInitialize.
			// We use FetchData to set its value, to "TitleOfCourtest LastName, FirstName"
			// TitleOfCourtesy, LastName and FirstName were added by ActiveReports from the data source.
			Fields["Name"].Value = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0} {1}, {2}", this.Fields["TitleOfCourtesy"].Value, this.Fields["LastName"].Value, this.Fields["FirstName"].Value);
		}
		/// <summary>
		/// BeforePrint Event
		/// ActiveReports raises this event before the section is rendered to a page.
		/// Use this event to modify the control's values before printing.
		/// The changes made here do not effect the height of the section.
		/// </summary>
		private void Detail_BeforePrint(object sender, EventArgs eArgs)
		{
			// Use the name unbound field that we created in DataInitialize
			// as the caption of the bookmark.
			Detail.AddBookmark(txtName.Text);
		}
	}
}
