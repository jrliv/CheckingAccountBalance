
Public Class CheckAccBalanceForm

    Dim TotalNumberDeposits, TotalNumberChecks, TotalNumberServiceCharges As Integer
    Dim NewBalanceDecimal, TransactionAmountDecimal As Decimal

    Private Function CalculateCheck(ByVal TransactionAmountDecimal As Decimal) As Decimal
        Return NewBalanceDecimal - TransactionAmountDecimal
    End Function

    Private Function CalculateDeposit(ByVal TransactionAmountDecimal As Decimal) As Decimal
        Return NewBalanceDecimal + TransactionAmountDecimal
    End Function

    Private Function CalculateServiceCharge(ByVal TransactionAmountDecimal As Decimal) As Decimal
        Return NewBalanceDecimal - TransactionAmountDecimal
    End Function

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        'Displays summary
        Dim MessageString As String
        If NewBalanceDecimal <> 0 Then
            MessageString = "Number of checks: " & TotalNumberChecks.ToString() & Environment.NewLine _
            & "Number of deposits: " & TotalNumberDeposits.ToString() & Environment.NewLine _
            & "Number of service charges: " & TotalNumberServiceCharges.ToString() & Environment.NewLine & Environment.NewLine _
            & "Current balance: " & NewBalanceDecimal.ToString("C")
            MessageBox.Show(MessageString, "Checking Account Summary", MessageBoxButtons.OK)
        Else
            MessageString = "No data to summarize"
            MessageBox.Show(MessageString, "Checking Account Summary", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        'Performs calculations from the toolstrip menu.
        Try
            TransactionAmountDecimal = Decimal.Parse(TransactionAmountTextBox.Text)

            If CheckRadioButton.Checked Then
                If TransactionAmountDecimal > NewBalanceDecimal Then
                    MessageBox.Show("Insufficient funds.", "Error", MessageBoxButtons.OK)
                    TotalNumberServiceCharges += 1
                    NewBalanceDecimal = NewBalanceDecimal - 10.0
                Else
                    NewBalanceDecimal = CalculateCheck(TransactionAmountDecimal)
                    TotalNumberChecks += 1
                End If
            ElseIf DepositRadioButton.Checked Then
                NewBalanceDecimal = CalculateDeposit(TransactionAmountDecimal)
                TotalNumberDeposits += 1
            ElseIf ServiceChargeRadioButton.Checked Then
                NewBalanceDecimal = CalculateCheck(TransactionAmountDecimal)
                TotalNumberServiceCharges += 1
            End If
            NewBalanceTextBox.Text = NewBalanceDecimal.ToString("C")
        Catch ex As Exception
            MessageBox.Show("Please select your transaction type and enter a decimal number for the transaction amount.", "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub CToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CToolStripMenuItem.Click
        'Clears transaction amount textbox from the toolstrip.
        With Me
            Me.TransactionAmountTextBox.Clear()
            Me.TransactionAmountTextBox.Focus()
        End With
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        'Allows user to change textbox font.
        With Me.FontDialog1
            .Font = Me.TransactionAmountTextBox.Font
            .ShowDialog()
            Me.TransactionAmountTextBox.Font = .Font
            Me.NewBalanceTextBox.Font = Font
        End With
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        'Allows user to change textbox colors.
        With Me.ColorDialog1
            .Color = Me.TransactionAmountTextBox.BackColor
            .ShowDialog()
            Me.TransactionAmountTextBox.BackColor = .Color
            Me.NewBalanceTextBox.BackColor = .Color
        End With
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        'Displays About information.
        Dim MessageString = "Checking Account Balance" & Environment.NewLine & Environment.NewLine _
        & "Jae Logan" & Environment.NewLine & "Created: 6/15/2010" & Environment.NewLine _
        & "Last edited: 8/4/2017" & Environment.NewLine & "jrliv.com"
        MessageBox.Show(MessageString, "About", MessageBoxButtons.OK)
    End Sub

    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        'Performs calculations from the Calculate button.
        Try
            TransactionAmountDecimal = Decimal.Parse(TransactionAmountTextBox.Text)

            If CheckRadioButton.Checked Then
                If TransactionAmountDecimal > NewBalanceDecimal Then
                    MessageBox.Show("Insufficient funds.", "Error", MessageBoxButtons.OK)
                    NewBalanceDecimal = NewBalanceDecimal - 10.0
                    TotalNumberServiceCharges += 1
                Else
                    NewBalanceDecimal = CalculateCheck(TransactionAmountDecimal)
                    TotalNumberChecks += 1
                End If
            ElseIf DepositRadioButton.Checked Then
                NewBalanceDecimal = CalculateDeposit(TransactionAmountDecimal)
                TotalNumberDeposits += 1
            ElseIf ServiceChargeRadioButton.Checked Then
                NewBalanceDecimal = CalculateCheck(TransactionAmountDecimal)
                TotalNumberServiceCharges += 1
            End If
            NewBalanceTextBox.Text = NewBalanceDecimal.ToString("C")
        Catch ex As Exception
            MessageBox.Show("Please select your transaction type and enter a decimal number for the transaction amount.", "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'Clears transaction amount textbox from the Clear button.
        With Me
            Me.TransactionAmountTextBox.Clear()
            Me.TransactionAmountTextBox.Focus()
        End With
    End Sub
End Class