Namespace NJRAT
	' Token: 0x02000018 RID: 24
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Note
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600040D RID: 1037 RVA: 0x00025F80 File Offset: 0x00024180
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

		' Token: 0x0600040E RID: 1038 RVA: 0x00025FC0 File Offset: 0x000241C0
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.Note))
			Me.FormSkin1 = New Global.NJRAT.FormSkin()
			Me.UserImage1 = New Global.NJRAT.UserImage()
			Me.FlatMini2 = New Global.NJRAT.FlatMini()
			Me.FlatButton4 = New Global.NJRAT.FlatButton()
			Me.PictureBox4 = New Global.System.Windows.Forms.PictureBox()
			Me.FlatButton2 = New Global.NJRAT.FlatButton()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.FormSkin1.SuspendLayout()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.FormSkin1.BackColor = Global.System.Drawing.Color.White
			Me.FormSkin1.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FormSkin1.BorderColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FormSkin1.BorderSize = 10
			Me.FormSkin1.Controls.Add(Me.UserImage1)
			Me.FormSkin1.Controls.Add(Me.FlatMini2)
			Me.FormSkin1.Controls.Add(Me.FlatButton4)
			Me.FormSkin1.Controls.Add(Me.PictureBox4)
			Me.FormSkin1.Controls.Add(Me.FlatButton2)
			Me.FormSkin1.Controls.Add(Me.TextBox1)
			Me.FormSkin1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.FormSkin1.FlatColor = Global.System.Drawing.Color.FromArgb(35, 168, 109)
			Me.FormSkin1.Font = New Global.System.Drawing.Font("Segoe UI", 12F)
			Me.FormSkin1.HeaderColor = Global.System.Drawing.Color.FromArgb(50, 50, 50)
			Me.FormSkin1.HeaderMaximize = False
			Dim formSkin As Global.System.Windows.Forms.Control = Me.FormSkin1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			formSkin.Location = location
			Me.FormSkin1.Name = "FormSkin1"
			Dim formSkin2 As Global.System.Windows.Forms.Control = Me.FormSkin1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(809, 472)
			formSkin2.Size = size
			Me.FormSkin1.TabIndex = 1
			Me.FormSkin1.Text = "Note"
			Me.UserImage1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UserImage1.BorderSize = 2
			Me.UserImage1.ColorActivityStatus = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.ColorBorder = Global.System.Drawing.Color.FromArgb(190, 190, 190)
			Me.UserImage1.ColorProgress = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.EnableHover = False
			Dim userImage As Global.System.Windows.Forms.Control = Me.UserImage1
			location = New Global.System.Drawing.Point(16, 64)
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
			Me.UserImage1.TabIndex = 83
			Me.UserImage1.Text = "UserImage1"
			Me.UserImage1.UImage = CType(componentResourceManager.GetObject("UserImage1.UImage"), Global.System.Drawing.Image)
			Me.UserImage1.Value = 50
			Me.FlatMini2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FlatMini2.BackColor = Global.System.Drawing.Color.White
			Me.FlatMini2.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FlatMini2.Font = New Global.System.Drawing.Font("Marlett", 12F)
			Dim flatMini As Global.System.Windows.Forms.Control = Me.FlatMini2
			location = New Global.System.Drawing.Point(779, 12)
			flatMini.Location = location
			Me.FlatMini2.Name = "FlatMini2"
			Dim flatMini2 As Global.System.Windows.Forms.Control = Me.FlatMini2
			size = New Global.System.Drawing.Size(18, 18)
			flatMini2.Size = size
			Me.FlatMini2.TabIndex = 82
			Me.FlatMini2.Text = "FlatMini2"
			Me.FlatMini2.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FlatButton4.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatButton4.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FlatButton4.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FlatButton4.Font = New Global.System.Drawing.Font("Segoe UI", 10.8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim flatButton As Global.System.Windows.Forms.Control = Me.FlatButton4
			location = New Global.System.Drawing.Point(65, 408)
			flatButton.Location = location
			Me.FlatButton4.Name = "FlatButton4"
			Me.FlatButton4.Rounded = False
			Dim flatButton2 As Global.System.Windows.Forms.Control = Me.FlatButton4
			size = New Global.System.Drawing.Size(88, 47)
			flatButton2.Size = size
			Me.FlatButton4.TabIndex = 81
			Me.FlatButton4.Text = "Exit"
			Me.FlatButton4.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.PictureBox4.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox4.Image = CType(componentResourceManager.GetObject("PictureBox4.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox4
			location = New Global.System.Drawing.Point(7, 408)
			pictureBox.Location = location
			Me.PictureBox4.Name = "PictureBox4"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox4
			size = New Global.System.Drawing.Size(52, 47)
			pictureBox2.Size = size
			Me.PictureBox4.TabIndex = 80
			Me.PictureBox4.TabStop = False
			Me.FlatButton2.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatButton2.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FlatButton2.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FlatButton2.Font = New Global.System.Drawing.Font("Segoe UI", 10.8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim flatButton3 As Global.System.Windows.Forms.Control = Me.FlatButton2
			location = New Global.System.Drawing.Point(167, 22)
			flatButton3.Location = location
			Me.FlatButton2.Name = "FlatButton2"
			Me.FlatButton2.Rounded = False
			Dim flatButton4 As Global.System.Windows.Forms.Control = Me.FlatButton2
			size = New Global.System.Drawing.Size(139, 35)
			flatButton4.Size = size
			Me.FlatButton2.TabIndex = 73
			Me.FlatButton2.Text = "Save Changes"
			Me.FlatButton2.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.TextBox1.BackColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.TextBox1.Font = New Global.System.Drawing.Font("Segoe UI", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(157, 64)
			textBox.Location = location
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			Dim margin As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			textBox2.Margin = margin
			Me.TextBox1.Multiline = True
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.ScrollBars = Global.System.Windows.Forms.ScrollBars.Both
			Dim textBox3 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(640, 391)
			textBox3.Size = size
			Me.TextBox1.TabIndex = 2
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(809, 472)
			Me.ClientSize = size
			Me.Controls.Add(Me.FormSkin1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Margin = margin
			Me.Name = "Note"
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Note"
			Me.TransparencyKey = Global.System.Drawing.Color.Fuchsia
			Me.FormSkin1.ResumeLayout(False)
			Me.FormSkin1.PerformLayout()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x040001DC RID: 476
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
