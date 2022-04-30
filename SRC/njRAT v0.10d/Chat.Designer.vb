Namespace NJRAT
	' Token: 0x0200000C RID: 12
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Chat
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600017C RID: 380 RVA: 0x0000F14C File Offset: 0x0000D34C
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

		' Token: 0x0600017D RID: 381 RVA: 0x0000F18C File Offset: 0x0000D38C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.Chat))
			Me.vmethod_8 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.FormSkin1 = New Global.NJRAT.FormSkin()
			Me.FlatButton2 = New Global.NJRAT.FlatButton()
			Me.PictureBox2 = New Global.System.Windows.Forms.PictureBox()
			Me.FlatMini1 = New Global.NJRAT.FlatMini()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.UserImage2 = New Global.NJRAT.UserImage()
			Me.UserImage1 = New Global.NJRAT.UserImage()
			Me.T2 = New Global.System.Windows.Forms.TextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.T1 = New Global.System.Windows.Forms.RichTextBox()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.FormSkin1.SuspendLayout()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.FormSkin1.BackColor = Global.System.Drawing.Color.White
			Me.FormSkin1.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FormSkin1.BorderColor = Global.System.Drawing.Color.FromArgb(0, 170, 220)
			Me.FormSkin1.BorderSize = 5
			Me.FormSkin1.Controls.Add(Me.FlatButton2)
			Me.FormSkin1.Controls.Add(Me.PictureBox2)
			Me.FormSkin1.Controls.Add(Me.FlatMini1)
			Me.FormSkin1.Controls.Add(Me.Label4)
			Me.FormSkin1.Controls.Add(Me.Label3)
			Me.FormSkin1.Controls.Add(Me.Label2)
			Me.FormSkin1.Controls.Add(Me.Label1)
			Me.FormSkin1.Controls.Add(Me.UserImage2)
			Me.FormSkin1.Controls.Add(Me.UserImage1)
			Me.FormSkin1.Controls.Add(Me.T2)
			Me.FormSkin1.Controls.Add(Me.Button1)
			Me.FormSkin1.Controls.Add(Me.T1)
			Me.FormSkin1.Controls.Add(Me.Panel1)
			Me.FormSkin1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.FormSkin1.FlatColor = Global.System.Drawing.Color.FromArgb(35, 168, 109)
			Me.FormSkin1.Font = New Global.System.Drawing.Font("Segoe UI", 12F)
			Me.FormSkin1.HeaderColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FormSkin1.HeaderMaximize = False
			Dim formSkin As Global.System.Windows.Forms.Control = Me.FormSkin1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			formSkin.Location = location
			Me.FormSkin1.Name = "FormSkin1"
			Dim formSkin2 As Global.System.Windows.Forms.Control = Me.FormSkin1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(511, 703)
			formSkin2.Size = size
			Me.FormSkin1.TabIndex = 0
			Me.FormSkin1.Text = "Chat"
			Me.FlatButton2.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatButton2.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FlatButton2.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FlatButton2.Font = New Global.System.Drawing.Font("Segoe UI", 10.8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim flatButton As Global.System.Windows.Forms.Control = Me.FlatButton2
			location = New Global.System.Drawing.Point(364, 136)
			flatButton.Location = location
			Me.FlatButton2.Name = "FlatButton2"
			Me.FlatButton2.Rounded = False
			Dim flatButton2 As Global.System.Windows.Forms.Control = Me.FlatButton2
			size = New Global.System.Drawing.Size(135, 47)
			flatButton2.Size = size
			Me.FlatButton2.TabIndex = 65
			Me.FlatButton2.Text = "Exit"
			Me.FlatButton2.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.PictureBox2.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox2.Image = CType(componentResourceManager.GetObject("PictureBox2.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox2
			location = New Global.System.Drawing.Point(306, 136)
			pictureBox.Location = location
			Me.PictureBox2.Name = "PictureBox2"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox2
			size = New Global.System.Drawing.Size(52, 47)
			pictureBox2.Size = size
			Me.PictureBox2.TabIndex = 64
			Me.PictureBox2.TabStop = False
			Me.FlatMini1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FlatMini1.BackColor = Global.System.Drawing.Color.White
			Me.FlatMini1.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FlatMini1.Font = New Global.System.Drawing.Font("Marlett", 12F)
			Dim flatMini As Global.System.Windows.Forms.Control = Me.FlatMini1
			location = New Global.System.Drawing.Point(481, 12)
			flatMini.Location = location
			Me.FlatMini1.Name = "FlatMini1"
			Dim flatMini2 As Global.System.Windows.Forms.Control = Me.FlatMini1
			size = New Global.System.Drawing.Size(18, 18)
			flatMini2.Size = size
			Me.FlatMini1.TabIndex = 63
			Me.FlatMini1.Text = "FlatMini1"
			Me.FlatMini1.TextColor = Global.System.Drawing.Color.FromArgb(243, 243, 243)
			Me.Label4.AutoSize = True
			Me.Label4.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label4.Font = New Global.System.Drawing.Font("Segoe UI", 10.2F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim label As Global.System.Windows.Forms.Control = Me.Label4
			location = New Global.System.Drawing.Point(153, 118)
			label.Location = location
			Me.Label4.Name = "Label4"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(38, 23)
			label2.Size = size
			Me.Label4.TabIndex = 9
			Me.Label4.Text = "You"
			Me.Label3.AutoSize = True
			Me.Label3.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label3.Font = New Global.System.Drawing.Font("Segoe UI", 10.2F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label3
			location = New Global.System.Drawing.Point(163, 584)
			label3.Location = location
			Me.Label3.Name = "Label3"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(34, 23)
			label4.Size = size
			Me.Label3.TabIndex = 8
			Me.Label3.Text = "Me"
			Me.Label2.AutoSize = True
			Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label2.Font = New Global.System.Drawing.Font("Segoe UI", 10.2F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(153, 155)
			label5.Location = location
			Me.Label2.Name = "Label2"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(82, 23)
			label6.Size = size
			Me.Label2.TabIndex = 7
			Me.Label2.Text = "writing....."
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label1.Font = New Global.System.Drawing.Font("Segoe UI", 10.2F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(163, 620)
			label7.Location = location
			Me.Label1.Name = "Label1"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(82, 23)
			label8.Size = size
			Me.Label1.TabIndex = 6
			Me.Label1.Text = "writing....."
			Me.UserImage2.BackColor = Global.System.Drawing.Color.Transparent
			Me.UserImage2.BorderSize = 2
			Me.UserImage2.ColorActivityStatus = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage2.ColorBorder = Global.System.Drawing.Color.FromArgb(190, 190, 190)
			Me.UserImage2.ColorProgress = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage2.EnableHover = False
			Dim userImage As Global.System.Windows.Forms.Control = Me.UserImage2
			location = New Global.System.Drawing.Point(22, 53)
			userImage.Location = location
			Me.UserImage2.Maximum = 100
			Me.UserImage2.Name = "UserImage2"
			Me.UserImage2.RotationAngle = 310
			Me.UserImage2.ShowActivityStatus = True
			Me.UserImage2.ShowBorder = False
			Me.UserImage2.ShowImage = True
			Me.UserImage2.ShowProgress = True
			Dim userImage2 As Global.System.Windows.Forms.Control = Me.UserImage2
			size = New Global.System.Drawing.Size(125, 125)
			userImage2.Size = size
			Me.UserImage2.StartingAngle = 70
			Me.UserImage2.TabIndex = 5
			Me.UserImage2.Text = "UserImage2"
			Me.UserImage2.UImage = CType(componentResourceManager.GetObject("UserImage2.UImage"), Global.System.Drawing.Image)
			Me.UserImage2.Value = 50
			Me.UserImage1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UserImage1.BorderSize = 2
			Me.UserImage1.ColorActivityStatus = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.ColorBorder = Global.System.Drawing.Color.FromArgb(190, 190, 190)
			Me.UserImage1.ColorProgress = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.EnableHover = False
			Dim userImage3 As Global.System.Windows.Forms.Control = Me.UserImage1
			location = New Global.System.Drawing.Point(22, 523)
			userImage3.Location = location
			Me.UserImage1.Maximum = 100
			Me.UserImage1.Name = "UserImage1"
			Me.UserImage1.RotationAngle = 310
			Me.UserImage1.ShowActivityStatus = True
			Me.UserImage1.ShowBorder = False
			Me.UserImage1.ShowImage = True
			Me.UserImage1.ShowProgress = True
			Dim userImage4 As Global.System.Windows.Forms.Control = Me.UserImage1
			size = New Global.System.Drawing.Size(125, 125)
			userImage4.Size = size
			Me.UserImage1.StartingAngle = 70
			Me.UserImage1.TabIndex = 4
			Me.UserImage1.Text = "UserImage1"
			Me.UserImage1.UImage = CType(componentResourceManager.GetObject("UserImage1.UImage"), Global.System.Drawing.Image)
			Me.UserImage1.Value = 50
			Me.T2.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.T2.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim t As Global.System.Windows.Forms.Control = Me.T2
			location = New Global.System.Drawing.Point(12, 655)
			t.Location = location
			Dim t2 As Global.System.Windows.Forms.Control = Me.T2
			Dim margin As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			t2.Margin = margin
			Me.T2.Multiline = True
			Me.T2.Name = "T2"
			Dim t3 As Global.System.Windows.Forms.Control = Me.T2
			size = New Global.System.Drawing.Size(377, 35)
			t3.Size = size
			Me.T2.TabIndex = 0
			Me.Button1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(395, 654)
			button.Location = location
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			button2.Margin = margin
			Me.Button1.Name = "Button1"
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(94, 36)
			button3.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Send"
			Me.Button1.UseVisualStyleBackColor = False
			Me.T1.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.T1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim t4 As Global.System.Windows.Forms.Control = Me.T1
			location = New Global.System.Drawing.Point(22, 190)
			t4.Location = location
			Dim t5 As Global.System.Windows.Forms.Control = Me.T1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			t5.Margin = margin
			Me.T1.Name = "T1"
			Dim t6 As Global.System.Windows.Forms.Control = Me.T1
			size = New Global.System.Drawing.Size(467, 322)
			t6.Size = size
			Me.T1.TabIndex = 3
			Me.T1.Text = ""
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			location = New Global.System.Drawing.Point(875, 379)
			panel.Location = location
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			panel2.Margin = margin
			Me.Panel1.Name = "Panel1"
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(10, 36)
			panel3.Size = size
			Me.Panel1.TabIndex = 2
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(511, 703)
			Me.ClientSize = size
			Me.Controls.Add(Me.FormSkin1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Margin = margin
			Me.Name = "Chat"
			Me.Opacity = 0.9
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Chat"
			Me.TransparencyKey = Global.System.Drawing.Color.Fuchsia
			Me.FormSkin1.ResumeLayout(False)
			Me.FormSkin1.PerformLayout()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x040000A6 RID: 166
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
