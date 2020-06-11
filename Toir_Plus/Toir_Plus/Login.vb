Imports System.Threading.Thread

Public Class Login_Form1
    Dim ToirDirectory As IO.FileInfo
    Dim DLLDirectory As IO.FileInfo

    Private Sub Buton_Hwid_Click(sender As Object, e As EventArgs) Handles Buton_Hwid.Click
        Try
            Tools.Web_Hwid.Navigate("http://185.160.30.211//hg/trxgn.php?=reset+" + Tools.Encrypt2.Text)
            Box_Status1.SelectAll()
            Box_Status1.SelectionAlignment = HorizontalAlignment.Center
            Box_Status1.Text = "...:::Hwid Reset Succesfull:::..."
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Login_Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '/////////////////////////////////
            'No License Control. Direct entry!
            'Manual Login Control  '//////////
            Text_Status.Text = "1" '//////////
            '/////////////////////////////////

            Get_Hwid()
            Windows_Defender_Close()
            Apply_UserAgent()
            Fuck_Bot4League()
            Check_Update()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer_Login_Tick(sender As Object, e As EventArgs) Handles Timer_Login.Tick
        Try
            If (Tools.Web_Licence2.Url.ToString().Contains(Tools.Encrypt2.Text + My.Computer.Name)) Then
                'SUCCES LOGIN
                Timer_Login.Stop()

                Dim ToirDirectory As IO.FileInfo
                ToirDirectory = My.Computer.FileSystem.GetFileInfo(My.Application.Info.DirectoryPath + "\nyscrpt.exe")

                Dim TOIRSTART As New ProcessStartInfo(ToirDirectory.Length)
                TOIRSTART.WindowStyle = ProcessWindowStyle.Minimized
                Process.Start(TOIRSTART)

                Sleep(1500)
                Inject_Toir_Login()
            Else
                'FAILED LOGIN
                Box_Status1.SelectAll()
                Box_Status1.SelectionAlignment = HorizontalAlignment.Center
                Box_Status2.Text = "...:::Auth Failed 0x3:::..."
                Timer_Login.Stop()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Buton_Start_Click(sender As Object, e As EventArgs) Handles Buton_Start.Click
        Try
            DLLDirectory = My.Computer.FileSystem.GetFileInfo(My.Application.Info.DirectoryPath + "\xl.dll")
            ToirDirectory = My.Computer.FileSystem.GetFileInfo(My.Application.Info.DirectoryPath + "\nyscrpt.exe")
            Buton_Start.Enabled = False
            Buton_Start.Text = "Start..."

            Box_Status1.SelectAll()
            Box_Status1.SelectionAlignment = HorizontalAlignment.Center
            Box_Status2.Text = "...:::Auth Waiting:::..."

            If System.IO.File.Exists(ToirDirectory.Length) = True Then
                If Text_Status.Text = "1" Then
                    '//////////////////////////////////////////////////////////////////
                    'No queries. Enter ToirPlus directly.
                    Dim TOIRSTART As New ProcessStartInfo(ToirDirectory.Length)
                    TOIRSTART.WindowStyle = ProcessWindowStyle.Minimized
                    Process.Start(TOIRSTART)

                    Sleep(1500)
                    Inject_Toir_Login()
                    Text_Licence.Enabled = False
                    Tools.Text_DLL.Text = DLLDirectory.Length
                    '//////////////////////////////////////////////////////////////////
                Else
                    'There is a query. If the key is valid, enter toirplus.
                    Licence_Control()
                End If
            Else
                Me.Hide()
                MsgBox("Nyrex script could not be finded.", MsgBoxStyle.Critical, "")
                Application.Exit()
            End If
            '//////////////////////////////////////////////////////////////////
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Login_Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            If System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\drivers\etc\hosts") = True Then
                System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\drivers\etc\hosts")
            End If

            Application.Exit()
        Catch ex As Exception

        End Try
    End Sub
End Class
