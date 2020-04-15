using System;
using System.IO;
using System.Text;
using System.Web.Services;
using System.Web.Script.Services;
namespace WebService
{
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	[ScriptService]
	public class Service : System.Web.Services.WebService
	{
		[WebMethod]
		[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
		public string GetJson()
		{
			string result;
			try
			{
				using (StreamReader streamReader = new StreamReader(Properties.Resource.JsonFilePath, Encoding.UTF8))
				{
					result = streamReader.ReadToEnd();
				}
			}
			catch (FileNotFoundException e)
			{
				var errorMessage = String.Format(Properties.Resource.FormatErrorMessage, e.Message, e.StackTrace);
				result = "{'error': '"+ errorMessage +"'}";
			}
			return result;
		}
	}
}
