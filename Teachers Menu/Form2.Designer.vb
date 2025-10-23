<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInputInfo = New System.Windows.Forms.Button()
        Me.btnInputGrades = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnViewReport = New System.Windows.Forms.Button()
        Me.btnSaveGrades = New System.Windows.Forms.Button()
        Me.btnGetRemarks = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Teacher Grading System"
        '
        'btnInputInfo
        '
        Me.btnInputInfo.Location = New System.Drawing.Point(49, 101)
        Me.btnInputInfo.Name = "btnInputInfo"
        Me.btnInputInfo.Size = New System.Drawing.Size(150, 36)
        Me.btnInputInfo.TabIndex = 1
        Me.btnInputInfo.Text = "Input Student Information"
        Me.btnInputInfo.UseVisualStyleBackColor = True
        '
        'btnInputGrades
        '
        Me.btnInputGrades.Location = New System.Drawing.Point(49, 154)
        Me.btnInputGrades.Name = "btnInputGrades"
        Me.btnInputGrades.Size = New System.Drawing.Size(150, 33)
        Me.btnInputGrades.TabIndex = 2
        Me.btnInputGrades.Text = "Input Grade"
        Me.btnInputGrades.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(49, 202)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(150, 33)
        Me.btnCompute.TabIndex = 3
        Me.btnCompute.Text = "Compute Final Grade"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnViewReport
        '
        Me.btnViewReport.Location = New System.Drawing.Point(49, 250)
        Me.btnViewReport.Name = "btnViewReport"
        Me.btnViewReport.Size = New System.Drawing.Size(150, 33)
        Me.btnViewReport.TabIndex = 4
        Me.btnViewReport.Text = "View Grade Report"
        Me.btnViewReport.UseVisualStyleBackColor = True
        '
        'btnSaveGrades
        '
        Me.btnSaveGrades.Location = New System.Drawing.Point(49, 301)
        Me.btnSaveGrades.Name = "btnSaveGrades"
        Me.btnSaveGrades.Size = New System.Drawing.Size(150, 33)
        Me.btnSaveGrades.TabIndex = 5
        Me.btnSaveGrades.Text = "Save Grade Records"
        Me.btnSaveGrades.UseVisualStyleBackColor = True
        '
        'btnGetRemarks
        '
        Me.btnGetRemarks.Location = New System.Drawing.Point(49, 349)
        Me.btnGetRemarks.Name = "btnGetRemarks"
        Me.btnGetRemarks.Size = New System.Drawing.Size(150, 33)
        Me.btnGetRemarks.TabIndex = 6
        Me.btnGetRemarks.Text = "Get Remarks"
        Me.btnGetRemarks.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(710, 405)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(78, 33)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnGetRemarks)
        Me.Controls.Add(Me.btnSaveGrades)
        Me.Controls.Add(Me.btnViewReport)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.btnInputGrades)
        Me.Controls.Add(Me.btnInputInfo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnInputInfo As Button
    Friend WithEvents btnInputGrades As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnViewReport As Button
    Friend WithEvents btnSaveGrades As Button
    Friend WithEvents btnGetRemarks As Button
    Friend WithEvents btnLogout As Button
End Class
