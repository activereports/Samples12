using System;
using System.Windows.Forms;
namespace GrapeCity.ActiveReports.Samples.HyperlinksAndDrillThrough
{
	/// <summary>
	///Summary description for frmViewMain. 
	/// 
	///Demonstrates using hyperlinks and the viewer hyperlink event to simulate  
	///drill-through from one report to another.
	/// </summary>
	public partial class ViewerMain : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private readonly bool _loadMainReport;
		public ViewerMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			_loadMainReport = true;
		}
		public ViewerMain(bool loadMainReport)
		{
			InitializeComponent();
			_loadMainReport = loadMainReport;
		}
		/// <summary>
		/// The main entry point for the application.
		/// 
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new ViewerMain());
		}
		/// <summary>
		/// Handles the hyperlink sent from the viewer object.
		/// </summary>
		private void arvMain_HyperLink(object sender, GrapeCity.ActiveReports.Viewer.Win.HyperLinkEventArgs e)
		{
			e.Handled = true;
			string hyperlink = e.HyperLink.Split(':')[1];
			string report = e.HyperLink.Split(':')[0];
			if (report == "DrillThrough1")
			{
				// Click on customer ID to open the drill through for that customer.
				DrillThrough1 rpt2 = new DrillThrough1();
				ViewerMain frm2 = new ViewerMain(false);
				rpt2.Parameters["customerID"].Value = hyperlink;
				frm2.arvMain.LoadDocument(rpt2);
				frm2.ShowDialog(this);
			}
			else if (report == "DrillThrough2")
			{
				// Click order number to open the order details
				DrillThrough2 rpt3 = new DrillThrough2();
				ViewerMain frm3 = new ViewerMain(false);
				rpt3.Parameters["orderID"].Value = hyperlink;
				frm3.arvMain.LoadDocument(rpt3);
				frm3.ShowDialog(this);
			}
		}
		/// <summary>
		/// ViewerForm_Load - Handles initial form setup.
		/// </summary>
		private void ViewerForm_Load(object sender, EventArgs e)
		{
			if(_loadMainReport)
			{
				DrillThroughMain rpt = new DrillThroughMain();
				arvMain.LoadDocument(rpt);
			}
		}
	}
}
