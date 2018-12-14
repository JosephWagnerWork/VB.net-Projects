<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activities
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.DGVChild = New System.Windows.Forms.DataGridView()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtActType = New System.Windows.Forms.TextBox()
        Me.TxtItemsNeeded = New System.Windows.Forms.TextBox()
        Me.CALActivityType = New System.Windows.Forms.DateTimePicker()
        Me.BtnAddParticipent = New System.Windows.Forms.Button()
        Me.BtnUpdateParticipent = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVChild, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.TxtSearch)
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(1038, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(103, 543)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.Color.White
        Me.TxtSearch.Location = New System.Drawing.Point(12, 19)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(86, 20)
        Me.TxtSearch.TabIndex = 3
        '
        'DGVChild
        '
        Me.DGVChild.BackgroundColor = System.Drawing.Color.White
        Me.DGVChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVChild.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVChild.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVChild.Location = New System.Drawing.Point(0, 0)
        Me.DGVChild.Name = "DGVChild"
        Me.DGVChild.Size = New System.Drawing.Size(1038, 543)
        Me.DGVChild.TabIndex = 0
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(12, 45)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(86, 23)
        Me.BtnSearch.TabIndex = 2
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(553, 16)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(183, 23)
        Me.BtnDelete.TabIndex = 10
        Me.BtnDelete.Text = "Delete Activity Participents"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(278, 54)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 20)
        Me.BtnAdd.TabIndex = 21
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(363, 54)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 20)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Items Needed"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Activity Type"
        '
        'TxtActType
        '
        Me.TxtActType.Location = New System.Drawing.Point(94, 19)
        Me.TxtActType.Name = "TxtActType"
        Me.TxtActType.Size = New System.Drawing.Size(160, 20)
        Me.TxtActType.TabIndex = 16
        '
        'TxtItemsNeeded
        '
        Me.TxtItemsNeeded.Location = New System.Drawing.Point(94, 54)
        Me.TxtItemsNeeded.Name = "TxtItemsNeeded"
        Me.TxtItemsNeeded.Size = New System.Drawing.Size(160, 20)
        Me.TxtItemsNeeded.TabIndex = 17
        '
        'CALActivityType
        '
        Me.CALActivityType.CustomFormat = "DDMMYYYY"
        Me.CALActivityType.Location = New System.Drawing.Point(278, 19)
        Me.CALActivityType.Name = "CALActivityType"
        Me.CALActivityType.Size = New System.Drawing.Size(160, 20)
        Me.CALActivityType.TabIndex = 23
        '
        'BtnAddParticipent
        '
        Me.BtnAddParticipent.Location = New System.Drawing.Point(553, 56)
        Me.BtnAddParticipent.Name = "BtnAddParticipent"
        Me.BtnAddParticipent.Size = New System.Drawing.Size(75, 20)
        Me.BtnAddParticipent.TabIndex = 29
        Me.BtnAddParticipent.Text = "Add"
        Me.BtnAddParticipent.UseVisualStyleBackColor = True
        '
        'BtnUpdateParticipent
        '
        Me.BtnUpdateParticipent.Location = New System.Drawing.Point(651, 56)
        Me.BtnUpdateParticipent.Name = "BtnUpdateParticipent"
        Me.BtnUpdateParticipent.Size = New System.Drawing.Size(75, 20)
        Me.BtnUpdateParticipent.TabIndex = 28
        Me.BtnUpdateParticipent.Text = "Update"
        Me.BtnUpdateParticipent.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnDelete)
        Me.GroupBox2.Controls.Add(Me.BtnUpdateParticipent)
        Me.GroupBox2.Controls.Add(Me.CALActivityType)
        Me.GroupBox2.Controls.Add(Me.BtnAddParticipent)
        Me.GroupBox2.Controls.Add(Me.BtnAdd)
        Me.GroupBox2.Controls.Add(Me.TxtItemsNeeded)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.TxtActType)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 445)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1038, 98)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Activity Participents"
        '
        'Activities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 543)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGVChild)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Activities"
        Me.Text = "Activities"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVChild, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents DGVChild As DataGridView
    Friend WithEvents BtnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtActType As TextBox
    Friend WithEvents TxtItemsNeeded As TextBox
    Friend WithEvents CALActivityType As DateTimePicker
    Friend WithEvents BtnAddParticipent As Button
    Friend WithEvents BtnUpdateParticipent As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
