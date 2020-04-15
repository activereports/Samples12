using System.IO;
using System.Web.Services;
using GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Models;
using GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Reports;
namespace GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC
{
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	public class ActiveReportsService : Web.ReportService
	{
		protected override object OnCreateReportHandler(string reportPath)
		{
			var data = reportPath.Split(';');
			if (data.Length != 2)
				return base.OnCreateReportHandler(reportPath);
			switch (data[0])
			{
				case "Section":
					return new OrderReport { DataSource = Repository.GetOrders(data[1]) };
				case "Page":
					var report = new PageReport(new FileInfo(Server.MapPath("~/Reports/OrderDetailsReport.rdlx")));
					report.Document.LocateDataSource += delegate (object sender, LocateDataSourceEventArgs args)
					{
						args.Data = Repository.GetDetails(data[1]);
					};
					return report;
			}
			return base.OnCreateReportHandler(reportPath);
		}
	}
}
