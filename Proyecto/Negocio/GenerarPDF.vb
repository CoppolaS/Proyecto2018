Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Windows.Forms

Public Class GenerarPDF

    'GPDF.Generopdf(Tabla1.DataGridView1, "Funcionarios", "Funcionarios")
    'es necesario usar rutas relativas aca

    Public Sub Generopdf(ByVal dgv As DataGridView, ByVal NombrePDF As String, ByVal TituloPDF As String)
        Dim paragraph As New Paragraph
        Dim PdfFile As New Document(PageSize.A4, 40, 40, 40, 20)
        PdfFile.AddTitle(TituloPDF)
        Dim Write As PdfWriter = PdfWriter.GetInstance(PdfFile, New FileStream("C:\Users\tiago\Documents\" & NombrePDF & ".pdf", FileMode.Create))
        PdfFile.Open()
        Dim pTitle As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim pTable As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        paragraph = New Paragraph(New Chunk(TituloPDF, pTitle))
        paragraph.Alignment = Element.ALIGN_CENTER
        paragraph.SpacingAfter = 5.0F
        PdfFile.Add(paragraph)
        Dim PdfTable As New PdfPTable(dgv.Columns.Count)
        PdfTable.TotalWidth = 500.0F
        PdfTable.LockedWidth = True
        Dim widths(0 To dgv.Columns.Count - 1) As Single
        For i As Integer = 0 To dgv.Columns.Count - 1
            widths(i) = 1.0F
        Next
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 0
        PdfTable.SpacingBefore = 5.0F
        Dim pdfcell As PdfPCell = New PdfPCell
        For i As Integer = 0 To dgv.Columns.Count - 1
            pdfcell = New PdfPCell(New Phrase(New Chunk(dgv.Columns(i).HeaderText, pTable)))
            pdfcell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            PdfTable.AddCell(pdfcell)
        Next
        For i As Integer = 0 To dgv.Rows.Count - 2
            For j As Integer = 0 To dgv.Columns.Count - 1
                pdfcell = New PdfPCell(New Phrase(dgv(j, i).Value.ToString(), pTable))
                PdfTable.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                PdfTable.AddCell(pdfcell)
            Next
        Next
        PdfFile.Add(PdfTable)
        PdfFile.Close()
        System.Diagnostics.Process.Start("C:\Users\tiago\Documents\" & NombrePDF & ".pdf")
    End Sub

End Class
