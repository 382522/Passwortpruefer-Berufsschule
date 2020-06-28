Public Class Form1
    Dim pw As String
    Dim keytry As String
    Dim trynr As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        pw = "Test"

    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click

        trynr = trynr + 1
        keytry = TextBox1.Text

        If trynr <= 3 Then

            If pw = keytry Then

                MsgBox(Prompt:="Das hast du toll gemacht, Kevin!")

            Else

                MsgBox(Prompt:="Das Passwort ist leider nicht richtig!")

            End If

        End If

        If trynr >= 3 Then

            TextBox1.Enabled = False
            btnCheck.Enabled = False

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()

    End Sub
End Class