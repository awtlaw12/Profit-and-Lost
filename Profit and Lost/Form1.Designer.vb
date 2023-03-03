<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatus
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
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.lblFinancialStatus = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtRev = New System.Windows.Forms.TextBox()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.btnShowFinancialStatus = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(68, 89)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(45, 23)
        Me.lblCost.TabIndex = 0
        Me.lblCost.Text = "Cost"
        '
        'lblRevenue
        '
        Me.lblRevenue.AutoSize = True
        Me.lblRevenue.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenue.Location = New System.Drawing.Point(68, 158)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(77, 23)
        Me.lblRevenue.TabIndex = 1
        Me.lblRevenue.Text = "Revenue"
        '
        'lblFinancialStatus
        '
        Me.lblFinancialStatus.AutoSize = True
        Me.lblFinancialStatus.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinancialStatus.Location = New System.Drawing.Point(68, 236)
        Me.lblFinancialStatus.Name = "lblFinancialStatus"
        Me.lblFinancialStatus.Size = New System.Drawing.Size(131, 23)
        Me.lblFinancialStatus.TabIndex = 2
        Me.lblFinancialStatus.Text = "Financial Status"
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(213, 81)
        Me.txtCost.Multiline = True
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(182, 40)
        Me.txtCost.TabIndex = 3
        '
        'txtRev
        '
        Me.txtRev.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRev.Location = New System.Drawing.Point(213, 147)
        Me.txtRev.Multiline = True
        Me.txtRev.Name = "txtRev"
        Me.txtRev.Size = New System.Drawing.Size(182, 41)
        Me.txtRev.TabIndex = 4
        '
        'txtResults
        '
        Me.txtResults.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResults.Location = New System.Drawing.Point(213, 228)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ReadOnly = True
        Me.txtResults.Size = New System.Drawing.Size(182, 40)
        Me.txtResults.TabIndex = 5
        '
        'btnShowFinancialStatus
        '
        Me.btnShowFinancialStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowFinancialStatus.Location = New System.Drawing.Point(46, 344)
        Me.btnShowFinancialStatus.Name = "btnShowFinancialStatus"
        Me.btnShowFinancialStatus.Size = New System.Drawing.Size(219, 40)
        Me.btnShowFinancialStatus.TabIndex = 6
        Me.btnShowFinancialStatus.Text = "Show Financial Status"
        Me.btnShowFinancialStatus.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(317, 344)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(157, 40)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowFinancialStatus)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.txtRev)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.lblFinancialStatus)
        Me.Controls.Add(Me.lblRevenue)
        Me.Controls.Add(Me.lblCost)
        Me.Name = "frmStatus"
        Me.Text = "Profit And Lost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCost As Label
    Friend WithEvents lblRevenue As Label
    Friend WithEvents lblFinancialStatus As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtRev As TextBox
    Friend WithEvents txtResults As TextBox
    Friend WithEvents btnShowFinancialStatus As Button
    Friend WithEvents btnExit As Button
End Class
