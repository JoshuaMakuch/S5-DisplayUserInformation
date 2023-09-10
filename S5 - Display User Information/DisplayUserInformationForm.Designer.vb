<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayUserInformationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DisplayButBackwardsButton = New System.Windows.Forms.Button()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.FinalOutputLabel = New System.Windows.Forms.Label()
        Me.FinalOutputTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdateLabel = New System.Windows.Forms.Label()
        Me.BirthdateTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DisplayButBackwardsButton
        '
        Me.DisplayButBackwardsButton.Location = New System.Drawing.Point(633, 99)
        Me.DisplayButBackwardsButton.Name = "DisplayButBackwardsButton"
        Me.DisplayButBackwardsButton.Size = New System.Drawing.Size(154, 77)
        Me.DisplayButBackwardsButton.TabIndex = 31
        Me.DisplayButBackwardsButton.Text = "Display, But Backwards"
        Me.DisplayButBackwardsButton.UseVisualStyleBackColor = True
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(633, 16)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(154, 77)
        Me.DisplayButton.TabIndex = 30
        Me.DisplayButton.Text = "Display"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'FinalOutputLabel
        '
        Me.FinalOutputLabel.AutoSize = True
        Me.FinalOutputLabel.Location = New System.Drawing.Point(12, 249)
        Me.FinalOutputLabel.Name = "FinalOutputLabel"
        Me.FinalOutputLabel.Size = New System.Drawing.Size(90, 20)
        Me.FinalOutputLabel.TabIndex = 29
        Me.FinalOutputLabel.Text = "Final Output"
        '
        'FinalOutputTextBox
        '
        Me.FinalOutputTextBox.Location = New System.Drawing.Point(12, 277)
        Me.FinalOutputTextBox.Name = "FinalOutputTextBox"
        Me.FinalOutputTextBox.ReadOnly = True
        Me.FinalOutputTextBox.Size = New System.Drawing.Size(766, 27)
        Me.FinalOutputTextBox.TabIndex = 28
        '
        'BirthdateLabel
        '
        Me.BirthdateLabel.AutoSize = True
        Me.BirthdateLabel.Location = New System.Drawing.Point(12, 172)
        Me.BirthdateLabel.Name = "BirthdateLabel"
        Me.BirthdateLabel.Size = New System.Drawing.Size(70, 20)
        Me.BirthdateLabel.TabIndex = 27
        Me.BirthdateLabel.Text = "Birthdate"
        '
        'BirthdateTextBox
        '
        Me.BirthdateTextBox.Location = New System.Drawing.Point(12, 195)
        Me.BirthdateTextBox.Name = "BirthdateTextBox"
        Me.BirthdateTextBox.Size = New System.Drawing.Size(585, 27)
        Me.BirthdateTextBox.TabIndex = 26
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Location = New System.Drawing.Point(12, 119)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(50, 20)
        Me.PhoneLabel.TabIndex = 25
        Me.PhoneLabel.Text = "Phone"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(12, 142)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(585, 27)
        Me.PhoneTextBox.TabIndex = 24
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(12, 66)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(62, 20)
        Me.AddressLabel.TabIndex = 23
        Me.AddressLabel.Text = "Address"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(12, 89)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(585, 27)
        Me.AddressTextBox.TabIndex = 22
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(12, 13)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(49, 20)
        Me.NameLabel.TabIndex = 21
        Me.NameLabel.Text = "Name"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(12, 36)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(585, 27)
        Me.NameTextBox.TabIndex = 20
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(633, 182)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(154, 77)
        Me.QuitButton.TabIndex = 19
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'DisplayUserInformationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 312)
        Me.Controls.Add(Me.DisplayButBackwardsButton)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.FinalOutputLabel)
        Me.Controls.Add(Me.FinalOutputTextBox)
        Me.Controls.Add(Me.BirthdateLabel)
        Me.Controls.Add(Me.BirthdateTextBox)
        Me.Controls.Add(Me.PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.QuitButton)
        Me.Name = "DisplayUserInformationForm"
        Me.Text = "DisplayUserInformationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayButBackwardsButton As Button
    Friend WithEvents DisplayButton As Button
    Friend WithEvents FinalOutputLabel As Label
    Friend WithEvents FinalOutputTextBox As TextBox
    Friend WithEvents BirthdateLabel As Label
    Friend WithEvents BirthdateTextBox As TextBox
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents AddressLabel As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents QuitButton As Button
End Class
