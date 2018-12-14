<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildParent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.DGVChild = New System.Windows.Forms.DataGridView()
        Me.BtnDeleteParents = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.TxtFname = New System.Windows.Forms.TextBox()
        Me.TxtSname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnParentAdd = New System.Windows.Forms.Button()
        Me.BtnParentUpdate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtParentFname = New System.Windows.Forms.TextBox()
        Me.TxtParentSname = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DGVChild, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVChild
        '
        Me.DGVChild.BackgroundColor = System.Drawing.Color.White
        Me.DGVChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVChild.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVChild.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVChild.Location = New System.Drawing.Point(0, 0)
        Me.DGVChild.Name = "DGVChild"
        Me.DGVChild.Size = New System.Drawing.Size(804, 470)
        Me.DGVChild.TabIndex = 0
        '
        'BtnDeleteParents
        '
        Me.BtnDeleteParents.Location = New System.Drawing.Point(64, 138)
        Me.BtnDeleteParents.Name = "BtnDeleteParents"
        Me.BtnDeleteParents.Size = New System.Drawing.Size(91, 23)
        Me.BtnDeleteParents.TabIndex = 11
        Me.BtnDeleteParents.Text = "Delete Parent"
        Me.BtnDeleteParents.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(64, 96)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(91, 23)
        Me.BtnDelete.TabIndex = 10
        Me.BtnDelete.Text = "Delete Child"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(80, 54)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 2
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.Color.White
        Me.TxtSearch.Location = New System.Drawing.Point(5, 17)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(150, 20)
        Me.TxtSearch.TabIndex = 3
        '
        'TxtFname
        '
        Me.TxtFname.Location = New System.Drawing.Point(93, 29)
        Me.TxtFname.Name = "TxtFname"
        Me.TxtFname.Size = New System.Drawing.Size(160, 20)
        Me.TxtFname.TabIndex = 4
        '
        'TxtSname
        '
        Me.TxtSname.Location = New System.Drawing.Point(93, 64)
        Me.TxtSname.Name = "TxtSname"
        Me.TxtSname.Size = New System.Drawing.Size(160, 20)
        Me.TxtSname.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Child First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Child Surname"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(174, 90)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(93, 90)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 9
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnParentAdd
        '
        Me.BtnParentAdd.Location = New System.Drawing.Point(365, 90)
        Me.BtnParentAdd.Name = "BtnParentAdd"
        Me.BtnParentAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnParentAdd.TabIndex = 15
        Me.BtnParentAdd.Text = "Add"
        Me.BtnParentAdd.UseVisualStyleBackColor = True
        '
        'BtnParentUpdate
        '
        Me.BtnParentUpdate.Location = New System.Drawing.Point(446, 90)
        Me.BtnParentUpdate.Name = "BtnParentUpdate"
        Me.BtnParentUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnParentUpdate.TabIndex = 14
        Me.BtnParentUpdate.Text = "Update"
        Me.BtnParentUpdate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(276, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Parent Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Parent First Name"
        '
        'TxtParentFname
        '
        Me.TxtParentFname.Location = New System.Drawing.Point(365, 29)
        Me.TxtParentFname.Name = "TxtParentFname"
        Me.TxtParentFname.Size = New System.Drawing.Size(160, 20)
        Me.TxtParentFname.TabIndex = 10
        '
        'TxtParentSname
        '
        Me.TxtParentSname.Location = New System.Drawing.Point(365, 64)
        Me.TxtParentSname.Name = "TxtParentSname"
        Me.TxtParentSname.Size = New System.Drawing.Size(160, 20)
        Me.TxtParentSname.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtSearch)
        Me.GroupBox2.Controls.Add(Me.BtnDeleteParents)
        Me.GroupBox2.Controls.Add(Me.BtnSearch)
        Me.GroupBox2.Controls.Add(Me.BtnDelete)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Location = New System.Drawing.Point(804, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 470)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSname)
        Me.GroupBox1.Controls.Add(Me.TxtFname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnParentAdd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnParentUpdate)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtParentSname)
        Me.GroupBox1.Controls.Add(Me.TxtParentFname)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 349)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 121)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'ChildParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 470)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGVChild)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ChildParent"
        Me.Text = "Child"
        CType(Me.DGVChild, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVChild As DataGridView
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents TxtFname As TextBox
    Friend WithEvents TxtSname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnParentAdd As Button
    Friend WithEvents BtnParentUpdate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtParentFname As TextBox
    Friend WithEvents TxtParentSname As TextBox
    Friend WithEvents BtnDeleteParents As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
