<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(173, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(272, 36)
        Label1.TabIndex = 0
        Label1.Text = "CONFIRMATION"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(63, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 31)
        Label2.TabIndex = 1
        Label2.Text = "NAME:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(63, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(205, 31)
        Label3.TabIndex = 2
        Label3.Text = "CONTACT NO:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(63, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 31)
        Label4.TabIndex = 3
        Label4.Text = "DATE:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(63, 252)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 31)
        Label5.TabIndex = 4
        Label5.Text = "TIME:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(63, 299)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 31)
        Label6.TabIndex = 5
        Label6.Text = "SLOT:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(173, 95)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(300, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(264, 151)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(297, 23)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(173, 197)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(187, 23)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(173, 262)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(187, 23)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(173, 307)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(187, 23)
        TextBox5.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(163, 354)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 50)
        Button1.TabIndex = 11
        Button1.Text = "BACK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(436, 354)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 50)
        Button2.TabIndex = 12
        Button2.Text = "NEXT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(621, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
