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
	' Token: 0x02000010 RID: 16
	<DesignerGenerated()>
	Public Partial Class FURL
		Inherits Form

		' Token: 0x06000289 RID: 649 RVA: 0x00019550 File Offset: 0x00017750
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FURL.__ENCList
			SyncLock _ENCList
				If FURL.__ENCList.Count = FURL.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FURL.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FURL.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FURL.__ENCList(num) = FURL.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FURL.__ENCList.RemoveRange(num, FURL.__ENCList.Count - num)
					FURL.__ENCList.Capacity = FURL.__ENCList.Count
				End If
				FURL.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170000F1 RID: 241
		' (get) Token: 0x0600028C RID: 652 RVA: 0x00019FA4 File Offset: 0x000181A4
		' (set) Token: 0x0600028D RID: 653 RVA: 0x00002808 File Offset: 0x00000A08
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

		' Token: 0x170000F2 RID: 242
		' (get) Token: 0x0600028E RID: 654 RVA: 0x00019FBC File Offset: 0x000181BC
		' (set) Token: 0x0600028F RID: 655 RVA: 0x00002811 File Offset: 0x00000A11
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

		' Token: 0x170000F3 RID: 243
		' (get) Token: 0x06000290 RID: 656 RVA: 0x00019FD4 File Offset: 0x000181D4
		' (set) Token: 0x06000291 RID: 657 RVA: 0x0000281A File Offset: 0x00000A1A
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

		' Token: 0x170000F4 RID: 244
		' (get) Token: 0x06000292 RID: 658 RVA: 0x00019FEC File Offset: 0x000181EC
		' (set) Token: 0x06000293 RID: 659 RVA: 0x00002823 File Offset: 0x00000A23
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

		' Token: 0x170000F5 RID: 245
		' (get) Token: 0x06000294 RID: 660 RVA: 0x0001A004 File Offset: 0x00018204
		' (set) Token: 0x06000295 RID: 661 RVA: 0x0001A01C File Offset: 0x0001821C
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1_TextAlignChanged
				Dim value3 As EventHandler = AddressOf Me.TextBox1_TextChanged
				If Me._TextBox1 IsNot Nothing Then
					RemoveHandler Me._TextBox1.TextAlignChanged, value2
					RemoveHandler Me._TextBox1.TextChanged, value3
				End If
				Me._TextBox1 = value
				If Me._TextBox1 IsNot Nothing Then
					AddHandler Me._TextBox1.TextAlignChanged, value2
					AddHandler Me._TextBox1.TextChanged, value3
				End If
			End Set
		End Property

		' Token: 0x170000F6 RID: 246
		' (get) Token: 0x06000296 RID: 662 RVA: 0x0001A098 File Offset: 0x00018298
		' (set) Token: 0x06000297 RID: 663 RVA: 0x0001A0B0 File Offset: 0x000182B0
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button2_Click
				If Me._Button2 IsNot Nothing Then
					RemoveHandler Me._Button2.Click, value2
				End If
				Me._Button2 = value
				If Me._Button2 IsNot Nothing Then
					AddHandler Me._Button2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000F7 RID: 247
		' (get) Token: 0x06000298 RID: 664 RVA: 0x0001A108 File Offset: 0x00018308
		' (set) Token: 0x06000299 RID: 665 RVA: 0x0001A120 File Offset: 0x00018320
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

		' Token: 0x170000F8 RID: 248
		' (get) Token: 0x0600029A RID: 666 RVA: 0x0001A178 File Offset: 0x00018378
		' (set) Token: 0x0600029B RID: 667 RVA: 0x0001A190 File Offset: 0x00018390
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

		' Token: 0x170000F9 RID: 249
		' (get) Token: 0x0600029C RID: 668 RVA: 0x0001A1E8 File Offset: 0x000183E8
		' (set) Token: 0x0600029D RID: 669 RVA: 0x0000282C File Offset: 0x00000A2C
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

		' Token: 0x0600029E RID: 670 RVA: 0x0001A200 File Offset: 0x00018400
		Public Sub New()
			AddHandler MyBase.KeyDown, AddressOf Me.FURL_KeyDown
			AddHandler MyBase.Load, AddressOf Me.FURL_Load
			FURL.__ENCAddToList(Me)
			Me.IsOK = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600029F RID: 671 RVA: 0x0001A24C File Offset: 0x0001844C
		Private Sub FURL_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.[Return] Then
				Me.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e)
			End If
		End Sub

		' Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub TextBox1_TextAlignChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060002A1 RID: 673 RVA: 0x0001A27C File Offset: 0x0001847C
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			If Me.TextBox1.Text.Length > 0 And Me.TextBox1.Text.ToLower().StartsWith("http") And Me.TextBox2.TextLength > 0 Then
				Me.IsOK = True
				Me.Close()
			End If
		End Sub

		' Token: 0x060002A2 RID: 674 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060002A3 RID: 675 RVA: 0x0001A2D8 File Offset: 0x000184D8
		Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
			Try
				Me.TextBox2.Text = Strings.Split(Me.TextBox1.Text, ".", -1, CompareMethod.Binary)(Strings.Split(Me.TextBox1.Text, ".", -1, CompareMethod.Binary).Length - 1)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub FURL_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060002A5 RID: 677 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0400011D RID: 285
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400011F RID: 287
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x04000120 RID: 288
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000121 RID: 289
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000122 RID: 290
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x04000123 RID: 291
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000124 RID: 292
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000125 RID: 293
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000126 RID: 294
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x04000127 RID: 295
		<AccessedThroughProperty("FlatMini1")>
		Private _FlatMini1 As FlatMini

		' Token: 0x04000128 RID: 296
		Public IsOK As Boolean
	End Class
End Namespace
