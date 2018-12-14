<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Foreign_Key_Selector
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
        Me.DGVSelector = New System.Windows.Forms.DataGridView()
        Me.BtnOK = New System.Windows.Forms.Button()
        CType(Me.DGVSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVSelector
        '
        Me.DGVSelector.AllowUserToAddRows = False
        Me.DGVSelector.AllowUserToDeleteRows = False
        Me.DGVSelector.AllowUserToResizeColumns = False
        Me.DGVSelector.AllowUserToResizeRows = False
        Me.DGVSelector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSelector.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVSelector.Location = New System.Drawing.Point(0, 0)
        Me.DGVSelector.MultiSelect = False
        Me.DGVSelector.Name = "DGVSelector"
        Me.DGVSelector.Size = New System.Drawing.Size(456, 337)
        Me.DGVSelector.TabIndex = 0
        '
        'BtnOK
        '
        Me.BtnOK.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnOK.Location = New System.Drawing.Point(0, 314)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(456, 23)
        Me.BtnOK.TabIndex = 1
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'Foreign_Key_Selector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 337)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.DGVSelector)
        Me.Name = "Foreign_Key_Selector"
        Me.Text = "Foreign_Key_Selector"
        CType(Me.DGVSelector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVSelector As DataGridView
    Friend WithEvents BtnOK As Button
End Class
