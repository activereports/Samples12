Option Strict On
Option Explicit On
Imports System
Namespace My.Resources
	
	'''<summary>
	'''  A strongly-typed resource class, for looking up localized strings, etc.
	'''</summary>
	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
	 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
	 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
	 Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
	Friend Module Resources
		
		Private resourceMan As Global.System.Resources.ResourceManager
		
		Private resourceCulture As Global.System.Globalization.CultureInfo
		
		'''<summary>
		'''  Returns the cached ResourceManager instance used by this class
		'''</summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
		Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
			Get
				If Object.ReferenceEquals(resourceMan, Nothing) Then
					Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("GrapeCity.ActiveReports.Samples.CustomResourceLocator.Resources", GetType(Resources).Assembly)
					resourceMan = temp
				End If
				Return resourceMan
			End Get
		End Property
		
		'''<summary>
		'''  Overrides the current thread's CurrentUICulture property for all
		'''  resource lookups using this strongly typed resource class.
		'''</summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
		Friend Property Culture() As Global.System.Globalization.CultureInfo
			Get
				Return resourceCulture
			End Get
			Set
				resourceCulture = value
			End Set
		End Property
		Friend ReadOnly Property Description() As String
			Get
				Return ResourceManager.GetString("Description", resourceCulture)
			End Get
		End Property
		
		Friend ReadOnly Property NoImage() As System.Drawing.Bitmap
			Get
				Dim obj As Object = ResourceManager.GetObject("NoImage", resourceCulture)
				Return CType(obj,System.Drawing.Bitmap)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to The name of resource to be obtained should be non-empty string.
		'''</summary>
		Friend ReadOnly Property ResourceNameIsNull() As String
			Get
				Return ResourceManager.GetString("ResourceNameIsNull", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to The specified resource schema is not supported.
		'''</summary>
		Friend ReadOnly Property ResourceSchemeIsNotSupported() As String
			Get
				Return ResourceManager.GetString("ResourceSchemeIsNotSupported", resourceCulture)
			End Get
		End Property
	End Module
End Namespace
