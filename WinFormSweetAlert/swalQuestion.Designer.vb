<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class swalQuestion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(swalQuestion))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaYes = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.GunaNo = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lblSubQuestion = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaYes
        '
        Me.GunaYes.AnimationHoverSpeed = 0.07!
        Me.GunaYes.AnimationSpeed = 0.03!
        Me.GunaYes.BackColor = System.Drawing.Color.Transparent
        Me.GunaYes.BaseColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaYes.BorderColor = System.Drawing.Color.Black
        Me.GunaYes.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaYes.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaYes.CheckedForeColor = System.Drawing.Color.White
        Me.GunaYes.CheckedImage = CType(resources.GetObject("GunaYes.CheckedImage"), System.Drawing.Image)
        Me.GunaYes.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaYes.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.GunaYes.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GunaYes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaYes.ForeColor = System.Drawing.Color.White
        Me.GunaYes.Image = Nothing
        Me.GunaYes.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaYes.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaYes.Location = New System.Drawing.Point(356, 246)
        Me.GunaYes.Name = "GunaYes"
        Me.GunaYes.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GunaYes.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaYes.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaYes.OnHoverImage = Nothing
        Me.GunaYes.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GunaYes.OnPressedColor = System.Drawing.Color.Black
        Me.GunaYes.Radius = 4
        Me.GunaYes.Size = New System.Drawing.Size(112, 38)
        Me.GunaYes.TabIndex = 1
        Me.GunaYes.Text = "Yes"
        Me.GunaYes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(195, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(12, 123)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(456, 40)
        Me.lblQuestion.TabIndex = 13
        Me.lblQuestion.Text = "Are you sure ?"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaNo
        '
        Me.GunaNo.AnimationHoverSpeed = 0.07!
        Me.GunaNo.AnimationSpeed = 0.03!
        Me.GunaNo.BackColor = System.Drawing.Color.Transparent
        Me.GunaNo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GunaNo.BorderColor = System.Drawing.Color.Black
        Me.GunaNo.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaNo.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaNo.CheckedForeColor = System.Drawing.Color.White
        Me.GunaNo.CheckedImage = CType(resources.GetObject("GunaNo.CheckedImage"), System.Drawing.Image)
        Me.GunaNo.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaNo.DialogResult = System.Windows.Forms.DialogResult.No
        Me.GunaNo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GunaNo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaNo.ForeColor = System.Drawing.Color.Black
        Me.GunaNo.Image = Nothing
        Me.GunaNo.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaNo.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaNo.Location = New System.Drawing.Point(238, 246)
        Me.GunaNo.Name = "GunaNo"
        Me.GunaNo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GunaNo.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaNo.OnHoverForeColor = System.Drawing.Color.Black
        Me.GunaNo.OnHoverImage = Nothing
        Me.GunaNo.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GunaNo.OnPressedColor = System.Drawing.Color.Black
        Me.GunaNo.Radius = 4
        Me.GunaNo.Size = New System.Drawing.Size(112, 38)
        Me.GunaNo.TabIndex = 0
        Me.GunaNo.Text = "No"
        Me.GunaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSubQuestion
        '
        Me.lblSubQuestion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubQuestion.Location = New System.Drawing.Point(12, 173)
        Me.lblSubQuestion.Name = "lblSubQuestion"
        Me.lblSubQuestion.Size = New System.Drawing.Size(456, 40)
        Me.lblSubQuestion.TabIndex = 15
        Me.lblSubQuestion.Text = "Are you sure ?"
        Me.lblSubQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 25
        '
        'swalQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 297)
        Me.Controls.Add(Me.lblSubQuestion)
        Me.Controls.Add(Me.GunaNo)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GunaYes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "swalQuestion"
        Me.Opacity = 0.3R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "swal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblSubQuestion As Label
    Friend WithEvents GunaNo As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblQuestion As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaYes As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Timer1 As Timer
End Class
