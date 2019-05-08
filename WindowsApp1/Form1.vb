Public Class Form1

    Const pixInc = 120
    Dim hgtInc As Double
    Dim xCoo As Int32

    Dim ctr As Int32


    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click

        hgtInc = (Me.Height) / pixInc

        Debug.Write(hgtInc)

        xCoo = MousePosition.X

        lblXCoo.Text = (xCoo.ToString)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BackColor = Color.MidnightBlue
        Debug.WriteLine("")
        Debug.WriteLine("Night has fallen.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BackColor = Color.Wheat
        Debug.WriteLine("")
        Debug.WriteLine("Morning is here.")
        ctr += 1

        If (ctr >= 5) Then
            Debug.WriteLine("")
            Debug.WriteLine("Soon it will be noon.")
            ctr = 0

        End If

    End Sub
End Class
