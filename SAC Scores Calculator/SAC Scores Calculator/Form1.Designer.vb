<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnDisplay = New Button()
        btnAppend = New Button()
        lstDisplay = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(141, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(540, 59)
        Label1.TabIndex = 0
        Label1.Text = "Append and Display Scores"
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Font = New Font("Segoe UI", 12F)
        btnDisplay.Location = New Point(119, 131)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(233, 74)
        btnDisplay.TabIndex = 1
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' btnAppend
        ' 
        btnAppend.Font = New Font("Segoe UI", 12F)
        btnAppend.Location = New Point(119, 310)
        btnAppend.Name = "btnAppend"
        btnAppend.Size = New Size(233, 74)
        btnAppend.TabIndex = 2
        btnAppend.Text = "Append"
        btnAppend.UseVisualStyleBackColor = True
        ' 
        ' lstDisplay
        ' 
        lstDisplay.FormattingEnabled = True
        lstDisplay.Location = New Point(377, 131)
        lstDisplay.Name = "lstDisplay"
        lstDisplay.Size = New Size(364, 260)
        lstDisplay.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstDisplay)
        Controls.Add(btnAppend)
        Controls.Add(btnDisplay)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "SAC SCORES"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnAppend As Button
    Friend WithEvents lstDisplay As ListBox

End Class
