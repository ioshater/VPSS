<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(106, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(559, 36)
        Label1.TabIndex = 0
        Label1.Text = "VEHICLE PARKIING SLOT SYSTEM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(47, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(269, 31)
        Label2.TabIndex = 1
        Label2.Text = "AVAILABLE SLOTS:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(469, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(263, 31)
        Label3.TabIndex = 2
        Label3.Text = "OCCUPIED SLOTS:"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(191, 294)
        Button1.Name = "Button1"
        Button1.Size = New Size(400, 100)
        Button1.TabIndex = 3
        Button1.Text = "BOOK PARKING SLOT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(148, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 31)
        Label4.TabIndex = 4
        Label4.Text = "15"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(596, 173)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 31)
        Label5.TabIndex = 5
        Label5.Text = "10"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 456)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
