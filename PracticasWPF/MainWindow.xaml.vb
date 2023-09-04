Class MainWindow
    Private Sub btnLogin_Click(sender As Object, e As RoutedEventArgs)
        If txtUser.Text = "kevin.gomez" And txtPass.Password = "Solido23#" Then
            MsgBox("Se a iniciado sesion")
            Me.Hide()

            Dim A As New Form1
            A.Show()
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Application.Current.Shutdown()
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs)
        WindowState = WindowState.Minimized
    End Sub
    Private Sub Window_MouseDown(sender As Object, e As MouseButtonEventArgs)
        If e.LeftButton = MouseButtonState.Pressed Then
            DragMove()
        End If
    End Sub
    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Key = Key.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub
End Class
