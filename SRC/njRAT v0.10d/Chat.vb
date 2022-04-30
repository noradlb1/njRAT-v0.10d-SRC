Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200000C RID: 12
	<DesignerGenerated()>
	Public Partial Class Chat
		Inherits Form

		' Token: 0x0600017B RID: 379 RVA: 0x0000F064 File Offset: 0x0000D264
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Chat.__ENCList
			SyncLock _ENCList
				If Chat.__ENCList.Count = Chat.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Chat.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Chat.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Chat.__ENCList(num) = Chat.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Chat.__ENCList.RemoveRange(num, Chat.__ENCList.Count - num)
					Chat.__ENCList.Capacity = Chat.__ENCList.Count
				End If
				Chat.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000091 RID: 145
		' (get) Token: 0x0600017E RID: 382 RVA: 0x0000FF98 File Offset: 0x0000E198
		' (set) Token: 0x0600017F RID: 383 RVA: 0x0000FFB0 File Offset: 0x0000E1B0
		Friend Overridable Property vmethod_8 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				If Me._vmethod_8 IsNot Nothing Then
					RemoveHandler Me._vmethod_8.Tick, value2
				End If
				Me._vmethod_8 = value
				If Me._vmethod_8 IsNot Nothing Then
					AddHandler Me._vmethod_8.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000092 RID: 146
		' (get) Token: 0x06000180 RID: 384 RVA: 0x00010008 File Offset: 0x0000E208
		' (set) Token: 0x06000181 RID: 385 RVA: 0x00002532 File Offset: 0x00000732
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

		' Token: 0x17000093 RID: 147
		' (get) Token: 0x06000182 RID: 386 RVA: 0x00010020 File Offset: 0x0000E220
		' (set) Token: 0x06000183 RID: 387 RVA: 0x0000253B File Offset: 0x0000073B
		Friend Overridable Property Label4 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		' Token: 0x17000094 RID: 148
		' (get) Token: 0x06000184 RID: 388 RVA: 0x00010038 File Offset: 0x0000E238
		' (set) Token: 0x06000185 RID: 389 RVA: 0x00002544 File Offset: 0x00000744
		Friend Overridable Property Label3 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		' Token: 0x17000095 RID: 149
		' (get) Token: 0x06000186 RID: 390 RVA: 0x00010050 File Offset: 0x0000E250
		' (set) Token: 0x06000187 RID: 391 RVA: 0x0000254D File Offset: 0x0000074D
		Friend Overridable Property Label2 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		' Token: 0x17000096 RID: 150
		' (get) Token: 0x06000188 RID: 392 RVA: 0x00010068 File Offset: 0x0000E268
		' (set) Token: 0x06000189 RID: 393 RVA: 0x00002556 File Offset: 0x00000756
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

		' Token: 0x17000097 RID: 151
		' (get) Token: 0x0600018A RID: 394 RVA: 0x00010080 File Offset: 0x0000E280
		' (set) Token: 0x0600018B RID: 395 RVA: 0x0000255F File Offset: 0x0000075F
		Friend Overridable Property UserImage2 As UserImage
			<DebuggerNonUserCode()>
			Get
				Return Me._UserImage2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UserImage)
				Me._UserImage2 = value
			End Set
		End Property

		' Token: 0x17000098 RID: 152
		' (get) Token: 0x0600018C RID: 396 RVA: 0x00010098 File Offset: 0x0000E298
		' (set) Token: 0x0600018D RID: 397 RVA: 0x00002568 File Offset: 0x00000768
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

		' Token: 0x17000099 RID: 153
		' (get) Token: 0x0600018E RID: 398 RVA: 0x000100B0 File Offset: 0x0000E2B0
		' (set) Token: 0x0600018F RID: 399 RVA: 0x000100C8 File Offset: 0x0000E2C8
		Friend Overridable Property T2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.T2_KeyDown
				If Me._T2 IsNot Nothing Then
					RemoveHandler Me._T2.KeyDown, value2
				End If
				Me._T2 = value
				If Me._T2 IsNot Nothing Then
					AddHandler Me._T2.KeyDown, value2
				End If
			End Set
		End Property

		' Token: 0x1700009A RID: 154
		' (get) Token: 0x06000190 RID: 400 RVA: 0x00010120 File Offset: 0x0000E320
		' (set) Token: 0x06000191 RID: 401 RVA: 0x00010138 File Offset: 0x0000E338
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

		' Token: 0x1700009B RID: 155
		' (get) Token: 0x06000192 RID: 402 RVA: 0x00010190 File Offset: 0x0000E390
		' (set) Token: 0x06000193 RID: 403 RVA: 0x000101A8 File Offset: 0x0000E3A8
		Friend Overridable Property T1 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Dim value2 As LinkClickedEventHandler = AddressOf Me.T1_LinkClicked
				If Me._T1 IsNot Nothing Then
					RemoveHandler Me._T1.LinkClicked, value2
				End If
				Me._T1 = value
				If Me._T1 IsNot Nothing Then
					AddHandler Me._T1.LinkClicked, value2
				End If
			End Set
		End Property

		' Token: 0x1700009C RID: 156
		' (get) Token: 0x06000194 RID: 404 RVA: 0x00010200 File Offset: 0x0000E400
		' (set) Token: 0x06000195 RID: 405 RVA: 0x00002571 File Offset: 0x00000771
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

		' Token: 0x1700009D RID: 157
		' (get) Token: 0x06000196 RID: 406 RVA: 0x00010218 File Offset: 0x0000E418
		' (set) Token: 0x06000197 RID: 407 RVA: 0x0000257A File Offset: 0x0000077A
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

		' Token: 0x1700009E RID: 158
		' (get) Token: 0x06000198 RID: 408 RVA: 0x00010230 File Offset: 0x0000E430
		' (set) Token: 0x06000199 RID: 409 RVA: 0x00010248 File Offset: 0x0000E448
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

		' Token: 0x1700009F RID: 159
		' (get) Token: 0x0600019A RID: 410 RVA: 0x000102A0 File Offset: 0x0000E4A0
		' (set) Token: 0x0600019B RID: 411 RVA: 0x00002583 File Offset: 0x00000783
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

		' Token: 0x0600019C RID: 412 RVA: 0x000102B8 File Offset: 0x0000E4B8
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Chat_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Chat_Load
			Chat.__ENCAddToList(Me)
			Me.hk = "!~Hacker~!"
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600019D RID: 413 RVA: 0x00010308 File Offset: 0x0000E508
		Private Sub Chat_FormClosing(sender As Object, e As FormClosingEventArgs)
			If Me.sk.CN Then
				Me.sk.Send("@")
			End If
			Me.sk.CN = False
		End Sub

		' Token: 0x0600019E RID: 414 RVA: 0x00010340 File Offset: 0x0000E540
		Private Sub Chat_Load(sender As Object, e As EventArgs)
			Me.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)))
			Me.Show()
			Dim left As String = Interaction.InputBox("Enter Your NickName", "Chat", Me.hk, -1, -1)
			If Operators.CompareString(left, String.Empty, False) = 0 Then
				Me.sk.CN = False
			Else
				Me.hk = left
				Me.sk.Send("~" + Class7.string_1 + Class6.smethod_14(Me.hk))
			End If
			Me.vmethod_8.Enabled = True
			Me.T2.[Select]()
			Me.T2.Focus()
		End Sub

		' Token: 0x0600019F RID: 415 RVA: 0x000103FC File Offset: 0x0000E5FC
		Private Sub T2_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.[Return] Then
				e.SuppressKeyPress = True
				If Operators.CompareString(Me.T2.Text, String.Empty, False) = 0 Then
					Return
				End If
				SyncLock Me
					Me.T1.SelectionStart = Me.T1.TextLength
					Me.T1.SelectionFont = New Font(Me.T1.Font, FontStyle.Bold)
					Me.T1.AppendText("[" + Me.hk + "] ")
					Me.T1.SelectionFont = Me.T1.Font
					Me.T1.AppendText(Me.T2.Text + vbCrLf)
					Me.T1.SelectionStart = Me.T1.TextLength
					Me.T1.ScrollToCaret()
					Dim t As TextBox = Me.T2
					Dim text As String = t.Text
					t.Text = text
					Me.sk.Send("!" + Class7.string_1 + Class6.smethod_14(text))
					Me.T2.Text = String.Empty
					Return
				End SyncLock
			End If
			Me.T2.[Select]()
		End Sub

		' Token: 0x060001A0 RID: 416 RVA: 0x00010560 File Offset: 0x0000E760
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.T2.Text, String.Empty, False) <> 0 Then
				SyncLock Me
					Me.T1.SelectionStart = Me.T1.TextLength
					Me.T1.SelectionFont = New Font(Me.T1.Font, FontStyle.Bold)
					Me.T1.AppendText("[" + Me.hk + "] ")
					Me.T1.SelectionFont = Me.T1.Font
					Me.T1.AppendText(Me.T2.Text + vbCrLf)
					Me.T1.SelectionStart = Me.T1.TextLength
					Me.T1.ScrollToCaret()
					Dim t As TextBox = Me.T2
					Dim text As String = t.Text
					t.Text = text
					Me.sk.Send("!" + Class7.string_1 + Class6.smethod_14(text))
					Me.T2.Text = String.Empty
				End SyncLock
			End If
		End Sub

		' Token: 0x060001A1 RID: 417 RVA: 0x000106A4 File Offset: 0x0000E8A4
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			If Me.sk Is Nothing Or Me.osk Is Nothing Then
				If Me.T2.Enabled Or Operators.CompareString(Me.T1.Text, String.Empty, False) = 0 Then
					Me.T1.AppendText("Disconnected ...")
				End If
				Me.T2.Enabled = False
				Me.Button1.Enabled = False
				Me.sk.Send("@")
				Me.sk.CN = False
				Me.Close()
			ElseIf Not Me.sk.CN Or Not Me.osk.CN Then
				If Me.T2.Enabled Or Operators.CompareString(Me.T1.Text, String.Empty, False) = 0 Then
					Me.T1.AppendText("Disconnected ...")
				End If
				Me.T2.Enabled = False
				Me.Button1.Enabled = False
				Me.sk.Send("@")
				Me.sk.CN = False
				Me.Close()
			End If
		End Sub

		' Token: 0x060001A2 RID: 418 RVA: 0x000107D0 File Offset: 0x0000E9D0
		Private Sub T1_LinkClicked(sender As Object, e As LinkClickedEventArgs)
			Try
				Process.Start(e.LinkText)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub Button1_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060001A4 RID: 420 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x040000A5 RID: 165
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000A7 RID: 167
		<AccessedThroughProperty("vmethod_8")>
		Private _vmethod_8 As Timer

		' Token: 0x040000A8 RID: 168
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x040000A9 RID: 169
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x040000AA RID: 170
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x040000AB RID: 171
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x040000AC RID: 172
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040000AD RID: 173
		<AccessedThroughProperty("UserImage2")>
		Private _UserImage2 As UserImage

		' Token: 0x040000AE RID: 174
		<AccessedThroughProperty("UserImage1")>
		Private _UserImage1 As UserImage

		' Token: 0x040000AF RID: 175
		<AccessedThroughProperty("T2")>
		Private _T2 As TextBox

		' Token: 0x040000B0 RID: 176
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040000B1 RID: 177
		<AccessedThroughProperty("T1")>
		Private _T1 As RichTextBox

		' Token: 0x040000B2 RID: 178
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x040000B3 RID: 179
		<AccessedThroughProperty("FlatMini1")>
		Private _FlatMini1 As FlatMini

		' Token: 0x040000B4 RID: 180
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x040000B5 RID: 181
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x040000B6 RID: 182
		Public hk As String

		' Token: 0x040000B7 RID: 183
		Public osk As Client

		' Token: 0x040000B8 RID: 184
		Public sk As Client
	End Class
End Namespace
