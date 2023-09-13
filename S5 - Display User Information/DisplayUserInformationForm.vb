'Joshua Makuch
'RCET 3371
'Fall 2023
'Display User Information
'https://github.com/JoshuaMakuch/S5-DisplayUserInformation

Option Strict On
Option Explicit On


Public Class DisplayUserInformationForm

    'When the user presses the display button
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        'This concatinates text from all input textboxes and outputs into the final output textbox
        FinalOutputTextBox.Text = NameTextBox.Text & ", " & AddressTextBox.Text() & ", " & PhoneTextBox.Text() & ", " & BirthdateTextBox.Text
    End Sub

    'When the user presses the display but backwards button
    Private Sub DisplayButBackwardsButton_Click(sender As Object, e As EventArgs) Handles DisplayButBackwardsButton.Click
        'This concatinates text from all input textboxes, backwards, and outputs into the final output textbox
        FinalOutputTextBox.Text = BirthdateTextBox.Text & ", " & PhoneTextBox.Text & ", " & AddressTextBox.Text & ", " & NameTextBox.Text
    End Sub

    'When the user presses the quit button is closes the form
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

End Class
