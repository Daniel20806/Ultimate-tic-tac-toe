<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog3
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        OK_Button = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.Location = New Point(97, 174)
        OK_Button.Margin = New Padding(6, 5, 6, 5)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(122, 41)
        OK_Button.TabIndex = 0
        OK_Button.Text = "確定"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Control
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Microsoft JhengHei UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(83, 75)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(223, 77)
        TextBox1.TabIndex = 1
        TextBox1.Text = "和局!!"
        ' 
        ' Dialog3
        ' 
        AcceptButton = OK_Button
        AutoScaleDimensions = New SizeF(11F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(333, 229)
        Controls.Add(TextBox1)
        Controls.Add(OK_Button)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(6, 5, 6, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Dialog3"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Dialog3"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents OK_Button As Button
    Friend WithEvents TextBox1 As TextBox
End Class
