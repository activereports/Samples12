using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Models;
namespace GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Reports
{
	/// <summary>
	/// Summary description for OrderReport.
	/// </summary>
	public partial class OrderReport : GrapeCity.ActiveReports.SectionReport
	{
		public OrderReport()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}
		private void OrderReport_ReportStart(object sender, EventArgs e)
		{
			
			List<string> xvalues = new List<string>();
			List<double> yvalues = new List<double>();
			foreach (var order in (List<Order>)this.DataSource)
			{
				xvalues.Add(order.ShippedDate);
				yvalues.Add(Convert.ToDouble(order.Freight));
			}
			this.chartControl1.Series[0].Points.DataBindXY(xvalues.ToArray(), yvalues.ToArray());
		  
			
		
		}
	}
}
