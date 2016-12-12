
Public Class frmMain

    Private Sub XemKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles XemKháchHàngToolStripMenuItem.Click
        frmKH.Show()
    End Sub

    Private Sub XemSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles XemSảnPhẩmToolStripMenuItem.Click
        frmXemSanPham.Show()
    End Sub

    Private Sub ThêmSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles ThêmSảnPhẩmToolStripMenuItem.Click
        frmCapNhatSanPham.Show()
    End Sub

    Private Sub ChỉnhSửaKHToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles ChỉnhSửaKHToolStripMenuItem.Click
        frmDieuChinhKH.Show()
    End Sub

End Class
