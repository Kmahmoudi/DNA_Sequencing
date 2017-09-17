<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.InputSeq = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MaxChunkSize = New System.Windows.Forms.TextBox()
        Me.MinChunkSize = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NumOfDuplicates = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DnaLength = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Repeats = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cpercent = New System.Windows.Forms.TextBox()
        Me.Gpercent = New System.Windows.Forms.TextBox()
        Me.Tpercent = New System.Windows.Forms.TextBox()
        Me.Apercent = New System.Windows.Forms.TextBox()
        Me.Output = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.InputSeq)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.MaxChunkSize)
        Me.GroupBox1.Controls.Add(Me.MinChunkSize)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.NumOfDuplicates)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DnaLength)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Repeats)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Cpercent)
        Me.GroupBox1.Controls.Add(Me.Gpercent)
        Me.GroupBox1.Controls.Add(Me.Tpercent)
        Me.GroupBox1.Controls.Add(Me.Apercent)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(935, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generate"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(713, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(65, 31)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Neo4J"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(714, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 39)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "DNA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sequence" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "input:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(784, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 31)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Set sequence below"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'InputSeq
        '
        Me.InputSeq.Location = New System.Drawing.Point(784, 49)
        Me.InputSeq.Multiline = True
        Me.InputSeq.Name = "InputSeq"
        Me.InputSeq.Size = New System.Drawing.Size(142, 48)
        Me.InputSeq.TabIndex = 10
        Me.InputSeq.Text = "AAABBBA"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(717, 103)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(212, 23)
        Me.ProgressBar1.TabIndex = 27
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(602, 91)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 31)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Assemble"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(602, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 31)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Chop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(576, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "bp"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(576, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "bp"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(576, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "bp"
        '
        'MaxChunkSize
        '
        Me.MaxChunkSize.Location = New System.Drawing.Point(528, 106)
        Me.MaxChunkSize.Name = "MaxChunkSize"
        Me.MaxChunkSize.Size = New System.Drawing.Size(42, 20)
        Me.MaxChunkSize.TabIndex = 9
        Me.MaxChunkSize.Text = "50"
        '
        'MinChunkSize
        '
        Me.MinChunkSize.Location = New System.Drawing.Point(528, 79)
        Me.MinChunkSize.Name = "MinChunkSize"
        Me.MinChunkSize.Size = New System.Drawing.Size(42, 20)
        Me.MinChunkSize.TabIndex = 8
        Me.MinChunkSize.Text = "2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(415, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Min Size of Chunk: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(415, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Max Size of Chunk :"
        '
        'NumOfDuplicates
        '
        Me.NumOfDuplicates.Location = New System.Drawing.Point(528, 50)
        Me.NumOfDuplicates.Name = "NumOfDuplicates"
        Me.NumOfDuplicates.Size = New System.Drawing.Size(42, 20)
        Me.NumOfDuplicates.TabIndex = 7
        Me.NumOfDuplicates.Text = "10"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(415, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Number of Duplicates : "
        '
        'DnaLength
        '
        Me.DnaLength.Location = New System.Drawing.Point(493, 16)
        Me.DnaLength.Name = "DnaLength"
        Me.DnaLength.Size = New System.Drawing.Size(77, 20)
        Me.DnaLength.TabIndex = 6
        Me.DnaLength.Text = "100"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(415, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "DNA Length :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(602, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 31)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Generate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(136, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 52)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Repeat(s) input:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[sequence,count]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "one repeat per line"
        '
        'Repeats
        '
        Me.Repeats.Location = New System.Drawing.Point(259, 23)
        Me.Repeats.Multiline = True
        Me.Repeats.Name = "Repeats"
        Me.Repeats.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Repeats.Size = New System.Drawing.Size(136, 94)
        Me.Repeats.TabIndex = 5
        Me.Repeats.Text = "CAGCAGCAGCAG,1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TTAT,2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(93, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(93, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(93, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "G:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "C:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "T:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "A:"
        '
        'Cpercent
        '
        Me.Cpercent.Location = New System.Drawing.Point(31, 70)
        Me.Cpercent.Name = "Cpercent"
        Me.Cpercent.Size = New System.Drawing.Size(56, 20)
        Me.Cpercent.TabIndex = 3
        Me.Cpercent.Text = "25"
        '
        'Gpercent
        '
        Me.Gpercent.Location = New System.Drawing.Point(31, 93)
        Me.Gpercent.Name = "Gpercent"
        Me.Gpercent.Size = New System.Drawing.Size(56, 20)
        Me.Gpercent.TabIndex = 4
        Me.Gpercent.Text = "25"
        '
        'Tpercent
        '
        Me.Tpercent.Location = New System.Drawing.Point(31, 47)
        Me.Tpercent.Name = "Tpercent"
        Me.Tpercent.Size = New System.Drawing.Size(56, 20)
        Me.Tpercent.TabIndex = 2
        Me.Tpercent.Text = "25"
        '
        'Apercent
        '
        Me.Apercent.Location = New System.Drawing.Point(31, 23)
        Me.Apercent.Name = "Apercent"
        Me.Apercent.Size = New System.Drawing.Size(56, 20)
        Me.Apercent.TabIndex = 1
        Me.Apercent.Text = "25"
        '
        'Output
        '
        Me.Output.Location = New System.Drawing.Point(12, 150)
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(711, 313)
        Me.Output.TabIndex = 1
        Me.Output.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DNAsequencer.My.Resources.Resources.dna_rna_double_helix_rotating_animation_13_3
        Me.PictureBox1.Location = New System.Drawing.Point(729, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 345)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 475)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DNA Sequencer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Repeats As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cpercent As TextBox
    Friend WithEvents Gpercent As TextBox
    Friend WithEvents Tpercent As TextBox
    Friend WithEvents Apercent As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Output As RichTextBox
    Friend WithEvents DnaLength As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents MaxChunkSize As TextBox
    Friend WithEvents MinChunkSize As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents NumOfDuplicates As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents InputSeq As TextBox
    Friend WithEvents Button5 As Button
End Class
