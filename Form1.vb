Imports System.Data.OleDb
Imports System.Windows.Forms



Public Class Form1

    Public Const NUM_FOODS As Integer = 7

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCreateDiet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateDiet.Click
        Try
            txtApog.Clear()
            txtEnd.Clear()
            txtMesim.Clear()
            txtPro.Clear()
            txtVrad.Clear()

            Dim R As Integer

            R = Int((NUM_FOODS * Rnd()) + 1)

            txtPro.AppendText(SQLquery("SELECT PRO_DESCR FROM PRO WHERE PRO_ID=" & R.ToString))

            R = Int((NUM_FOODS * Rnd()) + 1)

            txtEnd.AppendText(SQLquery("SELECT ENDIAM_DESCR FROM ENDIAM WHERE ENDIAM_ID=" & R.ToString))

            R = Int((NUM_FOODS * Rnd()) + 1)

            txtMesim.AppendText(SQLquery("SELECT MESIM_DESCR FROM MESIM WHERE MESIM_ID=" & R.ToString))

            R = Int((NUM_FOODS * Rnd()) + 1)

            txtApog.AppendText(SQLquery("SELECT APOG_DESCR FROM APOG WHERE APOG_ID=" & R.ToString))

            R = Int((NUM_FOODS * Rnd()) + 1)

            txtVrad.AppendText(SQLquery("SELECT VRAD_DESCR FROM VRAD WHERE VRAD_ID=" & R.ToString))

            TabControl1.SelectedTab() = TabControl1.TabPages.Item(1)

            btnWordExport.Visible = True

        Catch ex As Exception
            MessageBox.Show("Συνέβη κάποιο σφάλμα κατά τη διαδικασία. Παρακαλώ ελέγξτε.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Dim res As DialogResult

        res = MessageBox.Show("Να κλείσει η εφαρμογή;", "Έξοδος από την εφαρμογή", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If res = System.Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Function SQLquery(ByVal str As String) As String

        Dim conn As New System.Data.OleDb.OleDbConnection()

        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=" & Application.StartupPath & "\dfs.mdb"

        Try

            Dim custCMD As OleDbCommand = New OleDbCommand(str, conn)

            conn.Open()

            Dim custReader As OleDbDataReader = custCMD.ExecuteReader()

            custReader.Read()
            Return custReader.GetValue(0)

            'Do While custReader.Read()
            'Console.WriteLine(custReader.GetInt32(1) & vbTab & custReader.GetInt32(2) & vbTab & custReader.GetString(3))
            'Console.WriteLine(custReader.GetString(0))
            'txtPro.AppendText(custReader.GetValue(0))
            'Loop

            custReader.Close()

        Catch ex As Exception
            MessageBox.Show("Σφάλμα κατά τη σύνδεση με τη βάση δεδομένων." & vbNewLine & "Παρακαλώ ελέγξτε.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return ""
        Finally
            conn.Close()
        End Try


    End Function

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.kostasdelimaris.gr")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("http://www.eabd.gr")
    End Sub

    Private Sub btnWordExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWordExport.Click
        Try
            Dim oWord As Word.Application
            Dim oDoc As Word.Document
            Dim oTable As Word.Table
            Dim oPara1 As Word.Paragraph
            Dim oRng As Word.Range

            'Start Word and open the document template.
            oWord = CreateObject("Word.Application")
            oWord.Visible = True
            oDoc = oWord.Documents.Add

            'Insert a paragraph at the beginning of the document.
            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Range.Text = "Ημερήσια Δίαιτα"
            oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            oPara1.Range.Font.Bold = True
            oPara1.Range.Font.Size = 20
            'oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter()


            oPara1.Range.Font.Size = 13
            oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft


            oRng = oDoc.Bookmarks.Item("\endofdoc").Range
            oRng.InsertParagraphAfter()
            oRng.InsertParagraphAfter()
            'oRng.InsertBreak()
            'oRng.InsertAfter("--------------------------------------------------------------")


            oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 5, 2)
            oTable.Borders.Enable = True
            oTable.Range.ParagraphFormat.SpaceAfter = 6

            oTable.Cell(1, 1).Range.Text = "ΠΡΩΙΝΟ"
            oTable.Cell(2, 1).Range.Text = "ΕΝΔΙΑΜΕΣΟ"
            oTable.Cell(3, 1).Range.Text = "ΜΕΣΗΜΕΡΙΑΝΟ"
            oTable.Cell(4, 1).Range.Text = "ΑΠΟΓΕΥΜΑΤΙΝΟ"
            oTable.Cell(5, 1).Range.Text = "ΒΡΑΔΙΝΟ"

            oTable.Cell(1, 2).Range.Text = txtPro.Text
            oTable.Cell(2, 2).Range.Text = txtEnd.Text
            oTable.Cell(3, 2).Range.Text = txtMesim.Text
            oTable.Cell(4, 2).Range.Text = txtApog.Text
            oTable.Cell(5, 2).Range.Text = txtVrad.Text


            Dim i As Integer

            For i = 1 To 5
                oTable.Rows.Item(i).Range.Font.Bold = True
                'oTable.Rows.Item(i).Alignment = Word.WdRowAlignment.wdAlignRowLeft
            Next

        Catch ex As Exception
            MessageBox.Show("Σφάλμα κατά την εξαγωγή στο Word." & vbNewLine & "Παρακαλώ ελέγξτε.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub


    Private Sub btnCreateWeeklyDiet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateWeeklyDiet.Click
        Try
            Dim oWord As Word.Application
            Dim oDoc As Word.Document

            Dim oTable1 As Word.Table
            Dim oTable2 As Word.Table
            Dim oTable3 As Word.Table
            Dim oTable4 As Word.Table
            Dim oTable5 As Word.Table
            Dim oTable6 As Word.Table
            Dim oTable7 As Word.Table

            Dim oPara1 As Word.Paragraph
            'Dim oPara2 As Word.Paragraph
            'Dim oPara3 As Word.Paragraph
            'Dim oPara4 As Word.Paragraph
            'Dim oPara5 As Word.Paragraph
            'Dim oPara6 As Word.Paragraph
            'Dim oPara7 As Word.Paragraph

            Dim oRng1 As Word.Range
            Dim oRng2 As Word.Range
            Dim oRng3 As Word.Range
            Dim oRng4 As Word.Range
            Dim oRng5 As Word.Range
            Dim oRng6 As Word.Range
            Dim oRng7 As Word.Range

            'Start Word and open the document template.
            oWord = CreateObject("Word.Application")
            oWord.Visible = True
            oDoc = oWord.Documents.Add

            'Insert a paragraph at the beginning of the document.
            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Range.Text = "Εβδομαδιαία Δίαιτα"
            oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            oPara1.Range.Font.Bold = True
            oPara1.Range.Font.Size = 20
            'oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter()


            oPara1.Range.Font.Size = 13

            '================================== DEYTERA ================================================
            oRng1 = oDoc.Bookmarks.Item("\endofdoc").Range
            oRng1.InsertParagraphAfter()
            oRng1.InsertParagraphAfter()

            oRng1.InsertBefore("ΔΕΥΤΕΡΑ")

            oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft

            oTable1 = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 5, 2)
            oTable1.Borders.Enable = True
            oTable1.Range.ParagraphFormat.SpaceAfter = 6

            oTable1.Cell(1, 1).Range.Text = "ΠΡΩΙΝΟ"
            oTable1.Cell(2, 1).Range.Text = "ΕΝΔΙΑΜΕΣΟ"
            oTable1.Cell(3, 1).Range.Text = "ΜΕΣΗΜΕΡΙΑΝΟ"
            oTable1.Cell(4, 1).Range.Text = "ΑΠΟΓΕΥΜΑΤΙΝΟ"
            oTable1.Cell(5, 1).Range.Text = "ΒΡΑΔΙΝΟ"

            Dim R As Integer

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable1.Cell(1, 2).Range.Text = SQLquery("SELECT PRO_DESCR FROM PRO WHERE PRO_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable1.Cell(2, 2).Range.Text = SQLquery("SELECT ENDIAM_DESCR FROM ENDIAM WHERE ENDIAM_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable1.Cell(3, 2).Range.Text = SQLquery("SELECT MESIM_DESCR FROM MESIM WHERE MESIM_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable1.Cell(4, 2).Range.Text = SQLquery("SELECT APOG_DESCR FROM APOG WHERE APOG_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable1.Cell(5, 2).Range.Text = SQLquery("SELECT VRAD_DESCR FROM VRAD WHERE VRAD_ID=" & R.ToString)


            Dim i As Integer

            For i = 1 To 5
                oTable1.Rows.Item(i).Range.Font.Bold = True
            Next



            '================================== TRITH ==================================================================
            oRng2 = oDoc.Bookmarks.Item("\endofdoc").Range
            oRng2.InsertBreak(Word.WdBreakType.wdSectionBreakNextPage)

            oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            oRng2.InsertParagraphAfter()
            oRng2.InsertParagraphAfter()

            oRng2.InsertBefore("ΤΡΙΤΗ")


            oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft


            oTable2 = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 5, 2)
            oTable2.Borders.Enable = True
            oTable2.Range.ParagraphFormat.SpaceAfter = 6

            oTable2.Cell(1, 1).Range.Text = "ΠΡΩΙΝΟ"
            oTable2.Cell(2, 1).Range.Text = "ΕΝΔΙΑΜΕΣΟ"
            oTable2.Cell(3, 1).Range.Text = "ΜΕΣΗΜΕΡΙΑΝΟ"
            oTable2.Cell(4, 1).Range.Text = "ΑΠΟΓΕΥΜΑΤΙΝΟ"
            oTable2.Cell(5, 1).Range.Text = "ΒΡΑΔΙΝΟ"


            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable2.Cell(1, 2).Range.Text = SQLquery("SELECT PRO_DESCR FROM PRO WHERE PRO_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable2.Cell(2, 2).Range.Text = SQLquery("SELECT ENDIAM_DESCR FROM ENDIAM WHERE ENDIAM_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable2.Cell(3, 2).Range.Text = SQLquery("SELECT MESIM_DESCR FROM MESIM WHERE MESIM_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable2.Cell(4, 2).Range.Text = SQLquery("SELECT APOG_DESCR FROM APOG WHERE APOG_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable2.Cell(5, 2).Range.Text = SQLquery("SELECT VRAD_DESCR FROM VRAD WHERE VRAD_ID=" & R.ToString)


            For i = 1 To 5
                oTable2.Rows.Item(i).Range.Font.Bold = True
            Next



            '================================== TETARTH ==================================================================
            oRng3 = oDoc.Bookmarks.Item("\endofdoc").Range
            oRng3.InsertBreak(Word.WdBreakType.wdSectionBreakNextPage)

            oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            oRng3.InsertParagraphAfter()
            oRng3.InsertParagraphAfter()

            oRng3.InsertBefore("ΤΕΤΑΡΤΗ")


            oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft


            oTable3 = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 5, 2)
            oTable3.Borders.Enable = True
            oTable3.Range.ParagraphFormat.SpaceAfter = 6

            oTable3.Cell(1, 1).Range.Text = "ΠΡΩΙΝΟ"
            oTable3.Cell(2, 1).Range.Text = "ΕΝΔΙΑΜΕΣΟ"
            oTable3.Cell(3, 1).Range.Text = "ΜΕΣΗΜΕΡΙΑΝΟ"
            oTable3.Cell(4, 1).Range.Text = "ΑΠΟΓΕΥΜΑΤΙΝΟ"
            oTable3.Cell(5, 1).Range.Text = "ΒΡΑΔΙΝΟ"


            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable3.Cell(1, 2).Range.Text = SQLquery("SELECT PRO_DESCR FROM PRO WHERE PRO_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable3.Cell(2, 2).Range.Text = SQLquery("SELECT ENDIAM_DESCR FROM ENDIAM WHERE ENDIAM_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable3.Cell(3, 2).Range.Text = SQLquery("SELECT MESIM_DESCR FROM MESIM WHERE MESIM_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable3.Cell(4, 2).Range.Text = SQLquery("SELECT APOG_DESCR FROM APOG WHERE APOG_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable3.Cell(5, 2).Range.Text = SQLquery("SELECT VRAD_DESCR FROM VRAD WHERE VRAD_ID=" & R.ToString)


            For i = 1 To 5
                oTable3.Rows.Item(i).Range.Font.Bold = True
            Next


            '================================== PEMPTH ==================================================================
            oRng4 = oDoc.Bookmarks.Item("\endofdoc").Range
            oRng4.InsertBreak(Word.WdBreakType.wdSectionBreakNextPage)

            oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            oRng4.InsertParagraphAfter()
            oRng4.InsertParagraphAfter()

            oRng4.InsertBefore("ΠΕΜΠΤΗ")


            oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft


            oTable4 = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 5, 2)
            oTable4.Borders.Enable = True
            oTable4.Range.ParagraphFormat.SpaceAfter = 6

            oTable4.Cell(1, 1).Range.Text = "ΠΡΩΙΝΟ"
            oTable4.Cell(2, 1).Range.Text = "ΕΝΔΙΑΜΕΣΟ"
            oTable4.Cell(3, 1).Range.Text = "ΜΕΣΗΜΕΡΙΑΝΟ"
            oTable4.Cell(4, 1).Range.Text = "ΑΠΟΓΕΥΜΑΤΙΝΟ"
            oTable4.Cell(5, 1).Range.Text = "ΒΡΑΔΙΝΟ"


            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable4.Cell(1, 2).Range.Text = SQLquery("SELECT PRO_DESCR FROM PRO WHERE PRO_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable4.Cell(2, 2).Range.Text = SQLquery("SELECT ENDIAM_DESCR FROM ENDIAM WHERE ENDIAM_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable4.Cell(3, 2).Range.Text = SQLquery("SELECT MESIM_DESCR FROM MESIM WHERE MESIM_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable4.Cell(4, 2).Range.Text = SQLquery("SELECT APOG_DESCR FROM APOG WHERE APOG_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable4.Cell(5, 2).Range.Text = SQLquery("SELECT VRAD_DESCR FROM VRAD WHERE VRAD_ID=" & R.ToString)


            For i = 1 To 5
                oTable4.Rows.Item(i).Range.Font.Bold = True
            Next



            '================================== PARASKEVI ==================================================================
            oRng5 = oDoc.Bookmarks.Item("\endofdoc").Range
            oRng5.InsertBreak(Word.WdBreakType.wdSectionBreakNextPage)

            oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            oRng5.InsertParagraphAfter()
            oRng5.InsertParagraphAfter()

            oRng5.InsertBefore("ΠΑΡΑΣΚΕΥΗ")


            oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft


            oTable5 = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 5, 2)
            oTable5.Borders.Enable = True
            oTable5.Range.ParagraphFormat.SpaceAfter = 6

            oTable5.Cell(1, 1).Range.Text = "ΠΡΩΙΝΟ"
            oTable5.Cell(2, 1).Range.Text = "ΕΝΔΙΑΜΕΣΟ"
            oTable5.Cell(3, 1).Range.Text = "ΜΕΣΗΜΕΡΙΑΝΟ"
            oTable5.Cell(4, 1).Range.Text = "ΑΠΟΓΕΥΜΑΤΙΝΟ"
            oTable5.Cell(5, 1).Range.Text = "ΒΡΑΔΙΝΟ"


            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable5.Cell(1, 2).Range.Text = SQLquery("SELECT PRO_DESCR FROM PRO WHERE PRO_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable5.Cell(2, 2).Range.Text = SQLquery("SELECT ENDIAM_DESCR FROM ENDIAM WHERE ENDIAM_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable5.Cell(3, 2).Range.Text = SQLquery("SELECT MESIM_DESCR FROM MESIM WHERE MESIM_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable5.Cell(4, 2).Range.Text = SQLquery("SELECT APOG_DESCR FROM APOG WHERE APOG_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable5.Cell(5, 2).Range.Text = SQLquery("SELECT VRAD_DESCR FROM VRAD WHERE VRAD_ID=" & R.ToString)


            For i = 1 To 5
                oTable5.Rows.Item(i).Range.Font.Bold = True
            Next



            '================================== SAVATO ==================================================================
            oRng6 = oDoc.Bookmarks.Item("\endofdoc").Range
            oRng6.InsertBreak(Word.WdBreakType.wdSectionBreakNextPage)

            oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            oRng6.InsertParagraphAfter()
            oRng6.InsertParagraphAfter()

            oRng6.InsertBefore("ΣΑΒΒΑΤΟ")


            oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft


            oTable6 = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 5, 2)
            oTable6.Borders.Enable = True
            oTable6.Range.ParagraphFormat.SpaceAfter = 6

            oTable6.Cell(1, 1).Range.Text = "ΠΡΩΙΝΟ"
            oTable6.Cell(2, 1).Range.Text = "ΕΝΔΙΑΜΕΣΟ"
            oTable6.Cell(3, 1).Range.Text = "ΜΕΣΗΜΕΡΙΑΝΟ"
            oTable6.Cell(4, 1).Range.Text = "ΑΠΟΓΕΥΜΑΤΙΝΟ"
            oTable6.Cell(5, 1).Range.Text = "ΒΡΑΔΙΝΟ"


            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable6.Cell(1, 2).Range.Text = SQLquery("SELECT PRO_DESCR FROM PRO WHERE PRO_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable6.Cell(2, 2).Range.Text = SQLquery("SELECT ENDIAM_DESCR FROM ENDIAM WHERE ENDIAM_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable6.Cell(3, 2).Range.Text = SQLquery("SELECT MESIM_DESCR FROM MESIM WHERE MESIM_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable6.Cell(4, 2).Range.Text = SQLquery("SELECT APOG_DESCR FROM APOG WHERE APOG_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable6.Cell(5, 2).Range.Text = SQLquery("SELECT VRAD_DESCR FROM VRAD WHERE VRAD_ID=" & R.ToString)


            For i = 1 To 5
                oTable6.Rows.Item(i).Range.Font.Bold = True
            Next


            '================================== KYRIAKH ==================================================================
            oRng7 = oDoc.Bookmarks.Item("\endofdoc").Range
            oRng7.InsertBreak(Word.WdBreakType.wdSectionBreakNextPage)

            oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            oRng7.InsertParagraphAfter()
            oRng7.InsertParagraphAfter()

            oRng7.InsertBefore("ΚΥΡΙΑΚΗ")


            oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft


            oTable7 = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 5, 2)
            oTable7.Borders.Enable = True
            oTable7.Range.ParagraphFormat.SpaceAfter = 6

            oTable7.Cell(1, 1).Range.Text = "ΠΡΩΙΝΟ"
            oTable7.Cell(2, 1).Range.Text = "ΕΝΔΙΑΜΕΣΟ"
            oTable7.Cell(3, 1).Range.Text = "ΜΕΣΗΜΕΡΙΑΝΟ"
            oTable7.Cell(4, 1).Range.Text = "ΑΠΟΓΕΥΜΑΤΙΝΟ"
            oTable7.Cell(5, 1).Range.Text = "ΒΡΑΔΙΝΟ"


            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable7.Cell(1, 2).Range.Text = SQLquery("SELECT PRO_DESCR FROM PRO WHERE PRO_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable7.Cell(2, 2).Range.Text = SQLquery("SELECT ENDIAM_DESCR FROM ENDIAM WHERE ENDIAM_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable7.Cell(3, 2).Range.Text = SQLquery("SELECT MESIM_DESCR FROM MESIM WHERE MESIM_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable7.Cell(4, 2).Range.Text = SQLquery("SELECT APOG_DESCR FROM APOG WHERE APOG_ID=" & R.ToString)

            R = Int((NUM_FOODS * Rnd()) + 1)
            oTable7.Cell(5, 2).Range.Text = SQLquery("SELECT VRAD_DESCR FROM VRAD WHERE VRAD_ID=" & R.ToString)


            For i = 1 To 5
                oTable7.Rows.Item(i).Range.Font.Bold = True
            Next


        Catch ex As Exception
            MessageBox.Show("Σφάλμα κατά την εξαγωγή στο Word." & vbNewLine & "Παρακαλώ ελέγξτε.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
End Class
