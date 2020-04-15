using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
namespace GrapeCity.ActiveReports.Samples.ActiveReportsSilverlightViewer
{
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			InitializeComponent();
			//Loading the Main.rdlx from the server
			ReportViewer.LoadFromService(@"Reports\RPX\MainReport.rpx");
		}
		private void Containerborder_MouseEnter(object sender, MouseEventArgs e)
		{
			//Highlighting focused item
			((System.Windows.Controls.Border)sender).BorderBrush = new SolidColorBrush(Color.FromArgb(255, 100, 149, 237));
		}
		private void Containerborder_MouseLeave(object sender, MouseEventArgs e)
		{
			((System.Windows.Controls.Border)sender).BorderBrush = new SolidColorBrush(Colors.Transparent);
		}
		private void Container_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			//Displays report in the SilverlightViewer
			DisplayReport(((StackPanel)sender).Name);
		}
		private void DisplayReport(string report)
		{
			switch (report)
			{
				case "CodeContainer":
					{
						//Proceesses the CodeReport.cs in the Silverlight Host application and shows in the viewer
						ReportViewer.LoadFromService("GrapeCity.ActiveReports.Samples.ActiveReportsSilverlightViewer.Web.CodeReport");
						break;
					}
				case "RDFContainer":
					{
						//Displays the EmployeeSales.rdf in the Host Application's folder inside the Silverlight Viewer
						ReportViewer.LoadFromService(@"Reports\RDF\EmployeeSales.rdf");
						break;
					}
				case "RDLXContainer":
					{
						//Processes the SalesReport.rdlx in the Host Application's folder and shows in the Silverlight Viewer
						ReportViewer.LoadFromService(@"Reports\RDLX\SalesReport.rdlx");
						break;
					}
				case "RPXContainer":
					{
						//Processes the Invoice.rpx in the Host Application's folder and shows in the Silverlight Viewer
						ReportViewer.LoadFromService(@"Reports\RPX\Invoice.rpx");
						break;
					}
			}
		}
	}
}
