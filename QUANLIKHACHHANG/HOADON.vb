Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class HOADON
    'KHAI BÁO BIẾN
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=THAONHI-PC;database=NHINTNTPS00892;trusted_connection=false;uid=sa;pwd=123"
    Dim chuoiketnoi As String = "workstation id=ps00892.mssql.somee.com;packet size=4096;user id=ps00892_SQLLogin_1;pwd=9p3a6wnptu;data source=ps00892.mssql.somee.com;persist security info=False;initial catalog=ps00892"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If KiemTraLuu() = True Then
            Return
        End If
        If (String.IsNullOrEmpty(TXTMAHD.Text) Or String.IsNullOrWhiteSpace(TXTMAHD.Text) Or TXTMAHD.Text.Contains(" ")) And TXTMAHD.ReadOnly = False Then
            MessageBox.Show("Vui lòng kiểm tra lại mã hóa đơn. Mã hóa đơn không được trùng và không có chứa khoảng trắng.")
        End If
        'If (String.IsNullOrEmpty(TXTMAKH.Text) Or String.IsNullOrWhiteSpace(TXTMAKH.Text) Or TXTMAKH.Text.Contains(" ")) And TXTMAKH.ReadOnly = False Then
        '    MessageBox.Show("Vui lòng kiểm tra lại mã khách hàng. Mã khách hàng không được trùng và không có chứa khoảng trắng.")
        'End If
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "INSERT INTO HOADON(MAHD,MAKH,TONGTIEN) VALUES (@MAHD,@MAKH,@SoTien)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        save.Parameters.AddWithValue("@MAHD", TXTMAHD.Text)
        save.Parameters.AddWithValue("@MAKH", cbbChonKhachHang.SelectedValue)
        save.Parameters.AddWithValue("@SoTien", TXTTONGTIEN.Text)
        save.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("BẠN ĐÃ THÊM HÓA ĐƠN THÀNH CÔNG")
        reset()
        LoadData()
    End Sub
    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim click As Integer = dtgDanhSachHoaDon.CurrentCell.RowIndex
        TXTMAHD.Text = dtgDanhSachHoaDon.Item(0, click).Value
        'TXTMAKH.Text = dtgDanhSachHoaDon.Item(1, click).Value
        TXTTONGTIEN.Text = dtgDanhSachHoaDon.Item(2, click).Value
    End Sub
    Private Sub LoadData()
        Try
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            conn.Open()
            Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaHD as 'Mã HD' ,H.MAKH as 'MÃ KH',K.TENKH as N'Tên Khách Hàng', TONGTIEN as 'TỔNG TIỀN' 
                                                                from HOADON H inner join KHACHHANG K on H.MAKH = K.MAKH", conn)
            db.Clear()
            refesh.Fill(db)
            dtgDanhSachHoaDon.DataSource = db.DefaultView
            conn.Close()
            'Ẩn cột Mã khách hàng.
            dtgDanhSachHoaDon.Columns(1).Visible = False
        Catch ex As Exception
            MessageBox.Show("Có lỗi xảy ra khi load hóa đơn. Vui lòng liên hệ quản trị viên.")
        End Try

    End Sub

    Private Sub LoadKH()
        Try
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            conn.Open()
            Dim DB_KH As New DataTable
            Dim KH As SqlDataAdapter = New SqlDataAdapter("Select Makh,Tenkh from khachhang", conn)
            DB_KH.Clear()
            KH.Fill(DB_KH)
            cbbChonKhachHang.DataSource = DB_KH
            cbbChonKhachHang.ValueMember = "Makh"
            cbbChonKhachHang.DisplayMember = "Tenkh"
            conn.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Function KiemTraLuu() As Boolean
        KiemTraLuu = False
        If (String.IsNullOrEmpty(TXTMAHD.Text) Or String.IsNullOrWhiteSpace(TXTMAHD.Text) Or TXTMAHD.Text.Contains(" ")) And TXTMAHD.ReadOnly = False Then
            MessageBox.Show("Vui lòng kiểm tra lại mã Hóa Đơn. \n Mã Hóa Đơn là duy nhất không được trùng, và không có chứa khoảng trắng.")
            TXTMAHD.Focus()
            KiemTraLuu = True
            Return KiemTraLuu
        ElseIf (IsNumeric(TXTTONGTIEN.Text) = False) Then
            MessageBox.Show("Vui lòng kiểm tra lại số tiền.")
            TXTTONGTIEN.Focus()
            KiemTraLuu = True
            Return KiemTraLuu
        ElseIf (String.IsNullOrEmpty(cbbChonKhachHang.Text) Or String.IsNullOrWhiteSpace(cbbChonKhachHang.Text)) Then
            MessageBox.Show("Vui lòng chọn khách hàng.")
            cbbChonKhachHang.Show()
            KiemTraLuu = True
            Return KiemTraLuu
        End If
        'Kiểm tra hóa đơn bị trùng mã
        'Kiểm tra mã HD đã tồn tại hay chưa?
        Try
            If (TXTMAHD.ReadOnly = False) Then
                Dim db_check As New DataTable
                Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
                conn.Open()
                Dim query As String = "select * from HoaDon where UPPER(MaHD) = UPPER(" + "'" + TXTMAHD.Text + "'" + ")"
                Dim login As SqlDataAdapter = New SqlDataAdapter(query, conn)
                db_check.Clear()
                login.Fill(db_check)
                conn.Close()
                If db_check.Rows.Count >= 1 Then
                    MessageBox.Show("Mã hóa đơn đã tồn tại trong hệ thống. Vui lòng kiểm tra lại")
                    KiemTraLuu = True
                    Return KiemTraLuu
                End If
            End If
        Catch ex As Exception

        End Try



    End Function
    Private Sub reset()
        TXTMAHD.Clear()
        TXTTONGTIEN.Text = ""
        TXTMAHD.Focus()
        TXTMAHD.ReadOnly = False
        cbbChonKhachHang.SelectedValue = 0
    End Sub
    Private Sub HOADON_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        LoadKH()
    End Sub
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If KiemTraLuu() = True Then
            Return
        End If

        If (TXTMAHD.ReadOnly = False) Then
            MessageBox.Show("Vui lòng chọn 1 hóa đơn để sửa")
            Return
        End If
        Try
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "UPDATE HOADON SET MAKH=@MAKH,TONGTIEN=@TONGTIEN WHERE MAHD=@MAHD"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAHD", TXTMAHD.Text)
            save.Parameters.AddWithValue("@MAKH", cbbChonKhachHang.SelectedValue)
            save.Parameters.AddWithValue("@TONGTIEN", TXTTONGTIEN.Text)
            save.ExecuteNonQuery()
            conn.Close()
            reset()
            MessageBox.Show("Cập nhật thành công.")
            LoadData()
            reset()
        Catch ex As Exception
            MessageBox.Show("Có lỗi xảy ra khi cập nhật hóa đơn. Vui lòng liên hệ quản trị viên")

        End Try

        'Catch ex As Exception
        '    MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật. Vui lòng liên hệ quản trị viên.")
        'End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If (String.IsNullOrEmpty(TXTMAHD.Text) Or String.IsNullOrWhiteSpace(TXTMAHD.Text)) Then
            MessageBox.Show("Chọn sản phẩm cần xóa.")
            Return
        End If

        If MessageBox.Show("Bạn muốn xóa hóa đơn " + TXTMAHD.Text + " của khách hàng " + cbbChonKhachHang.Text, "Thông Báo", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If
        Try
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            'Kiểm tra hóa đơn đó nếu đã tồn tại tại trong bảng Chi tiết hóa đơn thì không cho xóa
            conn.Open()
            Dim db_check As New DataTable
            Dim query As String = "select 1 from CHITIETHOADON where UPPER(MASP) = UPPER(" + "'" + TXTMAHD.Text + "'" + ")"
            Dim check As SqlDataAdapter = New SqlDataAdapter(query, conn)
            db_check.Clear()
            check.Fill(db_check)
            conn.Close()
            If db_check.Rows.Count >= 1 Then
                MessageBox.Show("Sản phẩm đã được bán hàng. Không thể xóa. :LOL")
                Return
            End If

            Dim delquery As String = "delete from HoaDon where UPPER(MaHD)= UPPER(@MaHD)"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = DialogResult.Yes
            If resulft = DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MaHD", TXTMAHD.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                LoadData()
                reset()
                MessageBox.Show("BẠN ĐÃ XÓA THÀNH CÔNG ")
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi hệ thống xảy ra. Vui lòng liên hệ quản trị viên")
        End Try
    End Sub

    Private Sub dtgDanhSachHoaDon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgDanhSachHoaDon.CellClick
        Try
            Dim click As Integer = dtgDanhSachHoaDon.CurrentCell.RowIndex
            TXTMAHD.Text = dtgDanhSachHoaDon.Item(0, click).Value
            cbbChonKhachHang.SelectedValue = dtgDanhSachHoaDon.Item(1, click).Value
            TXTTONGTIEN.Text = dtgDanhSachHoaDon.Item(3, click).Value
            TXTMAHD.ReadOnly = True
        Catch ex As Exception
            reset()
        End Try

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        reset()
    End Sub

    Private Sub btndong_Click(sender As Object, e As EventArgs) Handles btndong.Click
        Me.Close()
    End Sub
End Class