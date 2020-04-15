using System;
namespace GrapeCity.ActiveReports.Samples.IListBinding
{
	public partial class IlistReportSample : GrapeCity.ActiveReports.SectionReport
	{
		private long _greenBarCounter;
		private IListBinding.DataLayer.ProductCollection _productCollection;
		public IlistReportSample(IListBinding.DataLayer.ProductCollection _productCollection)
		{
		   
			this._productCollection = _productCollection;
			InitializeComponent();
			
			Document.Name = "IList Sample ActiveReport";
			
			
		}
		void IlistReportSample_ReportStart(object sender, EventArgs e)
		{
			// Assign the productCollection DataLayer object to the report's datasource
			this.DataSource = _productCollection;
		}
		private void Detail_Format(object sender, EventArgs eArgs)
		{
			// Green bar effect colors the background of every other row.
			_greenBarCounter++;
			if ((_greenBarCounter % 2) == 0)
			{
				// Even number rows
				Detail.BackColor = System.Drawing.Color.Transparent;
			}
			else
			{
				// Odd number rows
				Detail.BackColor = System.Drawing.Color.LightGray;
			}
			// Reorder Row Coloring - Highlights the products that are to be
			// re-ordered for a better understanding.
			// Values for calculating the highlight.
			int reorderLevel = Int32.Parse(txtReorderLevel.Text);
			int unitsInStock = Int32.Parse(txtUnitsInStock.Text);
			if (unitsInStock < reorderLevel)
			{
				// Highlight since the re-stocking level has been met.
				Detail.BackColor = System.Drawing.Color.LightCoral;
				
				txtComments.Text = "Check " + txtProductName.Text;
				
				
			}
			else
			{
				// Reset the comments text
				txtComments.Text = "";
			}
		}
	}
}
