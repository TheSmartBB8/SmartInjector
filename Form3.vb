Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("rc7.exe")
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Network.DownloadFile("https://dl.dropbox.com/s/9b1ovw5lzbpnzg0/XYZv.vmp_1.dll?dl=0",
"XYZ.dll")
    End Sub
End Class