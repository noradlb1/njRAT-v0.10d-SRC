Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200004E RID: 78
	Public NotInheritable Class GClass5
		' Token: 0x0600076B RID: 1899 RVA: 0x00003C0A File Offset: 0x00001E0A
		Public Sub New(string_1 As String)
			Me.string_0 = string_1
		End Sub

		' Token: 0x0600076C RID: 1900 RVA: 0x00042850 File Offset: 0x00040A50
		Public Function method_0() As Integer
			Dim result As Integer
			If Me.string_0 = Nothing Or Operators.CompareString(Me.string_0, String.Empty, False) = 0 Then
				result = GClass5.int_0
			Else
				result = Convert.ToInt32(Me.string_0.Substring(4, 3)) - 105
			End If
			Return result
		End Function

		' Token: 0x0600076D RID: 1901 RVA: 0x0004289C File Offset: 0x00040A9C
		Public Function method_1() As Boolean
			Return Me.string_0.IndexOf("FREE") < 0
		End Function

		' Token: 0x0600076E RID: 1902 RVA: 0x000428BC File Offset: 0x00040ABC
		Public Function method_2() As DateTime
			Dim num As Integer = Me.string_0.Length - 10
			For i As Integer = 0 To num
				If Char.IsWhiteSpace(Me.string_0(i)) Then
					Dim s As String = Me.string_0.Substring(i + 1, 8)
					Try
						Return DateTime.ParseExact(s, "yyyyMMdd", Nothing)
					Catch ex As Exception
						Dim ex2 As Exception = ex
						Console.Write(ex2.Message)
					End Try
					IL_7F:
					Return DateTime.Now
				End If
			Next
			GoTo IL_7F
		End Function

		' Token: 0x0600076F RID: 1903 RVA: 0x00042960 File Offset: 0x00040B60
		Public Function method_3() As String
			Return Me.string_0
		End Function

		' Token: 0x040003E4 RID: 996
		Public Shared int_0 As Integer = 1

		' Token: 0x040003E5 RID: 997
		Public Shared int_1 As Integer = 7

		' Token: 0x040003E6 RID: 998
		Public Shared int_10 As Integer = 11

		' Token: 0x040003E7 RID: 999
		Public Shared int_11 As Integer = 12

		' Token: 0x040003E8 RID: 1000
		Public Shared int_12 As Integer = 21

		' Token: 0x040003E9 RID: 1001
		Public Shared int_13 As Integer = 22

		' Token: 0x040003EA RID: 1002
		Public Shared int_14 As Integer = 23

		' Token: 0x040003EB RID: 1003
		Public Shared int_15 As Integer = 24

		' Token: 0x040003EC RID: 1004
		Public Shared int_16 As Integer = 30

		' Token: 0x040003ED RID: 1005
		Public Shared int_17 As Integer = 31

		' Token: 0x040003EE RID: 1006
		Public Shared int_18 As Integer = 32

		' Token: 0x040003EF RID: 1007
		Public Shared int_19 As Integer = 33

		' Token: 0x040003F0 RID: 1008
		Public Shared int_2 As Integer = 3

		' Token: 0x040003F1 RID: 1009
		Public Shared int_3 As Integer = 6

		' Token: 0x040003F2 RID: 1010
		Public Shared int_4 As Integer = 2

		' Token: 0x040003F3 RID: 1011
		Public Shared int_5 As Integer = 5

		' Token: 0x040003F4 RID: 1012
		Public Shared int_6 As Integer = 4

		' Token: 0x040003F5 RID: 1013
		Public Shared int_7 As Integer = 8

		' Token: 0x040003F6 RID: 1014
		Public Shared int_8 As Integer = 9

		' Token: 0x040003F7 RID: 1015
		Public Shared int_9 As Integer = 10

		' Token: 0x040003F8 RID: 1016
		Private string_0 As String
	End Class
End Namespace
