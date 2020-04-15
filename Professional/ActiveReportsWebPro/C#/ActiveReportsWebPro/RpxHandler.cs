using System;
using System.IO;
using System.Web;
using System.Web.Caching;
using GrapeCity.ActiveReports.Export.Html;
namespace GrapeCity.ActiveReports.Samples.Web.Professional
{
	public class RpxHandler : IHttpHandler
	{
		public const string HandlerCacheExtension = ".rpxWeb";
		public void ProcessRequest(HttpContext context)
		{
			// return image
			var keyName = Path.GetFileName(context.Request.FilePath);
			var cacheItem = context.Cache[keyName];
			context.Response.BinaryWrite((byte[])cacheItem);
		}
		public bool IsReusable
		{
			get { return true; }
		}
		public sealed class HtmlOutputHandler : IOutputHtml
		{
			private readonly Cache _cache;
			private readonly string _name;
			public HtmlOutputHandler(Cache cache, string name)
			{
				_cache = cache;
				_name = name;
			}
			public string OutputHtmlData(HtmlOutputInfoArgs info)
			{
				var stream = info.OutputStream;
				var dataLen = (int)stream.Length;
				if (dataLen <= 0)
					return string.Empty;
				var bytesData = new byte[dataLen];
				stream.Seek(0, SeekOrigin.Begin);
				stream.Read(bytesData, 0, dataLen);
				if (info.OutputKind == HtmlOutputKind.HtmlPage)
				{
					MainPageData = bytesData;
					return _name;
				}
				var keyName = Guid.NewGuid() + HandlerCacheExtension;
				// 30 seconds should be enough to load all images
				_cache.Insert(keyName, bytesData, null, Cache.NoAbsoluteExpiration, new TimeSpan(0, 0, 30));
				return keyName;
			}
			public void Finish()
			{
			}
			public byte[] MainPageData { get; private set; }
		}
	}
}
