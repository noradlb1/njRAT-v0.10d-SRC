Namespace NJRAT
	' Token: 0x0200000D RID: 13
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class DW
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060001A7 RID: 423 RVA: 0x000108F4 File Offset: 0x0000EAF4
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

		' Token: 0x060001A8 RID: 424 RVA: 0x00010934 File Offset: 0x0000EB34
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim listViewItem As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("File")
			Dim listViewItem2 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Size")
			Dim listViewItem3 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Speed")
			Dim listViewItem4 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Downloaded")
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.FormSkin1 = New Global.NJRAT.FormSkin()
			Me.FlatGroupBox1 = New Global.NJRAT.FlatGroupBox()
			Me.Lv1 = New Global.NJRAT.GClass9()
			Me.ColumnHeader1 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader2 = New Global.System.Windows.Forms.ColumnHeader()
			Me.FlatButton2 = New Global.NJRAT.FlatButton()
			Me.FlatMini1 = New Global.NJRAT.FlatMini()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.FormSkin1.SuspendLayout()
			Me.FlatGroupBox1.SuspendLayout()
			Me.SuspendLayout()
			Me.Timer1.Interval = 1000
			Me.FormSkin1.BackColor = Global.System.Drawing.Color.White
			Me.FormSkin1.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FormSkin1.BorderColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FormSkin1.BorderSize = 10
			Me.FormSkin1.Controls.Add(Me.FlatGroupBox1)
			Me.FormSkin1.Controls.Add(Me.FlatButton2)
			Me.FormSkin1.Controls.Add(Me.FlatMini1)
			Me.FormSkin1.Controls.Add(Me.Button1)
			Me.FormSkin1.Controls.Add(Me.ProgressBar1)
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
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(763, 199)
			formSkin2.Size = size
			Me.FormSkin1.TabIndex = 0
			Me.FormSkin1.Text = "DW"
			Me.FlatGroupBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatGroupBox1.BaseColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FlatGroupBox1.Controls.Add(Me.Lv1)
			Me.FlatGroupBox1.Font = New Global.System.Drawing.Font("Segoe UI", 10F)
			Dim flatGroupBox As Global.System.Windows.Forms.Control = Me.FlatGroupBox1
			location = New Global.System.Drawing.Point(12, 48)
			flatGroupBox.Location = location
			Me.FlatGroupBox1.Name = "FlatGroupBox1"
			Me.FlatGroupBox1.ShowText = True
			Dim flatGroupBox2 As Global.System.Windows.Forms.Control = Me.FlatGroupBox1
			size = New Global.System.Drawing.Size(666, 138)
			flatGroupBox2.Size = size
			Me.FlatGroupBox1.TabIndex = 69
			Me.Lv1.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.Lv1.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader1, Me.ColumnHeader2 })
			Me.Lv1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.Lv1.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Lv1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.Lv1.FullRowSelect = True
			Me.Lv1.GridLines = True
			Me.Lv1.HeaderStyle = Global.System.Windows.Forms.ColumnHeaderStyle.None
			Me.Lv1.HideSelection = False
			Me.Lv1.Items.AddRange(New Global.System.Windows.Forms.ListViewItem() { listViewItem, listViewItem2, listViewItem3, listViewItem4 })
			Dim lv As Global.System.Windows.Forms.Control = Me.Lv1
			location = New Global.System.Drawing.Point(0, 0)
			lv.Location = location
			Dim lv2 As Global.System.Windows.Forms.Control = Me.Lv1
			Dim margin As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			lv2.Margin = margin
			Me.Lv1.Name = "Lv1"
			Me.Lv1.OwnerDraw = True
			Dim lv3 As Global.System.Windows.Forms.Control = Me.Lv1
			size = New Global.System.Drawing.Size(666, 138)
			lv3.Size = size
			Me.Lv1.TabIndex = 5
			Me.Lv1.UseCompatibleStateImageBehavior = False
			Me.Lv1.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader1.Width = 109
			Me.ColumnHeader2.Width = 553
			Me.FlatButton2.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatButton2.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FlatButton2.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FlatButton2.Font = New Global.System.Drawing.Font("Segoe UI", 10.8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim flatButton As Global.System.Windows.Forms.Control = Me.FlatButton2
			location = New Global.System.Drawing.Point(706, 11)
			flatButton.Location = location
			Me.FlatButton2.Name = "FlatButton2"
			Me.FlatButton2.Rounded = False
			Dim flatButton2 As Global.System.Windows.Forms.Control = Me.FlatButton2
			size = New Global.System.Drawing.Size(45, 35)
			flatButton2.Size = size
			Me.FlatButton2.TabIndex = 68
			Me.FlatButton2.Text = "Exit"
			Me.FlatButton2.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FlatMini1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FlatMini1.BackColor = Global.System.Drawing.Color.White
			Me.FlatMini1.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FlatMini1.Font = New Global.System.Drawing.Font("Marlett", 12F)
			Dim flatMini As Global.System.Windows.Forms.Control = Me.FlatMini1
			location = New Global.System.Drawing.Point(682, 22)
			flatMini.Location = location
			Me.FlatMini1.Name = "FlatMini1"
			Dim flatMini2 As Global.System.Windows.Forms.Control = Me.FlatMini1
			size = New Global.System.Drawing.Size(18, 18)
			flatMini2.Size = size
			Me.FlatMini1.TabIndex = 66
			Me.FlatMini1.Text = "FlatMini1"
			Me.FlatMini1.TextColor = Global.System.Drawing.Color.FromArgb(243, 243, 243)
			Me.Button1.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(682, 48)
			button.Location = location
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			button2.Margin = margin
			Me.Button1.Name = "Button1"
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(69, 138)
			button3.Size = size
			Me.Button1.TabIndex = 5
			Me.Button1.Text = "Stop"
			Me.Button1.UseVisualStyleBackColor = False
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			location = New Global.System.Drawing.Point(22, 264)
			progressBar.Location = location
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			progressBar2.Margin = margin
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar3 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			size = New Global.System.Drawing.Size(637, 28)
			progressBar3.Size = size
			Me.ProgressBar1.TabIndex = 3
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(763, 199)
			Me.ClientSize = size
			Me.Controls.Add(Me.FormSkin1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Margin = margin
			Me.MaximizeBox = False
			Me.Name = "DW"
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "DW"
			Me.TransparencyKey = Global.System.Drawing.Color.Fuchsia
			Me.FormSkin1.ResumeLayout(False)
			Me.FlatGroupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x040000BA RID: 186
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
