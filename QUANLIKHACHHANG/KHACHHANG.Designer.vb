<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KHACHHANG
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KHACHHANG))
        Me.GRBTTCKH = New System.Windows.Forms.GroupBox()
        Me.grivewKhachHang = New System.Windows.Forms.DataGridView()
        Me.btndong = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.GRBTTCKH.SuspendLayout()
        CType(Me.grivewKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GRBTTCKH
        '
        Me.GRBTTCKH.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GRBTTCKH.Controls.Add(Me.grivewKhachHang)
        Me.GRBTTCKH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBTTCKH.ForeColor = System.Drawing.Color.Black
        Me.GRBTTCKH.Location = New System.Drawing.Point(15, 29)
        Me.GRBTTCKH.Name = "GRBTTCKH"
        Me.GRBTTCKH.Size = New System.Drawing.Size(827, 370)
        Me.GRBTTCKH.TabIndex = 0
        Me.GRBTTCKH.TabStop = False
        Me.GRBTTCKH.Text = "Thông tin chi tiết khách hàng "
        '
        'grivewKhachHang
        '
        Me.grivewKhachHang.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grivewKhachHang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grivewKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grivewKhachHang.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grivewKhachHang.Location = New System.Drawing.Point(26, 28)
        Me.grivewKhachHang.MultiSelect = False
        Me.grivewKhachHang.Name = "grivewKhachHang"
        Me.grivewKhachHang.ReadOnly = True
        Me.grivewKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grivewKhachHang.Size = New System.Drawing.Size(778, 320)
        Me.grivewKhachHang.TabIndex = 0
        '
        'btndong
        '
        Me.btndong.BackgroundImage = CType(resources.GetObject("btndong.BackgroundImage"), System.Drawing.Image)
        Me.btndong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndong.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndong.Location = New System.Drawing.Point(772, 443)
        Me.btndong.Name = "btndong"
        Me.btndong.Size = New System.Drawing.Size(66, 35)
        Me.btndong.TabIndex = 64
        Me.btndong.Text = "       Đóng"
        Me.btndong.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.BackgroundImage = CType(resources.GetObject("btnXoa.BackgroundImage"), System.Drawing.Image)
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnXoa.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(449, 423)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 55
        Me.btnXoa.Text = "   Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.BackgroundImage = CType(resources.GetObject("btnSua.BackgroundImage"), System.Drawing.Image)
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSua.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(367, 423)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 25)
        Me.btnSua.TabIndex = 54
        Me.btnSua.Text = "   Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.BackgroundImage = CType(resources.GetObject("btnThem.BackgroundImage"), System.Drawing.Image)
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnThem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(286, 423)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 53
        Me.btnThem.Text = "   Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'KHACHHANG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(854, 500)
        Me.Controls.Add(Me.btndong)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.GRBTTCKH)
        Me.Name = "KHACHHANG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KHÁCH HÀNG"
        Me.GRBTTCKH.ResumeLayout(False)
        CType(Me.grivewKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GRBTTCKH As GroupBox
    Friend WithEvents grivewKhachHang As DataGridView
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btndong As Button
End Class
