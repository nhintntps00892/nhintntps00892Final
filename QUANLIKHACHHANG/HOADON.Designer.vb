<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HOADON
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LBLTONGTIEN = New System.Windows.Forms.Label()
        Me.LBLMAKH = New System.Windows.Forms.Label()
        Me.LBLMAHD = New System.Windows.Forms.Label()
        Me.TXTTONGTIEN = New System.Windows.Forms.TextBox()
        Me.TXTMAHD = New System.Windows.Forms.TextBox()
        Me.GRBTTCKH = New System.Windows.Forms.GroupBox()
        Me.dtgDanhSachHoaDon = New System.Windows.Forms.DataGridView()
        Me.grpttcb = New System.Windows.Forms.GroupBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btndong = New System.Windows.Forms.Button()
        Me.cbbChonKhachHang = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.GRBTTCKH.SuspendLayout()
        CType(Me.dtgDanhSachHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpttcb.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBLTONGTIEN
        '
        Me.LBLTONGTIEN.AutoSize = True
        Me.LBLTONGTIEN.BackColor = System.Drawing.Color.Transparent
        Me.LBLTONGTIEN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTONGTIEN.ForeColor = System.Drawing.Color.Black
        Me.LBLTONGTIEN.Location = New System.Drawing.Point(317, 38)
        Me.LBLTONGTIEN.Name = "LBLTONGTIEN"
        Me.LBLTONGTIEN.Size = New System.Drawing.Size(82, 21)
        Me.LBLTONGTIEN.TabIndex = 21
        Me.LBLTONGTIEN.Text = "Tổng tiền :"
        '
        'LBLMAKH
        '
        Me.LBLMAKH.AutoSize = True
        Me.LBLMAKH.BackColor = System.Drawing.Color.Transparent
        Me.LBLMAKH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMAKH.ForeColor = System.Drawing.Color.Black
        Me.LBLMAKH.Location = New System.Drawing.Point(20, 87)
        Me.LBLMAKH.Name = "LBLMAKH"
        Me.LBLMAKH.Size = New System.Drawing.Size(78, 21)
        Me.LBLMAKH.TabIndex = 20
        Me.LBLMAKH.Text = "Chọn KH :"
        '
        'LBLMAHD
        '
        Me.LBLMAHD.AutoSize = True
        Me.LBLMAHD.BackColor = System.Drawing.Color.Transparent
        Me.LBLMAHD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMAHD.ForeColor = System.Drawing.Color.Black
        Me.LBLMAHD.Location = New System.Drawing.Point(22, 39)
        Me.LBLMAHD.Name = "LBLMAHD"
        Me.LBLMAHD.Size = New System.Drawing.Size(65, 21)
        Me.LBLMAHD.TabIndex = 18
        Me.LBLMAHD.Text = "Mã HD :"
        '
        'TXTTONGTIEN
        '
        Me.TXTTONGTIEN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTONGTIEN.Location = New System.Drawing.Point(419, 37)
        Me.TXTTONGTIEN.Name = "TXTTONGTIEN"
        Me.TXTTONGTIEN.Size = New System.Drawing.Size(183, 26)
        Me.TXTTONGTIEN.TabIndex = 65
        '
        'TXTMAHD
        '
        Me.TXTMAHD.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMAHD.Location = New System.Drawing.Point(103, 38)
        Me.TXTMAHD.Name = "TXTMAHD"
        Me.TXTMAHD.Size = New System.Drawing.Size(195, 26)
        Me.TXTMAHD.TabIndex = 66
        '
        'GRBTTCKH
        '
        Me.GRBTTCKH.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GRBTTCKH.Controls.Add(Me.dtgDanhSachHoaDon)
        Me.GRBTTCKH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBTTCKH.ForeColor = System.Drawing.Color.Black
        Me.GRBTTCKH.Location = New System.Drawing.Point(16, 12)
        Me.GRBTTCKH.Name = "GRBTTCKH"
        Me.GRBTTCKH.Size = New System.Drawing.Size(617, 278)
        Me.GRBTTCKH.TabIndex = 77
        Me.GRBTTCKH.TabStop = False
        Me.GRBTTCKH.Text = "Thông tin chi tiết hóa đơn"
        '
        'dtgDanhSachHoaDon
        '
        Me.dtgDanhSachHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgDanhSachHoaDon.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgDanhSachHoaDon.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgDanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDanhSachHoaDon.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgDanhSachHoaDon.Location = New System.Drawing.Point(25, 38)
        Me.dtgDanhSachHoaDon.MultiSelect = False
        Me.dtgDanhSachHoaDon.Name = "dtgDanhSachHoaDon"
        Me.dtgDanhSachHoaDon.ReadOnly = True
        Me.dtgDanhSachHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDanhSachHoaDon.Size = New System.Drawing.Size(569, 213)
        Me.dtgDanhSachHoaDon.TabIndex = 0
        '
        'grpttcb
        '
        Me.grpttcb.Controls.Add(Me.cbbChonKhachHang)
        Me.grpttcb.Controls.Add(Me.TXTTONGTIEN)
        Me.grpttcb.Controls.Add(Me.LBLMAHD)
        Me.grpttcb.Controls.Add(Me.LBLMAKH)
        Me.grpttcb.Controls.Add(Me.LBLTONGTIEN)
        Me.grpttcb.Controls.Add(Me.TXTMAHD)
        Me.grpttcb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpttcb.ForeColor = System.Drawing.Color.Black
        Me.grpttcb.Location = New System.Drawing.Point(16, 356)
        Me.grpttcb.Name = "grpttcb"
        Me.grpttcb.Size = New System.Drawing.Size(617, 128)
        Me.grpttcb.TabIndex = 78
        Me.grpttcb.TabStop = False
        Me.grpttcb.Text = "Thông tin cơ bản :"
        '
        'btnXoa
        '
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnXoa.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(295, 312)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(86, 25)
        Me.btnXoa.TabIndex = 81
        Me.btnXoa.Text = "   Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSua.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(203, 312)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(86, 25)
        Me.btnSua.TabIndex = 80
        Me.btnSua.Text = "   Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnThem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(111, 312)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(86, 25)
        Me.btnThem.TabIndex = 79
        Me.btnThem.Text = "   Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btndong
        '
        Me.btndong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndong.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndong.Location = New System.Drawing.Point(567, 506)
        Me.btndong.Name = "btndong"
        Me.btndong.Size = New System.Drawing.Size(66, 28)
        Me.btndong.TabIndex = 82
        Me.btndong.Text = "       Đóng"
        Me.btndong.UseVisualStyleBackColor = True
        '
        'cbbChonKhachHang
        '
        Me.cbbChonKhachHang.FormattingEnabled = True
        Me.cbbChonKhachHang.Location = New System.Drawing.Point(103, 84)
        Me.cbbChonKhachHang.Name = "cbbChonKhachHang"
        Me.cbbChonKhachHang.Size = New System.Drawing.Size(195, 29)
        Me.cbbChonKhachHang.TabIndex = 67
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(387, 312)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(86, 25)
        Me.btnRefresh.TabIndex = 81
        Me.btnRefresh.Text = "   Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'HOADON
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(652, 544)
        Me.Controls.Add(Me.btndong)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.grpttcb)
        Me.Controls.Add(Me.GRBTTCKH)
        Me.Name = "HOADON"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HOADON"
        Me.GRBTTCKH.ResumeLayout(False)
        CType(Me.dtgDanhSachHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpttcb.ResumeLayout(False)
        Me.grpttcb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LBLTONGTIEN As Label
    Friend WithEvents LBLMAKH As Label
    Friend WithEvents LBLMAHD As Label
    Friend WithEvents TXTTONGTIEN As TextBox
    Friend WithEvents TXTMAHD As TextBox
    Friend WithEvents GRBTTCKH As GroupBox
    Friend WithEvents dtgDanhSachHoaDon As DataGridView
    Friend WithEvents grpttcb As GroupBox
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btndong As Button
    Friend WithEvents cbbChonKhachHang As ComboBox
    Friend WithEvents btnRefresh As Button
End Class
