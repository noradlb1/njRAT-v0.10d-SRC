Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200001F RID: 31
	<DesignerGenerated()>
	Public Partial Class script
		Inherits Form

		' Token: 0x0600050C RID: 1292 RVA: 0x0002E0BC File Offset: 0x0002C2BC
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = script.__ENCList
			SyncLock _ENCList
				If script.__ENCList.Count = script.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = script.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = script.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								script.__ENCList(num) = script.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					script.__ENCList.RemoveRange(num, script.__ENCList.Count - num)
					script.__ENCList.Capacity = script.__ENCList.Count
				End If
				script.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170001CE RID: 462
		' (get) Token: 0x0600050F RID: 1295 RVA: 0x0002EA34 File Offset: 0x0002CC34
		' (set) Token: 0x06000510 RID: 1296 RVA: 0x00002F1C File Offset: 0x0000111C
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

		' Token: 0x170001CF RID: 463
		' (get) Token: 0x06000511 RID: 1297 RVA: 0x0002EA4C File Offset: 0x0002CC4C
		' (set) Token: 0x06000512 RID: 1298 RVA: 0x00002F25 File Offset: 0x00001125
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

		' Token: 0x170001D0 RID: 464
		' (get) Token: 0x06000513 RID: 1299 RVA: 0x0002EA64 File Offset: 0x0002CC64
		' (set) Token: 0x06000514 RID: 1300 RVA: 0x00002F2E File Offset: 0x0000112E
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

		' Token: 0x170001D1 RID: 465
		' (get) Token: 0x06000515 RID: 1301 RVA: 0x0002EA7C File Offset: 0x0002CC7C
		' (set) Token: 0x06000516 RID: 1302 RVA: 0x0002EA94 File Offset: 0x0002CC94
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

		' Token: 0x170001D2 RID: 466
		' (get) Token: 0x06000517 RID: 1303 RVA: 0x0002EAEC File Offset: 0x0002CCEC
		' (set) Token: 0x06000518 RID: 1304 RVA: 0x00002F37 File Offset: 0x00001137
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

		' Token: 0x170001D3 RID: 467
		' (get) Token: 0x06000519 RID: 1305 RVA: 0x0002EB04 File Offset: 0x0002CD04
		' (set) Token: 0x0600051A RID: 1306 RVA: 0x00002F40 File Offset: 0x00001140
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

		' Token: 0x170001D4 RID: 468
		' (get) Token: 0x0600051B RID: 1307 RVA: 0x0002EB1C File Offset: 0x0002CD1C
		' (set) Token: 0x0600051C RID: 1308 RVA: 0x0002EB34 File Offset: 0x0002CD34
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

		' Token: 0x170001D5 RID: 469
		' (get) Token: 0x0600051D RID: 1309 RVA: 0x0002EB8C File Offset: 0x0002CD8C
		' (set) Token: 0x0600051E RID: 1310 RVA: 0x00002F49 File Offset: 0x00001149
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

		' Token: 0x0600051F RID: 1311 RVA: 0x00002F52 File Offset: 0x00001152
		Public Sub New()
			script.__ENCAddToList(Me)
			Me.RunAs = "vbs"
			Me.Code = String.Empty
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000520 RID: 1312 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub Button1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000521 RID: 1313 RVA: 0x00002F7C File Offset: 0x0000117C
		Private Sub Button1_Click_1(sender As Object, e As EventArgs)
			Me.Code = Me.TextBox1.Text
			Me.RunAs = Me.ComboBox1.Text
			Me.Close()
		End Sub

		' Token: 0x06000522 RID: 1314 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x04000253 RID: 595
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000255 RID: 597
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000256 RID: 598
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x04000257 RID: 599
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x04000258 RID: 600
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000259 RID: 601
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x0400025A RID: 602
		<AccessedThroughProperty("FlatMini2")>
		Private _FlatMini2 As FlatMini

		' Token: 0x0400025B RID: 603
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x0400025C RID: 604
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x0400025D RID: 605
		Public Code As String

		' Token: 0x0400025E RID: 606
		Public F As Form1

		' Token: 0x0400025F RID: 607
		Public RunAs As String
	End Class
End Namespace
