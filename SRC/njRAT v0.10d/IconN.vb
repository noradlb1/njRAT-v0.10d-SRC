Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security

Namespace NJRAT
	' Token: 0x0200005C RID: 92
	Public Class IconN
		' Token: 0x060007A1 RID: 1953 RVA: 0x000020D7 File Offset: 0x000002D7
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x060007A2 RID: 1954 RVA: 0x00003CE9 File Offset: 0x00001EE9
		Public Shared Sub InjectIcon(exeFileName As String, iconFileName As String)
			IconN.InjectIcon(exeFileName, iconFileName, 1UI, 1UI)
		End Sub

		' Token: 0x060007A3 RID: 1955 RVA: 0x00044040 File Offset: 0x00042240
		Public Shared Sub InjectIcon(exeFileName As String, iconFileName As String, iconGroupID As UInteger, iconBaseID As UInteger)
			Dim iconFile As IconN.IconFile = IconN.IconFile.FromFile(iconFileName)
			Dim intPtr As IntPtr = IconN.NativeMethods.BeginUpdateResource(exeFileName, False)
			Dim array As Byte() = iconFile.CreateIconGroupData(iconBaseID)
			Dim hUpdate As IntPtr = intPtr
			Dim intPtr2 As IntPtr = New IntPtr(14L)
			Dim type As IntPtr = intPtr2
			Dim intPtr3 As IntPtr = New IntPtr(CLng(CULng(iconGroupID)))
			IconN.NativeMethods.UpdateResource(hUpdate, type, intPtr3, 0S, array, array.Length)
			Dim num As Integer = 0
			Dim num2 As Integer = iconFile.ImageCount - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit For
				End If
				Dim array2 As Byte() = iconFile.get_ImageData(num3)
				Dim hUpdate2 As IntPtr = intPtr
				intPtr3 = New IntPtr(3L)
				Dim type2 As IntPtr = intPtr3
				intPtr2 = New IntPtr(CLng((CULng(iconBaseID) + CULng(CLng(num3)))))
				IconN.NativeMethods.UpdateResource(hUpdate2, type2, intPtr2, 0S, array2, array2.Length)
				num3 += 1
			End While
			IconN.NativeMethods.EndUpdateResource(intPtr, False)
		End Sub

		' Token: 0x0200005D RID: 93
		<SuppressUnmanagedCodeSecurity()>
		Private Class NativeMethods
			' Token: 0x060007A4 RID: 1956 RVA: 0x000020D7 File Offset: 0x000002D7
			<DebuggerNonUserCode()>
			Public Sub New()
			End Sub

			' Token: 0x060007A5 RID: 1957
			Public Declare Function BeginUpdateResource Lib "kernel32" (fileName As String, <MarshalAs(UnmanagedType.Bool)> deleteExistingResources As Boolean) As IntPtr

			' Token: 0x060007A6 RID: 1958
			Public Declare Function UpdateResource Lib "kernel32" (hUpdate As IntPtr, type As IntPtr, name As IntPtr, language As Short, <MarshalAs(UnmanagedType.LPArray, SizeParamIndex := 5)> data As Byte(), dataSize As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean

			' Token: 0x060007A7 RID: 1959
			Public Declare Function EndUpdateResource Lib "kernel32" (hUpdate As IntPtr, <MarshalAs(UnmanagedType.Bool)> discard As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
		End Class

		' Token: 0x0200005E RID: 94
		Private Structure ICONDIR
			' Token: 0x04000437 RID: 1079
			Public Reserved As UShort

			' Token: 0x04000438 RID: 1080
			Public Type As UShort

			' Token: 0x04000439 RID: 1081
			Public Count As UShort
		End Structure

		' Token: 0x0200005F RID: 95
		Private Structure ICONDIRENTRY
			' Token: 0x0400043A RID: 1082
			Public Width As Byte

			' Token: 0x0400043B RID: 1083
			Public Height As Byte

			' Token: 0x0400043C RID: 1084
			Public ColorCount As Byte

			' Token: 0x0400043D RID: 1085
			Public Reserved As Byte

			' Token: 0x0400043E RID: 1086
			Public Planes As UShort

			' Token: 0x0400043F RID: 1087
			Public BitCount As UShort

			' Token: 0x04000440 RID: 1088
			Public BytesInRes As Integer

			' Token: 0x04000441 RID: 1089
			Public ImageOffset As Integer
		End Structure

		' Token: 0x02000060 RID: 96
		Private Structure BITMAPINFOHEADER
			' Token: 0x04000442 RID: 1090
			Public Size As UInteger

			' Token: 0x04000443 RID: 1091
			Public Width As Integer

			' Token: 0x04000444 RID: 1092
			Public Height As Integer

			' Token: 0x04000445 RID: 1093
			Public Planes As UShort

			' Token: 0x04000446 RID: 1094
			Public BitCount As UShort

			' Token: 0x04000447 RID: 1095
			Public Compression As UInteger

			' Token: 0x04000448 RID: 1096
			Public SizeImage As UInteger

			' Token: 0x04000449 RID: 1097
			Public XPelsPerMeter As Integer

			' Token: 0x0400044A RID: 1098
			Public YPelsPerMeter As Integer

			' Token: 0x0400044B RID: 1099
			Public ClrUsed As UInteger

			' Token: 0x0400044C RID: 1100
			Public ClrImportant As UInteger
		End Structure

		' Token: 0x02000061 RID: 97
		<StructLayout(LayoutKind.Sequential, Pack := 2)>
		Private Structure GRPICONDIRENTRY
			' Token: 0x0400044D RID: 1101
			Public Width As Byte

			' Token: 0x0400044E RID: 1102
			Public Height As Byte

			' Token: 0x0400044F RID: 1103
			Public ColorCount As Byte

			' Token: 0x04000450 RID: 1104
			Public Reserved As Byte

			' Token: 0x04000451 RID: 1105
			Public Planes As UShort

			' Token: 0x04000452 RID: 1106
			Public BitCount As UShort

			' Token: 0x04000453 RID: 1107
			Public BytesInRes As Integer

			' Token: 0x04000454 RID: 1108
			Public ID As UShort
		End Structure

		' Token: 0x02000062 RID: 98
		Private Class IconFile
			' Token: 0x1700025D RID: 605
			' (get) Token: 0x060007A8 RID: 1960 RVA: 0x000440E8 File Offset: 0x000422E8
			Public ReadOnly Property ImageCount As Integer
				Get
					Return CInt(Me.iconDir.Count)
				End Get
			End Property

			' Token: 0x1700025E RID: 606
			' (get) Token: 0x060007A9 RID: 1961 RVA: 0x00044104 File Offset: 0x00042304
			Public ReadOnly Property ImageData(index As Integer) As Byte()
				Get
					Return Me.iconImage(index)
				End Get
			End Property

			' Token: 0x060007AA RID: 1962 RVA: 0x00003CF4 File Offset: 0x00001EF4
			Private Sub New()
				Me.iconDir = Nothing
			End Sub

			' Token: 0x060007AB RID: 1963 RVA: 0x0004411C File Offset: 0x0004231C
			Public Shared Function FromFile(filename As String) As IconN.IconFile
				Dim iconFile As IconN.IconFile = New IconN.IconFile()
				Dim array As Byte() = File.ReadAllBytes(filename)
				Dim gchandle As GCHandle = GCHandle.Alloc(array, GCHandleType.Pinned)
				iconFile.iconDir = CType(Marshal.PtrToStructure(gchandle.AddrOfPinnedObject(), GetType(IconN.ICONDIR)), IconN.ICONDIR)
				iconFile.iconEntry = New IconN.ICONDIRENTRY(CInt((iconFile.iconDir.Count - 1US + 1US)) - 1) {}
				iconFile.iconImage = New Byte(CInt((iconFile.iconDir.Count - 1US + 1US)) - 1)() {}
				Dim num As Integer = Marshal.SizeOf(iconFile.iconDir)
				Dim typeFromHandle As Type = GetType(IconN.ICONDIRENTRY)
				Dim num2 As Integer = Marshal.SizeOf(typeFromHandle)
				Dim num3 As Integer = 0
				Dim num4 As Integer = CInt((iconFile.iconDir.Count - 1US))
				Dim num5 As Integer = num3
				While True
					Dim num6 As Integer = num5
					Dim num7 As Integer = num4
					If num6 > num7 Then
						Exit For
					End If
					Dim ptr As IntPtr = New IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + CLng(num))
					Dim icondirentry As IconN.ICONDIRENTRY = CType(Marshal.PtrToStructure(ptr, typeFromHandle), IconN.ICONDIRENTRY)
					iconFile.iconEntry(num5) = icondirentry
					iconFile.iconImage(num5) = New Byte(icondirentry.BytesInRes - 1 + 1 - 1) {}
					Buffer.BlockCopy(array, icondirentry.ImageOffset, iconFile.iconImage(num5), 0, icondirentry.BytesInRes)
					num += num2
					num5 += 1
				End While
				gchandle.Free()
				Return iconFile
			End Function

			' Token: 0x060007AC RID: 1964 RVA: 0x00044274 File Offset: 0x00042474
			Public Function CreateIconGroupData(iconBaseID As UInteger) As Byte()
				Dim num As Integer = Marshal.SizeOf(GetType(IconN.ICONDIR)) + Marshal.SizeOf(GetType(IconN.GRPICONDIRENTRY)) * Me.ImageCount
				Dim array As Byte() = New Byte(num - 1 + 1 - 1) {}
				Dim gchandle As GCHandle = GCHandle.Alloc(array, GCHandleType.Pinned)
				Marshal.StructureToPtr(Me.iconDir, gchandle.AddrOfPinnedObject(), False)
				Dim num2 As Integer = Marshal.SizeOf(Me.iconDir)
				Dim num3 As Integer = 0
				Dim num4 As Integer = Me.ImageCount - 1
				Dim num5 As Integer = num3
				While True
					Dim num6 As Integer = num5
					Dim num7 As Integer = num4
					If num6 > num7 Then
						Exit For
					End If
					Dim grpicondirentry As IconN.GRPICONDIRENTRY = Nothing
					Dim bitmapinfoheader As IconN.BITMAPINFOHEADER = Nothing
					Dim gchandle2 As GCHandle = GCHandle.Alloc(bitmapinfoheader, GCHandleType.Pinned)
					Marshal.Copy(Me.get_ImageData(num5), 0, gchandle2.AddrOfPinnedObject(), Marshal.SizeOf(GetType(IconN.BITMAPINFOHEADER)))
					gchandle2.Free()
					grpicondirentry.Width = Me.iconEntry(num5).Width
					grpicondirentry.Height = Me.iconEntry(num5).Height
					grpicondirentry.ColorCount = Me.iconEntry(num5).ColorCount
					grpicondirentry.Reserved = Me.iconEntry(num5).Reserved
					grpicondirentry.Planes = bitmapinfoheader.Planes
					grpicondirentry.BitCount = bitmapinfoheader.BitCount
					grpicondirentry.BytesInRes = Me.iconEntry(num5).BytesInRes
					grpicondirentry.ID = CUShort((CULng(iconBaseID) + CULng(CLng(num5))))
					Dim [structure] As Object = grpicondirentry
					Dim ptr As IntPtr = New IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + CLng(num2))
					Marshal.StructureToPtr([structure], ptr, False)
					num2 += Marshal.SizeOf(GetType(IconN.GRPICONDIRENTRY))
					num5 += 1
				End While
				gchandle.Free()
				Return array
			End Function

			' Token: 0x04000455 RID: 1109
			Private iconDir As IconN.ICONDIR

			' Token: 0x04000456 RID: 1110
			Private iconEntry As IconN.ICONDIRENTRY()

			' Token: 0x04000457 RID: 1111
			Private iconImage As Byte()()
		End Class
	End Class
End Namespace
