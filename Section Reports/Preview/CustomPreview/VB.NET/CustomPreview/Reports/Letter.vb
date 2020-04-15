Imports System
Public Class Letter
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		
		Document.Name = "Letter Report"
		
		'
	End Sub
	
	' Format Event
	' ActiveReports raises this event after the data is loaded and bound to the controls contained in a section, 
	' but before the section is rendered to a page.The Format event is the only event in which you can change
	' the section's height. Use this section to set or change the properties of any controls or the section itself.
	' Also use the Format event to pass information, such as an SQL String, to a Subreport.
	Private Sub ghCustomerID_Format(ByVal sender As Object, ByVal e As EventArgs) Handles ghCustomerID.Format
		'Replace the positions in the RichTextBox control with the data bound to 
		'the hidden fields
		rtbMain.ReplaceField("CompanyName", txtCompanyName.Text)
		rtbMain.ReplaceField("ContactName", txtContactName.Text)
		rtbMain.ReplaceField("AddressLine", txtAddress.Text)
		rtbMain.ReplaceField("City", txtCity.Text)
		rtbMain.ReplaceField("Region", txtRegion.Text)
		rtbMain.ReplaceField("Country", txtCountry.Text)
		rtbMain.ReplaceField("PostalCode", txtPostalCode.Text)
		rtbMain.ReplaceField("Date", DateTime.Now.ToLongDateString())
	End Sub
	' BeforePrint Event
	' ActiveReports raises this event before the section is rendered to a page.
	' Use this event to modify the control's values before printing.
	' The changes made here do not effect the height of the section.
	Private Sub ghCustomerID_BeforePrint(ByVal sender As Object, ByVal e As EventArgs) Handles ghCustomerID.BeforePrint
		' Totals are not calculated until the section is ready to print, 
		' so update the total fields in the rich textbox in the BeforePrint event.
		rtbMain.ReplaceField("TotalOrders", Me.txtTotalOrders.Text)
	End Sub
	
	Public ds As Data.OleDBDataSource
	
End Class
