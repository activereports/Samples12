Imports GrapeCity.ActiveReports.Export.Pdf.Section
Imports GrapeCity.ActiveReports.Export.Pdf.Section.Signing
Imports System.Security.Cryptography.X509Certificates
Imports System.IO
Public Class PDFDigitalSignature
	Private Sub PDFDigitalSignature_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
		' Set the default state of the combo "format of the signature"
		cmbVisibilityType.SelectedIndex = 3
		arvMain.LoadDocument("..//..//Report//Invoice.rpx")
	End Sub
	Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExport.Click
		Dim oPDFExport As New PdfExport
		Dim sfd As New SaveFileDialog()
		Dim tmpCursor As Cursor = Nothing
		Dim tempPath As String = String.Empty
		
		sfd.Title = "PDF files should be saved with electronic signature"
		
		'
		' Title
		' Name of the file for initial display
		sfd.FileName = "DigitalSignature.pdf"
		sfd.Filter = "PDF|*.pdf"		   ' Filter
		If sfd.ShowDialog() <> DialogResult.OK Then
			Exit Sub
		End If
		Try
			'Change the cursor
			tmpCursor = Cursor
			Cursor = Cursors.WaitCursor
			Application.DoEvents()
			' Sets the type of signature.
			oPDFExport.Signature.VisibilityType = CType(cmbVisibilityType.SelectedIndex, Export.Pdf.Section.Signing.VisibilityType)
			' Set the signature display area.
			oPDFExport.Signature.Stamp.Bounds = New RectangleF(0.05F, 0.05F, 4.0F, 0.9F)
			' Sets the character position of the signature text
			oPDFExport.Signature.Stamp.TextAlignment = Alignment.Left
			
			oPDFExport.Signature.Stamp.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point, 128)
			
			'
			'Set the rectangle in which the text is placed in the area that displays the signature.
			' The coordinate specified in this property starts with the top left point, relative to the rectangular signature.
			oPDFExport.Signature.Stamp.TextRectangle = New RectangleF(1.2F, 0.0F, 2.8F, 0.9F)
			' Set the signature image.
			Dim fs As New FileStream(Application.StartupPath + "..//..//..//Image//gc.bmp", FileMode.Open, FileAccess.Read)
			oPDFExport.Signature.Stamp.Image = New Bitmap(Image.FromStream(fs))
			fs.Close()
			' Set the display position of the signature image.
			oPDFExport.Signature.Stamp.ImageAlignment = Alignment.Center
			'Set the rectangle image so that it is placed in the area that displays the signature.
			'The coordinate specified in this property starts with the top left point, relative to the rectangular signature.
			oPDFExport.Signature.Stamp.ImageRectangle = New RectangleF(0, 0, 1, 0.9)
			'Sets the password for the certificate and digital signature.
			'For X509Certificate2 class, etc. Please refer to the site of Microsoft.
			' 　[X509Certificate2 クラス(System.Security.Cryptography.X509Certificates)]
			' 　http://msdn.microsoft.com/ja-jp/library/system.security.cryptography.x509certificates.x509certificate2.aspx
			oPDFExport.Signature.Certificate = New X509Certificate2(Application.StartupPath + "..//..//..//GrapeCity.pfx", "password")
			' 
			If chkTimeStamp.Checked Then
				oPDFExport.Signature.TimeStamp = New TimeStamp("http://tsa.safecreative.org:80", "", "")
			End If
			' Sets the time stamp.
			oPDFExport.Signature.SignDate = New SignatureField(Of Date)(DateTime.Now(), True)		   ' Signing time
			oPDFExport.Signature.DistinguishedName.Visible = False	' Display whether or not the distinguished name				
			oPDFExport.Signature.Contact = New SignatureField(Of String)("activereports.support@grapecity.com", True)	 'Contact
			
			oPDFExport.Signature.Reason = New SignatureField(Of String)("Approval", True)
			
			'					'   Reason
			
			oPDFExport.Signature.Location = New SignatureField(Of String)("Pittsburg", True)
			
			'
			'  Location
			tempPath = Path.GetTempFileName()
			' Export the file.
			oPDFExport.Export(arvMain.Document, tempPath)
			File.Move(tempPath, sfd.FileName)
			'' Start the output file (Open)
			Process.Start(sfd.FileName)
			' Display the notification message.
			MessageBox.Show(My.Resources.Resource.FinishExportMessage, Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
		Catch ex As PdfSigningException
			File.Delete(tempPath)
			MessageBox.Show(My.Resources.Resource.LimitMessage, Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
		Catch ex As Exception
			MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			' Replace the cursor
			Cursor = tmpCursor
			Application.DoEvents()
			' End processing
			sfd.Dispose()
			oPDFExport.Dispose()
		End Try
	End Sub
End Class
