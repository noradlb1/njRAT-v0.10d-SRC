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
	' Token: 0x02000008 RID: 8
	<DesignerGenerated()>
	Public Partial Class About
		Inherits Form

		' Token: 0x0600004B RID: 75 RVA: 0x000020EB File Offset: 0x000002EB
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.About_Load
			About.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600004C RID: 76 RVA: 0x00004AE4 File Offset: 0x00002CE4
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = About.__ENCList
			SyncLock _ENCList
				If About.__ENCList.Count = About.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = About.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = About.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								About.__ENCList(num) = About.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					About.__ENCList.RemoveRange(num, About.__ENCList.Count - num)
					About.__ENCList.Capacity = About.__ENCList.Count
				End If
				About.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700001D RID: 29
		' (get) Token: 0x0600004F RID: 79 RVA: 0x00005D80 File Offset: 0x00003F80
		' (set) Token: 0x06000050 RID: 80 RVA: 0x00002112 File Offset: 0x00000312
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

		' Token: 0x1700001E RID: 30
		' (get) Token: 0x06000051 RID: 81 RVA: 0x00005D98 File Offset: 0x00003F98
		' (set) Token: 0x06000052 RID: 82 RVA: 0x0000211B File Offset: 0x0000031B
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

		' Token: 0x1700001F RID: 31
		' (get) Token: 0x06000053 RID: 83 RVA: 0x00005DB0 File Offset: 0x00003FB0
		' (set) Token: 0x06000054 RID: 84 RVA: 0x00002124 File Offset: 0x00000324
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

		' Token: 0x17000020 RID: 32
		' (get) Token: 0x06000055 RID: 85 RVA: 0x00005DC8 File Offset: 0x00003FC8
		' (set) Token: 0x06000056 RID: 86 RVA: 0x0000212D File Offset: 0x0000032D
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

		' Token: 0x17000021 RID: 33
		' (get) Token: 0x06000057 RID: 87 RVA: 0x00005DE0 File Offset: 0x00003FE0
		' (set) Token: 0x06000058 RID: 88 RVA: 0x00002136 File Offset: 0x00000336
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

		' Token: 0x17000022 RID: 34
		' (get) Token: 0x06000059 RID: 89 RVA: 0x00005DF8 File Offset: 0x00003FF8
		' (set) Token: 0x0600005A RID: 90 RVA: 0x00005E10 File Offset: 0x00004010
		Friend Overridable Property UserImage1 As UserImage
			<DebuggerNonUserCode()>
			Get
				Return Me._UserImage1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UserImage)
				Dim value2 As EventHandler = AddressOf Me.UserImage1_Click
				If Me._UserImage1 IsNot Nothing Then
					RemoveHandler Me._UserImage1.Click, value2
				End If
				Me._UserImage1 = value
				If Me._UserImage1 IsNot Nothing Then
					AddHandler Me._UserImage1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x0600005B RID: 91 RVA: 0x00005E68 File Offset: 0x00004068
		' (set) Token: 0x0600005C RID: 92 RVA: 0x0000213F File Offset: 0x0000033F
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

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x0600005D RID: 93 RVA: 0x00005E80 File Offset: 0x00004080
		' (set) Token: 0x0600005E RID: 94 RVA: 0x00002148 File Offset: 0x00000348
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

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x0600005F RID: 95 RVA: 0x00005E98 File Offset: 0x00004098
		' (set) Token: 0x06000060 RID: 96 RVA: 0x00002151 File Offset: 0x00000351
		Friend Overridable Property UserImage3 As UserImage
			<DebuggerNonUserCode()>
			Get
				Return Me._UserImage3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UserImage)
				Me._UserImage3 = value
			End Set
		End Property

		' Token: 0x17000026 RID: 38
		' (get) Token: 0x06000061 RID: 97 RVA: 0x00005EB0 File Offset: 0x000040B0
		' (set) Token: 0x06000062 RID: 98 RVA: 0x0000215A File Offset: 0x0000035A
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

		' Token: 0x17000027 RID: 39
		' (get) Token: 0x06000063 RID: 99 RVA: 0x00005EC8 File Offset: 0x000040C8
		' (set) Token: 0x06000064 RID: 100 RVA: 0x00002163 File Offset: 0x00000363
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

		' Token: 0x17000028 RID: 40
		' (get) Token: 0x06000065 RID: 101 RVA: 0x00005EE0 File Offset: 0x000040E0
		' (set) Token: 0x06000066 RID: 102 RVA: 0x0000216C File Offset: 0x0000036C
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

		' Token: 0x17000029 RID: 41
		' (get) Token: 0x06000067 RID: 103 RVA: 0x00005EF8 File Offset: 0x000040F8
		' (set) Token: 0x06000068 RID: 104 RVA: 0x00005F10 File Offset: 0x00004110
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

		' Token: 0x1700002A RID: 42
		' (get) Token: 0x06000069 RID: 105 RVA: 0x00005F68 File Offset: 0x00004168
		' (set) Token: 0x0600006A RID: 106 RVA: 0x00002175 File Offset: 0x00000375
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

		' Token: 0x1700002B RID: 43
		' (get) Token: 0x0600006B RID: 107 RVA: 0x00005F80 File Offset: 0x00004180
		' (set) Token: 0x0600006C RID: 108 RVA: 0x00005F98 File Offset: 0x00004198
		Friend Overridable Property Label5 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.Label5_Click
				If Me._Label5 IsNot Nothing Then
					RemoveHandler Me._Label5.Click, value2
				End If
				Me._Label5 = value
				If Me._Label5 IsNot Nothing Then
					AddHandler Me._Label5.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700002C RID: 44
		' (get) Token: 0x0600006D RID: 109 RVA: 0x00005FF0 File Offset: 0x000041F0
		' (set) Token: 0x0600006E RID: 110 RVA: 0x0000217E File Offset: 0x0000037E
		Friend Overridable Property UserImage4 As UserImage
			<DebuggerNonUserCode()>
			Get
				Return Me._UserImage4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UserImage)
				Me._UserImage4 = value
			End Set
		End Property

		' Token: 0x0600006F RID: 111 RVA: 0x00002187 File Offset: 0x00000387
		Private Sub About_Load(sender As Object, e As EventArgs)
			Me.RichTextBox1.Text = Resources.RichTextBox1
		End Sub

		' Token: 0x06000070 RID: 112 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub UserImage1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000071 RID: 113 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000072 RID: 114 RVA: 0x000021A1 File Offset: 0x000003A1
		Private Sub Label5_Click(sender As Object, e As EventArgs)
			Process.Start("https://www.facebook.com/FR4ONHALAB/")
		End Sub

		' Token: 0x0400001F RID: 31
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000021 RID: 33
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000022 RID: 34
		<AccessedThroughProperty("RichTextBox1")>
		Private _RichTextBox1 As RichTextBox

		' Token: 0x04000023 RID: 35
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x04000024 RID: 36
		<AccessedThroughProperty("FlatMini1")>
		Private _FlatMini1 As FlatMini

		' Token: 0x04000025 RID: 37
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000026 RID: 38
		<AccessedThroughProperty("UserImage1")>
		Private _UserImage1 As UserImage

		' Token: 0x04000027 RID: 39
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x04000028 RID: 40
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000029 RID: 41
		<AccessedThroughProperty("UserImage3")>
		Private _UserImage3 As UserImage

		' Token: 0x0400002A RID: 42
		<AccessedThroughProperty("UserImage2")>
		Private _UserImage2 As UserImage

		' Token: 0x0400002B RID: 43
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x0400002C RID: 44
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x0400002D RID: 45
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x0400002E RID: 46
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x0400002F RID: 47
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x04000030 RID: 48
		<AccessedThroughProperty("UserImage4")>
		Private _UserImage4 As UserImage
	End Class
End Namespace
