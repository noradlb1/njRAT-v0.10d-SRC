Imports System
Imports System.Diagnostics

Namespace NJRAT
	' Token: 0x0200004F RID: 79
	Public NotInheritable Class GClass6
		' Token: 0x06000771 RID: 1905 RVA: 0x000020D7 File Offset: 0x000002D7
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x06000772 RID: 1906 RVA: 0x00042978 File Offset: 0x00040B78
		Public Function method_0(gclass6_0 As GClass6) As Double
			Dim num As Double = Me.double_0
			Dim num2 As Double = Me.double_1
			Dim num3 As Double = gclass6_0.double_0
			Dim num4 As Double = gclass6_0.double_1
			num *= GClass6.double_4
			num3 *= GClass6.double_4
			Dim num5 As Double = num3 - num
			Dim num6 As Double = (num4 - num2) * GClass6.double_4
			Dim num7 As Double = Math.Pow(Math.Sin(num5 / 2.0), 2.0) + Math.Cos(num) * Math.Cos(num3) * Math.Pow(Math.Sin(num6 / 2.0), 2.0)
			Return GClass6.double_2 * Math.Atan2(Math.Sqrt(num7), Math.Sqrt(1.0 - num7))
		End Function

		' Token: 0x040003F9 RID: 1017
		Public double_0 As Double

		' Token: 0x040003FA RID: 1018
		Public double_1 As Double

		' Token: 0x040003FB RID: 1019
		Private Shared double_2 As Double = 12756.4

		' Token: 0x040003FC RID: 1020
		Private Shared double_3 As Double = 3.14159265

		' Token: 0x040003FD RID: 1021
		Private Shared double_4 As Double = GClass6.double_3 / 180.0

		' Token: 0x040003FE RID: 1022
		Public int_0 As Integer

		' Token: 0x040003FF RID: 1023
		Public int_1 As Integer

		' Token: 0x04000400 RID: 1024
		Public int_2 As Integer

		' Token: 0x04000401 RID: 1025
		Public string_0 As String

		' Token: 0x04000402 RID: 1026
		Public string_1 As String

		' Token: 0x04000403 RID: 1027
		Public string_2 As String

		' Token: 0x04000404 RID: 1028
		Public string_3 As String

		' Token: 0x04000405 RID: 1029
		Public string_4 As String

		' Token: 0x04000406 RID: 1030
		Public string_5 As String
	End Class
End Namespace
