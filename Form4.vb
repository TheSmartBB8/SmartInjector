Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("memcheck.exe")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        My.Computer.Network.DownloadFile("http://download1757.mediafire.com/jgtfjpolw7kg/d82r2ei15irbl38/memcheck%281%29.dll",
"memcheck.dll")
    End Sub
End Class