﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckAccBalanceForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckAccBalanceForm))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.TransactionTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.ServiceChargeRadioButton = New System.Windows.Forms.RadioButton()
        Me.DepositRadioButton = New System.Windows.Forms.RadioButton()
        Me.CheckRadioButton = New System.Windows.Forms.RadioButton()
        Me.TransactionAmountLabel = New System.Windows.Forms.Label()
        Me.TransactionAmountTextBox = New System.Windows.Forms.TextBox()
        Me.NewBalanceLabel = New System.Windows.Forms.Label()
        Me.NewBalanceTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.TransactionTypeGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(142, 43)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(270, 25)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Checking Account Balance"
        '
        'TransactionTypeGroupBox
        '
        Me.TransactionTypeGroupBox.Controls.Add(Me.ServiceChargeRadioButton)
        Me.TransactionTypeGroupBox.Controls.Add(Me.DepositRadioButton)
        Me.TransactionTypeGroupBox.Controls.Add(Me.CheckRadioButton)
        Me.TransactionTypeGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionTypeGroupBox.Location = New System.Drawing.Point(70, 126)
        Me.TransactionTypeGroupBox.Name = "TransactionTypeGroupBox"
        Me.TransactionTypeGroupBox.Size = New System.Drawing.Size(161, 96)
        Me.TransactionTypeGroupBox.TabIndex = 1
        Me.TransactionTypeGroupBox.TabStop = False
        Me.TransactionTypeGroupBox.Text = "Transaction Type"
        '
        'ServiceChargeRadioButton
        '
        Me.ServiceChargeRadioButton.AutoSize = True
        Me.ServiceChargeRadioButton.Location = New System.Drawing.Point(6, 65)
        Me.ServiceChargeRadioButton.Name = "ServiceChargeRadioButton"
        Me.ServiceChargeRadioButton.Size = New System.Drawing.Size(135, 24)
        Me.ServiceChargeRadioButton.TabIndex = 2
        Me.ServiceChargeRadioButton.TabStop = True
        Me.ServiceChargeRadioButton.Text = "Service Charge"
        Me.ServiceChargeRadioButton.UseVisualStyleBackColor = True
        '
        'DepositRadioButton
        '
        Me.DepositRadioButton.AutoSize = True
        Me.DepositRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.DepositRadioButton.Name = "DepositRadioButton"
        Me.DepositRadioButton.Size = New System.Drawing.Size(82, 24)
        Me.DepositRadioButton.TabIndex = 2
        Me.DepositRadioButton.TabStop = True
        Me.DepositRadioButton.Text = "Deposit"
        Me.DepositRadioButton.UseVisualStyleBackColor = True
        '
        'CheckRadioButton
        '
        Me.CheckRadioButton.AutoSize = True
        Me.CheckRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.CheckRadioButton.Name = "CheckRadioButton"
        Me.CheckRadioButton.Size = New System.Drawing.Size(72, 24)
        Me.CheckRadioButton.TabIndex = 2
        Me.CheckRadioButton.TabStop = True
        Me.CheckRadioButton.Text = "Check"
        Me.CheckRadioButton.UseVisualStyleBackColor = True
        '
        'TransactionAmountLabel
        '
        Me.TransactionAmountLabel.AutoSize = True
        Me.TransactionAmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionAmountLabel.Location = New System.Drawing.Point(315, 126)
        Me.TransactionAmountLabel.Name = "TransactionAmountLabel"
        Me.TransactionAmountLabel.Size = New System.Drawing.Size(152, 20)
        Me.TransactionAmountLabel.TabIndex = 2
        Me.TransactionAmountLabel.Text = "Transaction Amount"
        '
        'TransactionAmountTextBox
        '
        Me.TransactionAmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionAmountTextBox.Location = New System.Drawing.Point(319, 149)
        Me.TransactionAmountTextBox.Name = "TransactionAmountTextBox"
        Me.TransactionAmountTextBox.Size = New System.Drawing.Size(148, 26)
        Me.TransactionAmountTextBox.TabIndex = 3
        '
        'NewBalanceLabel
        '
        Me.NewBalanceLabel.AutoSize = True
        Me.NewBalanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewBalanceLabel.Location = New System.Drawing.Point(339, 185)
        Me.NewBalanceLabel.Name = "NewBalanceLabel"
        Me.NewBalanceLabel.Size = New System.Drawing.Size(102, 20)
        Me.NewBalanceLabel.TabIndex = 7
        Me.NewBalanceLabel.Text = "New Balance"
        '
        'NewBalanceTextBox
        '
        Me.NewBalanceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewBalanceTextBox.Location = New System.Drawing.Point(343, 208)
        Me.NewBalanceTextBox.Name = "NewBalanceTextBox"
        Me.NewBalanceTextBox.ReadOnly = True
        Me.NewBalanceTextBox.Size = New System.Drawing.Size(100, 26)
        Me.NewBalanceTextBox.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(564, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SummaryToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(122, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.TransactionToolStripMenuItem.Text = " "
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.CToolStripMenuItem, Me.ToolStripSeparator1, Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ClearToolStripMenuItem.Text = "&Calculate"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.CToolStripMenuItem.Text = "C&lear"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(120, 6)
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.FontToolStripMenuItem.Text = "&Font"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ColorToolStripMenuItem.Text = "C&olor"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem.Text = "&Help"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.HelpToolStripMenuItem.Text = "&About"
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(159, 333)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(94, 38)
        Me.CalculateButton.TabIndex = 11
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(305, 333)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(81, 38)
        Me.ClearButton.TabIndex = 12
        Me.ClearButton.Text = "C&lear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CheckAccBalanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 409)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.NewBalanceTextBox)
        Me.Controls.Add(Me.NewBalanceLabel)
        Me.Controls.Add(Me.TransactionAmountTextBox)
        Me.Controls.Add(Me.TransactionAmountLabel)
        Me.Controls.Add(Me.TransactionTypeGroupBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CheckAccBalanceForm"
        Me.Text = "Checking Account Balance"
        Me.TransactionTypeGroupBox.ResumeLayout(False)
        Me.TransactionTypeGroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents TransactionTypeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ServiceChargeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DepositRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CheckRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TransactionAmountLabel As System.Windows.Forms.Label
    Friend WithEvents TransactionAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NewBalanceLabel As System.Windows.Forms.Label
    Friend WithEvents NewBalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
End Class