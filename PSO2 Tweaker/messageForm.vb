Imports PSO2_Tweaker.My
Imports System.Windows.Forms


Public Class messageForm




    Private Sub ok_btn_Click(sender As Object, e As EventArgs) Handles ok_btn.Click
        ok_btn.BackgroundImage = Resources._134EN
        Close()
    End Sub

    Private Sub message_txt_Enter(sender As Object, e As EventArgs) Handles message_txt.Enter
        Dim position As Integer = message_txt.Text.Length
        message_txt.Select(position, position)
    End Sub


    Sub locatePSO2()

        message_txt.Text = "Could not find ""pso2.exe""." & vbCrLf & "Please locate the ""pso2_bin"" folder."

    End Sub

    Sub locateWin32()

        message_txt.Text = "Could not find ""win32"" folder." & vbCrLf & "Please locate folder."

    End Sub

    Sub downloadPSO2()
        message_txt.Text = "Welp.. It broke. Downloading ""pso2.exe""."
    End Sub

    Sub firstTimeRun()
        message_txt.Text = "Welcome to Phantasy Star Online 2.  This is a first time run and it is required that you locate your PSO2 bin folder."
    End Sub

    Sub failedUpdate()
        message_txt.Text = "AL update failed with an unknown error. Please try again later."
    End Sub

    Private Sub messageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show that our message has been copied to clipboard.
        NotifyIcon1.Icon = SystemIcons.Exclamation
        NotifyIcon1.BalloonTipTitle = "PSO2 Tweaker"
        NotifyIcon1.BalloonTipText = "Copied to clipboard: " & message_txt.Text
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info

        'Text is copied to clipboard to paste into notepad or shown in balloon.

        Clipboard.SetText(message_txt.Text)
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(30000)


    End Sub

    Private Sub ok_btn_MouseEnter(sender As Object, e As EventArgs) Handles ok_btn.MouseEnter
        ok_btn.BackgroundImage = Resources._135EN
    End Sub

    Private Sub ok_btn_MouseLeave(sender As Object, e As EventArgs) Handles ok_btn.MouseLeave
        ok_btn.BackgroundImage = Resources._136EN
    End Sub

    Private Sub ok_btn_MouseDown(sender As Object, e As MouseEventArgs) Handles ok_btn.MouseDown
        ok_btn.BackgroundImage = Resources._134EN
    End Sub
End Class