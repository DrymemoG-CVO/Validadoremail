Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim regexPattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$"
        Dim emailRegEx As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(regexPattern)
        Dim result As Boolean = emailRegEx.IsMatch(TextBox1.Text)
        If Not result Then
            MessageBox.Show("Ingrese un correo vàlido")
        End If
        If result Then
            MessageBox.Show("Correo vàlido")
        End If
        'xd
    End Sub
End Class
