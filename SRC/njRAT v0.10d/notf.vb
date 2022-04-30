Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My

Namespace NJRAT
	' Token: 0x02000019 RID: 25
	<DesignerGenerated()>
	Public Partial Class notf
		Inherits Form

		' Token: 0x06000423 RID: 1059 RVA: 0x00026A08 File Offset: 0x00024C08
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = notf.__ENCList
			SyncLock _ENCList
				If notf.__ENCList.Count = notf.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = notf.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = notf.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								notf.__ENCList(num) = notf.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					notf.__ENCList.RemoveRange(num, notf.__ENCList.Count - num)
					notf.__ENCList.Capacity = notf.__ENCList.Count
				End If
				notf.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000184 RID: 388
		' (get) Token: 0x06000426 RID: 1062 RVA: 0x00026E18 File Offset: 0x00025018
		' (set) Token: 0x06000427 RID: 1063 RVA: 0x00002C5D File Offset: 0x00000E5D
		Friend Overridable Property FormSkin1 As FormSkin
			<DebuggerNonUserCode()>
			Get
				Return Me._FormSkin1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FormSkin)
				Me._FormSkin1 = value
			End Set
		End Property

		' Token: 0x17000185 RID: 389
		' (get) Token: 0x06000428 RID: 1064 RVA: 0x00026E30 File Offset: 0x00025030
		' (set) Token: 0x06000429 RID: 1065 RVA: 0x00026E48 File Offset: 0x00025048
		Friend Overridable Property p As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._p
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As EventHandler = AddressOf Me.p_Click_1
				If Me._p IsNot Nothing Then
					RemoveHandler Me._p.Click, value2
				End If
				Me._p = value
				If Me._p IsNot Nothing Then
					AddHandler Me._p.Click, value2
				End If
			End Set
		End Property

		' Token: 0x0600042A RID: 1066 RVA: 0x00026EA0 File Offset: 0x000250A0
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.notf_Load
			notf.__ENCAddToList(Me)
			AddHandler MyBase.Load, AddressOf Me.notf_Load
			Me.bool_0 = True
			Me.Items = New List(Of notf.GClass15)()
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600042B RID: 1067 RVA: 0x00026EF8 File Offset: 0x000250F8
		Public Sub AddItem(img As Bitmap, Text As String)
			Dim items As List(Of notf.GClass15) = Me.Items
			Dim obj As List(Of notf.GClass15) = items
			SyncLock obj
				If Me.Items.Count > 50 Then
					Me.Items.RemoveAt(0)
				End If
				Dim item As notf.GClass15 = New notf.GClass15() With { .bitmap_0 = CType(img.Clone(), Bitmap), .string_0 = Text }
				Me.Items.Add(item)
			End SyncLock
		End Sub

		' Token: 0x0600042C RID: 1068 RVA: 0x00026F78 File Offset: 0x00025178
		Public Sub back()
			Me.bool_0 = True
			Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
			Me.Left = workingArea.Width - Me.Width - 5
			Me.Top = workingArea.Height - Me.Height - 5
		End Sub

		' Token: 0x0600042D RID: 1069 RVA: 0x00026FC4 File Offset: 0x000251C4
		Public Sub go()
			Me.bool_0 = False
			Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
			Me.Left = workingArea.Width
			Me.Top = workingArea.Height
		End Sub

		' Token: 0x0600042E RID: 1070 RVA: 0x00027000 File Offset: 0x00025200
		Private Sub p_Click(sender As Object, e As EventArgs)
			Dim items As List(Of notf.GClass15) = Me.Items
			Dim obj As List(Of notf.GClass15) = items
			SyncLock obj
				Me.Items.Clear()
			End SyncLock
		End Sub

		' Token: 0x0600042F RID: 1071 RVA: 0x00027040 File Offset: 0x00025240
		Private Sub notf_Load(sender As Object, e As EventArgs)
			Me.p.BackColor = Color.Pink
			Me.TransparencyKey = Color.Pink
			Me.back()
			Control.CheckForIllegalCrossThreadCalls = False
			Dim thread As Thread = AddressOf Me.wrk
			thread.Start()
		End Sub

		' Token: 0x06000430 RID: 1072 RVA: 0x00027090 File Offset: 0x00025290
		Public Sub wrk()
			While True
				Thread.Sleep(50)
				If Me.Items.Count <> 0 Then
					Try
						Dim bitmap As Bitmap = New Bitmap(Me.p.Width, Me.p.Height)
						Dim graphics As Graphics = Graphics.FromImage(bitmap)
						graphics.Clear(Me.p.BackColor)
						Dim items As List(Of notf.GClass15) = Me.Items
						Dim obj As List(Of notf.GClass15) = items
						SyncLock obj
							Try
								For Each gclass As notf.GClass15 In Me.Items
									If gclass.int_0 <= 2 Then
										gclass.int_0 = 2
										Dim gclass2 As notf.GClass15 = gclass
										Dim gclass3 As notf.GClass15 = gclass2
										gclass3.int_1 += 1
									Else
										Dim count As Integer = Me.Items.Count
										If count > 30 Then
											gclass.int_0 = 2
										ElseIf count > 20 Then
											Dim gclass2 As notf.GClass15 = gclass
											gclass2.int_0 += -20
										ElseIf count > 10 Then
											Dim gclass2 As notf.GClass15 = gclass
											gclass2.int_0 += -10
										Else
											Dim gclass2 As notf.GClass15 = gclass
											gclass2.int_0 += -2
										End If
										If gclass.int_0 < 2 Then
											gclass.int_0 = 2
										End If
									End If
									Dim size As Size = TextRenderer.MeasureText(gclass.string_0, Me.Font)
									size.Width = bitmap.Width
									size.Height += 5
									Dim rectangle As Rectangle = New Rectangle(0, gclass.int_0 - 2, Me.Width, size.Height)
									graphics.FillRectangle(Brushes.DarkSlateBlue, rectangle)
									rectangle = New Rectangle(0, gclass.int_0 - 2, Me.Width, size.Height)
									ControlPaint.DrawLockedFrame(graphics, rectangle, False)
									Dim array As Object() = New Object(1) {}
									array(0) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(gclass.bitmap_0.Clone())))
									Dim point As Point = New Point(5, gclass.int_0 - 2)
									array(1) = point
									NewLateBinding.LateCall(graphics, Nothing, "DrawImage", array, Nothing, Nothing, Nothing, True)
									graphics.DrawString(gclass.string_0, Me.Font, Brushes.Teal, 5F, CSng(gclass.int_0))
									If gclass.int_0 > Me.Height - 50 Then
										Exit For
									End If
								Next
							Finally
								Dim enumerator As List(Of notf.GClass15).Enumerator
								CType(enumerator, IDisposable).Dispose()
							End Try
							Try
								IL_23E:
								For Each gclass4 As notf.GClass15 In Me.Items
									If gclass4.int_1 = 40 Then
										Me.Items.Remove(gclass4)
										GoTo IL_28C
									End If
								Next
								GoTo IL_28F
							Finally
								Dim enumerator2 As List(Of notf.GClass15).Enumerator
								CType(enumerator2, IDisposable).Dispose()
							End Try
							GoTo IL_28C
							IL_28F:
							If Me.Items.Count = 0 And Me.bool_0 Then
								Me.go()
							End If
							If Me.Items.Count > 0 And Not Me.bool_0 Then
								Me.back()
							End If
							GoTo IL_2D6
							IL_28C:
							GoTo IL_23E
						End SyncLock
						IL_2D6:
						graphics.Flush(FlushIntention.Sync)
						graphics.Dispose()
						Me.p.Image = bitmap
						Continue For
					Catch ex As Exception
						Continue For
					End Try
				End If
				Me.go()
			End While
		End Sub

		' Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub p_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x040001E6 RID: 486
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001E8 RID: 488
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x040001E9 RID: 489
		<AccessedThroughProperty("p")>
		Private _p As PictureBox

		' Token: 0x040001EA RID: 490
		Private bool_0 As Boolean

		' Token: 0x040001EB RID: 491
		Public Items As List(Of notf.GClass15)

		' Token: 0x0200001A RID: 26
		Public NotInheritable Class GClass15
			' Token: 0x06000432 RID: 1074 RVA: 0x00002C66 File Offset: 0x00000E66
			Public Sub New()
				Me.int_0 = MyProject.Forms.notf.Height
				Me.int_1 = 0
			End Sub

			' Token: 0x040001EC RID: 492
			Public bitmap_0 As Bitmap

			' Token: 0x040001ED RID: 493
			Public int_0 As Integer

			' Token: 0x040001EE RID: 494
			Public int_1 As Integer

			' Token: 0x040001EF RID: 495
			Public string_0 As String
		End Class
	End Class
End Namespace
