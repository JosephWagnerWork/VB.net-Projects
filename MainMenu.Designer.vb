<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.BtnChildParticipation = New System.Windows.Forms.Button()
        Me.BtnStaff = New System.Windows.Forms.Button()
        Me.BtnActivities = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnChildProgression = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnChildParticipation
        '
        Me.BtnChildParticipation.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnChildParticipation.Location = New System.Drawing.Point(0, 215)
        Me.BtnChildParticipation.Name = "BtnChildParticipation"
        Me.BtnChildParticipation.Size = New System.Drawing.Size(591, 46)
        Me.BtnChildParticipation.TabIndex = 0
        Me.BtnChildParticipation.Text = "Child Participation"
        Me.BtnChildParticipation.UseVisualStyleBackColor = True
        '
        'BtnStaff
        '
        Me.BtnStaff.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnStaff.Location = New System.Drawing.Point(0, 169)
        Me.BtnStaff.Name = "BtnStaff"
        Me.BtnStaff.Size = New System.Drawing.Size(591, 46)
        Me.BtnStaff.TabIndex = 1
        Me.BtnStaff.Text = "Staff"
        Me.BtnStaff.UseVisualStyleBackColor = True
        '
        'BtnActivities
        '
        Me.BtnActivities.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnActivities.Location = New System.Drawing.Point(0, 124)
        Me.BtnActivities.Name = "BtnActivities"
        Me.BtnActivities.Size = New System.Drawing.Size(591, 45)
        Me.BtnActivities.TabIndex = 2
        Me.BtnActivities.Text = "ActivityEditor"
        Me.BtnActivities.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(477, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "What do You Want to do Today"
        '
        'BtnChildProgression
        '
        Me.BtnChildProgression.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnChildProgression.Location = New System.Drawing.Point(0, 79)
        Me.BtnChildProgression.Name = "BtnChildProgression"
        Me.BtnChildProgression.Size = New System.Drawing.Size(591, 45)
        Me.BtnChildProgression.TabIndex = 4
        Me.BtnChildProgression.Text = "Child Progression Editor"
        Me.BtnChildProgression.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 261)
        Me.Controls.Add(Me.BtnChildProgression)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnActivities)
        Me.Controls.Add(Me.BtnStaff)
        Me.Controls.Add(Me.BtnChildParticipation)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnChildParticipation As Button
    Friend WithEvents BtnStaff As Button
    Friend WithEvents BtnActivities As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnChildProgression As Button
End Class
