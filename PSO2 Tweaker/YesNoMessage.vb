Imports System.IO
Imports System
Imports PSO2_Tweaker.My

''' <summary>
''' 
''' </summary>

Public Class YesNoMessage

    Dim yesM As Boolean
    Public Shared ok_yesM As Boolean

    Private Sub ok_btn_Click(sender As Object, e As EventArgs) Handles ok_btn.Click
        ok_btn.BackgroundImage = Resources._137EN
        yesM = True
        'Settings.resetSettings = yesM
        My.Settings.Save()
        Close()
    End Sub

    Private Sub ok_btn_MouseEnter(sender As Object, e As EventArgs) Handles ok_btn.MouseEnter
        ok_btn.BackgroundImage = Resources._138EN
    End Sub

    Private Sub ok_btn_MouseLeave(sender As Object, e As EventArgs) Handles ok_btn.MouseLeave
        ok_btn.BackgroundImage = Resources._139EN
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        cancel_btn.BackgroundImage = Resources.blankCBTN
        yesM = False
        'My.Settings.resetSettings = yesM
        My.Settings.Save()
        Close()
    End Sub

    Private Sub cancel_btn_MouseEnter(sender As Object, e As EventArgs) Handles cancel_btn.MouseEnter
        cancel_btn.BackgroundImage = Resources.blankHBTN
    End Sub

    Private Sub cancel_btn_MouseLeave(sender As Object, e As EventArgs) Handles cancel_btn.MouseLeave
        cancel_btn.BackgroundImage = Resources.blankBTN
    End Sub

    Private Sub ok_btn_MouseDown(sender As Object, e As MouseEventArgs) Handles ok_btn.MouseDown
        ok_btn.BackgroundImage = Resources._137EN
    End Sub

    Private Sub cancel_btn_MouseDown(sender As Object, e As MouseEventArgs) Handles cancel_btn.MouseDown
        cancel_btn.BackgroundImage = Resources.blankCBTN
    End Sub

    Private Sub YesNoMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clipboard.SetText(message_txt.Text)
    End Sub

    'Public Function yesM() As Boolean
    '    If yesM = True Then Return yesM
    '    Return yesM
    'End Function

End Class