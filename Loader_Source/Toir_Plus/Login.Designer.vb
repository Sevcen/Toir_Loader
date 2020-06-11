<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form1))
        Me.Buton_Hwid = New System.Windows.Forms.Button()
        Me.Label_Key = New System.Windows.Forms.Label()
        Me.Buton_Start = New System.Windows.Forms.Button()
        Me.Text_Licence = New System.Windows.Forms.TextBox()
        Me.Box_Status1 = New System.Windows.Forms.RichTextBox()
        Me.Box_Status2 = New System.Windows.Forms.RichTextBox()
        Me.Text_Hwid = New System.Windows.Forms.TextBox()
        Me.Timer_Login = New System.Windows.Forms.Timer(Me.components)
        Me.Text_Status = New System.Windows.Forms.TextBox()
        Me.Box_Space2 = New System.Windows.Forms.PictureBox()
        Me.Box_Space1 = New System.Windows.Forms.PictureBox()
        CType(Me.Box_Space2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box_Space1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buton_Hwid
        '
        Me.Buton_Hwid.Enabled = False
        Me.Buton_Hwid.Location = New System.Drawing.Point(1, 7)
        Me.Buton_Hwid.Name = "Buton_Hwid"
        Me.Buton_Hwid.Size = New System.Drawing.Size(88, 22)
        Me.Buton_Hwid.TabIndex = 0
        Me.Buton_Hwid.Text = "HWID RESET"
        Me.Buton_Hwid.UseVisualStyleBackColor = True
        '
        'Label_Key
        '
        Me.Label_Key.AutoSize = True
        Me.Label_Key.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label_Key.Location = New System.Drawing.Point(148, 221)
        Me.Label_Key.Name = "Label_Key"
        Me.Label_Key.Size = New System.Drawing.Size(54, 15)
        Me.Label_Key.TabIndex = 1
        Me.Label_Key.Text = "..::KEY::.."
        '
        'Buton_Start
        '
        Me.Buton_Start.Location = New System.Drawing.Point(88, 288)
        Me.Buton_Start.Name = "Buton_Start"
        Me.Buton_Start.Size = New System.Drawing.Size(134, 37)
        Me.Buton_Start.TabIndex = 2
        Me.Buton_Start.Text = "START"
        Me.Buton_Start.UseVisualStyleBackColor = True
        '
        'Text_Licence
        '
        Me.Text_Licence.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Text_Licence.Location = New System.Drawing.Point(35, 240)
        Me.Text_Licence.Name = "Text_Licence"
        Me.Text_Licence.Size = New System.Drawing.Size(301, 24)
        Me.Text_Licence.TabIndex = 3
        '
        'Box_Status1
        '
        Me.Box_Status1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Box_Status1.BackColor = System.Drawing.SystemColors.Control
        Me.Box_Status1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Box_Status1.Enabled = False
        Me.Box_Status1.Location = New System.Drawing.Point(44, 74)
        Me.Box_Status1.Name = "Box_Status1"
        Me.Box_Status1.Size = New System.Drawing.Size(288, 72)
        Me.Box_Status1.TabIndex = 7
        Me.Box_Status1.Text = ""
        '
        'Box_Status2
        '
        Me.Box_Status2.BackColor = System.Drawing.SystemColors.Control
        Me.Box_Status2.Enabled = False
        Me.Box_Status2.Location = New System.Drawing.Point(46, 162)
        Me.Box_Status2.Name = "Box_Status2"
        Me.Box_Status2.Size = New System.Drawing.Size(279, 53)
        Me.Box_Status2.TabIndex = 9
        Me.Box_Status2.Text = ""
        '
        'Text_Hwid
        '
        Me.Text_Hwid.Enabled = False
        Me.Text_Hwid.Location = New System.Drawing.Point(0, 0)
        Me.Text_Hwid.Name = "Text_Hwid"
        Me.Text_Hwid.Size = New System.Drawing.Size(0, 20)
        Me.Text_Hwid.TabIndex = 10
        Me.Text_Hwid.Visible = False
        '
        'Timer_Login
        '
        '
        'Text_Status
        '
        Me.Text_Status.Enabled = False
        Me.Text_Status.Location = New System.Drawing.Point(183, 178)
        Me.Text_Status.Name = "Text_Status"
        Me.Text_Status.Size = New System.Drawing.Size(0, 20)
        Me.Text_Status.TabIndex = 11
        Me.Text_Status.Visible = False
        '
        'Box_Space2
        '
        Me.Box_Space2.BackColor = System.Drawing.Color.Transparent
        Me.Box_Space2.Image = Global.Toir_Plus.My.Resources.Resources.V1
        Me.Box_Space2.Location = New System.Drawing.Point(42, 158)
        Me.Box_Space2.Name = "Box_Space2"
        Me.Box_Space2.Size = New System.Drawing.Size(288, 62)
        Me.Box_Space2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Box_Space2.TabIndex = 8
        Me.Box_Space2.TabStop = False
        '
        'Box_Space1
        '
        Me.Box_Space1.BackColor = System.Drawing.Color.Transparent
        Me.Box_Space1.Image = Global.Toir_Plus.My.Resources.Resources.V1
        Me.Box_Space1.Location = New System.Drawing.Point(40, 71)
        Me.Box_Space1.Name = "Box_Space1"
        Me.Box_Space1.Size = New System.Drawing.Size(296, 80)
        Me.Box_Space1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Box_Space1.TabIndex = 6
        Me.Box_Space1.TabStop = False
        '
        'Login_Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 376)
        Me.Controls.Add(Me.Text_Status)
        Me.Controls.Add(Me.Text_Hwid)
        Me.Controls.Add(Me.Box_Status2)
        Me.Controls.Add(Me.Box_Space2)
        Me.Controls.Add(Me.Box_Status1)
        Me.Controls.Add(Me.Box_Space1)
        Me.Controls.Add(Me.Text_Licence)
        Me.Controls.Add(Me.Buton_Start)
        Me.Controls.Add(Me.Label_Key)
        Me.Controls.Add(Me.Buton_Hwid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login_Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAJTM5"
        CType(Me.Box_Space2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box_Space1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Buton_Hwid As Button
    Friend WithEvents Label_Key As Label
    Friend WithEvents Buton_Start As Button
    Friend WithEvents Text_Licence As TextBox
    Friend WithEvents Box_Space1 As PictureBox
    Friend WithEvents Box_Status1 As RichTextBox
    Friend WithEvents Box_Space2 As PictureBox
    Friend WithEvents Box_Status2 As RichTextBox
    Friend WithEvents Text_Hwid As TextBox
    Friend WithEvents Timer_Login As Timer
    Friend WithEvents Text_Status As TextBox
End Class
