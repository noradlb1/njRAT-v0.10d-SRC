Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000069 RID: 105
	Public NotInheritable Class Pp1
		Inherits PictureBox

		' Token: 0x060007D0 RID: 2000 RVA: 0x00044E1C File Offset: 0x0004301C
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Pp1.__ENCList
			SyncLock _ENCList
				If Pp1.__ENCList.Count = Pp1.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Pp1.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Pp1.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Pp1.__ENCList(num) = Pp1.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Pp1.__ENCList.RemoveRange(num, Pp1.__ENCList.Count - num)
					Pp1.__ENCList.Capacity = Pp1.__ENCList.Count
				End If
				Pp1.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x060007D1 RID: 2001 RVA: 0x00044F04 File Offset: 0x00043104
		Public Sub New()
			Pp1.__ENCAddToList(Me)
			Me.font = New Font("arial", 8F, FontStyle.Bold)
			Me.Lines = New List(Of Object())()
			Dim t As Timer = New Timer() With { .Interval = 50, .Enabled = False }
			Me.T = t
			Me.SizeMode = PictureBoxSizeMode.Normal
		End Sub

		' Token: 0x060007D2 RID: 2002 RVA: 0x00044F64 File Offset: 0x00043164
		<CompilerGenerated()>
		<DebuggerStepThrough()>
		Private Sub ksh__4(a0 As Object, a1 As EventArgs)
			Try
				Me.wrk()
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060007D3 RID: 2003 RVA: 0x00044F98 File Offset: 0x00043198
		Public Sub wrk()
			Try
				Me.T.Enabled = False
				SyncLock Me
					Dim image As Bitmap = New Bitmap(Me.Width, Me.Height)
					Me.G = Graphics.FromImage(image)
					Me.G.Clear(Color.Black)
					Dim num As Integer = 3
					Dim height As Integer = TextRenderer.MeasureText("test", Me.font).Height
					Dim color As Color = Color.White
					For i As Integer = Me.Lines.Count - 1 To 0 Step -1
						Dim num2 As Integer = 3
						Dim array As Object() = Me.Lines(i)
						Dim num3 As Integer = array.Length - 1
						For j As Integer = 0 To num3
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array(j))))))))
							Dim left As String = objectValue.[GetType]().ToString()
							If Operators.CompareString(left, GetType(Bitmap).ToString(), False) = 0 Then
								Dim bitmap As Bitmap = CType(objectValue, Bitmap)
								If bitmap.Height > height Then
									Dim callbackData As IntPtr
									bitmap = CType(bitmap.GetThumbnailImage(height, height, Nothing, callbackData), Bitmap)
								End If
								Me.G.DrawImage(bitmap, num2, num)
								num2 += bitmap.Width + 3
							ElseIf Operators.CompareString(left, GetType(String).ToString(), False) = 0 Then
								Dim text As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue))))
								Dim size As Size = TextRenderer.MeasureText(text, Me.font)
								Me.G.DrawString(text, Me.font, New Pen(color).Brush, CSng(num2), CSng(num))
								If size.Height - height > 0 Then
									num += size.Height - height
									num2 = 3
								Else
									num2 += size.Width + 3
								End If
							ElseIf Operators.CompareString(left, GetType(Color).ToString(), False) = 0 Then
								color = CType(objectValue, Color)
							End If
						Next
						num += height
					Next
					Me.G.Dispose()
					Me.Image = image
				End SyncLock
				Me.T.Enabled = True
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060007D4 RID: 2004 RVA: 0x00045240 File Offset: 0x00043440
		Public Sub WRT(ParamArray A As Object())
			SyncLock Me
				Me.Lines.Add(A)
				If Me.Lines.Count = 100 Then
					Me.Lines.RemoveAt(0)
				End If
			End SyncLock
		End Sub

		' Token: 0x1700025F RID: 607
		' (get) Token: 0x060007D5 RID: 2005 RVA: 0x0004529C File Offset: 0x0004349C
		' (set) Token: 0x060007D6 RID: 2006 RVA: 0x000452B4 File Offset: 0x000434B4
		Public Property T As Timer
			Get
				Return Me._T
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.ksh__4
				If Me._T IsNot Nothing Then
					RemoveHandler Me._T.Tick, value2
				End If
				Me._T = value
				If Me._T IsNot Nothing Then
					AddHandler Me._T.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x0400045F RID: 1119
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000460 RID: 1120
		Private _T As Timer

		' Token: 0x04000461 RID: 1121
		Public font As Font

		' Token: 0x04000462 RID: 1122
		Public G As Graphics

		' Token: 0x04000463 RID: 1123
		Public Lines As List(Of Object())
	End Class
End Namespace
