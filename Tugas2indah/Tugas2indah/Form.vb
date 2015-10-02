Public Class Form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonGantiWarna.Click
        If Me.BackColor = Color.Blue Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.Blue

        End If
    End Sub

    Private Sub FormBiru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Blue
    End Sub
End Class
