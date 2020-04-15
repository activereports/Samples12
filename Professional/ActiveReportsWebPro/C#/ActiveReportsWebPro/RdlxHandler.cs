using System;
using System.IO;
using System.Web;
using System.Web.Caching;
using GrapeCity.ActiveReports.Rendering.IO;
namespace GrapeCity.ActiveReports.Samples.Web.Professional
{
	public class RdlxHandler : IHttpHandler
	{
		public const string HandlerCacheExtension = ".rdlxWeb";
		public void ProcessRequest(HttpContext context)
		{
			// return image
			var keyName = Path.GetFileName(context.Request.FilePath);
			var cacheItem = context.Cache[keyName];
			context.Response.BinaryWrite((byte[]) cacheItem);
		}
		public bool IsReusable
		{
			get { return true; }
		}
		public sealed class HtmlStreamProvider : MemoryStreamProvider
		{
			protected override Uri GetStreamUri(string extension)
			{
				Uri uri = base.GetStreamUri(extension);
				return new Uri(uri.OriginalString + HandlerCacheExtension, UriKind.Relative);
			}
			public void CacheImages(Cache cache)
			{
				foreach (var secondaryStreamInfo in GetSecondaryStreams())
				{
					var secondaryStream = (MemoryStream)secondaryStreamInfo.OpenStream();
					// 30 seconds should be enough to load all images
					cache.Insert(secondaryStreamInfo.Uri.OriginalString, secondaryStream.ToArray(), null,
						Cache.NoAbsoluteExpiration, new TimeSpan(0, 0, 30));
				}
			}
		}
	}
}
