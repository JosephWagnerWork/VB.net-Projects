<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildProgression
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdateProgression = New System.Windows.Forms.Button()
        Me.BtnAddProgression = New System.Windows.Forms.Button()
        Me.CALP_Date = New System.Windows.Forms.DateTimePicker()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtP_Notes = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.DGVChild = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVChild, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnDelete)
        Me.GroupBox2.Controls.Add(Me.CALP_Date)
        Me.GroupBox2.Controls.Add(Me.BtnUpdateProgression)
        Me.GroupBox2.Controls.Add(Me.BtnAddProgression)
        Me.GroupBox2.Controls.Add(Me.BtnAdd)
        Me.GroupBox2.Controls.Add(Me.TxtP_Notes)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 524)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(829, 155)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Child Progression"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(354, 22)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(183, 23)
        Me.BtnDelete.TabIndex = 10
        Me.BtnDelete.Text = "Delete child Progression"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnUpdateProgression
        '
        Me.BtnUpdateProgression.Location = New System.Drawing.Point(462, 66)
        Me.BtnUpdateProgression.Name = "BtnUpdateProgression"
        Me.BtnUpdateProgression.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdateProgression.TabIndex = 28
        Me.BtnUpdateProgression.Text = "Update"
        Me.BtnUpdateProgression.UseVisualStyleBackColor = True
        '
        'BtnAddProgression
        '
        Me.BtnAddProgression.Location = New System.Drawing.Point(354, 66)
        Me.BtnAddProgression.Name = "BtnAddProgression"
        Me.BtnAddProgression.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddProgression.TabIndex = 29
        Me.BtnAddProgression.Text = "Add"
        Me.BtnAddProgression.UseVisualStyleBackColor = True
        '
        'CALP_Date
        '
        Me.CALP_Date.Location = New System.Drawing.Point(107, 59)
        Me.CALP_Date.Name = "CALP_Date"
        Me.CALP_Date.Size = New System.Drawing.Size(160, 20)
        Me.CALP_Date.TabIndex = 38
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(107, 106)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 37
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(192, 106)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 36
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Progression Notes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 528)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 34
        '
        'TxtP_Notes
        '
        Me.TxtP_Notes.Location = New System.Drawing.Point(107, 19)
        Me.TxtP_Notes.Name = "TxtP_Notes"
        Me.TxtP_Notes.Size = New System.Drawing.Size(160, 20)
        Me.TxtP_Notes.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.TxtSearch)
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(829, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(103, 679)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.Color.White
        Me.TxtSearch.Location = New System.Drawing.Point(5, 19)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(92, 20)
        Me.TxtSearch.TabIndex = 2
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(6, 45)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(92, 23)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'DGVChild
        '
        Me.DGVChild.BackgroundColor = System.Drawing.Color.White
        Me.DGVChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVChild.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVChild.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVChild.Location = New System.Drawing.Point(0, 0)
        Me.DGVChild.Name = "DGVChild"
        Me.DGVChild.Size = New System.Drawing.Size(829, 679)
        Me.DGVChild.TabIndex = 0
        '
        'ChildProgression
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 679)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGVChild)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ChildProgression"
        Me.Text = "ChildProgression"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVChild, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdateProgression As Button
    Friend WithEvents BtnAddProgression As Button
    Friend WithEvents CALP_Date As DateTimePicker
    Friend WithEvents BtnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtP_Notes As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents DGVChild As DataGridView
    Friend WithEvents BtnSearch As Button
End Class
