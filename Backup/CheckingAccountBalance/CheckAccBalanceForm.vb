
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
    Private Sub TransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        'Calculations
        Try
            TransactionAmountDecimal = Decimal.Parse(TransactionAmountTextBox.Text)

            If CheckRadioButton.Checked Then
                If TransactionAmountDecimal > NewBalanceDecimal Then
                    MessageBox.Show("Insufficient Funds", "Error", MessageBoxButtons.OK)
                    NewBalanceDecimal = NewBalanceDecimal - 10.0
                    TotalNumberServiceCharges += 1
                    TotalAmountServiceCharges = NewBalanceDecimal
                Else
                    NewBalanceDecimal = CalculateCheck(TransactionAmountDecimal)
                    TotalNumberChecks += 1
                    TotalAmountChecks = NewBalanceDecimal
                End If
            ElseIf DepositRadioButton.Checked Then
                NewBalanceDecimal = CalculateDeposit(TransactionAmountDecimal)
                TotalNumberDeposits += 1
                TotalAmountDeposits = NewBalanceDecimal
            ElseIf ServiceChargeRadioButton.Checked Then
                NewBalanceDecimal = CalculateCheck(TransactionAmountDecimal)
                TotalNumberServiceCharges += 1
                TotalAmountServiceCharges = NewBalanceDecimal
            End If
            NewBalanceTextBox.Text = NewBalanceDecimal.ToString("C")
        Catch ex As Exception
            'Error message.
            MessageBox.Show("Insufficient Funds", "Error", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Terminates program
        Me.Close()
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
    Private Function CalculateCheck(ByVal TransactionAmountDecimal As Decimal) As Decimal
        'Calculate checks.
        Return NewBalanceDecimal - TransactionAmountDecimal
    End Function
    Private Function CalculateDeposit(ByVal TransactionAmountDecimal As Decimal) As Decimal
        'Calculates deposits.
        Return NewBalanceDecimal + TransactionAmountDecimal
    End Function
    Private Function CalculateServiceCharge(ByVal TransactionAmountDecimal As Decimal) As Decimal
        'Calculates services charges.
        Return NewBalanceDecimal - TransactionAmountDecimal
    End Function
    Private Sub CToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CToolStripMenuItem.Click
        'Clears textboxes.
        With Me
            Me.TransactionAmountTextBox.Clear()
            Me.NewBalanceTextBox.Clear()
            Me.TransactionAmountTextBox.Focus()
        End With
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        'Displays the about message box.
        Dim MessageString = "Checking Account Balance Program " & Environment.NewLine & Environment.NewLine _
        & "Written by: Jae Logan " & Environment.NewLine & "6/15/2010"
        MessageBox.Show(MessageString, "About", MessageBoxButtons.OK)
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        'Allows user to change font.
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
End Class