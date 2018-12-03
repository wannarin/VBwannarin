Public Class Mywork1


    Private Sub btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click

        lblmoney.Text = Val(txtsalary.Text) * 12
        lblvat.Text = lblmoney.Text * 5 / 100
        lblresult.Text = lblmoney.Text - lblvat.Text

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click

        Me.Close()
    End Sub
End Class
