Public Class Form1


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        RectangleShape2.Width += 5
        If RectangleShape2.Width >= 242 Then
            Timer1.Dispose()
            Me.Hide()
            Form2.Show()
        End If
    End Sub
End Class
