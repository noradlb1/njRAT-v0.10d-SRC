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
	' Token: 0x0200000F RID: 15
	<DesignerGenerated()>
	Public Partial Class FromLink
		Inherits Form

		' Token: 0x0600026E RID: 622 RVA: 0x000027A3 File Offset: 0x000009A3
		<DebuggerNonUserCode()>
		Public Sub New()
			FromLink.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600026F RID: 623 RVA: 0x000188FC File Offset: 0x00016AFC
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FromLink.__ENCList
			SyncLock _ENCList
				If FromLink.__ENCList.Count = FromLink.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FromLink.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FromLink.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FromLink.__ENCList(num) = FromLink.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FromLink.__ENCList.RemoveRange(num, FromLink.__ENCList.Count - num)
					FromLink.__ENCList.Capacity = FromLink.__ENCList.Count
				End If
				FromLink.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170000E8 RID: 232
		' (get) Token: 0x06000272 RID: 626 RVA: 0x000192F4 File Offset: 0x000174F4
		' (set) Token: 0x06000273 RID: 627 RVA: 0x000027B7 File Offset: 0x000009B7
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

		' Token: 0x170000E9 RID: 233
		' (get) Token: 0x06000274 RID: 628 RVA: 0x0001930C File Offset: 0x0001750C
		' (set) Token: 0x06000275 RID: 629 RVA: 0x000027C0 File Offset: 0x000009C0
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

		' Token: 0x170000EA RID: 234
		' (get) Token: 0x06000276 RID: 630 RVA: 0x00019324 File Offset: 0x00017524
		' (set) Token: 0x06000277 RID: 631 RVA: 0x000027C9 File Offset: 0x000009C9
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

		' Token: 0x170000EB RID: 235
		' (get) Token: 0x06000278 RID: 632 RVA: 0x0001933C File Offset: 0x0001753C
		' (set) Token: 0x06000279 RID: 633 RVA: 0x000027D2 File Offset: 0x000009D2
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

		' Token: 0x170000EC RID: 236
		' (get) Token: 0x0600027A RID: 634 RVA: 0x00019354 File Offset: 0x00017554
		' (set) Token: 0x0600027B RID: 635 RVA: 0x000027DB File Offset: 0x000009DB
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

		' Token: 0x170000ED RID: 237
		' (get) Token: 0x0600027C RID: 636 RVA: 0x0001936C File Offset: 0x0001756C
		' (set) Token: 0x0600027D RID: 637 RVA: 0x00019384 File Offset: 0x00017584
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

		' Token: 0x170000EE RID: 238
		' (get) Token: 0x0600027E RID: 638 RVA: 0x000193DC File Offset: 0x000175DC
		' (set) Token: 0x0600027F RID: 639 RVA: 0x000193F4 File Offset: 0x000175F4
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

		' Token: 0x170000EF RID: 239
		' (get) Token: 0x06000280 RID: 640 RVA: 0x0001944C File Offset: 0x0001764C
		' (set) Token: 0x06000281 RID: 641 RVA: 0x00019464 File Offset: 0x00017664
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

		' Token: 0x170000F0 RID: 240
		' (get) Token: 0x06000282 RID: 642 RVA: 0x000194BC File Offset: 0x000176BC
		' (set) Token: 0x06000283 RID: 643 RVA: 0x000027E4 File Offset: 0x000009E4
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

		' Token: 0x06000284 RID: 644 RVA: 0x000194D4 File Offset: 0x000176D4
		Private Sub TextBox1_TextAlignChanged(sender As Object, e As EventArgs)
			Try
				Me.TextBox2.Text = Strings.Split(Me.TextBox1.Text, "\", -1, CompareMethod.Binary)(Strings.Split(Me.TextBox1.Text, "\", -1, CompareMethod.Binary).Length - 1)
			Catch ex As Exception
				Me.TextBox2.Text = "File.txt"
			End Try
		End Sub

		' Token: 0x06000285 RID: 645 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000286 RID: 646 RVA: 0x000027ED File Offset: 0x000009ED
		Private Sub Button1_Click_1(sender As Object, e As EventArgs)
			Me.IsOK = True
			Me.Close()
		End Sub

		' Token: 0x06000287 RID: 647 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub Button2_Click_1(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x04000111 RID: 273
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000113 RID: 275
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x04000114 RID: 276
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000115 RID: 277
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000116 RID: 278
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x04000117 RID: 279
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000118 RID: 280
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000119 RID: 281
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400011A RID: 282
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x0400011B RID: 283
		<AccessedThroughProperty("FlatMini1")>
		Private _FlatMini1 As FlatMini

		' Token: 0x0400011C RID: 284
		Public IsOK As Boolean
	End Class
End Namespace
