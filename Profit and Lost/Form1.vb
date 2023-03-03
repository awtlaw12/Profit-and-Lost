Public Class frmStatus
    Private Sub btnShowFinancialStatus_Click(sender As Object, e As EventArgs) Handles btnShowFinancialStatus.Click
        Dim costs, revenue, profit, loss As Double
        costs = CDbl(txtCost.Text)
        revenue = CDbl(txtRev.Text)
        If costs = revenue Then
            txtResults.Text = "Break even"
        ElseIf costs < revenue Then
            profit = revenue - costs
            txtResults.Text = "Profit is " & FormatCurrency(profit)
        Else
            loss = costs - revenue
            txtResults.Text = "Loss is " & FormatCurrency(loss)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Display a message box to confirm whether the user wants to exit
        Dim msgResponse As MsgBoxResult, Cancel
        msgResponse = MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo, "Confirm Exit")

        ' If the user clicks No, cancel the form closing event
        If msgResponse = vbNo Then
            Cancel = True
        ElseIf msgResponse = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
