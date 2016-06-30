Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Text.RegularExpressions
Public Class Thongtinkhachhang
    'KHAI BÁO BIẾN
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=THAONHI-PC;database=NHINTNTPS00892;trusted_connection=false;uid=sa;pwd=123"
    Dim chuoiketnoi As String = "workstation id=ps00892.mssql.somee.com;packet size=4096;user id=ps00892_SQLLogin_1;pwd=9p3a6wnptu;data source=ps00892.mssql.somee.com;persist security info=False;initial catalog=ps00892"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Public Shared IsUpdate As Boolean = False
    Public Shared MaKH As String = ""
    'Public Property DataGridView1 As Object
    'Private Sub LoadData()
    '    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    '    conn.Open()
    '    Dim refesh As SqlDataAdapter = New SqlDataAdapter("Select Makh As 'MÃ KH' ,Tenkh as 'TÊN KH', SDT as 'SĐT', Diachi as 'ĐỊA CHỈ',email as 'EMAIL',ghichu as 'GHI CHÚ', nguoitao as 'NGƯỜI TẠO',ngaytao as 'NGÀY TẠO'  from khachhang", conn)
    '    db.Clear()
    '    refesh.Fill(db)
    '    DataGridView1.DataSource = db.DefaultView
    '    conn.Close()
    'End Sub
    'Private Sub reset()
    '    TXTMAKH.Text = Focus()
    '    TXTTENKH.Text = ""
    '    TXTSĐT.Text = ""
    '    TXTDIACHI.Text = ""
    '    TXTEMAIL.Text = ""
    '    TXTGHICHU.Text = ""
    'End Sub
    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    Dim click As Integer = DataGridView1.CurrentCell.RowIndex
    '    TXTMAKH.Text = DataGridView1.Item(0, click).Value
    '    TXTTENKH.Text = DataGridView1.Item(1, click).Value
    '    TXTSĐT.Text = DataGridView1.Item(2, click).Value
    '    TXTDIACHI.Text = DataGridView1.Item(3, click).Value
    '    TXTEMAIL.Text = DataGridView1.Item(4, click).Value
    '    TXTGHICHU.Text = DataGridView1.Item(5, click).Value
    'End Sub
    Private Sub BTNOK_Click(sender As Object, e As EventArgs) Handles BTNOK.Click
        If KIEMTRALUUTHONGTIN() = True Then
            Return
        End If
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        If (IsUpdate = False) Then
            Dim query As String = "INSERT INTO KHACHHANG(MAKH,TENKH,SDT,DIACHI,EMAIL,GHICHU,NGUOITAO,NGAYTAO)
                                   VALUES (@MAKH,@TENKH,@SDT,@DIACHI,@EMAIL,@GHICHU,@NGUOITAO,Getdate())"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAKH", TXTMAKH.Text)
            save.Parameters.AddWithValue("@TENKH", TXTTENKH.Text)
            save.Parameters.AddWithValue("@SDT", TXTSĐT.Text)
            save.Parameters.AddWithValue("@DIACHI", TXTDIACHI.Text)
            save.Parameters.AddWithValue("@EMAIL", TXTEMAIL.Text)
            save.Parameters.AddWithValue("@GHICHU", TXTGHICHU.Text)
            save.Parameters.AddWithValue("@NGUOITAO", Class1.nguoitao)
            'save.Parameters.AddWithValue("@NGAYTAO", TXTNGAYTAO.Text)
            'save.Parameters.AddWithValue("@NGUOITAO", TXTNGUOITAO.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("BẠN ĐÃ THÊM KHÁCH HÀNG THÀNH CÔNG")
        Else
            Dim query As String = "UPDATE KHACHHANG set TENKH = @TenKH,SDT= @SDT,DIACHI=@DiaChi,EMAIL = @Email,GHICHU=@GhiChu WHERE MAKH = @MaKH"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaKH", TXTMAKH.Text)
            save.Parameters.AddWithValue("@TenKH", TXTTENKH.Text)
            save.Parameters.AddWithValue("@SDT", TXTSĐT.Text)
            save.Parameters.AddWithValue("@DiaChi", TXTDIACHI.Text)
            save.Parameters.AddWithValue("@Email", TXTEMAIL.Text)
            save.Parameters.AddWithValue("@GhiChu", TXTGHICHU.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Cập nhật khách hàng thành công!")
        End If



    End Sub
    Private Function KIEMTRALUUTHONGTIN() As Boolean
        KIEMTRALUUTHONGTIN = False
        'kiêm tra nút khách hàng đã được nhập hay chưa
        If TXTMAKH.Text = "" Then
            MessageBox.Show("CHƯA NHẬP MÃ KHÁCH HÀNG")
            TXTTENKH.Focus()
            KIEMTRALUUTHONGTIN = True
            Return KIEMTRALUUTHONGTIN = True
        ElseIf TXTTENKH.Text = "" Then
            MessageBox.Show("CHƯA NHẬP TÊN KHÁCH HÀNG")
            TXTSĐT.Focus()
            KIEMTRALUUTHONGTIN = True
            Return KIEMTRALUUTHONGTIN = True
        ElseIf TXTSĐT.Text = "" Then
            MessageBox.Show("CHƯA NHẬP SỐ ĐIỆN THOẠI")
            TXTDIACHI.Focus()
            KIEMTRALUUTHONGTIN = True
            Return KIEMTRALUUTHONGTIN = True
        ElseIf TXTDIACHI.Text = "" Then
            MessageBox.Show("CHƯA NHẬP ĐỊA CHỈ")
            TXTEMAIL.Focus()
            KIEMTRALUUTHONGTIN = True
            Return KIEMTRALUUTHONGTIN = True
        ElseIf TXTEMAIL.Text = "" Then
            MessageBox.Show("CHƯA NHẬP EMAIL")
            TXTEMAIL.Focus()
            KIEMTRALUUTHONGTIN = True
            Return KIEMTRALUUTHONGTIN = True
        ElseIf TXTGHICHU.Text = "" Then
            MessageBox.Show("CHƯA NHẬP GHI CHÚ")
            TXTGHICHU.Focus()
            KIEMTRALUUTHONGTIN = True
            Return KIEMTRALUUTHONGTIN = True
        End If
        'Nếu mã khách hàng chứa bất kỳ khoảng trắng nào báo lỗi.
        If TXTMAKH.Text.Contains(" ") Then
            MessageBox.Show("MÃ KHÁCH HÀNG KHÔNG ĐƯỢC CHỨA KHOẢNG TRẮNG !!!")
            TXTTENKH.Focus()
            KIEMTRALUUTHONGTIN = True
            Return KIEMTRALUUTHONGTIN = True
        End If
        Dim reg As New Regex("^(0\d{9,10})$")
        If (reg.IsMatch(TXTSĐT.Text)) Then

        Else
            MessageBox.Show("SỐ ĐIỆN THOẠI KHÔNG HỢP LỆ .VUI LÒNG KIỂM TRA LẠI SỐ ĐIỆN THOẠI ")
            TXTDIACHI.Focus()
            KIEMTRALUUTHONGTIN = True
            Return KIEMTRALUUTHONGTIN
        End If

        If (IsUpdate = False) Then
            Dim db As New DataTable
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            conn.Open()
            Dim query As String = "Select 1 from khachhang where Makh = " + "'" + TXTMAKH.Text + "'"
            Dim login As SqlDataAdapter = New SqlDataAdapter(query, conn)
            db.Clear()
            conn.Close()
            If db.Rows.Count >= 1 Then
                MessageBox.Show("Mã Khách hàng đã tồn tại trong hệ thống. Vui lòng kiểm tra lại")
                KIEMTRALUUTHONGTIN = True
                Return KIEMTRALUUTHONGTIN
                KIEMTRALUUTHONGTIN = True
            End If
        End If

    End Function
    Private Sub btndong_Click(sender As Object, e As EventArgs) Handles btndong.Click
        Me.Close()
    End Sub

    Private Sub Thongtinkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim db As New DataTable
        If IsUpdate Then
            If MaKH <> "" Then
                Dim query As String = "SELECT * FROM KHACHHANG WHERE maKH ='" + MaKH + "'"
                Dim login As SqlDataAdapter = New SqlDataAdapter(query, conn)
                db.Clear()
                login.Fill(db)
                conn.Close()
                If db.Rows.Count > 0 Then
                    TXTMAKH.Text = db.Rows(0)("MAKH")
                    TXTTENKH.Text = db.Rows(0)("TENKH")
                    TXTSĐT.Text = db.Rows(0)("SDT")
                    TXTDIACHI.Text = db.Rows(0)("DIACHI")
                    TXTEMAIL.Text = db.Rows(0)("EMAIL")
                    TXTGHICHU.Text = db.Rows(0)("GHICHU")
                    TXTMAKH.ReadOnly = True
                    BTNOK.Name = "Cập nhật"
                End If
            End If
        End If
    End Sub

    Private Sub Thongtinkhachhang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        IsUpdate = False
        MaKH = ""
    End Sub
End Class