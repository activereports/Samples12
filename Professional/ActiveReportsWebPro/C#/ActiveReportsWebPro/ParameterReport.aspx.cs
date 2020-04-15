using System;
namespace GrapeCity.ActiveReports.Samples.Web.Professional
{
	public partial class ParameterReport : System.Web.UI.Page
	{
		//Parametrized Report Generation
		SectionReport _rpt = new SectionReport();
		protected void Page_Load(object sender, EventArgs e)
		{
			// Load the report layout
			System.Xml.XmlTextReader xtr = new System.Xml.XmlTextReader(Server.MapPath("~") + @"\RpxReports\Params.rpx");
			_rpt.LoadLayout(xtr);
			xtr.Close();
			if (!IsPostBack)
			{
				// Sets the combo box.
				cboViewerType.Items.Clear();
				cboViewerType.Items.Add("HTML");
				cboViewerType.Items.Add("Flash");
				cboViewerType.Items.Add("AcrobatReader");
				cboViewerType.Items.Add("RawHtml");
				// The default is set to HTML viewer.
				cboViewerType.SelectedIndex = 0;
				DateTime InitDate = new DateTime(1994, 9, 2);
				Calendar1.VisibleDate = InitDate;
			}
			_rpt.Restart();
			WebViewer1.Report = _rpt;
			Session["Report"] = _rpt;
		}
		protected void cboViewerType_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Select Viewer Type
			string selection = cboViewerType.Items[cboViewerType.SelectedIndex].Text;
			switch (selection)
			{
				// Sets Viewer type to Acrobat Reader
				case "AcrobatReader":
					Session["ViewerType"] = ActiveReports.Web.ViewerType.AcrobatReader;
					break;
				// Sets Viewer type to Flash Viewer
				case "Flash":
					Session["ViewerType"] = ActiveReports.Web.ViewerType.FlashViewer;
					break;
				// Sets Viewer type to HTML
				case "HTML":
					Session["ViewerType"] = ActiveReports.Web.ViewerType.HtmlViewer;
					break;
				// Sets Viewer type to RAW HTML
				case "RawHtml":
					Session["ViewerType"] = ActiveReports.Web.ViewerType.RawHtml;
					break;
			}
			// Save Report and Viewer Type to session.
			WebViewer1.Report = Session["Report"];
			WebViewer1.ViewerType = (ActiveReports.Web.ViewerType)Session["ViewerType"];
		}
		protected void Calendar1_SelectionChanged(object sender, EventArgs e)
		{
			// Set Viewer Type
			if (Session["ViewerType"] != null)
			{
				WebViewer1.ViewerType = (ActiveReports.Web.ViewerType)Session["ViewerType"];
			}
			else
			{
				WebViewer1.ViewerType = ActiveReports.Web.ViewerType.HtmlViewer;
			}
			
			// Set Sql query based on Parameter
			((Data.OleDBDataSource)_rpt.DataSource).SQL = "SELECT * FROM orders INNER JOIN [order details] ON orders.orderid = [order details].orderid WHERE orderdate = #" + Calendar1.SelectedDate.ToShortDateString() + "#";
		}
	}
}
