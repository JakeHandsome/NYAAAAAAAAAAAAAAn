Public Class Form1
    Dim deccounter As Decimal
    Private Declare Function mciSendString Lib "Winmm.dll" Alias "mciSendStringA" _
(ByVal lpstrCommand As String, ByVal lpstrReturnString As String, _
ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSTART.Click
        tmrNYAN.Enabled = True
        tmrMusic.Enabled = True
        lblCounter.Visible = True
        lblNYAN.Visible = True
        Label1.Visible = True
        picNYAN.Visible = True
        Dim file As String = Chr(34) & "NyanCat.mp3" & Chr(34)
        mciSendString("open " & file & " alias track", Nothing, 0, 0)
        mciSendString("play track", Nothing, 0, 0)

   

    End Sub

    Private Sub tmrNYAN_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrNYAN.Tick
        Dim strpicture(3) As String
        Dim strcurrent As String

        Static intnumber As Integer
        strpicture(0) = "NYAN1.png"
        strpicture(1) = "NYAN2.png"
        strpicture(2) = "NYAN3.png"
        strpicture(3) = "NYAN4.png"
        intnumber = intnumber + 1
        If intnumber = 4 Then
            intnumber = 0
        End If
        picNYAN.BackgroundImage = Image.FromFile(strpicture(intnumber))

        deccounter = deccounter + 0.1
        lblCounter.Text = (deccounter)



    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        tmrNYAN.Enabled = False
        tmrMusic.Enabled = False
        lblCounter.Visible = False
        lblNYAN.Visible = False
        Label1.Visible = False
        deccounter = 0
        picNYAN.Visible = False

        Dim file As String = Chr(34) & "NyanCat.mp3" & Chr(34)
        mciSendString("open " & file & " alias track", Nothing, 0, 0)
        mciSendString("stop track", Nothing, 0, 0)

    End Sub

    Private Sub tmrMusic_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMusic.Tick
        MessageBox.Show("YOU SURVIVED THE NYAN!")
    End Sub
End Class
