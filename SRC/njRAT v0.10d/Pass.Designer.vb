Namespace NJRAT
	' Token: 0x0200001B RID: 27
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Pass
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000435 RID: 1077 RVA: 0x00027518 File Offset: 0x00025718
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.components IsNot Nothing Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06000436 RID: 1078 RVA: 0x00027558 File Offset: 0x00025758
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.Pass))
			Me.ContextMenuStrip1 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.CopyUseToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CopyPassToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CopySiteToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CopyALLToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SaveAllToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.InClipboardToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.InDiskToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.FindToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RemoveEmptyPWToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SaveFileDialog1 = New Global.System.Windows.Forms.SaveFileDialog()
			Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.ToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.FormSkin1 = New Global.NJRAT.FormSkin()
			Me.FlatGroupBox1 = New Global.NJRAT.FlatGroupBox()
			Me.L1 = New Global.NJRAT.GClass9()
			Me.ColumnHeader1 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader2 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader3 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader4 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader5 = New Global.System.Windows.Forms.ColumnHeader()
			Me.UserImage1 = New Global.NJRAT.UserImage()
			Me.FlatMini2 = New Global.NJRAT.FlatMini()
			Me.FlatButton4 = New Global.NJRAT.FlatButton()
			Me.PictureBox4 = New Global.System.Windows.Forms.PictureBox()
			Me.FlatButton2 = New Global.NJRAT.FlatButton()
			Me.ContextMenuStrip1.SuspendLayout()
			Me.MenuStrip1.SuspendLayout()
			Me.FormSkin1.SuspendLayout()
			Me.FlatGroupBox1.SuspendLayout()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ContextMenuStrip1.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.ContextMenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.CopyUseToolStripMenuItem, Me.CopyPassToolStripMenuItem, Me.CopySiteToolStripMenuItem, Me.CopyALLToolStripMenuItem, Me.SaveAllToolStripMenuItem, Me.FindToolStripMenuItem, Me.RemoveEmptyPWToolStripMenuItem })
			Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
			Me.ContextMenuStrip1.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Me.ContextMenuStrip1.ShowImageMargin = False
			Dim contextMenuStrip As Global.System.Windows.Forms.Control = Me.ContextMenuStrip1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(180, 172)
			contextMenuStrip.Size = size
			Me.CopyUseToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.CopyUseToolStripMenuItem.Name = "CopyUseToolStripMenuItem"
			Dim copyUseToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CopyUseToolStripMenuItem
			size = New Global.System.Drawing.Size(179, 24)
			copyUseToolStripMenuItem.Size = size
			Me.CopyUseToolStripMenuItem.Text = "Copy User"
			Me.CopyPassToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.CopyPassToolStripMenuItem.Name = "CopyPassToolStripMenuItem"
			Dim copyPassToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CopyPassToolStripMenuItem
			size = New Global.System.Drawing.Size(179, 24)
			copyPassToolStripMenuItem.Size = size
			Me.CopyPassToolStripMenuItem.Text = "Copy Pass"
			Me.CopySiteToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.CopySiteToolStripMenuItem.Name = "CopySiteToolStripMenuItem"
			Dim copySiteToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CopySiteToolStripMenuItem
			size = New Global.System.Drawing.Size(179, 24)
			copySiteToolStripMenuItem.Size = size
			Me.CopySiteToolStripMenuItem.Text = "Copy Site"
			Me.CopyALLToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.CopyALLToolStripMenuItem.Name = "CopyALLToolStripMenuItem"
			Dim copyALLToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CopyALLToolStripMenuItem
			size = New Global.System.Drawing.Size(179, 24)
			copyALLToolStripMenuItem.Size = size
			Me.CopyALLToolStripMenuItem.Text = "Copy ALL"
			Me.SaveAllToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.InClipboardToolStripMenuItem, Me.InDiskToolStripMenuItem })
			Me.SaveAllToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem"
			Dim saveAllToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SaveAllToolStripMenuItem
			size = New Global.System.Drawing.Size(179, 24)
			saveAllToolStripMenuItem.Size = size
			Me.SaveAllToolStripMenuItem.Text = "Save All"
			Me.InClipboardToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.InClipboardToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.InClipboardToolStripMenuItem.Name = "InClipboardToolStripMenuItem"
			Dim inClipboardToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.InClipboardToolStripMenuItem
			size = New Global.System.Drawing.Size(160, 24)
			inClipboardToolStripMenuItem.Size = size
			Me.InClipboardToolStripMenuItem.Text = "in Clipboard"
			Me.InDiskToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.InDiskToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.InDiskToolStripMenuItem.Name = "InDiskToolStripMenuItem"
			Dim inDiskToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.InDiskToolStripMenuItem
			size = New Global.System.Drawing.Size(160, 24)
			inDiskToolStripMenuItem.Size = size
			Me.InDiskToolStripMenuItem.Text = "in Disk"
			Me.FindToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
			Dim findToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.FindToolStripMenuItem
			size = New Global.System.Drawing.Size(179, 24)
			findToolStripMenuItem.Size = size
			Me.FindToolStripMenuItem.Text = "Find"
			Me.RemoveEmptyPWToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.RemoveEmptyPWToolStripMenuItem.Name = "RemoveEmptyPWToolStripMenuItem"
			Dim removeEmptyPWToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.RemoveEmptyPWToolStripMenuItem
			size = New Global.System.Drawing.Size(179, 24)
			removeEmptyPWToolStripMenuItem.Size = size
			Me.RemoveEmptyPWToolStripMenuItem.Text = "Remove Empty PW"
			Me.SaveFileDialog1.FileName = "Pass.txt"
			Me.SaveFileDialog1.Filter = "Text|.txt"
			Me.ImageList1.ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList1.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.ImageList1.Images.SetKeyName(0, "1.bmp")
			Me.ImageList1.Images.SetKeyName(1, "2.bmp")
			Me.ImageList1.Images.SetKeyName(2, "3.bmp")
			Me.ImageList1.Images.SetKeyName(3, "4.bmp")
			Me.ImageList1.Images.SetKeyName(4, "5.bmp")
			Me.ImageList1.Images.SetKeyName(5, "6.bmp")
			Me.ImageList1.Images.SetKeyName(6, "7.bmp")
			Me.ImageList1.Images.SetKeyName(7, "8.bmp")
			Me.ImageList1.Images.SetKeyName(8, "9.bmp")
			Me.ImageList1.Images.SetKeyName(9, "10.bmp")
			Me.ImageList1.Images.SetKeyName(10, "11.bmp")
			Me.ImageList1.Images.SetKeyName(11, "12.bmp")
			Me.ImageList1.Images.SetKeyName(12, "13.bmp")
			Me.MenuStrip1.BackColor = Global.System.Drawing.Color.Black
			Me.MenuStrip1.Dock = Global.System.Windows.Forms.DockStyle.None
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ToolStripMenuItem1 })
			Dim menuStrip As Global.System.Windows.Forms.Control = Me.MenuStrip1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(71, 265)
			menuStrip.Location = location
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim menuStrip2 As Global.System.Windows.Forms.Control = Me.MenuStrip1
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(7, 2, 0, 2)
			menuStrip2.Padding = padding
			Dim menuStrip3 As Global.System.Windows.Forms.Control = Me.MenuStrip1
			size = New Global.System.Drawing.Size(105, 24)
			menuStrip3.Size = size
			Me.MenuStrip1.TabIndex = 1
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.ToolStripMenuItem1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.Yellow
			Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
			Dim toolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripMenuItem1
			size = New Global.System.Drawing.Size(96, 20)
			toolStripMenuItem.Size = size
			Me.ToolStripMenuItem1.Text = "Passwords"
			Me.FormSkin1.BackColor = Global.System.Drawing.Color.White
			Me.FormSkin1.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FormSkin1.BorderColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FormSkin1.BorderSize = 10
			Me.FormSkin1.Controls.Add(Me.FlatGroupBox1)
			Me.FormSkin1.Controls.Add(Me.UserImage1)
			Me.FormSkin1.Controls.Add(Me.FlatMini2)
			Me.FormSkin1.Controls.Add(Me.FlatButton4)
			Me.FormSkin1.Controls.Add(Me.PictureBox4)
			Me.FormSkin1.Controls.Add(Me.FlatButton2)
			Me.FormSkin1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.FormSkin1.FlatColor = Global.System.Drawing.Color.FromArgb(35, 168, 109)
			Me.FormSkin1.Font = New Global.System.Drawing.Font("Segoe UI", 12F)
			Me.FormSkin1.HeaderColor = Global.System.Drawing.Color.FromArgb(50, 50, 50)
			Me.FormSkin1.HeaderMaximize = False
			Dim formSkin As Global.System.Windows.Forms.Control = Me.FormSkin1
			location = New Global.System.Drawing.Point(0, 0)
			formSkin.Location = location
			Me.FormSkin1.Name = "FormSkin1"
			Dim formSkin2 As Global.System.Windows.Forms.Control = Me.FormSkin1
			size = New Global.System.Drawing.Size(902, 533)
			formSkin2.Size = size
			Me.FormSkin1.TabIndex = 2
			Me.FormSkin1.Text = "Passwords"
			Me.FlatGroupBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatGroupBox1.BaseColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.FlatGroupBox1.Controls.Add(Me.L1)
			Me.FlatGroupBox1.Font = New Global.System.Drawing.Font("Segoe UI", 10F)
			Dim flatGroupBox As Global.System.Windows.Forms.Control = Me.FlatGroupBox1
			location = New Global.System.Drawing.Point(179, 62)
			flatGroupBox.Location = location
			Me.FlatGroupBox1.Name = "FlatGroupBox1"
			Me.FlatGroupBox1.ShowText = True
			Dim flatGroupBox2 As Global.System.Windows.Forms.Control = Me.FlatGroupBox1
			size = New Global.System.Drawing.Size(711, 459)
			flatGroupBox2.Size = size
			Me.FlatGroupBox1.TabIndex = 89
			Me.FlatGroupBox1.Text = "FlatGroupBox1"
			Me.L1.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.L1.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5 })
			Me.L1.ContextMenuStrip = Me.ContextMenuStrip1
			Me.L1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.L1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.L1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.L1.FullRowSelect = True
			Me.L1.HideSelection = False
			Dim l As Global.System.Windows.Forms.Control = Me.L1
			location = New Global.System.Drawing.Point(0, 0)
			l.Location = location
			Dim l2 As Global.System.Windows.Forms.Control = Me.L1
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			l2.Margin = padding
			Me.L1.Name = "L1"
			Me.L1.OwnerDraw = True
			Dim l3 As Global.System.Windows.Forms.Control = Me.L1
			size = New Global.System.Drawing.Size(711, 459)
			l3.Size = size
			Me.L1.SmallImageList = Me.ImageList1
			Me.L1.TabIndex = 4
			Me.L1.UseCompatibleStateImageBehavior = False
			Me.L1.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader1.Text = "UserName"
			Me.ColumnHeader1.Width = 115
			Me.ColumnHeader2.Text = "Password"
			Me.ColumnHeader2.Width = 93
			Me.ColumnHeader3.Text = "URL"
			Me.ColumnHeader3.Width = 93
			Me.ColumnHeader4.Text = "App"
			Me.ColumnHeader4.Width = 95
			Me.ColumnHeader5.Text = "User"
			Me.ColumnHeader5.Width = 311
			Me.UserImage1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UserImage1.BorderSize = 2
			Me.UserImage1.ColorActivityStatus = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.ColorBorder = Global.System.Drawing.Color.FromArgb(190, 190, 190)
			Me.UserImage1.ColorProgress = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.EnableHover = False
			Dim userImage As Global.System.Windows.Forms.Control = Me.UserImage1
			location = New Global.System.Drawing.Point(27, 63)
			userImage.Location = location
			Me.UserImage1.Maximum = 100
			Me.UserImage1.Name = "UserImage1"
			Me.UserImage1.RotationAngle = 310
			Me.UserImage1.ShowActivityStatus = True
			Me.UserImage1.ShowBorder = False
			Me.UserImage1.ShowImage = True
			Me.UserImage1.ShowProgress = True
			Dim userImage2 As Global.System.Windows.Forms.Control = Me.UserImage1
			size = New Global.System.Drawing.Size(125, 125)
			userImage2.Size = size
			Me.UserImage1.StartingAngle = 70
			Me.UserImage1.TabIndex = 88
			Me.UserImage1.Text = "UserImage1"
			Me.UserImage1.UImage = CType(componentResourceManager.GetObject("UserImage1.UImage"), Global.System.Drawing.Image)
			Me.UserImage1.Value = 50
			Me.FlatMini2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FlatMini2.BackColor = Global.System.Drawing.Color.White
			Me.FlatMini2.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FlatMini2.Font = New Global.System.Drawing.Font("Marlett", 12F)
			Dim flatMini As Global.System.Windows.Forms.Control = Me.FlatMini2
			location = New Global.System.Drawing.Point(872, 12)
			flatMini.Location = location
			Me.FlatMini2.Name = "FlatMini2"
			Dim flatMini2 As Global.System.Windows.Forms.Control = Me.FlatMini2
			size = New Global.System.Drawing.Size(18, 18)
			flatMini2.Size = size
			Me.FlatMini2.TabIndex = 87
			Me.FlatMini2.Text = "FlatMini2"
			Me.FlatMini2.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FlatButton4.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatButton4.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FlatButton4.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FlatButton4.Font = New Global.System.Drawing.Font("Segoe UI", 10.8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim flatButton As Global.System.Windows.Forms.Control = Me.FlatButton4
			location = New Global.System.Drawing.Point(88, 474)
			flatButton.Location = location
			Me.FlatButton4.Name = "FlatButton4"
			Me.FlatButton4.Rounded = False
			Dim flatButton2 As Global.System.Windows.Forms.Control = Me.FlatButton4
			size = New Global.System.Drawing.Size(88, 47)
			flatButton2.Size = size
			Me.FlatButton4.TabIndex = 86
			Me.FlatButton4.Text = "Exit"
			Me.FlatButton4.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.PictureBox4.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox4.Image = CType(componentResourceManager.GetObject("PictureBox4.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox4
			location = New Global.System.Drawing.Point(12, 474)
			pictureBox.Location = location
			Me.PictureBox4.Name = "PictureBox4"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox4
			size = New Global.System.Drawing.Size(52, 47)
			pictureBox2.Size = size
			Me.PictureBox4.TabIndex = 85
			Me.PictureBox4.TabStop = False
			Me.FlatButton2.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatButton2.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FlatButton2.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FlatButton2.Font = New Global.System.Drawing.Font("Segoe UI", 10.8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim flatButton3 As Global.System.Windows.Forms.Control = Me.FlatButton2
			location = New Global.System.Drawing.Point(193, 21)
			flatButton3.Location = location
			Me.FlatButton2.Name = "FlatButton2"
			Me.FlatButton2.Rounded = False
			Dim flatButton4 As Global.System.Windows.Forms.Control = Me.FlatButton2
			size = New Global.System.Drawing.Size(139, 35)
			flatButton4.Size = size
			Me.FlatButton2.TabIndex = 84
			Me.FlatButton2.Text = "Passwords"
			Me.FlatButton2.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(902, 533)
			Me.ClientSize = size
			Me.Controls.Add(Me.FormSkin1)
			Me.Controls.Add(Me.MenuStrip1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.MainMenuStrip = Me.MenuStrip1
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Margin = padding
			Me.Name = "Pass"
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Pass"
			Me.TransparencyKey = Global.System.Drawing.Color.Fuchsia
			Me.ContextMenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.FormSkin1.ResumeLayout(False)
			Me.FlatGroupBox1.ResumeLayout(False)
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040001F1 RID: 497
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
