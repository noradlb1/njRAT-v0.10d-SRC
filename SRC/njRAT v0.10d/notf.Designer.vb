Namespace NJRAT
	' Token: 0x02000019 RID: 25
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class notf
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000424 RID: 1060 RVA: 0x00026AF0 File Offset: 0x00024CF0
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

		' Token: 0x06000425 RID: 1061 RVA: 0x00026B30 File Offset: 0x00024D30
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.FormSkin1 = New Global.NJRAT.FormSkin()
			Me.p = New Global.System.Windows.Forms.PictureBox()
			Me.FormSkin1.SuspendLayout()
			CType(Me.p, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.FormSkin1.BackColor = Global.System.Drawing.Color.White
			Me.FormSkin1.BaseColor = Global.System.Drawing.Color.FromArgb(50, 50, 50)
			Me.FormSkin1.BorderColor = Global.System.Drawing.Color.FromArgb(0, 170, 220)
			Me.FormSkin1.BorderSize = 5
			Me.FormSkin1.Controls.Add(Me.p)
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
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(364, 191)
			formSkin2.Size = size
			Me.FormSkin1.TabIndex = 0
			Me.FormSkin1.Text = "FormSkin1"
			Me.p.BackColor = Global.System.Drawing.Color.DarkSlateBlue
			Me.p.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.p.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim p As Global.System.Windows.Forms.Control = Me.p
			location = New Global.System.Drawing.Point(0, 0)
			p.Location = location
			Dim p2 As Global.System.Windows.Forms.Control = Me.p
			Dim margin As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			p2.Margin = margin
			Me.p.Name = "p"
			Dim p3 As Global.System.Windows.Forms.Control = Me.p
			size = New Global.System.Drawing.Size(364, 191)
			p3.Size = size
			Me.p.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.p.TabIndex = 1
			Me.p.TabStop = False
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(364, 191)
			Me.ClientSize = size
			Me.Controls.Add(Me.FormSkin1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Margin = margin
			Me.Name = "notf"
			Me.Opacity = 0.8
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "notf"
			Me.TopMost = True
			Me.TransparencyKey = Global.System.Drawing.Color.Fuchsia
			Me.FormSkin1.ResumeLayout(False)
			CType(Me.p, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x040001E7 RID: 487
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
