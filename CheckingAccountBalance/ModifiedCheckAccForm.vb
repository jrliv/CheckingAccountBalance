
'Name: Jae Logan
'Date: 6/3/2010
'Description: This program will calculate the checking account transactions
'and display the new balance of the checking account. It will also display
'a summary of all the transactions. 

Public Class CheckAccBalanceForm

    'Declared variables
    Dim TotalNumberDeposits, TotalNumberChecks, TotalNumberServiceCharges As Integer
    Dim TotalAmountDeposits, TotalAmountChecks, TotalAmountServiceCharges As Decimal
    Dim NewBalanceDecimal, TransactionAmountDecimal As Decimal
    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        'Calculations
        Try
            TransactionAmountDecimal = Decimal.Parse(TransactionAmountTextBox.Text)

            If CheckRadioButton.Checked Then
                NewBalanceDecimal -= TransactionAmountDecimal
                TotalNumberChecks += 1
                TotalAmountChecks = NewBalanceDecimal
            ElseIf DepositRadioButton.Checked Then
                NewBalanceDecimal += TransactionAmountDecimal
                TotalNumberDeposits += 1
                TotalAmountDeposits = NewBalanceDecimal
            ElseIf ServiceChargeRadioButton.Checked Then
                NewBalanceDecimal -= TransactionAmountDecimal
                TotalNumberServiceCharges += 1
                TotalAmountServiceCharges = NewBalanceDecimal
            End If
            NewBalanceTextBox.Text = NewBalanceDecimal.ToString("C")
        Catch ex As Exception
            'Error message.
            MessageBox.Show("Insufficient Funds", "Error", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'Clears textboxes
        TransactionAmountTextBox.Clear()
        NewBalanceTextBox.Clear()
    End Sub

    Private Sub TransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionToolStripMenuItem.Click

    End Sub

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        'Displays summary
        Dim MessageString As String
        If NewBalanceDecimal <> 0 Then
            MessageString = "Number of checks: " & TotalNumberChecks.ToString() & Environment.NewLine & Environment.NewLine _
            & "Number of deposits: " & TotalNumberDeposits.ToString() & Environment.NewLine & Environment.NewLine _
            & "Number of service charges: " & TotalNumberServiceCharges.ToString() & Environment.NewLine & Environment.NewLine _
            & "Checks amount: " & TotalAmountChecks.ToString("C") & Environment.NewLine & Environment.NewLine _
            & "Deposits amount: " & TotalAmountDeposits.ToString("C") & Environment.NewLine & Environment.NewLine _
            & "Service charges amount: " & TotalAmountServiceCharges.ToString()
            MessageBox.Show(MessageString, "Checking Account Summary", MessageBoxButtons.OK)
        Else
            MessageString = "No data to summarize"
            MessageBox.Show(MessageString, "Checking Account Summary", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Terminates program
        Me.Close()
    End Sub
End Class