using GrapeCity.ActiveReports.Document;
using GrapeCity.ActiveReports.Export;
namespace GrapeCity.ActiveReports.Samples.CustomPreview
{
	class SectionExport
	{
		public string DisplayName { get; set; }
		public string Filter { get; set; }
		public string DefaultFileName { get; set; }
		public IDocumentExportEx Settings { get; set; }
		public void Export(SectionDocument sectionDocument,string filePath)
		{
			Settings.Export(sectionDocument, filePath);
		}
	}
}
