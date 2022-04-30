Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My.Resources

Namespace NJRAT
	' Token: 0x02000017 RID: 23
	<DesignerGenerated()>
	Public Partial Class Mynoip
		Inherits Form

		' Token: 0x060003E2 RID: 994 RVA: 0x00002B4E File Offset: 0x00000D4E
		Public Sub New()
			Mynoip.__ENCAddToList(Me)
			Me.wc = New WebClient()
			Me.utf8 = New UTF8Encoding()
			Me.InitializeComponent()
		End Sub

		' Token: 0x060003E3 RID: 995 RVA: 0x00024790 File Offset: 0x00022990
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Mynoip.__ENCList
			SyncLock _ENCList
				If Mynoip.__ENCList.Count = Mynoip.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Mynoip.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Mynoip.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Mynoip.__ENCList(num) = Mynoip.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Mynoip.__ENCList.RemoveRange(num, Mynoip.__ENCList.Count - num)
					Mynoip.__ENCList.Capacity = Mynoip.__ENCList.Count
				End If
				Mynoip.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700016C RID: 364
		' (get) Token: 0x060003E6 RID: 998 RVA: 0x00025904 File Offset: 0x00023B04
		' (set) Token: 0x060003E7 RID: 999 RVA: 0x00002B78 File Offset: 0x00000D78
		Friend Overridable Property RichTextBox1 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._RichTextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._RichTextBox1 = value
			End Set
		End Property

		' Token: 0x1700016D RID: 365
		' (get) Token: 0x060003E8 RID: 1000 RVA: 0x0002591C File Offset: 0x00023B1C
		' (set) Token: 0x060003E9 RID: 1001 RVA: 0x00002B81 File Offset: 0x00000D81
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

		' Token: 0x1700016E RID: 366
		' (get) Token: 0x060003EA RID: 1002 RVA: 0x00025934 File Offset: 0x00023B34
		' (set) Token: 0x060003EB RID: 1003 RVA: 0x00002B8A File Offset: 0x00000D8A
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

		' Token: 0x1700016F RID: 367
		' (get) Token: 0x060003EC RID: 1004 RVA: 0x0002594C File Offset: 0x00023B4C
		' (set) Token: 0x060003ED RID: 1005 RVA: 0x00002B93 File Offset: 0x00000D93
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

		' Token: 0x17000170 RID: 368
		' (get) Token: 0x060003EE RID: 1006 RVA: 0x00025964 File Offset: 0x00023B64
		' (set) Token: 0x060003EF RID: 1007 RVA: 0x00002B9C File Offset: 0x00000D9C
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

		' Token: 0x17000171 RID: 369
		' (get) Token: 0x060003F0 RID: 1008 RVA: 0x0002597C File Offset: 0x00023B7C
		' (set) Token: 0x060003F1 RID: 1009 RVA: 0x00002BA5 File Offset: 0x00000DA5
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

		' Token: 0x17000172 RID: 370
		' (get) Token: 0x060003F2 RID: 1010 RVA: 0x00025994 File Offset: 0x00023B94
		' (set) Token: 0x060003F3 RID: 1011 RVA: 0x000259AC File Offset: 0x00023BAC
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

		' Token: 0x17000173 RID: 371
		' (get) Token: 0x060003F4 RID: 1012 RVA: 0x00025A04 File Offset: 0x00023C04
		' (set) Token: 0x060003F5 RID: 1013 RVA: 0x00002BAE File Offset: 0x00000DAE
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

		' Token: 0x17000174 RID: 372
		' (get) Token: 0x060003F6 RID: 1014 RVA: 0x00025A1C File Offset: 0x00023C1C
		' (set) Token: 0x060003F7 RID: 1015 RVA: 0x00002BB7 File Offset: 0x00000DB7
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

		' Token: 0x17000175 RID: 373
		' (get) Token: 0x060003F8 RID: 1016 RVA: 0x00025A34 File Offset: 0x00023C34
		' (set) Token: 0x060003F9 RID: 1017 RVA: 0x00002BC0 File Offset: 0x00000DC0
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

		' Token: 0x17000176 RID: 374
		' (get) Token: 0x060003FA RID: 1018 RVA: 0x00025A4C File Offset: 0x00023C4C
		' (set) Token: 0x060003FB RID: 1019 RVA: 0x00002BC9 File Offset: 0x00000DC9
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

		' Token: 0x17000177 RID: 375
		' (get) Token: 0x060003FC RID: 1020 RVA: 0x00025A64 File Offset: 0x00023C64
		' (set) Token: 0x060003FD RID: 1021 RVA: 0x00002BD2 File Offset: 0x00000DD2
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

		' Token: 0x17000178 RID: 376
		' (get) Token: 0x060003FE RID: 1022 RVA: 0x00025A7C File Offset: 0x00023C7C
		' (set) Token: 0x060003FF RID: 1023 RVA: 0x00002BDB File Offset: 0x00000DDB
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

		' Token: 0x17000179 RID: 377
		' (get) Token: 0x06000400 RID: 1024 RVA: 0x00025A94 File Offset: 0x00023C94
		' (set) Token: 0x06000401 RID: 1025 RVA: 0x00002BE4 File Offset: 0x00000DE4
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

		' Token: 0x1700017A RID: 378
		' (get) Token: 0x06000402 RID: 1026 RVA: 0x00025AAC File Offset: 0x00023CAC
		' (set) Token: 0x06000403 RID: 1027 RVA: 0x00025AC4 File Offset: 0x00023CC4
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

		' Token: 0x1700017B RID: 379
		' (get) Token: 0x06000404 RID: 1028 RVA: 0x00025B1C File Offset: 0x00023D1C
		' (set) Token: 0x06000405 RID: 1029 RVA: 0x00002BED File Offset: 0x00000DED
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

		' Token: 0x1700017C RID: 380
		' (get) Token: 0x06000406 RID: 1030 RVA: 0x00025B34 File Offset: 0x00023D34
		' (set) Token: 0x06000407 RID: 1031 RVA: 0x00002BF6 File Offset: 0x00000DF6
		Friend Overridable Property FlatMini2 As FlatMini
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatMini2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatMini)
				Me._FlatMini2 = value
			End Set
		End Property

		' Token: 0x06000408 RID: 1032 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000409 RID: 1033 RVA: 0x00025B4C File Offset: 0x00023D4C
		Private Sub Button1_Click_1(sender As Object, e As EventArgs)
			Try
				Dim instance As Object = Me.utf8
				Dim type As Type = Nothing
				Dim memberName As String = "GetString"
				Dim array As Object() = New Object(0) {}
				Dim array2 As Object() = array
				Dim num As Integer = 0
				Dim obj As Object = Me.wc
				Dim instance2 As Object = obj
				Dim type2 As Type = Nothing
				Dim memberName2 As String = "DownloadData"
				Dim array3 As Object() = New Object(0) {}
				Dim array4 As Object() = array3
				Dim num2 As Integer = 0
				Dim text As String = String.Concat(New String() { "http://dynupdate.no-ip.com/dns?username=", Me.TextBox1.Text, "&password=", Me.TextBox2.Text, "&hostname=", Me.TextBox3.Text })
				array4(num2) = text
				array2(num) = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance2, type2, memberName2, array3, Nothing, Nothing, Nothing))
				Dim array5 As Object() = array
				Dim arguments As Object() = array5
				Dim argumentNames As String() = Nothing
				Dim typeArguments As Type() = Nothing
				Dim array6 As Boolean() = New Boolean() { True }
				Dim value As Object = NewLateBinding.LateGet(instance, type, memberName, arguments, argumentNames, typeArguments, array6)
				If array6(0) Then
					NewLateBinding.LateSetComplex(obj, Nothing, "DownloadData", New Object() { text, RuntimeHelpers.GetObjectValue(array5(0)) }, Nothing, Nothing, True, False)
				End If
				Dim text2 As String = Conversions.ToString(value)
				Dim array7 As String() = text2.Split(New Char() { ":"c })
				Me.RichTextBox1.Text = array7(1)
				If array7(1).Contains("0") Then
					Interaction.MsgBox("Success - IP address is current, no update performed", MsgBoxStyle.Information, Nothing)
				End If
				If array7(1).Contains("1") Then
					Interaction.MsgBox("Success - DNS hostname update successful", MsgBoxStyle.Information, Nothing)
				End If
				If array7(1).Contains("2") Then
					Interaction.MsgBox("Error - Hostname supplied does not exist", MsgBoxStyle.Critical, Nothing)
				End If
				If array7(1).Contains("3") Then
					Interaction.MsgBox("Error - Invalid username", MsgBoxStyle.Critical, Nothing)
				End If
				If array7(1).Contains("4") Then
					Interaction.MsgBox("Error - Invalid password", MsgBoxStyle.Critical, Nothing)
				End If
				If array7(1).Contains("5") Then
					Interaction.MsgBox("Error - Too many updates sent. Updates are blocked   until 1 hour passes since last status of 5 returned.", MsgBoxStyle.Critical, Nothing)
				End If
				If array7(1).Contains("6") Then
					Interaction.MsgBox("Error - Account disabled due to violation of No-IP   terms of service. Our terms of service can be viewed at   http://www.no-ip.com/legal/tos", MsgBoxStyle.Critical, Nothing)
				End If
				If array7(1).Contains("7") Then
					Interaction.MsgBox("Error - Invalid IP. Invalid IP submitted is   improperly formated, is a private LAN RFC 1918 address, or an abuse   blacklisted address.", MsgBoxStyle.Critical, Nothing)
				End If
				If array7(1).Contains("8") Then
					Interaction.MsgBox("Error - Disabled / Locked hostname", MsgBoxStyle.Critical, Nothing)
				End If
				If array7(1).Contains("9") Then
					Interaction.MsgBox("Host updated is configured as a web redirect and no update was performed.", MsgBoxStyle.Information, Nothing)
				End If
				If array7(1).Contains("10") Then
					Interaction.MsgBox("Error - Group supplied does not exist", MsgBoxStyle.Critical, Nothing)
				End If
				If array7(1).Contains("11") Then
					Interaction.MsgBox("Success - DNS group update is successful", MsgBoxStyle.Information, Nothing)
				End If
				If array7(1).Contains("12") Then
					Interaction.MsgBox("Success - DNS group is current, no update performed.", MsgBoxStyle.Information, Nothing)
				End If
				If array7(1).Contains("13") Then
					Interaction.MsgBox("Error - Update client support not available for supplied hostname or group", MsgBoxStyle.Critical, Nothing)
				End If
				If array7(1).Contains("14") Then
					Interaction.MsgBox("Error - Hostname supplied does not have offline   settings configured. Returned if sending offline=YES on a host that  does  not have any offline actions configured.", MsgBoxStyle.Critical, Nothing)
				End If
				If array7(1).Contains("99") Then
					Interaction.MsgBox("Error - Client disabled. Client should exit and not   perform any more updates without user intervention.", MsgBoxStyle.Critical, Nothing)
				End If
				If array7(1).Contains("100") Then
					Interaction.MsgBox("Error - User input error usually returned if missing required request parameters", MsgBoxStyle.Critical, Nothing)
				End If
			Catch ex As Exception
				Interaction.MsgBox("Check your Internet Connection", MsgBoxStyle.Exclamation, "NO-IP Updater")
			End Try
		End Sub

		' Token: 0x040001C6 RID: 454
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001C8 RID: 456
		<AccessedThroughProperty("RichTextBox1")>
		Private _RichTextBox1 As RichTextBox

		' Token: 0x040001C9 RID: 457
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x040001CA RID: 458
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x040001CB RID: 459
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x040001CC RID: 460
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x040001CD RID: 461
		<AccessedThroughProperty("UserImage1")>
		Private _UserImage1 As UserImage

		' Token: 0x040001CE RID: 462
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040001CF RID: 463
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x040001D0 RID: 464
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x040001D1 RID: 465
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040001D2 RID: 466
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x040001D3 RID: 467
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x040001D4 RID: 468
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040001D5 RID: 469
		<AccessedThroughProperty("FlatMini1")>
		Private _FlatMini1 As FlatMini

		' Token: 0x040001D6 RID: 470
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x040001D7 RID: 471
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x040001D8 RID: 472
		<AccessedThroughProperty("FlatMini2")>
		Private _FlatMini2 As FlatMini

		' Token: 0x040001D9 RID: 473
		Private wc As Object

		' Token: 0x040001DA RID: 474
		Private utf8 As Object
	End Class
End Namespace
