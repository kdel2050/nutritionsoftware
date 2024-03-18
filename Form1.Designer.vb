<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCreateDiet = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVrad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApog = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMesim = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPro = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnWordExport = New System.Windows.Forms.Button()
        Me.btnCreateWeeklyDiet = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(-2, -3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(601, 508)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnCreateWeeklyDiet)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.btnCreateDiet)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(593, 482)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Αρχική"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(579, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Καλώς ήρθατε στο λογισμικό δημιουργίας ημερήσιας δίαιτας. Κάντε κλικ στο κουμπί π" & _
            "αρακάτω για να ξεκινήσετε:"
        '
        'btnCreateDiet
        '
        Me.btnCreateDiet.Location = New System.Drawing.Point(88, 87)
        Me.btnCreateDiet.Name = "btnCreateDiet"
        Me.btnCreateDiet.Size = New System.Drawing.Size(154, 59)
        Me.btnCreateDiet.TabIndex = 2
        Me.btnCreateDiet.Text = "&Δημιουργία Ημερήσιας δίαιτας 1500 θερμίδων"
        Me.btnCreateDiet.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtVrad)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtApog)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtMesim)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtEnd)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtPro)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(593, 482)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ημερήσιο Διαιτολόγιο"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Βραδινό"
        '
        'txtVrad
        '
        Me.txtVrad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtVrad.Location = New System.Drawing.Point(103, 374)
        Me.txtVrad.Multiline = True
        Me.txtVrad.Name = "txtVrad"
        Me.txtVrad.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtVrad.Size = New System.Drawing.Size(479, 83)
        Me.txtVrad.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Απογευματινό"
        '
        'txtApog
        '
        Me.txtApog.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtApog.Location = New System.Drawing.Point(103, 285)
        Me.txtApog.Multiline = True
        Me.txtApog.Name = "txtApog"
        Me.txtApog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtApog.Size = New System.Drawing.Size(479, 83)
        Me.txtApog.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Μεσημεριανό"
        '
        'txtMesim
        '
        Me.txtMesim.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMesim.Location = New System.Drawing.Point(103, 196)
        Me.txtMesim.Multiline = True
        Me.txtMesim.Name = "txtMesim"
        Me.txtMesim.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMesim.Size = New System.Drawing.Size(479, 83)
        Me.txtMesim.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ενδιάμεσο"
        '
        'txtEnd
        '
        Me.txtEnd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEnd.Location = New System.Drawing.Point(103, 107)
        Me.txtEnd.Multiline = True
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEnd.Size = New System.Drawing.Size(479, 83)
        Me.txtEnd.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Πρωινό"
        '
        'txtPro
        '
        Me.txtPro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPro.Location = New System.Drawing.Point(103, 18)
        Me.txtPro.Multiline = True
        Me.txtPro.Name = "txtPro"
        Me.txtPro.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPro.Size = New System.Drawing.Size(479, 83)
        Me.txtPro.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.LinkLabel2)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.LinkLabel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(593, 482)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Περί...."
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(435, 66)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(101, 13)
        Me.LinkLabel2.TabIndex = 5
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "http://www.eabd.gr"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(38, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(428, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Δημιουργήθηκε το 2012 με χρήση της Visual Basic 2010 Express Edition."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(38, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(367, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Ανάλυση και Προγραμματισμός: Κωνσταντίνος Α. Δελημάρης"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(38, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(391, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Αλγόριθμος - Υλοποίηση Διαιτολογίου: Δρ. Ιωάννης Α. Δελημάρης"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(38, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(222, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Λογισμικό Διατροφής - Διαιτολογίας"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(411, 100)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(148, 13)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://www.kostasdelimaris.gr"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(467, 517)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 33)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Έ&ξοδος"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnWordExport
        '
        Me.btnWordExport.Location = New System.Drawing.Point(290, 517)
        Me.btnWordExport.Name = "btnWordExport"
        Me.btnWordExport.Size = New System.Drawing.Size(165, 33)
        Me.btnWordExport.TabIndex = 4
        Me.btnWordExport.Text = "&Εξαγωγή σε αρχείο Word"
        Me.btnWordExport.UseVisualStyleBackColor = True
        Me.btnWordExport.Visible = False
        '
        'btnCreateWeeklyDiet
        '
        Me.btnCreateWeeklyDiet.Location = New System.Drawing.Point(288, 87)
        Me.btnCreateWeeklyDiet.Name = "btnCreateWeeklyDiet"
        Me.btnCreateWeeklyDiet.Size = New System.Drawing.Size(200, 59)
        Me.btnCreateWeeklyDiet.TabIndex = 4
        Me.btnCreateWeeklyDiet.Text = "Δημιου&ργία Εβδομαδιαίας δίαιτας 1500 θερμίδων σε Word αρχείο"
        Me.btnCreateWeeklyDiet.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 562)
        Me.Controls.Add(Me.btnWordExport)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delimaris Food Software"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnCreateDiet As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtPro As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtVrad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtApog As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMesim As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnWordExport As System.Windows.Forms.Button
    Friend WithEvents btnCreateWeeklyDiet As System.Windows.Forms.Button

End Class
