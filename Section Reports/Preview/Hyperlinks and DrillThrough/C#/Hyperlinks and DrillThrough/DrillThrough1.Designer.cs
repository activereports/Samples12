using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.HyperlinksAndDrillThrough
{
	public partial class DrillThrough1
	{
  protected override void Dispose(bool disposing)
	{
	if (disposing)
	  {
	  }
	base.Dispose(disposing);
	}
	  
		#region ActiveReports Designer generated code
	   
	   
		
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrillThrough1));
			this.txtCustomerID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtOrderID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtEmployeeID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtOrderDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtShippedDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblCustomerID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblOrderID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblEmployeeID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblOrderDate = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblShippedDate = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.cscBorder = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.groupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.groupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			// txtCustomerID
			// 
			this.txtCustomerID.DataField = "CustomerID";
			resources.ApplyResources(this.txtCustomerID, "txtCustomerID");
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0);
			// 
			// txtOrderID
			// 
			this.txtOrderID.DataField = "OrderID";
			resources.ApplyResources(this.txtOrderID, "txtOrderID");
			this.txtOrderID.Name = "txtOrderID";
			// 
			// txtEmployeeID
			// 
			this.txtEmployeeID.DataField = "EmployeeID";
			resources.ApplyResources(this.txtEmployeeID, "txtEmployeeID");
			this.txtEmployeeID.Name = "txtEmployeeID";
			// 
			// txtOrderDate
			// 
			this.txtOrderDate.DataField = "OrderDate";
			resources.ApplyResources(this.txtOrderDate, "txtOrderDate");
			this.txtOrderDate.Name = "txtOrderDate";
			// 
			// txtShippedDate
			// 
			this.txtShippedDate.DataField = "ShippedDate";
			resources.ApplyResources(this.txtShippedDate, "txtShippedDate");
			this.txtShippedDate.Name = "txtShippedDate";
			// 
			// lblCustomerID
			// 
			resources.ApplyResources(this.lblCustomerID, "lblCustomerID");
			this.lblCustomerID.Name = "lblCustomerID";
			this.lblCustomerID.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0);
			// 
			// lblOrderID
			// 
			resources.ApplyResources(this.lblOrderID, "lblOrderID");
			this.lblOrderID.Name = "lblOrderID";
			// 
			// lblEmployeeID
			// 
			resources.ApplyResources(this.lblEmployeeID, "lblEmployeeID");
			this.lblEmployeeID.Name = "lblEmployeeID";
			// 
			// lblOrderDate
			// 
			resources.ApplyResources(this.lblOrderDate, "lblOrderDate");
			this.lblOrderDate.Name = "lblOrderDate";
			// 
			// lblShippedDate
			// 
			resources.ApplyResources(this.lblShippedDate, "lblShippedDate");
			this.lblShippedDate.Name = "lblShippedDate";
			// 
			// cscBorder
			// 
			this.cscBorder.BackColor = System.Drawing.Color.RosyBrown;
			this.cscBorder.Bottom = 0F;
			resources.ApplyResources(this.cscBorder, "cscBorder");
			this.cscBorder.LineColor = System.Drawing.Color.Purple;
			this.cscBorder.LineWeight = 3F;
			this.cscBorder.Name = "cscBorder";
			this.cscBorder.Right = 0F;
			// 
			// Detail
			// 
			this.Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtCustomerID,
			this.txtOrderID,
			this.txtEmployeeID,
			this.txtOrderDate,
			this.txtShippedDate});
			this.Detail.Height = 0.2F;
			this.Detail.Name = "Detail";
			this.Detail.BeforePrint += new System.EventHandler(this.Detail_BeforePrint);
			// 
			// groupHeader1
			// 
			this.groupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblCustomerID,
			this.lblOrderID,
			this.lblEmployeeID,
			this.lblOrderDate,
			this.lblShippedDate,
			this.cscBorder});
			this.groupHeader1.Height = 0.25F;
			this.groupHeader1.Name = "groupHeader1";
			this.groupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage;
			// 
			// groupFooter1
			// 
			this.groupFooter1.Height = 0.01041667F;
			this.groupFooter1.Name = "groupFooter1";
			// 
			// DrillThrough1
			// 
			this.MasterReport = false;
			this.PageSettings.DefaultPaperSize = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.5F;
			this.Sections.Add(this.groupHeader1);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.groupFooter1);
			this.ShowParameterUI = false;
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
		   
		}
		#endregion
		private GroupHeader groupHeader1;
		private GroupFooter groupFooter1;
		private CrossSectionBox cscBorder;
		public GrapeCity.ActiveReports.Data.OleDBDataSource ds;
		private Label lblCustomerID;
		private Label lblOrderID;
		private Label lblEmployeeID;
		private Label lblOrderDate;
		private Label lblShippedDate;
		private Detail Detail;
		private TextBox txtCustomerID;
		private TextBox txtOrderID;
		private TextBox txtEmployeeID;
		private TextBox txtOrderDate;
		private TextBox txtShippedDate;
	}
}
