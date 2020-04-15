using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
namespace GrapeCity.ActiveReports.Samples.RdfViewer
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			RdfViewerForm mainForm = new RdfViewerForm();
			if (args.Length > 0)
			{
				string pathToFile = args[0];
				if (!string.IsNullOrEmpty(pathToFile) && File.Exists(pathToFile))
					mainForm.ReportDoc.Load(pathToFile);
			}
			Application.Run(mainForm);
		}
	}
}
