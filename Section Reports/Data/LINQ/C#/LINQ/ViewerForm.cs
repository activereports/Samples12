using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace GrapeCity.ActiveReports.Samples.LINQ
{
	public partial class ViewerForm : Form
	{
		public ViewerForm()
		{
			InitializeComponent();
		}
	  
		
		// Define a structure for LINQtoObject.
		private void ViewerForm_Load(object sender, EventArgs e)
		{
			// To generate a report.
			rptLINQtoObject rpt = new rptLINQtoObject();
		   
			// To run the report.
			arvMain.LoadDocument(rpt);
		}
	}
}
