Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmXemSanPham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QLDienThoaiPS01072.mssql.somee.com;packet size=4096;user id=trungnqps01072_SQLLogin_1;pwd=3gun4dz3t2;data source=QLDienThoaiPS01072.mssql.somee.com;persist security info=False;initial catalog=QLDienThoaiPS01072"

    Dim connect As SqlConnection = New SqlConnection("workstation id=QLDienThoaiPS01072.mssql.somee.com;packet size=4096;user id=trungnqps01072_SQLLogin_1;pwd=3gun4dz3t2;data source=QLDienThoaiPS01072.mssql.somee.com;persist security info=False;initial catalog=QLDienThoaiPS01072")
    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        Dim hienthi As New Class1
        dgvXemsp.DataSource = hienthi.Loadsanpham.Tables(0)
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection("workstation id=QLDienThoaiPS01072.mssql.somee.com;packet size=4096;user id=trungnqps01072_SQLLogin_1;pwd=3gun4dz3t2;data source=QLDienThoaiPS01072.mssql.somee.com;persist security info=False;initial catalog=QLDienThoaiPS01072")
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại',SANPHAM.SOLUONG as 'Số lượng' from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP where SANPHAM.MASP ='" & txtMASP.Text & "' ", connect)
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemsp.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                    txtMASP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtMASP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

End Class