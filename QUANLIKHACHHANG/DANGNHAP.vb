Imports System.Data.SqlClient
Imports System.Data.DataTable
'SỰ KIỆN CLICK ĐĂNG NHẬP'
Public Class FRMDANGNHAP
    'KHAI BÁO BIẾN
    Dim chuoiketnoi As String = "workstation id=ps00892.mssql.somee.com;packet size=4096;user id=ps00892_SQLLogin_1;pwd=9p3a6wnptu;data source=ps00892.mssql.somee.com;persist security info=False;initial catalog=ps00892"
    'Dim chuoiketnoi As String = "Data Source=THAONHI-PC;Initial Catalog=NHINTNTPS00892;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        Dim db As New DataTable
        ' KIỂM TRA MẬT KHẨU VÀ ID '
        If TXTTAIKHOAN.Text = "" Or TXTMATKHAU.Text = "" Then
            MessageBox.Show("VUI LÒNG NHẬP LẠI MẬT KHẨU VÀ TÀI KHOẢN", "THÔNG BÁO")
            Return
        End If
        'Nếu mật khẩu và tài khoản đã được nhập thì tiến hành kiểm tra kết nối
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim query As String = "select * from taikhoan where tendangnhap = " + "'" + TXTTAIKHOAN.Text + "'" + " AND MatKhau = " + "'" + TXTMATKHAU.Text + "'"
        Dim login As SqlDataAdapter = New SqlDataAdapter(query, conn)
        db.Clear()
        login.Fill(db)
        conn.Close()
        If db.Rows.Count >= 1 Then
            Class1.nguoitao = TXTTAIKHOAN.Text
            MessageBox.Show("BẠN ĐÃ ĐĂNG NHẬP THÀNH CÔNG !!!", "THÔNG BÁO")
            FRMTRANGCHU.Show()
            Me.Hide()
        Else
            MessageBox.Show("SAI MẬT KHẨU HOẶC TÀI KHOẢN !!!", "THÔNG BÁO")
            TXTTAIKHOAN.Text = ""
            TXTMATKHAU.Text = ""
            TXTTAIKHOAN.Focus()
        End If
    End Sub
    Private Sub BUTTHOAT_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
