<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMDANGNHAP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMDANGNHAP))
        Me.LBLTUADE = New System.Windows.Forms.Label()
        Me.LBLTAIKHOAN = New System.Windows.Forms.Label()
        Me.LBLMATKHAU = New System.Windows.Forms.Label()
        Me.TXTTAIKHOAN = New System.Windows.Forms.TextBox()
        Me.TXTMATKHAU = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLTUADE
        '
        Me.LBLTUADE.AutoSize = True
        Me.LBLTUADE.BackColor = System.Drawing.Color.Transparent
        Me.LBLTUADE.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTUADE.ForeColor = System.Drawing.Color.Black
        Me.LBLTUADE.Location = New System.Drawing.Point(78, 18)
        Me.LBLTUADE.Name = "LBLTUADE"
        Me.LBLTUADE.Size = New System.Drawing.Size(311, 25)
        Me.LBLTUADE.TabIndex = 0
        Me.LBLTUADE.Text = "PHẦN MỀM QUẢN LÍ KHÁCH HÀNG"
        Me.LBLTUADE.UseWaitCursor = True
        '
        'LBLTAIKHOAN
        '
        Me.LBLTAIKHOAN.AutoSize = True
        Me.LBLTAIKHOAN.BackColor = System.Drawing.Color.Transparent
        Me.LBLTAIKHOAN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTAIKHOAN.ForeColor = System.Drawing.Color.Black
        Me.LBLTAIKHOAN.Location = New System.Drawing.Point(8, 70)
        Me.LBLTAIKHOAN.Name = "LBLTAIKHOAN"
        Me.LBLTAIKHOAN.Size = New System.Drawing.Size(84, 21)
        Me.LBLTAIKHOAN.TabIndex = 1
        Me.LBLTAIKHOAN.Text = "Tài khoản :"
        Me.LBLTAIKHOAN.UseWaitCursor = True
        '
        'LBLMATKHAU
        '
        Me.LBLMATKHAU.AutoSize = True
        Me.LBLMATKHAU.BackColor = System.Drawing.Color.Transparent
        Me.LBLMATKHAU.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMATKHAU.ForeColor = System.Drawing.Color.Black
        Me.LBLMATKHAU.Location = New System.Drawing.Point(12, 119)
        Me.LBLMATKHAU.Name = "LBLMATKHAU"
        Me.LBLMATKHAU.Size = New System.Drawing.Size(82, 21)
        Me.LBLMATKHAU.TabIndex = 2
        Me.LBLMATKHAU.Text = "Mật khẩu :"
        Me.LBLMATKHAU.UseWaitCursor = True
        '
        'TXTTAIKHOAN
        '
        Me.TXTTAIKHOAN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTAIKHOAN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXTTAIKHOAN.Location = New System.Drawing.Point(117, 64)
        Me.TXTTAIKHOAN.Name = "TXTTAIKHOAN"
        Me.TXTTAIKHOAN.Size = New System.Drawing.Size(193, 26)
        Me.TXTTAIKHOAN.TabIndex = 3
        Me.TXTTAIKHOAN.UseWaitCursor = True
        '
        'TXTMATKHAU
        '
        Me.TXTMATKHAU.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMATKHAU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXTMATKHAU.Location = New System.Drawing.Point(117, 116)
        Me.TXTMATKHAU.Name = "TXTMATKHAU"
        Me.TXTMATKHAU.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTMATKHAU.Size = New System.Drawing.Size(193, 26)
        Me.TXTMATKHAU.TabIndex = 4
        Me.TXTMATKHAU.UseWaitCursor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.QUANLIKHACHHANG.My.Resources.Resources.khách_hàng
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(316, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 175)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'btnDangNhap
        '
        Me.btnDangNhap.BackgroundImage = CType(resources.GetObject("btnDangNhap.BackgroundImage"), System.Drawing.Image)
        Me.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDangNhap.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangNhap.ForeColor = System.Drawing.Color.Black
        Me.btnDangNhap.Location = New System.Drawing.Point(114, 185)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(88, 23)
        Me.btnDangNhap.TabIndex = 9
        Me.btnDangNhap.Text = "    Đăng Nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = True
        Me.btnDangNhap.UseWaitCursor = True
        '
        'btncancel
        '
        Me.btncancel.BackgroundImage = CType(resources.GetObject("btncancel.BackgroundImage"), System.Drawing.Image)
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Black
        Me.btncancel.Location = New System.Drawing.Point(235, 185)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 10
        Me.btncancel.Text = "   Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        Me.btncancel.UseWaitCursor = True
        '
        'FRMDANGNHAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(490, 226)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TXTMATKHAU)
        Me.Controls.Add(Me.TXTTAIKHOAN)
        Me.Controls.Add(Me.LBLMATKHAU)
        Me.Controls.Add(Me.LBLTAIKHOAN)
        Me.Controls.Add(Me.LBLTUADE)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Name = "FRMDANGNHAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ĐĂNG NHẬP "
        Me.UseWaitCursor = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLTUADE As Label
    Friend WithEvents LBLTAIKHOAN As Label
    Friend WithEvents LBLMATKHAU As Label
    Friend WithEvents TXTTAIKHOAN As TextBox
    Friend WithEvents TXTMATKHAU As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDangNhap As Button
    Friend WithEvents btncancel As Button
End Class
