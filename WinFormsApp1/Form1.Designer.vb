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
        txtData = New TextBox()
        btnSave = New Button()
        btnOpen = New Button()
        SuspendLayout()
        ' 
        ' txtData
        ' 
        txtData.Location = New Point(22, 12)
        txtData.Multiline = True
        txtData.Name = "txtData"
        txtData.Size = New Size(443, 318)
        txtData.TabIndex = 0
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(90, 357)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 1
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnOpen
        ' 
        btnOpen.Location = New Point(255, 357)
        btnOpen.Name = "btnOpen"
        btnOpen.Size = New Size(94, 29)
        btnOpen.TabIndex = 2
        btnOpen.Text = "Open"
        btnOpen.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(477, 450)
        Controls.Add(btnOpen)
        Controls.Add(btnSave)
        Controls.Add(txtData)
        Name = "Form1"
        Text = "Bekerja Dengan File"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtData As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnOpen As Button

End Class
