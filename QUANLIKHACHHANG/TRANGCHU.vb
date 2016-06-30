Public Class FRMTRANGCHU
    Private Sub BNTKHACHHANG_Click(sender As Object, e As EventArgs) Handles BNTKHACHHANG.Click
        KHACHHANG.ShowDialog()
    End Sub
    Private Sub BNTSANPHAM_Click(sender As Object, e As EventArgs) Handles BNTSANPHAM.Click
        SANPHAM.ShowDialog()
    End Sub
    Private Sub BNTHOADON_Click(sender As Object, e As EventArgs) Handles BNTHOADON.Click
        HOADON.ShowDialog()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class