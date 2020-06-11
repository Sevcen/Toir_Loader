Module Module_Inject
    Private TargetProcessHandle As Integer
    Private pfnStartAddr As Integer
    Private pszLibFileRemote As String
    Private TargetBufferSize As Integer
    Public Const PROCESS_VM_READ = &H10
    Public Const TH32CS_SNAPPROCESS = &H2
    Public Const MEM_COMMIT = 4096
    Public Const PAGE_READWRITE = 4
    Public Const PROCESS_CREATE_THREAD = (&H2)
    Public Const PROCESS_VM_OPERATION = (&H8)
    Public Const PROCESS_VM_WRITE = (&H20)
    Public Declare Function ReadProcessMemory Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpBaseAddress As Integer,
    ByVal lpBuffer As String,
    ByVal nSize As Integer,
    ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function LoadLibrary Lib "kernel32" Alias "LoadLibraryA" (
    ByVal lpLibFileName As String) As Integer
    Public Declare Function VirtualAllocEx Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpAddress As Integer,
    ByVal dwSize As Integer,
    ByVal flAllocationType As Integer,
    ByVal flProtect As Integer) As Integer
    Public Declare Function WriteProcessMemory Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpBaseAddress As Integer,
    ByVal lpBuffer As String,
    ByVal nSize As Integer,
    ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function GetProcAddress Lib "kernel32" (
    ByVal hModule As Integer, ByVal lpProcName As String) As Integer
    Private Declare Function GetModuleHandle Lib "Kernel32" Alias "GetModuleHandleA" (
    ByVal lpModuleName As String) As Integer
    Public Declare Function CreateRemoteThread Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpThreadAttributes As Integer,
    ByVal dwStackSize As Integer,
    ByVal lpStartAddress As Integer,
    ByVal lpParameter As Integer,
    ByVal dwCreationFlags As Integer,
    ByRef lpThreadId As IntPtr) As Integer
    Public Declare Function OpenProcess Lib "kernel32" (
    ByVal dwDesiredAccess As Integer,
    ByVal bInheritHandle As Integer,
    ByVal dwProcessId As Integer) As Integer
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (
    ByVal lpClassName As String,
    ByVal lpWindowName As String) As Integer
    Private Declare Function CloseHandle Lib "kernel32" Alias "CloseHandleA" (
    ByVal hObject As Integer) As Integer

    Friend WithEvents Timer_Inject As New Timer
    Dim ExeName As String = Tools.Text_DLL.Text

    Public Sub Inject_Toir_Login()
        Dim TargetProcess As Process() = Process.GetProcessesByName("nyscrpt")
        Dim lpThreadId As IntPtr
        Try
            If System.Environment.Is64BitOperatingSystem Then
                TargetProcessHandle = OpenProcess(&H1F0FFF, 0, TargetProcess(0).Id)
            Else
                TargetProcessHandle = OpenProcess(PROCESS_CREATE_THREAD Or PROCESS_VM_OPERATION Or PROCESS_VM_WRITE, False, TargetProcess(0).Id)
            End If
            pszLibFileRemote = ExeName
            pfnStartAddr = GetProcAddress(GetModuleHandle("Kernel32"), "LoadLibraryA")
            TargetBufferSize = 1 + Len(pszLibFileRemote)
            Dim Rtn As Integer
            Dim LoadLibParamAdr As Integer
            LoadLibParamAdr = VirtualAllocEx(TargetProcessHandle, 0, TargetBufferSize, MEM_COMMIT, PAGE_READWRITE)
            Rtn = WriteProcessMemory(TargetProcessHandle, LoadLibParamAdr, pszLibFileRemote, TargetBufferSize, 0)
            CreateRemoteThread(TargetProcessHandle, 0, 0, pfnStartAddr, LoadLibParamAdr, 0, lpThreadId)
            If lpThreadId = IntPtr.Zero Then
                Login_Form1.Box_Status1.SelectAll()
                Login_Form1.Box_Status1.SelectionAlignment = HorizontalAlignment.Center
                Login_Form1.Box_Status2.Text = "...:::Auth Failed 0x2:::..."
            Else
                'INJECT OK
                Login_Form1.Box_Status1.SelectAll()
                Login_Form1.Box_Status1.SelectionAlignment = HorizontalAlignment.Center
                Login_Form1.Box_Status2.Text = "...:::Auth Succesfull:::..."
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Timer_Injects()
        Try
            Dim Target As Process() = Process.GetProcessesByName("nyscrpt")
            If Target.Length <> 0 Then
                Threading.Thread.Sleep(500)
                Inject_Toir_Login()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Module
