<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Thongtinkhachhang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Thongtinkhachhang))
        Me.grpttctkh = New System.Windows.Forms.GroupBox()
        Me.BTNOK = New System.Windows.Forms.Button()
        Me.btndong = New System.Windows.Forms.Button()
        Me.TXTTENKH = New System.Windows.Forms.TextBox()
        Me.LBLMAKH = New System.Windows.Forms.Label()
        Me.TXTMAKH = New System.Windows.Forms.TextBox()
        Me.LBLTENKH = New System.Windows.Forms.Label()
        Me.LBLSĐT = New System.Windows.Forms.Label()
        Me.TXTGHICHU = New System.Windows.Forms.TextBox()
        Me.LBLDIACHI = New System.Windows.Forms.Label()
        Me.TXTEMAIL = New System.Windows.Forms.TextBox()
        Me.LBLEMAIL = New System.Windows.Forms.Label()
        Me.TXTDIACHI = New System.Windows.Forms.TextBox()
        Me.LBLGHICHU = New System.Windows.Forms.Label()
        Me.TXTSĐT = New System.Windows.Forms.TextBox()
        Me.ptbAvarta = New System.Windows.Forms.PictureBox()
        Me.grpttctkh.SuspendLayout()
        CType(Me.ptbAvarta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpttctkh
        '
        Me.grpttctkh.Controls.Add(Me.BTNOK)
        Me.grpttctkh.Controls.Add(Me.btndong)
        Me.grpttctkh.Controls.Add(Me.TXTTENKH)
        Me.grpttctkh.Controls.Add(Me.LBLMAKH)
        Me.grpttctkh.Controls.Add(Me.TXTMAKH)
        Me.grpttctkh.Controls.Add(Me.LBLTENKH)
        Me.grpttctkh.Controls.Add(Me.LBLSĐT)
        Me.grpttctkh.Controls.Add(Me.TXTGHICHU)
        Me.grpttctkh.Controls.Add(Me.LBLDIACHI)
        Me.grpttctkh.Controls.Add(Me.TXTEMAIL)
        Me.grpttctkh.Controls.Add(Me.LBLEMAIL)
        Me.grpttctkh.Controls.Add(Me.TXTDIACHI)
        Me.grpttctkh.Controls.Add(Me.LBLGHICHU)
        Me.grpttctkh.Controls.Add(Me.TXTSĐT)
        Me.grpttctkh.Controls.Add(Me.ptbAvarta)
        Me.grpttctkh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpttctkh.Location = New System.Drawing.Point(12, 12)
        Me.grpttctkh.Name = "grpttctkh"
        Me.grpttctkh.Size = New System.Drawing.Size(542, 321)
        Me.grpttctkh.TabIndex = 58
        Me.grpttctkh.TabStop = False
        Me.grpttctkh.Text = "Thông tin chi tiết khách hàng :"
        '
        'BTNOK
        '
        Me.BTNOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNOK.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNOK.Location = New System.Drawing.Point(345, 259)
        Me.BTNOK.Name = "BTNOK"
        Me.BTNOK.Size = New System.Drawing.Size(81, 27)
        Me.BTNOK.TabIndex = 86
        Me.BTNOK.Text = "OK"
        Me.BTNOK.UseVisualStyleBackColor = True
        '
        'btndong
        '
        Me.btndong.BackgroundImage = CType(resources.GetObject("btndong.BackgroundImage"), System.Drawing.Image)
        Me.btndong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndong.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndong.Location = New System.Drawing.Point(443, 259)
        Me.btndong.Name = "btndong"
        Me.btndong.Size = New System.Drawing.Size(75, 27)
        Me.btndong.TabIndex = 85
        Me.btndong.Text = "       Đóng"
        Me.btndong.UseVisualStyleBackColor = True
        '
        'TXTTENKH
        '
        Me.TXTTENKH.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTENKH.Location = New System.Drawing.Point(93, 75)
        Me.TXTTENKH.Name = "TXTTENKH"
        Me.TXTTENKH.Size = New System.Drawing.Size(207, 26)
        Me.TXTTENKH.TabIndex = 79
        '
        'LBLMAKH
        '
        Me.LBLMAKH.AutoSize = True
        Me.LBLMAKH.BackColor = System.Drawing.Color.Transparent
        Me.LBLMAKH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMAKH.ForeColor = System.Drawing.Color.Black
        Me.LBLMAKH.Location = New System.Drawing.Point(16, 43)
        Me.LBLMAKH.Name = "LBLMAKH"
        Me.LBLMAKH.Size = New System.Drawing.Size(63, 21)
        Me.LBLMAKH.TabIndex = 72
        Me.LBLMAKH.Text = "Mã KH :"
        '
        'TXTMAKH
        '
        Me.TXTMAKH.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMAKH.Location = New System.Drawing.Point(94, 43)
        Me.TXTMAKH.Name = "TXTMAKH"
        Me.TXTMAKH.Size = New System.Drawing.Size(206, 26)
        Me.TXTMAKH.TabIndex = 73
        '
        'LBLTENKH
        '
        Me.LBLTENKH.AutoSize = True
        Me.LBLTENKH.BackColor = System.Drawing.Color.Transparent
        Me.LBLTENKH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTENKH.ForeColor = System.Drawing.Color.Black
        Me.LBLTENKH.Location = New System.Drawing.Point(16, 78)
        Me.LBLTENKH.Name = "LBLTENKH"
        Me.LBLTENKH.Size = New System.Drawing.Size(66, 21)
        Me.LBLTENKH.TabIndex = 74
        Me.LBLTENKH.Text = "Tên KH :"
        '
        'LBLSĐT
        '
        Me.LBLSĐT.AutoSize = True
        Me.LBLSĐT.BackColor = System.Drawing.Color.Transparent
        Me.LBLSĐT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSĐT.ForeColor = System.Drawing.Color.Black
        Me.LBLSĐT.Location = New System.Drawing.Point(17, 110)
        Me.LBLSĐT.Name = "LBLSĐT"
        Me.LBLSĐT.Size = New System.Drawing.Size(45, 21)
        Me.LBLSĐT.TabIndex = 75
        Me.LBLSĐT.Text = "SĐT :"
        '
        'TXTGHICHU
        '
        Me.TXTGHICHU.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTGHICHU.Location = New System.Drawing.Point(93, 209)
        Me.TXTGHICHU.Name = "TXTGHICHU"
        Me.TXTGHICHU.Size = New System.Drawing.Size(207, 26)
        Me.TXTGHICHU.TabIndex = 83
        '
        'LBLDIACHI
        '
        Me.LBLDIACHI.AutoSize = True
        Me.LBLDIACHI.BackColor = System.Drawing.Color.Transparent
        Me.LBLDIACHI.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDIACHI.ForeColor = System.Drawing.Color.Black
        Me.LBLDIACHI.Location = New System.Drawing.Point(20, 143)
        Me.LBLDIACHI.Name = "LBLDIACHI"
        Me.LBLDIACHI.Size = New System.Drawing.Size(64, 21)
        Me.LBLDIACHI.TabIndex = 76
        Me.LBLDIACHI.Text = "Địa chỉ :"
        '
        'TXTEMAIL
        '
        Me.TXTEMAIL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTEMAIL.Location = New System.Drawing.Point(93, 176)
        Me.TXTEMAIL.Name = "TXTEMAIL"
        Me.TXTEMAIL.Size = New System.Drawing.Size(207, 26)
        Me.TXTEMAIL.TabIndex = 82
        '
        'LBLEMAIL
        '
        Me.LBLEMAIL.AutoSize = True
        Me.LBLEMAIL.BackColor = System.Drawing.Color.Transparent
        Me.LBLEMAIL.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEMAIL.ForeColor = System.Drawing.Color.Black
        Me.LBLEMAIL.Location = New System.Drawing.Point(20, 179)
        Me.LBLEMAIL.Name = "LBLEMAIL"
        Me.LBLEMAIL.Size = New System.Drawing.Size(55, 21)
        Me.LBLEMAIL.TabIndex = 77
        Me.LBLEMAIL.Text = "Email :"
        '
        'TXTDIACHI
        '
        Me.TXTDIACHI.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDIACHI.Location = New System.Drawing.Point(93, 140)
        Me.TXTDIACHI.Name = "TXTDIACHI"
        Me.TXTDIACHI.Size = New System.Drawing.Size(207, 26)
        Me.TXTDIACHI.TabIndex = 81
        '
        'LBLGHICHU
        '
        Me.LBLGHICHU.AutoSize = True
        Me.LBLGHICHU.BackColor = System.Drawing.Color.Transparent
        Me.LBLGHICHU.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLGHICHU.ForeColor = System.Drawing.Color.Black
        Me.LBLGHICHU.Location = New System.Drawing.Point(20, 212)
        Me.LBLGHICHU.Name = "LBLGHICHU"
        Me.LBLGHICHU.Size = New System.Drawing.Size(70, 21)
        Me.LBLGHICHU.TabIndex = 78
        Me.LBLGHICHU.Text = "Ghi chú :"
        '
        'TXTSĐT
        '
        Me.TXTSĐT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSĐT.Location = New System.Drawing.Point(94, 107)
        Me.TXTSĐT.Name = "TXTSĐT"
        Me.TXTSĐT.Size = New System.Drawing.Size(207, 26)
        Me.TXTSĐT.TabIndex = 80
        '
        'ptbAvarta
        '
        Me.ptbAvarta.BackgroundImage = CType(resources.GetObject("ptbAvarta.BackgroundImage"), System.Drawing.Image)
        Me.ptbAvarta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbAvarta.Location = New System.Drawing.Point(345, 28)
        Me.ptbAvarta.Name = "ptbAvarta"
        Me.ptbAvarta.Size = New System.Drawing.Size(173, 207)
        Me.ptbAvarta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbAvarta.TabIndex = 58
        Me.ptbAvarta.TabStop = False
        '
        'Thongtinkhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(572, 353)
        Me.Controls.Add(Me.grpttctkh)
        Me.Name = "Thongtinkhachhang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin khách hàng "
        Me.grpttctkh.ResumeLayout(False)
        Me.grpttctkh.PerformLayout()
        CType(Me.ptbAvarta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpttctkh As GroupBox
    Friend WithEvents ptbAvarta As PictureBox
    Friend WithEvents TXTTENKH As TextBox
    Friend WithEvents LBLMAKH As Label
    Friend WithEvents TXTMAKH As TextBox
    Friend WithEvents LBLTENKH As Label
    Friend WithEvents LBLSĐT As Label
    Friend WithEvents TXTGHICHU As TextBox
    Friend WithEvents LBLDIACHI As Label
    Friend WithEvents TXTEMAIL As TextBox
    Friend WithEvents LBLEMAIL As Label
    Friend WithEvents TXTDIACHI As TextBox
    Friend WithEvents LBLGHICHU As Label
    Friend WithEvents TXTSĐT As TextBox
    Friend WithEvents btndong As Button
    Friend WithEvents BTNOK As Button
End Class
