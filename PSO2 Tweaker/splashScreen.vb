Imports Microsoft.VisualBasic.ApplicationServices

Public Class splashScreen
    Private Sub splashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The form that we will end up showing
        Dim formToShow As System.Windows.Forms.Form = Nothing

        'The determiner as to which form to show
        Dim GUIcorns As String = RegKey.GetValue(Of String)(RegKey.GUIPlatform)

        'Choose the appropriate form
        Select Case GUIcorns
            Case "Advance"
                formToShow = New FrmMain
            Case Else
                formToShow = New FrmMain2
        End Select

        'Show the form, and keep it open until it's explicitly closed.
        formToShow.ShowDialog()


    End Sub

    Private Sub frmMain2_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'Me.Close()
    End Sub
    ' Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '     Application.Exit()
    ' End Sub

End Class