<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ContactTypesCheckedComboBox1 = New CheckComboBoxTest.CheckedComboBox()
        Me.ReadFromDatabaseButton = New System.Windows.Forms.Button()
        Me.ClearComboButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContactTypesCheckedComboBox1
        '
        Me.ContactTypesCheckedComboBox1.CheckOnClick = True
        Me.ContactTypesCheckedComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.ContactTypesCheckedComboBox1.DropDownHeight = 1
        Me.ContactTypesCheckedComboBox1.FormattingEnabled = True
        Me.ContactTypesCheckedComboBox1.IntegralHeight = False
        Me.ContactTypesCheckedComboBox1.Location = New System.Drawing.Point(12, 19)
        Me.ContactTypesCheckedComboBox1.Name = "ContactTypesCheckedComboBox1"
        Me.ContactTypesCheckedComboBox1.Size = New System.Drawing.Size(390, 21)
        Me.ContactTypesCheckedComboBox1.TabIndex = 1
        Me.ContactTypesCheckedComboBox1.ValueSeparator = ", "
        '
        'ReadFromDatabaseButton
        '
        Me.ReadFromDatabaseButton.Location = New System.Drawing.Point(408, 17)
        Me.ReadFromDatabaseButton.Name = "ReadFromDatabaseButton"
        Me.ReadFromDatabaseButton.Size = New System.Drawing.Size(75, 23)
        Me.ReadFromDatabaseButton.TabIndex = 2
        Me.ReadFromDatabaseButton.Text = "Read"
        Me.ReadFromDatabaseButton.UseVisualStyleBackColor = True
        '
        'ClearComboButton
        '
        Me.ClearComboButton.Location = New System.Drawing.Point(489, 17)
        Me.ClearComboButton.Name = "ClearComboButton"
        Me.ClearComboButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearComboButton.TabIndex = 3
        Me.ClearComboButton.Text = "Clear"
        Me.ClearComboButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ContactTypesCheckedComboBox1)
        Me.Panel1.Controls.Add(Me.ClearComboButton)
        Me.Panel1.Controls.Add(Me.ReadFromDatabaseButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(585, 64)
        Me.Panel1.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(585, 206)
        Me.DataGridView1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 270)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContactTypesCheckedComboBox1 As CheckComboBoxTest.CheckedComboBox
    Friend WithEvents ReadFromDatabaseButton As Button
    Friend WithEvents ClearComboButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
End Class
