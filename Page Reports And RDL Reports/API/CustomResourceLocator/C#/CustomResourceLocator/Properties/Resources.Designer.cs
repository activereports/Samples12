namespace GrapeCity.ActiveReports.Samples.CustomResourceLocator.Properties {
	using System;
	
	
	/// <summary>
	///   A strongly-typed resource class, for looking up localized strings, etc.
	/// </summary>
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	internal class Resources {
		
		private static global::System.Resources.ResourceManager resourceMan;
		
		private static global::System.Globalization.CultureInfo resourceCulture;
		
		[global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		internal Resources() {
		}
		
		/// <summary>
		///   Returns the cached ResourceManager instance used by this class.
		/// </summary>
		[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager {
			get {
				if (object.ReferenceEquals(resourceMan, null)) {
					global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GrapeCity.ActiveReports.Samples.CustomResourceLocator.Properties.Resources", typeof(Resources).Assembly);
					resourceMan = temp;
				}
				return resourceMan;
			}
		}
		
		/// <summary>
		///   Overrides the current thread's CurrentUICulture property for all
		///   resource lookups using this strongly typed resource class.
		///   
		/// </summary>
		[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture {
			get {
				return resourceCulture;
			}
			set {
				resourceCulture = value;
			}
		}
		
		
		internal static string Description {
			get {
				return ResourceManager.GetString("Description", resourceCulture);
			}
		}
		
		internal static System.Drawing.Bitmap NoImage {
			get {
				object obj = ResourceManager.GetObject("NoImage", resourceCulture);
				return ((System.Drawing.Bitmap)(obj));
			}
		}
		
		/// <summary>
		///   Looks up a localized string similar to 'The name of resource to be obtained should be non-empty string'.
		/// </summary>
		internal static string ResourceNameIsNull {
			get {
				return ResourceManager.GetString("ResourceNameIsNull", resourceCulture);
			}
		}
		
		/// <summary>
		///  Looks up a localized string similar to The specified resource schema is not supported.
		/// </summary>
		internal static string ResourceSchemeIsNotSupported {
			get {
				return ResourceManager.GetString("ResourceSchemeIsNotSupported", resourceCulture);
			}
		}
	}
}
