Imports System.Data.SqlClient
Imports System.Data

Public Class Class1

    Private conn As Object
    Public Shared nguoitao As String
    Public Function Loadkhachang() As DataSet
        'Dim chuoiketnoi As String = "server=THAONHI-PC;database=NHINTNTPS00892;trusted_connection=false;uid=sa;pwd=123"
        Dim chuoiketnoi As String = "workstation id=ps00892.mssql.somee.com;packet size=4096;user id=ps00892_SQLLogin_1;pwd=9p3a6wnptu;data source=ps00892.mssql.somee.com;persist security info=False;initial catalog=ps00892"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("Select Makh As 'Mã khách hàng' ,Tenkh as 'Tên khách hàng', SDT as 'SĐT', Diachi as 'Địa chỉ',email as 'email',ghichu as 'ghi chú', nguoitao as 'người tạo',ngaytao as 'ngày tạo'  from khachhang", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadhoadon() As DataSet
        'Dim chuoiketnoi As String = "server=THAONHI-PC;database=NHINTNTPS00892;trusted_connection=false;uid=sa;pwd=123"
        Dim chuoiketnoi As String = "workstation id=ps00892.mssql.somee.com;packet size=4096;user id=ps00892_SQLLogin_1;pwd=9p3a6wnptu;data source=ps00892.mssql.somee.com;persist security info=False;initial catalog=ps00892"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("Select MASP AS 'MÃ SP,TENSP AS 'TÊN SP' ,MALOAI AS 'MÃ LOẠI' , DVT AS 'ĐVT' FROM SANPHAM", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        'Dim chuoiketnoi As String = "server=THAONHI-PC;database=NHINTNTPS00892;trusted_connection=false;uid=sa;pwd=123"
        Dim chuoiketnoi As String = "workstation id=ps00892.mssql.somee.com;packet size=4096;user id=ps00892_SQLLogin_1;pwd=9p3a6wnptu;data source=ps00892.mssql.somee.com;persist security info=False;initial catalog=ps00892"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("Select MAHD AS 'MÃ HD,MAKH AS 'MÃ KH' ,TONGTIEN AS 'TỔNG TIỀN' , NGGAYBAN AS 'NGÀY BÁN' FROM HOADON", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class