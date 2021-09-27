Public Class frmLoans

    Private Sub frmLoans_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        openCon()

        Try
            cmd1.Connection = conn
            cmd1.CommandText = "SELECT * FROM loan_release"
            adapter.SelectCommand = cmd1
            table.Clear()
            adapter.Fill(table)
            dgViewLoans.DataSource = table
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        conn.Close()
    End Sub

    Private Sub btnShowfrmLoanAdd_Click(sender As Object, e As EventArgs) Handles btnShowfrmLoanAdd.Click
        Dim form = New frmLoanAdd
        'frmAddCust.BringToFront()
        form.Show()
    End Sub

    Private Sub btnShowAddPayment_Click(sender As Object, e As EventArgs) Handles btnShowAddPayment.Click
        Dim form = New frmCollection
        'frmAddCust.BringToFront()
        form.Show()
    End Sub
End Class