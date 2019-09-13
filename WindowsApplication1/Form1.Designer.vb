Imports FormControls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.ValidButton1 = New System.Windows.Forms.Button()
        Me.ValidWithApostropheButton = New System.Windows.Forms.Button()
        Me.WithNoSeparatorButton = New System.Windows.Forms.Button()
        Me.WithoutSelectStatementButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BadSelectStatementButton = New System.Windows.Forms.Button()
        Me.ValidWithNoMatchesButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ValidDateTimeButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ValidIntegersButton = New System.Windows.Forms.Button()
        Me.TextBoxWhere1 = New FormControls.TextBoxWhere()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ValidButton1
        '
        Me.ValidButton1.Location = New System.Drawing.Point(7, 15)
        Me.ValidButton1.Name = "ValidButton1"
        Me.ValidButton1.Size = New System.Drawing.Size(156, 23)
        Me.ValidButton1.TabIndex = 0
        Me.ValidButton1.Text = "Valid 1"
        Me.ValidButton1.UseVisualStyleBackColor = True
        '
        'ValidWithApostropheButton
        '
        Me.ValidWithApostropheButton.Location = New System.Drawing.Point(7, 44)
        Me.ValidWithApostropheButton.Name = "ValidWithApostropheButton"
        Me.ValidWithApostropheButton.Size = New System.Drawing.Size(156, 23)
        Me.ValidWithApostropheButton.TabIndex = 2
        Me.ValidWithApostropheButton.Text = "Valid 2 with apostrophe"
        Me.ValidWithApostropheButton.UseVisualStyleBackColor = True
        '
        'WithNoSeparatorButton
        '
        Me.WithNoSeparatorButton.Location = New System.Drawing.Point(7, 73)
        Me.WithNoSeparatorButton.Name = "WithNoSeparatorButton"
        Me.WithNoSeparatorButton.Size = New System.Drawing.Size(156, 23)
        Me.WithNoSeparatorButton.TabIndex = 3
        Me.WithNoSeparatorButton.Text = "No separator"
        Me.WithNoSeparatorButton.UseVisualStyleBackColor = True
        '
        'WithoutSelectStatementButton
        '
        Me.WithoutSelectStatementButton.Location = New System.Drawing.Point(7, 102)
        Me.WithoutSelectStatementButton.Name = "WithoutSelectStatementButton"
        Me.WithoutSelectStatementButton.Size = New System.Drawing.Size(156, 23)
        Me.WithoutSelectStatementButton.TabIndex = 4
        Me.WithoutSelectStatementButton.Text = "No SELECT statement"
        Me.WithoutSelectStatementButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 215)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(525, 254)
        Me.DataGridView1.TabIndex = 4
        '
        'BadSelectStatementButton
        '
        Me.BadSelectStatementButton.Location = New System.Drawing.Point(7, 131)
        Me.BadSelectStatementButton.Name = "BadSelectStatementButton"
        Me.BadSelectStatementButton.Size = New System.Drawing.Size(156, 23)
        Me.BadSelectStatementButton.TabIndex = 5
        Me.BadSelectStatementButton.Text = "Invalid SELECT statement"
        Me.BadSelectStatementButton.UseVisualStyleBackColor = True
        '
        'ValidWithNoMatchesButton
        '
        Me.ValidWithNoMatchesButton.Location = New System.Drawing.Point(178, 15)
        Me.ValidWithNoMatchesButton.Name = "ValidWithNoMatchesButton"
        Me.ValidWithNoMatchesButton.Size = New System.Drawing.Size(156, 23)
        Me.ValidWithNoMatchesButton.TabIndex = 1
        Me.ValidWithNoMatchesButton.Text = "Valid no matches"
        Me.ValidWithNoMatchesButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ValidWithNoMatchesButton)
        Me.GroupBox1.Controls.Add(Me.BadSelectStatementButton)
        Me.GroupBox1.Controls.Add(Me.WithoutSelectStatementButton)
        Me.GroupBox1.Controls.Add(Me.WithNoSeparatorButton)
        Me.GroupBox1.Controls.Add(Me.ValidWithApostropheButton)
        Me.GroupBox1.Controls.Add(Me.ValidButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 164)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "String"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ValidDateTimeButton)
        Me.GroupBox2.Location = New System.Drawing.Point(364, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(179, 59)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DateTime2(7)"
        '
        'ValidDateTimeButton
        '
        Me.ValidDateTimeButton.Location = New System.Drawing.Point(6, 19)
        Me.ValidDateTimeButton.Name = "ValidDateTimeButton"
        Me.ValidDateTimeButton.Size = New System.Drawing.Size(156, 23)
        Me.ValidDateTimeButton.TabIndex = 0
        Me.ValidDateTimeButton.Text = "Valid 1"
        Me.ValidDateTimeButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ValidIntegersButton)
        Me.GroupBox3.Location = New System.Drawing.Point(369, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(174, 59)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Integer"
        '
        'ValidIntegersButton
        '
        Me.ValidIntegersButton.Location = New System.Drawing.Point(1, 19)
        Me.ValidIntegersButton.Name = "ValidIntegersButton"
        Me.ValidIntegersButton.Size = New System.Drawing.Size(156, 23)
        Me.ValidIntegersButton.TabIndex = 0
        Me.ValidIntegersButton.Text = "Valid 1"
        Me.ValidIntegersButton.UseVisualStyleBackColor = True
        '
        'TextBoxWhere1
        '
        Me.TextBoxWhere1.ColumnName = "supplier_name"
        Me.TextBoxWhere1.DataType = FormControls.DataTypes.[String]
        Me.TextBoxWhere1.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxWhere1.Name = "TextBoxWhere1"
        Me.TextBoxWhere1.SelectStatement = "SELECT supplier_id,supplier_name,city,[state] FROM WhereSimple"
        Me.TextBoxWhere1.Separator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.TextBoxWhere1.Size = New System.Drawing.Size(240, 20)
        Me.TextBoxWhere1.TabIndex = 0
        Me.TextBoxWhere1.Text = "Google,Kimberly-Clarks,Tyson Foods"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 481)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBoxWhere1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code Sample"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxWhere1 As TextBoxWhere
    Friend WithEvents ValidButton1 As Button
    Friend WithEvents ValidWithApostropheButton As Button
    Friend WithEvents WithNoSeparatorButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BadSelectStatementButton As Button
    Friend WithEvents ValidWithNoMatchesButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ValidDateTimeButton As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ValidIntegersButton As Button
    Friend WithEvents WithoutSelectStatementButton As Button
End Class
