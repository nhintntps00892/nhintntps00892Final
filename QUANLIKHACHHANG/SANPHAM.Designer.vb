<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SANPHAM
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SANPHAM))
        Me.LBLMASP = New System.Windows.Forms.Label()
        Me.LBLDVT = New System.Windows.Forms.Label()
        Me.LBLMALOAI = New System.Windows.Forms.Label()
        Me.LBTTENSP = New System.Windows.Forms.Label()
        Me.TXTTENSP = New System.Windows.Forms.TextBox()
        Me.TXTDONGIA = New System.Windows.Forms.TextBox()
        Me.GRBTTCKH = New System.Windows.Forms.GroupBox()
        Me.dtChiTietSanPham = New System.Windows.Forms.DataGridView()
        Me.grpttcb = New System.Windows.Forms.GroupBox()
        Me.TXTMASP = New System.Windows.Forms.TextBox()
        Me.cbbMaLoai = New System.Windows.Forms.ComboBox()
        Me.picChonHinh = New System.Windows.Forms.PictureBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.btndong = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.openpicture = New System.Windows.Forms.OpenFileDialog()
        Me.GRBTTCKH.SuspendLayout()
        CType(Me.dtChiTietSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpttcb.SuspendLayout()
        CType(Me.picChonHinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLMASP
        '
        Me.LBLMASP.AutoSize = True
        Me.LBLMASP.BackColor = System.Drawing.Color.Transparent
        Me.LBLMASP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMASP.ForeColor = System.Drawing.Color.Black
        Me.LBLMASP.Location = New System.Drawing.Point(62, 45)
        Me.LBLMASP.Name = "LBLMASP"
        Me.LBLMASP.Size = New System.Drawing.Size(54, 21)
        Me.LBLMASP.TabIndex = 2
        Me.LBLMASP.Text = "Mã SP"
        '
        'LBLDVT
        '
        Me.LBLDVT.AutoSize = True
        Me.LBLDVT.BackColor = System.Drawing.Color.Transparent
        Me.LBLDVT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDVT.ForeColor = System.Drawing.Color.Black
        Me.LBLDVT.Location = New System.Drawing.Point(352, 77)
        Me.LBLDVT.Name = "LBLDVT"
        Me.LBLDVT.Size = New System.Drawing.Size(72, 21)
        Me.LBLDVT.TabIndex = 4
        Me.LBLDVT.Text = "Đơn giá :"
        '
        'LBLMALOAI
        '
        Me.LBLMALOAI.AutoSize = True
        Me.LBLMALOAI.BackColor = System.Drawing.Color.Transparent
        Me.LBLMALOAI.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMALOAI.ForeColor = System.Drawing.Color.Black
        Me.LBLMALOAI.Location = New System.Drawing.Point(354, 48)
        Me.LBLMALOAI.Name = "LBLMALOAI"
        Me.LBLMALOAI.Size = New System.Drawing.Size(61, 21)
        Me.LBLMALOAI.TabIndex = 5
        Me.LBLMALOAI.Text = "Loại SP"
        '
        'LBTTENSP
        '
        Me.LBTTENSP.AutoSize = True
        Me.LBTTENSP.BackColor = System.Drawing.Color.Transparent
        Me.LBTTENSP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBTTENSP.ForeColor = System.Drawing.Color.Black
        Me.LBTTENSP.Location = New System.Drawing.Point(62, 77)
        Me.LBTTENSP.Name = "LBTTENSP"
        Me.LBTTENSP.Size = New System.Drawing.Size(64, 21)
        Me.LBTTENSP.TabIndex = 6
        Me.LBTTENSP.Text = "Tên SP :"
        '
        'TXTTENSP
        '
        Me.TXTTENSP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTENSP.Location = New System.Drawing.Point(135, 74)
        Me.TXTTENSP.Name = "TXTTENSP"
        Me.TXTTENSP.Size = New System.Drawing.Size(167, 26)
        Me.TXTTENSP.TabIndex = 44
        '
        'TXTDONGIA
        '
        Me.TXTDONGIA.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDONGIA.Location = New System.Drawing.Point(457, 76)
        Me.TXTDONGIA.Name = "TXTDONGIA"
        Me.TXTDONGIA.Size = New System.Drawing.Size(167, 26)
        Me.TXTDONGIA.TabIndex = 58
        '
        'GRBTTCKH
        '
        Me.GRBTTCKH.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GRBTTCKH.Controls.Add(Me.dtChiTietSanPham)
        Me.GRBTTCKH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBTTCKH.ForeColor = System.Drawing.Color.Black
        Me.GRBTTCKH.Location = New System.Drawing.Point(23, 26)
        Me.GRBTTCKH.Name = "GRBTTCKH"
        Me.GRBTTCKH.Size = New System.Drawing.Size(646, 278)
        Me.GRBTTCKH.TabIndex = 59
        Me.GRBTTCKH.TabStop = False
        Me.GRBTTCKH.Text = "Thông tin chi tiết sản phẩm"
        '
        'dtChiTietSanPham
        '
        Me.dtChiTietSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtChiTietSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtChiTietSanPham.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtChiTietSanPham.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtChiTietSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtChiTietSanPham.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtChiTietSanPham.Location = New System.Drawing.Point(25, 38)
        Me.dtChiTietSanPham.MultiSelect = False
        Me.dtChiTietSanPham.Name = "dtChiTietSanPham"
        Me.dtChiTietSanPham.ReadOnly = True
        Me.dtChiTietSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtChiTietSanPham.Size = New System.Drawing.Size(599, 213)
        Me.dtChiTietSanPham.TabIndex = 0
        '
        'grpttcb
        '
        Me.grpttcb.Controls.Add(Me.TXTMASP)
        Me.grpttcb.Controls.Add(Me.cbbMaLoai)
        Me.grpttcb.Controls.Add(Me.LBLMALOAI)
        Me.grpttcb.Controls.Add(Me.LBLMASP)
        Me.grpttcb.Controls.Add(Me.LBLDVT)
        Me.grpttcb.Controls.Add(Me.LBTTENSP)
        Me.grpttcb.Controls.Add(Me.TXTDONGIA)
        Me.grpttcb.Controls.Add(Me.TXTTENSP)
        Me.grpttcb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpttcb.ForeColor = System.Drawing.Color.Black
        Me.grpttcb.Location = New System.Drawing.Point(23, 355)
        Me.grpttcb.Name = "grpttcb"
        Me.grpttcb.Size = New System.Drawing.Size(646, 128)
        Me.grpttcb.TabIndex = 64
        Me.grpttcb.TabStop = False
        Me.grpttcb.Text = "Thông tin cơ bản :"
        '
        'TXTMASP
        '
        Me.TXTMASP.Location = New System.Drawing.Point(135, 42)
        Me.TXTMASP.Name = "TXTMASP"
        Me.TXTMASP.Size = New System.Drawing.Size(167, 29)
        Me.TXTMASP.TabIndex = 60
        '
        'cbbMaLoai
        '
        Me.cbbMaLoai.FormattingEnabled = True
        Me.cbbMaLoai.Location = New System.Drawing.Point(457, 45)
        Me.cbbMaLoai.Name = "cbbMaLoai"
        Me.cbbMaLoai.Size = New System.Drawing.Size(167, 29)
        Me.cbbMaLoai.TabIndex = 59
        '
        'picChonHinh
        '
        Me.picChonHinh.BackgroundImage = Global.QUANLIKHACHHANG.My.Resources.Resources.khongcohinh
        Me.picChonHinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picChonHinh.Location = New System.Drawing.Point(710, 45)
        Me.picChonHinh.Name = "picChonHinh"
        Me.picChonHinh.Size = New System.Drawing.Size(195, 232)
        Me.picChonHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChonHinh.TabIndex = 85
        Me.picChonHinh.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImage = CType(resources.GetObject("btnRefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(461, 324)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 25)
        Me.btnRefresh.TabIndex = 84
        Me.btnRefresh.Text = "   Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'bntxoa
        '
        Me.bntxoa.BackgroundImage = CType(resources.GetObject("bntxoa.BackgroundImage"), System.Drawing.Image)
        Me.bntxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bntxoa.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntxoa.Location = New System.Drawing.Point(381, 324)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 25)
        Me.bntxoa.TabIndex = 84
        Me.bntxoa.Text = "   Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.BackgroundImage = CType(resources.GetObject("bntsua.BackgroundImage"), System.Drawing.Image)
        Me.bntsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bntsua.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntsua.Location = New System.Drawing.Point(299, 324)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(75, 25)
        Me.bntsua.TabIndex = 83
        Me.bntsua.Text = "   Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntthem
        '
        Me.bntthem.BackgroundImage = CType(resources.GetObject("bntthem.BackgroundImage"), System.Drawing.Image)
        Me.bntthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bntthem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntthem.Location = New System.Drawing.Point(218, 324)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 25)
        Me.bntthem.TabIndex = 82
        Me.bntthem.Text = "   Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'btndong
        '
        Me.btndong.BackgroundImage = CType(resources.GetObject("btndong.BackgroundImage"), System.Drawing.Image)
        Me.btndong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndong.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndong.Location = New System.Drawing.Point(603, 519)
        Me.btndong.Name = "btndong"
        Me.btndong.Size = New System.Drawing.Size(66, 28)
        Me.btndong.TabIndex = 63
        Me.btndong.Text = "       Đóng"
        Me.btndong.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.BackgroundImage = CType(resources.GetObject("btnXoa.BackgroundImage"), System.Drawing.Image)
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnXoa.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(439, 375)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 62
        Me.btnXoa.Text = "   Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.BackgroundImage = CType(resources.GetObject("btnSua.BackgroundImage"), System.Drawing.Image)
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSua.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(357, 375)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 25)
        Me.btnSua.TabIndex = 61
        Me.btnSua.Text = "   Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.BackgroundImage = CType(resources.GetObject("btnThem.BackgroundImage"), System.Drawing.Image)
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnThem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(276, 375)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 60
        Me.btnThem.Text = "   Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'openpicture
        '
        Me.openpicture.FileName = "OpenFileDialog1"
        '
        'SANPHAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(944, 577)
        Me.Controls.Add(Me.picChonHinh)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.bntxoa)
        Me.Controls.Add(Me.bntsua)
        Me.Controls.Add(Me.bntthem)
        Me.Controls.Add(Me.grpttcb)
        Me.Controls.Add(Me.btndong)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.GRBTTCKH)
        Me.Name = "SANPHAM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SẢN PHẨM "
        Me.GRBTTCKH.ResumeLayout(False)
        CType(Me.dtChiTietSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpttcb.ResumeLayout(False)
        Me.grpttcb.PerformLayout()
        CType(Me.picChonHinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LBLMASP As Label
    Friend WithEvents LBLDVT As Label
    Friend WithEvents LBLMALOAI As Label
    Friend WithEvents LBTTENSP As Label
    Friend WithEvents TXTTENSP As TextBox
    Friend WithEvents TXTDONGIA As TextBox
    Friend WithEvents GRBTTCKH As GroupBox
    Friend WithEvents dtChiTietSanPham As DataGridView
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btndong As Button
    Friend WithEvents grpttcb As GroupBox
    Friend WithEvents bntxoa As Button
    Friend WithEvents bntsua As Button
    Friend WithEvents bntthem As Button
    Friend WithEvents cbbMaLoai As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents TXTMASP As TextBox
    Friend WithEvents picChonHinh As PictureBox
    Friend WithEvents openpicture As OpenFileDialog
End Class
