Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.IO
Public Class SANPHAM
    'KHAI BÁO BIẾN
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=THAONHI-PC;database=NHINTNTPS00892;trusted_connection=false;uid=sa;pwd=123"
    Dim chuoiketnoi As String = "workstation id=ps00892.mssql.somee.com;packet size=4096;user id=ps00892_SQLLogin_1;pwd=9p3a6wnptu;data source=ps00892.mssql.somee.com;persist security info=False;initial catalog=ps00892"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim filename As String = ""
    Private Sub bntthem_Click_1(sender As Object, e As EventArgs) Handles bntthem.Click
        If (TXTMASP.ReadOnly = True) Then
            MessageBox.Show("Vui lòng nhấn cập nhật để cập nhật sản phẩm. Không thể thêm")
            Return
        End If
        If KiemTraLuu() = True Then
            Return
        End If
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "INSERT INTO SANPHAM VALUES (@MASP,@TENSP,@MALOAI,@DONGIA,@FileHinh)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        save.Parameters.AddWithValue("@MASP", TXTMASP.Text)
        save.Parameters.AddWithValue("@TENSP", TXTTENSP.Text)
        save.Parameters.AddWithValue("@MALOAI", cbbMaLoai.SelectedValue)
        save.Parameters.AddWithValue("@DONGIA", TXTDONGIA.Text)
        save.Parameters.AddWithValue("@FileHinh", filename)
        save.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("BẠN ĐÃ THÊM SẢN PHẨM THÀNH CÔNG")
        reset()
        LoadData()
    End Sub
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim click As Integer = dtChiTietSanPham.CurrentCell.RowIndex
        TXTMASP.Text = dtChiTietSanPham.Item(0, click).Value
        TXTTENSP.Text = dtChiTietSanPham.Item(1, click).Value
        'TXTMALOAI.Text = DataGridView2.Item(2, click).Value
        TXTDONGIA.Text = dtChiTietSanPham.Item(3, click).Value
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim DB_V2 As New DataTable
        conn.Open()
        Dim refesh_1 As SqlDataAdapter = New SqlDataAdapter("Select MaSP As 'Mã SP' ,TenSP as 'Tên Sản phẩm', S.MALOAI as 'Mã Loại', L.TENLOAI as 'Tên loại', Dongia as 'Đơn giá' ,ISNULL(S.FileHinh,'') as File_Name
                                                             from SANPHAM S inner join LOAISANPHAM L on S.MALOAI = L.MALOAI", conn)
        DB_V2.Clear()
        refesh_1.Fill(DB_V2)
        dtChiTietSanPham.DataSource = DB_V2.DefaultView
        conn.Close()
        'Ẩn cột file hình và cột mã loại
        dtChiTietSanPham.Columns(5).Visible = False
        dtChiTietSanPham.Columns(2).Visible = False
    End Sub
    Private Sub LoadLoaiSanPham()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim DB_V1 As New DataTable
        DB_V1.Clear()
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select * from LOAISANPHAM", conn)
        refesh.Fill(DB_V1)
        cbbMaLoai.DataSource = DB_V1
        cbbMaLoai.ValueMember = "MALOAI"
        cbbMaLoai.DisplayMember = "TENLOAI"
        conn.Close()
    End Sub

    Private Function KiemTraLuu() As Boolean
        KiemTraLuu = False
        If (String.IsNullOrEmpty(TXTMASP.Text) Or String.IsNullOrWhiteSpace(TXTMASP.Text) Or TXTMASP.Text.Contains(" ")) And TXTMASP.ReadOnly = False Then
            MessageBox.Show("Vui lòng kiểm tra lại mã sản phẩm. \n Mã sản phẩm là duy nhất không được trùng, và không có chứa khoảng trắng.")
            TXTMASP.Focus()
            KiemTraLuu = True
            Return KiemTraLuu
        ElseIf String.IsNullOrEmpty(TXTTENSP.Text) Or String.IsNullOrWhiteSpace(TXTTENSP.Text) Then
            MessageBox.Show("Vui lòng kiểm tra tên sản phẩm")
            TXTTENSP.Focus()
            KiemTraLuu = True
            Return KiemTraLuu
        ElseIf String.IsNullOrEmpty(TXTDONGIA.Text) Or String.IsNullOrWhiteSpace(TXTDONGIA.Text) Or IsNumeric(TXTDONGIA.Text) = False Then
            MessageBox.Show("VUI LÒNG KIỂM TRA GIÁ SẢN PHẨM")
            TXTDONGIA.Focus()
            KiemTraLuu = True
            Return KiemTraLuu
        End If

        'Kiểm tra mã sản phẩm đã tồn tại hay chưa?
        If (TXTMASP.ReadOnly = False) Then
            Dim db As New DataTable
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            conn.Open()
            Dim query As String = "select * from SANPHAM where UPPER(MASP) = UPPER(" + "'" + TXTMASP.Text + "'" + ")"
            Dim login As SqlDataAdapter = New SqlDataAdapter(query, conn)
            db.Clear()
            login.Fill(db)
            conn.Close()
            If db.Rows.Count >= 1 Then
                MessageBox.Show("Mã sản phẩm đã tồn tại trong hệ thống. Vui lòng kiểm tra lại")
                KiemTraLuu = True
                Return KiemTraLuu
            End If
        End If
    End Function
    Private Sub reset()
        TXTMASP.Clear()
        TXTTENSP.Text = ""
        TXTDONGIA.Text = ""
        TXTMASP.Focus()
        TXTMASP.ReadOnly = False
        filename = ""
        picChonHinh.ImageLocation = Application.StartupPath + "\images\" + filename

    End Sub
    Private Sub SANPHAM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        LoadLoaiSanPham()
    End Sub
    Private Sub bntsua_Click_1(sender As Object, e As EventArgs) Handles bntsua.Click
        If (KiemTraLuu() = True) Then
            Return
        End If
        Try
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "UPDATE SANPHAM SET TENSP=@TENSP,MALOAI=@MALOAI,DONGIA=@DONGIA, FileHinh = @FileHinh WHERE MASP=@MASP"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASP", TXTMASP.Text)
            save.Parameters.AddWithValue("@TENSP", TXTTENSP.Text)
            save.Parameters.AddWithValue("@MALOAI", cbbMaLoai.SelectedValue)
            save.Parameters.AddWithValue("@DONGIA", TXTDONGIA.Text)
            save.Parameters.AddWithValue("@FileHinh", filename)
            save.ExecuteNonQuery()
            conn.Close()
            reset()
            LoadData()
            MessageBox.Show("Cập nhật thành công.")
        Catch ex As Exception
            MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật. Vui lòng liên hệ quản trị viên.")
        End Try

    End Sub
    Private Sub bntxoa_Click_1(sender As Object, e As EventArgs) Handles bntxoa.Click
        If (String.IsNullOrEmpty(TXTMASP.Text) Or String.IsNullOrWhiteSpace(TXTMASP.Text)) Then
            MessageBox.Show("Chọn sản phẩm cần xóa.")
            Return
        End If

        If (TXTMASP.ReadOnly = False) Then
            MessageBox.Show("Sản phẩm không tồn tại trong hệ thống. Không thể xóa")
            Return
        End If

        If MessageBox.Show("Bạn muốn xóa sản phẩm: " + TXTTENSP.Text, "Thông Báo", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If


        Try
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

            'Kiểm tra khách hàng đó nếu đã tồn tại tại trong bảng hóa đơn thì không cho xóa
            conn.Open()
            Dim db_check As New DataTable
            Dim query As String = "select 1 from CHITIETHOADON where UPPER(MASP) = UPPER(" + "'" + TXTMASP.Text + "'" + ")"
            Dim check As SqlDataAdapter = New SqlDataAdapter(query, conn)
            db_check.Clear()
            check.Fill(db_check)
            conn.Close()
            If db_check.Rows.Count >= 1 Then
                MessageBox.Show("Sản phẩm đã được bán hàng. Không thể xóa. :LOL")
                Return
            End If

            Dim delquery As String = "delete from SanPham where UPPER(MASP)= UPPER(@MaSP)"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = DialogResult.Yes
            If resulft = DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MaSP", TXTMASP.Text)
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

    Private Sub btndong_Click(sender As Object, e As EventArgs) Handles btndong.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        reset()
    End Sub

    Private Sub dtChiTietSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtChiTietSanPham.CellClick
        Dim click As Integer = dtChiTietSanPham.CurrentCell.RowIndex
        Try
            'Khi click vào thì hiển thịthông tin xuống text box
            TXTMASP.Text = dtChiTietSanPham.Item(0, click).Value
            TXTTENSP.Text = dtChiTietSanPham.Item(1, click).Value
            cbbMaLoai.SelectedValue = dtChiTietSanPham.Item(2, click).Value
            TXTDONGIA.Text = dtChiTietSanPham.Item(4, click).Value
            picChonHinh.ImageLocation = Application.StartupPath + "\images\" + dtChiTietSanPham.Item(5, click).Value      'hiển thị lên picturebox
            TXTMASP.ReadOnly = True
        Catch ex As Exception
            reset()
        End Try

    End Sub

    Private Sub picChonHinh_Click(sender As Object, e As EventArgs) Handles picChonHinh.Click

        If (openpicture.ShowDialog() = DialogResult.OK) Then
            filename = openpicture.SafeFileName
            ''Dim newname = DateTime.Now.ToString()
            If hinhcheck(filename) = True Then
                If File.Exists(Application.StartupPath + "\images\" + openpicture.SafeFileName) = False Then
                    File.Copy(openpicture.FileName, Application.StartupPath + "\images\" + openpicture.SafeFileName)
                End If
            End If
        End If
        filename = openpicture.SafeFileName                         'lưu tên file
        picChonHinh.ImageLocation = Application.StartupPath + "\images\" + filename      'hiển thị lên picturebox
    End Sub

    Function hinhcheck(ByVal tenanh As String) As Boolean
        If (tenanh.EndsWith(".jpg") = False AndAlso tenanh.EndsWith(".png") = False AndAlso tenanh.EndsWith(".jpeg") = False) Then
            MessageBox.Show("sai định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function

End Class