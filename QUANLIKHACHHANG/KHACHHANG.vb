Imports System.Data.SqlClient
Imports System.Data.DataTable
'SỰ KIỆN CLICK ĐĂNG NHẬP'
Public Class KHACHHANG
    'KHAI BÁO BIẾN
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=THAONHI-PC;database=NHINTNTPS00892;trusted_connection=false;uid=sa;pwd=123"
    Dim chuoiketnoi As String = "workstation id=ps00892.mssql.somee.com;packet size=4096;user id=ps00892_SQLLogin_1;pwd=9p3a6wnptu;data source=ps00892.mssql.somee.com;persist security info=False;initial catalog=ps00892"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim MaKh As String
    Dim TenKh As String
    Private Sub LoadData()
        Try
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            conn.Open()
            Dim refesh As SqlDataAdapter = New SqlDataAdapter("Select Makh As 'MÃ KH' ,Tenkh as 'TÊN KH', SDT as 'SĐT', Diachi as 'ĐỊA CHỈ',email as 'EMAIL',ghichu as 'GHI CHÚ', nguoitao as 'NGƯỜI TẠO',ngaytao as 'NGÀY TẠO'  from khachhang", conn)
            db.Clear()
            refesh.Fill(db)
            grivewKhachHang.DataSource = db.DefaultView
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Có lỗi xảy ra. Vui lòng liên hệ quản trị viên.")
        End Try


    End Sub
    'Private Sub reset()
    '    TXTMAKH.Text = Focus()
    '    TXTTENKH.Text = ""
    '    TXTSĐT.Text = ""
    '    TXTDIACHI.Text = ""
    '    TXTEMAIL.Text = ""
    '    TXTGHICHU.Text = ""
    'End Sub
    Private Sub khachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grivewKhachHang.CellContentClick
        'Dim click As Integer = grivewKhachHang.CurrentCell.RowIndex
        'MaKh = grivewKhachHang.Item(0, click).Value
        'TenKh = grivewKhachHang.Item(1, click).Value
        'MessageBox.Show(MaKh)
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        MaKh = ""
        Thongtinkhachhang.MaKH = MaKh
        Thongtinkhachhang.IsUpdate = False
        Thongtinkhachhang.ShowDialog()
        LoadData()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click

        Thongtinkhachhang.MaKH = MaKh
        Thongtinkhachhang.IsUpdate = True
        If (MaKh = "") Then
            MessageBox.Show("Vui lòng chọn 1 khách hàng để sửa thông tin.")
            Return
        End If
        Thongtinkhachhang.ShowDialog()
        LoadData()
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If MaKh = "" Then
            MessageBox.Show("Chọn mã khách hàng cần xóa.")
            Return
        End If
        If MessageBox.Show("Bạn muốn xóa khách hàng " + TenKh, "Thông Báo", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Try
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

            'Kiểm tra khách hàng đó nếu đã tồn tại tại trong bảng hóa đơn thì không cho xóa
            conn.Open()
            Dim db_check As New DataTable
            Dim query As String = "select 1 from HOADON where MAKH =" + "'" + MaKh + "'"
            Dim check As SqlDataAdapter = New SqlDataAdapter(query, conn)
            db_check.Clear()
            check.Fill(db_check)
            conn.Close()
            If db_check.Rows.Count >= 1 Then
                MessageBox.Show("Khách hàng đã tồn tại trong bảng hóa đơn. Không thể xóa. :LOL")
                Return
            End If


            Dim delquery As String = "delete from KHACHHANG where MaKH=@MAKH"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = DialogResult.Yes
            If resulft = DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MAKH", MaKh)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("BẠN ĐÃ XÓA THÀNH CÔNG ")
                LoadData()
            End If
        Catch ex As Exception
            MessageBox.Show("Có lỗi xảy ra. Vui lòng liên hệ quản trị viên.")
        End Try

    End Sub
    Private Sub btndong_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btndong_Click_1(sender As Object, e As EventArgs) Handles btndong.Click
        Me.Close()
    End Sub

    Private Sub grivewKhachHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grivewKhachHang.CellClick
        Dim click As Integer = grivewKhachHang.CurrentCell.RowIndex
        MaKh = grivewKhachHang.Item(0, click).Value
        TenKh = grivewKhachHang.Item(1, click).Value

    End Sub
End Class