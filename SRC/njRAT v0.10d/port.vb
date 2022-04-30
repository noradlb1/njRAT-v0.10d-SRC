Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My.Resources

Namespace NJRAT
	' Token: 0x0200001C RID: 28
	<DesignerGenerated()>
	Public Partial Class port
		Inherits Form

		' Token: 0x0600047E RID: 1150 RVA: 0x000297F8 File Offset: 0x000279F8
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = NJRAT.port.__ENCList
			SyncLock _ENCList
				If NJRAT.port.__ENCList.Count = NJRAT.port.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = NJRAT.port.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = NJRAT.port.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								NJRAT.port.__ENCList(num) = NJRAT.port.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					NJRAT.port.__ENCList.RemoveRange(num, NJRAT.port.__ENCList.Count - num)
					NJRAT.port.__ENCList.Capacity = NJRAT.port.__ENCList.Count
				End If
				NJRAT.port.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170001A1 RID: 417
		' (get) Token: 0x06000481 RID: 1153 RVA: 0x0002A8B0 File Offset: 0x00028AB0
		' (set) Token: 0x06000482 RID: 1154 RVA: 0x00002D61 File Offset: 0x00000F61
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

		' Token: 0x170001A2 RID: 418
		' (get) Token: 0x06000483 RID: 1155 RVA: 0x0002A8C8 File Offset: 0x00028AC8
		' (set) Token: 0x06000484 RID: 1156 RVA: 0x00002D6A File Offset: 0x00000F6A
		Friend Overridable Property FlatGroupBox1 As FlatGroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatGroupBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatGroupBox)
				Me._FlatGroupBox1 = value
			End Set
		End Property

		' Token: 0x170001A3 RID: 419
		' (get) Token: 0x06000485 RID: 1157 RVA: 0x0002A8E0 File Offset: 0x00028AE0
		' (set) Token: 0x06000486 RID: 1158 RVA: 0x00002D73 File Offset: 0x00000F73
		Friend Overridable Property PictureBox3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox3 = value
			End Set
		End Property

		' Token: 0x170001A4 RID: 420
		' (get) Token: 0x06000487 RID: 1159 RVA: 0x0002A8F8 File Offset: 0x00028AF8
		' (set) Token: 0x06000488 RID: 1160 RVA: 0x00002D7C File Offset: 0x00000F7C
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox1 = value
			End Set
		End Property

		' Token: 0x170001A5 RID: 421
		' (get) Token: 0x06000489 RID: 1161 RVA: 0x0002A910 File Offset: 0x00028B10
		' (set) Token: 0x0600048A RID: 1162 RVA: 0x00002D85 File Offset: 0x00000F85
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

		' Token: 0x170001A6 RID: 422
		' (get) Token: 0x0600048B RID: 1163 RVA: 0x0002A928 File Offset: 0x00028B28
		' (set) Token: 0x0600048C RID: 1164 RVA: 0x0002A940 File Offset: 0x00028B40
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button2_Click_1
				If Me._Button2 IsNot Nothing Then
					RemoveHandler Me._Button2.Click, value2
				End If
				Me._Button2 = value
				If Me._Button2 IsNot Nothing Then
					AddHandler Me._Button2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001A7 RID: 423
		' (get) Token: 0x0600048D RID: 1165 RVA: 0x0002A998 File Offset: 0x00028B98
		' (set) Token: 0x0600048E RID: 1166 RVA: 0x00002D8E File Offset: 0x00000F8E
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

		' Token: 0x170001A8 RID: 424
		' (get) Token: 0x0600048F RID: 1167 RVA: 0x0002A9B0 File Offset: 0x00028BB0
		' (set) Token: 0x06000490 RID: 1168 RVA: 0x0002A9C8 File Offset: 0x00028BC8
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

		' Token: 0x170001A9 RID: 425
		' (get) Token: 0x06000491 RID: 1169 RVA: 0x0002AA20 File Offset: 0x00028C20
		' (set) Token: 0x06000492 RID: 1170 RVA: 0x00002D97 File Offset: 0x00000F97
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

		' Token: 0x170001AA RID: 426
		' (get) Token: 0x06000493 RID: 1171 RVA: 0x0002AA38 File Offset: 0x00028C38
		' (set) Token: 0x06000494 RID: 1172 RVA: 0x00002DA0 File Offset: 0x00000FA0
		Friend Overridable Property TextBox3 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox3 = value
			End Set
		End Property

		' Token: 0x170001AB RID: 427
		' (get) Token: 0x06000495 RID: 1173 RVA: 0x0002AA50 File Offset: 0x00028C50
		' (set) Token: 0x06000496 RID: 1174 RVA: 0x00002DA9 File Offset: 0x00000FA9
		Friend Overridable Property TextBox2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox2 = value
			End Set
		End Property

		' Token: 0x170001AC RID: 428
		' (get) Token: 0x06000497 RID: 1175 RVA: 0x0002AA68 File Offset: 0x00028C68
		' (set) Token: 0x06000498 RID: 1176 RVA: 0x00002DB2 File Offset: 0x00000FB2
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

		' Token: 0x170001AD RID: 429
		' (get) Token: 0x06000499 RID: 1177 RVA: 0x0002AA80 File Offset: 0x00028C80
		' (set) Token: 0x0600049A RID: 1178 RVA: 0x00002DBB File Offset: 0x00000FBB
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

		' Token: 0x170001AE RID: 430
		' (get) Token: 0x0600049B RID: 1179 RVA: 0x0002AA98 File Offset: 0x00028C98
		' (set) Token: 0x0600049C RID: 1180 RVA: 0x00002DC4 File Offset: 0x00000FC4
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

		' Token: 0x170001AF RID: 431
		' (get) Token: 0x0600049D RID: 1181 RVA: 0x0002AAB0 File Offset: 0x00028CB0
		' (set) Token: 0x0600049E RID: 1182 RVA: 0x00002DCD File Offset: 0x00000FCD
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

		' Token: 0x170001B0 RID: 432
		' (get) Token: 0x0600049F RID: 1183 RVA: 0x0002AAC8 File Offset: 0x00028CC8
		' (set) Token: 0x060004A0 RID: 1184 RVA: 0x00002DD6 File Offset: 0x00000FD6
		Friend Overridable Property PictureBox4 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox4 = value
			End Set
		End Property

		' Token: 0x060004A1 RID: 1185 RVA: 0x0002AAE0 File Offset: 0x00028CE0
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.port_Load
			AddHandler MyBase.Activated, AddressOf Me.port_Activated
			AddHandler MyBase.KeyDown, AddressOf Me.port_KeyDown
			NJRAT.port.__ENCAddToList(Me)
			Me.port = -1
			Me.InitializeComponent()
		End Sub

		' Token: 0x060004A2 RID: 1186 RVA: 0x00002DDF File Offset: 0x00000FDF
		Private Sub port_Activated(sender As Object, e As EventArgs)
			Me.TextBox1.Focus()
		End Sub

		' Token: 0x060004A3 RID: 1187 RVA: 0x0002AB40 File Offset: 0x00028D40
		Private Sub port_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.[Return] Then
				e.SuppressKeyPress = True
				If Me.Button1.Enabled Then
					Me.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), New EventArgs())
				End If
			ElseIf e.KeyCode = Keys.Escape Then
				Me.port = -1
				Me.Close()
			End If
		End Sub

		' Token: 0x060004A4 RID: 1188 RVA: 0x00002DED File Offset: 0x00000FED
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.port = Conversions.ToInteger(Me.TextBox1.Text)
			Me.Close()
		End Sub

		' Token: 0x060004A5 RID: 1189 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub Button2_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060004A6 RID: 1190 RVA: 0x00002E0B File Offset: 0x0000100B
		Private Sub port_Load(sender As Object, e As EventArgs)
			Me.Icon = Resources.icon
		End Sub

		' Token: 0x060004A7 RID: 1191 RVA: 0x0002ABA4 File Offset: 0x00028DA4
		Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
			Try
				Conversions.ToInteger(Me.TextBox1.Text)
				If Conversions.ToInteger(Me.TextBox1.Text) > 65534 Or Conversions.ToInteger(Me.TextBox1.Text) < 1 Then
					Me.Button1.Enabled = False
				Else
					Me.Button1.Enabled = True
				End If
			Catch ex As Exception
				Me.Button1.Enabled = False
			End Try
		End Sub

		' Token: 0x060004A8 RID: 1192 RVA: 0x00002DED File Offset: 0x00000FED
		Private Sub Button1_Click_1(sender As Object, e As EventArgs)
			Me.port = Conversions.ToInteger(Me.TextBox1.Text)
			Me.Close()
		End Sub

		' Token: 0x060004A9 RID: 1193 RVA: 0x00002E18 File Offset: 0x00001018
		Private Sub Button2_Click_1(sender As Object, e As EventArgs)
			Me.port = -1
			Me.Close()
		End Sub

		' Token: 0x0400020E RID: 526
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000210 RID: 528
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x04000211 RID: 529
		<AccessedThroughProperty("FlatGroupBox1")>
		Private _FlatGroupBox1 As FlatGroupBox

		' Token: 0x04000212 RID: 530
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x04000213 RID: 531
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000214 RID: 532
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000215 RID: 533
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000216 RID: 534
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000217 RID: 535
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000218 RID: 536
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000219 RID: 537
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x0400021A RID: 538
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x0400021B RID: 539
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x0400021C RID: 540
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x0400021D RID: 541
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x0400021E RID: 542
		<AccessedThroughProperty("UserImage1")>
		Private _UserImage1 As UserImage

		' Token: 0x0400021F RID: 543
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x04000220 RID: 544
		Public port As Integer
	End Class
End Namespace
