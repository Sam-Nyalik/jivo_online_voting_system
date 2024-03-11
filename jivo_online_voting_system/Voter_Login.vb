Public Class Voter_Login
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        openVoterRegistrationSection()
    End Sub

    Private Sub openVoterRegistrationSection()
        Dim voter_regstration_page As New Voter_Registration()

        voter_regstration_page.Show()
    End Sub
End Class