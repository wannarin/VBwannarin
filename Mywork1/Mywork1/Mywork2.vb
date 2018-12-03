Public Class Mywork2

    Private Sub btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click

        Dim vistra As Integer
        Dim frista As Integer
        Dim result As Integer

        Dim comvis As Integer
        Dim comfri As Integer
        Dim commit As Integer

        vistra = Val(txtvistra.Text)
        frista = Val(txtfrita.Text)
        result = vistra + frista

        lblresult.Text = result

        comvis = vistra * 5 / 100
        comfri = frista * 10 / 100
        commit = comvis + comfri

        lblfri.Text = comfri
        lblvis.Text = comvis
        lblcommit.Text = commit

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click

        Me.Close()

    End Sub
End Class