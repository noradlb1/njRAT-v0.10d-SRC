Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security

Namespace NJRAT
	' Token: 0x02000055 RID: 85
	Public Class IconInjector
		' Token: 0x06000795 RID: 1941 RVA: 0x000020D7 File Offset: 0x000002D7
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x06000796 RID: 1942 RVA: 0x00003CCA File Offset: 0x00001ECA
		Public Shared Sub InjectIcon(exeFileName As String, iconFileName As String)
			IconInjector.InjectIcon(exeFileName, iconFileName, 1UI, 1UI)
		End Sub

		' Token: 0x06000797 RID: 1943 RVA: 0x00043C3C File Offset: 0x00041E3C
		Public Shared Sub InjectIcon(exeFileName As String, iconFileName As String, iconGroupID As UInteger, iconBaseID As UInteger)
			Dim iconFile As IconInjector.IconFile = IconInjector.IconFile.FromFile(iconFileName)
			Dim intPtr As IntPtr = IconInjector.NativeMethods.BeginUpdateResource(exeFileName, False)
			Dim array As Byte() = iconFile.CreateIconGroupData(iconBaseID)
			Dim hUpdate As IntPtr = intPtr
			Dim intPtr2 As IntPtr = New IntPtr(14L)
			Dim type As IntPtr = intPtr2
			Dim intPtr3 As IntPtr = New IntPtr(CLng(CULng(iconGroupID)))
			IconInjector.NativeMethods.UpdateResource(hUpdate, type, intPtr3, 0S, array, array.Length)
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
				IconInjector.NativeMethods.UpdateResource(hUpdate2, type2, intPtr2, 0S, array2, array2.Length)
				num3 += 1
			End While
			IconInjector.NativeMethods.EndUpdateResource(intPtr, False)
		End Sub

		' Token: 0x02000056 RID: 86
		<SuppressUnmanagedCodeSecurity()>
		Private Class NativeMethods
			' Token: 0x06000798 RID: 1944 RVA: 0x000020D7 File Offset: 0x000002D7
			<DebuggerNonUserCode()>
			Public Sub New()
			End Sub

			' Token: 0x06000799 RID: 1945
			Public Declare Function BeginUpdateResource Lib "kernel32" (fileName As String, <MarshalAs(UnmanagedType.Bool)> deleteExistingResources As Boolean) As IntPtr

			' Token: 0x0600079A RID: 1946
			Public Declare Function UpdateResource Lib "kernel32" (hUpdate As IntPtr, type As IntPtr, name As IntPtr, language As Short, <MarshalAs(UnmanagedType.LPArray, SizeParamIndex := 5)> data As Byte(), dataSize As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean

			' Token: 0x0600079B RID: 1947
			Public Declare Function EndUpdateResource Lib "kernel32" (hUpdate As IntPtr, <MarshalAs(UnmanagedType.Bool)> discard As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
		End Class

		' Token: 0x02000057 RID: 87
		Private Structure ICONDIR
			' Token: 0x04000416 RID: 1046
			Public Reserved As UShort

			' Token: 0x04000417 RID: 1047
			Public Type As UShort

			' Token: 0x04000418 RID: 1048
			Public Count As UShort
		End Structure

		' Token: 0x02000058 RID: 88
		Private Structure ICONDIRENTRY
			' Token: 0x04000419 RID: 1049
			Public Width As Byte

			' Token: 0x0400041A RID: 1050
			Public Height As Byte

			' Token: 0x0400041B RID: 1051
			Public ColorCount As Byte

			' Token: 0x0400041C RID: 1052
			Public Reserved As Byte

			' Token: 0x0400041D RID: 1053
			Public Planes As UShort

			' Token: 0x0400041E RID: 1054
			Public BitCount As UShort

			' Token: 0x0400041F RID: 1055
			Public BytesInRes As Integer

			' Token: 0x04000420 RID: 1056
			Public ImageOffset As Integer
		End Structure

		' Token: 0x02000059 RID: 89
		Private Structure BITMAPINFOHEADER
			' Token: 0x04000421 RID: 1057
			Public Size As UInteger

			' Token: 0x04000422 RID: 1058
			Public Width As Integer

			' Token: 0x04000423 RID: 1059
			Public Height As Integer

			' Token: 0x04000424 RID: 1060
			Public Planes As UShort

			' Token: 0x04000425 RID: 1061
			Public BitCount As UShort

			' Token: 0x04000426 RID: 1062
			Public Compression As UInteger

			' Token: 0x04000427 RID: 1063
			Public SizeImage As UInteger

			' Token: 0x04000428 RID: 1064
			Public XPelsPerMeter As Integer

			' Token: 0x04000429 RID: 1065
			Public YPelsPerMeter As Integer

			' Token: 0x0400042A RID: 1066
			Public ClrUsed As UInteger

			' Token: 0x0400042B RID: 1067
			Public ClrImportant As UInteger
		End Structure

		' Token: 0x0200005A RID: 90
		<StructLayout(LayoutKind.Sequential, Pack := 2)>
		Private Structure GRPICONDIRENTRY
			' Token: 0x0400042C RID: 1068
			Public Width As Byte

			' Token: 0x0400042D RID: 1069
			Public Height As Byte

			' Token: 0x0400042E RID: 1070
			Public ColorCount As Byte

			' Token: 0x0400042F RID: 1071
			Public Reserved As Byte

			' Token: 0x04000430 RID: 1072
			Public Planes As UShort

			' Token: 0x04000431 RID: 1073
			Public BitCount As UShort

			' Token: 0x04000432 RID: 1074
			Public BytesInRes As Integer

			' Token: 0x04000433 RID: 1075
			Public ID As UShort
		End Structure

		' Token: 0x0200005B RID: 91
		Private Class IconFile
			' Token: 0x1700025B RID: 603
			' (get) Token: 0x0600079C RID: 1948 RVA: 0x00043CE4 File Offset: 0x00041EE4
			Public ReadOnly Property ImageCount As Integer
				Get
					Return CInt(Me.iconDir.Count)
				End Get
			End Property

			' Token: 0x1700025C RID: 604
			' (get) Token: 0x0600079D RID: 1949 RVA: 0x00043D00 File Offset: 0x00041F00
			Public ReadOnly Property ImageData(index As Integer) As Byte()
				Get
					Return Me.iconImage(index)
				End Get
			End Property

			' Token: 0x0600079E RID: 1950 RVA: 0x00003CD5 File Offset: 0x00001ED5
			Private Sub New()
				Me.iconDir = Nothing
			End Sub

			' Token: 0x0600079F RID: 1951 RVA: 0x00043D18 File Offset: 0x00041F18
			Public Shared Function FromFile(filename As String) As IconInjector.IconFile
				Dim iconFile As IconInjector.IconFile = New IconInjector.IconFile()
				Dim array As Byte() = File.ReadAllBytes(filename)
				Dim gchandle As GCHandle = GCHandle.Alloc(array, GCHandleType.Pinned)
				iconFile.iconDir = CType(Marshal.PtrToStructure(gchandle.AddrOfPinnedObject(), GetType(IconInjector.ICONDIR)), IconInjector.ICONDIR)
				iconFile.iconEntry = New IconInjector.ICONDIRENTRY(CInt((iconFile.iconDir.Count - 1US + 1US)) - 1) {}
				iconFile.iconImage = New Byte(CInt((iconFile.iconDir.Count - 1US + 1US)) - 1)() {}
				Dim num As Integer = Marshal.SizeOf(iconFile.iconDir)
				Dim typeFromHandle As Type = GetType(IconInjector.ICONDIRENTRY)
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
					Dim icondirentry As IconInjector.ICONDIRENTRY = CType(Marshal.PtrToStructure(ptr, typeFromHandle), IconInjector.ICONDIRENTRY)
					iconFile.iconEntry(num5) = icondirentry
					iconFile.iconImage(num5) = New Byte(icondirentry.BytesInRes - 1 + 1 - 1) {}
					Buffer.BlockCopy(array, icondirentry.ImageOffset, iconFile.iconImage(num5), 0, icondirentry.BytesInRes)
					num += num2
					num5 += 1
				End While
				gchandle.Free()
				Return iconFile
			End Function

			' Token: 0x060007A0 RID: 1952 RVA: 0x00043E70 File Offset: 0x00042070
			Public Function CreateIconGroupData(iconBaseID As UInteger) As Byte()
				Dim num As Integer = Marshal.SizeOf(GetType(IconInjector.ICONDIR)) + Marshal.SizeOf(GetType(IconInjector.GRPICONDIRENTRY)) * Me.ImageCount
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
					Dim grpicondirentry As IconInjector.GRPICONDIRENTRY = Nothing
					Dim bitmapinfoheader As IconInjector.BITMAPINFOHEADER = Nothing
					Dim gchandle2 As GCHandle = GCHandle.Alloc(bitmapinfoheader, GCHandleType.Pinned)
					Marshal.Copy(Me.get_ImageData(num5), 0, gchandle2.AddrOfPinnedObject(), Marshal.SizeOf(GetType(IconInjector.BITMAPINFOHEADER)))
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
					num2 += Marshal.SizeOf(GetType(IconInjector.GRPICONDIRENTRY))
					num5 += 1
				End While
				gchandle.Free()
				Return array
			End Function

			' Token: 0x04000434 RID: 1076
			Private iconDir As IconInjector.ICONDIR

			' Token: 0x04000435 RID: 1077
			Private iconEntry As IconInjector.ICONDIRENTRY()

			' Token: 0x04000436 RID: 1078
			Private iconImage As Byte()()
		End Class
	End Class
End Namespace
