'------------------------------------------------------------------------------
' <auto-generated>
'	 This code was generated by a tool.
'	 Runtime Version:4.0.30319.34014
'	 Changes to this file may cause incorrect behavior and will be lost if
'	 the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Option Strict On
Option Explicit On
Imports System
Namespace My.Resources
	
	'This class was auto-generated by the StronglyTypedResourceBuilder
	'class via a tool like ResGen or Visual Studio.
	'To add or remove a member, edit your .ResX file then rerun ResGen
	'with the /str option, or rebuild your VS project.ResGenを実行し直すか、または VS プロジェクトをビルドし直します。
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
		'''  Returns the cached ResourceManager instance used by this class.
		'''</summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
		Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
			Get
				If Object.ReferenceEquals(resourceMan, Nothing) Then
					Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("GrapeCity.ActiveReports.Samples.RdfViewer.Resources", GetType(Resources).Assembly)
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
		
		'''<summary>
		'''   Looks up a localized string similar to ActiveReports_Excel.xlsx.
		'''</summary>
		Friend ReadOnly Property Excel2007FileName() As String
			Get
				Return ResourceManager.GetString("Excel2007FileName", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to Excel 2007 files (*.xlsx)|*.xlsx|Excel files (*.xls)|*.xls|All files (*.*)|*.*.
		'''</summary>
		Friend ReadOnly Property Excel2007Filter() As String
			Get
				Return ResourceManager.GetString("Excel2007Filter", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''   Looks up a localized string similar to ActiveReports_Excel.xlsx.
		'''</summary>
		Friend ReadOnly Property ExcelFileName() As String
			Get
				Return ResourceManager.GetString("ExcelFileName", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to Excel files (*.xls)|*.xls|All files (*.*)|*.*.
		'''</summary>
		Friend ReadOnly Property ExcelFilter() As String
			Get
				Return ResourceManager.GetString("ExcelFilter", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to Export Complete.
		'''</summary>
		Friend ReadOnly Property ExportCompleteString() As String
			Get
				Return ResourceManager.GetString("ExportCompleteString", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to ActiveReports_HTML.html.
		'''</summary>
		Friend ReadOnly Property HTMLFileName() As String
			Get
				Return ResourceManager.GetString("HTMLFileName", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to Html files (*.htm)|*.html|All files (*.*)|*.*.
		'''</summary>
		Friend ReadOnly Property HTMLFilter() As String
			Get
				Return ResourceManager.GetString("HTMLFilter", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to ActiveReports_PDF.pdf.
		'''</summary>
		Friend ReadOnly Property PDFFileName() As String
			Get
				Return ResourceManager.GetString("PDFFileName", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*.
		'''</summary>
		Friend ReadOnly Property PDFFilter() As String
			Get
				Return ResourceManager.GetString("PDFFilter", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to ActiveReports_RTF.rtf.
		'''</summary>
		Friend ReadOnly Property RtfFileName() As String
			Get
				Return ResourceManager.GetString("RtfFileName", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to Rtf files (*.rtf)|*.rtf|All files (*.*)|*.*.
		'''</summary>
		Friend ReadOnly Property RtfFilter() As String
			Get
				Return ResourceManager.GetString("RtfFilter", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to Microsoft Excel WorkBook( XLS , XLSX ).
		'''</summary>
		Friend ReadOnly Property SectionExcelString() As String
			Get
				Return ResourceManager.GetString("SectionExcelString", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to Hypertext Markup Language(HTML).
		'''</summary>
		Friend ReadOnly Property SectionHTMLString() As String
			Get
				Return ResourceManager.GetString("SectionHTMLString", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to Portable Document Format(PDF).
		'''</summary>
		Friend ReadOnly Property SectionPDFString() As String
			Get
				Return ResourceManager.GetString("SectionPDFString", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to Plain Text(TXT).
		'''</summary>
		Friend ReadOnly Property SectionPlainTextString() As String
			Get
				Return ResourceManager.GetString("SectionPlainTextString", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to Rich Text Format(RTF).
		'''</summary>
		Friend ReadOnly Property SectionRTFString() As String
			Get
				Return ResourceManager.GetString("SectionRTFString", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to Tagged Image Format(TIFF).
		'''</summary>
		Friend ReadOnly Property SectionTIFFString() As String
			Get
				Return ResourceManager.GetString("SectionTIFFString", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to ActiveReports_Text.txt.
		'''</summary>
		Friend ReadOnly Property TextFileName() As String
			Get
				Return ResourceManager.GetString("TextFileName", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to txt files (*.txt)|*.txt|All files (*.*)|*.*.
		'''</summary>
		Friend ReadOnly Property TextFilter() As String
			Get
				Return ResourceManager.GetString("TextFilter", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to ActiveReports_Tiff.tiff.
		'''</summary>
		Friend ReadOnly Property TiffFileName() As String
			Get
				Return ResourceManager.GetString("TiffFileName", resourceCulture)
			End Get
		End Property
		
		'''<summary>
		'''  Looks up a localized string similar to Tiff files (*.tiff)|*.tiff|All files (*.*)|*.*.
		'''</summary>
		Friend ReadOnly Property TiffFilter() As String
			Get
				Return ResourceManager.GetString("TiffFilter", resourceCulture)
			End Get
		End Property
	End Module
End Namespace
