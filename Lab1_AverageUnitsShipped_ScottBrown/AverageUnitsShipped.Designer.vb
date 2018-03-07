<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtInputBox = New System.Windows.Forms.TextBox()
        Me.lblDayLabel = New System.Windows.Forms.Label()
        Me.lblResultDisplay = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtResultBox = New System.Windows.Forms.TextBox()
        Me.AverageShippedToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(80, 29)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(44, 17)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInputBox
        '
        Me.txtInputBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtInputBox.Location = New System.Drawing.Point(156, 26)
        Me.txtInputBox.Name = "txtInputBox"
        Me.txtInputBox.Size = New System.Drawing.Size(68, 22)
        Me.txtInputBox.TabIndex = 2
        Me.AverageShippedToolTips.SetToolTip(Me.txtInputBox, "Enter the amount of units shipped for teh specified date here.")
        '
        'lblDayLabel
        '
        Me.lblDayLabel.Location = New System.Drawing.Point(246, 29)
        Me.lblDayLabel.Name = "lblDayLabel"
        Me.lblDayLabel.Size = New System.Drawing.Size(58, 19)
        Me.lblDayLabel.TabIndex = 3
        Me.lblDayLabel.Text = "&Day 1"
        Me.lblDayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblResultDisplay
        '
        Me.lblResultDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultDisplay.Location = New System.Drawing.Point(83, 260)
        Me.lblResultDisplay.Name = "lblResultDisplay"
        Me.lblResultDisplay.Size = New System.Drawing.Size(221, 37)
        Me.lblResultDisplay.TabIndex = 5
        Me.lblResultDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageShippedToolTips.SetToolTip(Me.lblResultDisplay, "Displays the average units shipped in the week.")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 322)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(112, 37)
        Me.btnEnter.TabIndex = 6
        Me.btnEnter.Text = "&Enter"
        Me.AverageShippedToolTips.SetToolTip(Me.btnEnter, "This button is used when for when you want to add a value for each day." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(263, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 37)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.AverageShippedToolTips.SetToolTip(Me.btnExit, "Used to exit the form.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(137, 322)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(112, 37)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.AverageShippedToolTips.SetToolTip(Me.btnReset, "Used to reset this form.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtResultBox
        '
        Me.txtResultBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtResultBox.Location = New System.Drawing.Point(83, 60)
        Me.txtResultBox.Multiline = True
        Me.txtResultBox.Name = "txtResultBox"
        Me.txtResultBox.ReadOnly = True
        Me.txtResultBox.Size = New System.Drawing.Size(221, 191)
        Me.txtResultBox.TabIndex = 4
        Me.AverageShippedToolTips.SetToolTip(Me.txtResultBox, "Shows the units shipped for each day entered by you." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(387, 371)
        Me.Controls.Add(Me.txtResultBox)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblResultDisplay)
        Me.Controls.Add(Me.lblDayLabel)
        Me.Controls.Add(Me.txtInputBox)
        Me.Controls.Add(Me.lblUnits)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtInputBox As TextBox
    Friend WithEvents lblDayLabel As Label
    Friend WithEvents lblResultDisplay As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtResultBox As TextBox
    Friend WithEvents AverageShippedToolTips As ToolTip
End Class
