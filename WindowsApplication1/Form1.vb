Imports WindowsApplication1.Classes
Imports FormControls

Public Class Form1
    Private ReadOnly _dataOperations As DataOperations = New DataOperations

    Private ReadOnly _selectStatementForStrings As String =
                <SQL>
                    SELECT 
                        supplier_id,
                        supplier_name,
                        city,
                        [state] 
                    FROM WhereInSimple
                </SQL>.Value

    Private ReadOnly _selectStatementForDateTime As String =
                <SQL>
                    SELECT 
                        supplier_id,
                        supplier_name, 
                        CAST(some_Date AS DATE) AS Registered 
                    FROM WhereInSimple
                </SQL>.Value


    ''' <summary>
    ''' Simple, comma delimited, no apostrophe, column name specified
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ValidButton1_Click(sender As Object, e As EventArgs) Handles ValidButton1.Click

        TextBoxWhere1.Text = "Google,Kimberly-Clark,Tyson Foods"
        TextBoxWhere1.SelectStatement = _selectStatementForStrings
        TextBoxWhere1.DataType = DataTypes.String
        TextBoxWhere1.Separator = ","c
        TextBoxWhere1.ColumnName = "supplier_name"

        TextBoxWhere1.CreateWhereStatement()

        If TextBoxWhere1.IsValid Then

            DataGridView1.DataSource = _dataOperations.PopulateDataDataGridView(TextBoxWhere1.Statement)

            _dataOperations.TableNames()

            If Not _dataOperations.IsSuccessFul Then
                MessageBox.Show(_dataOperations.LastExceptionMessage)
            End If

        Else
            DataGridView1.DataSource = Nothing
        End If

    End Sub
    Private Sub ValidWithApostropheButton_Click_1(sender As Object, e As EventArgs) Handles ValidWithApostropheButton.Click

        TextBoxWhere1.Text = "Google's,Kimberly-Clark,Tyson Foods"
        TextBoxWhere1.SelectStatement = _selectStatementForStrings
        TextBoxWhere1.DataType = DataTypes.String
        TextBoxWhere1.Separator = ","c
        TextBoxWhere1.ColumnName = "supplier_name"

        TextBoxWhere1.CreateWhereStatement()

        If TextBoxWhere1.IsValid Then
            DataGridView1.DataSource = _dataOperations.PopulateDataDataGridView(TextBoxWhere1.Statement)
        Else
            DataGridView1.DataSource = Nothing
        End If

    End Sub

    Private Sub WithNoSeparatorButton_Click(sender As Object, e As EventArgs) Handles WithNoSeparatorButton.Click

        TextBoxWhere1.Text = "Google's,Kimberly-Clark,Tyson Foods"
        TextBoxWhere1.SelectStatement = _selectStatementForStrings
        TextBoxWhere1.DataType = DataTypes.String
        TextBoxWhere1.Separator = Nothing
        TextBoxWhere1.ColumnName = "supplier_name"

        TextBoxWhere1.CreateWhereStatement()

        If TextBoxWhere1.IsValid Then
            DataGridView1.DataSource = _dataOperations.PopulateDataDataGridView(TextBoxWhere1.Statement)
        Else
            DataGridView1.DataSource = Nothing
            MessageBox.Show("Not configured correctly")
        End If

    End Sub

    Private Sub WithoutSelectStatementButton_Click(sender As Object, e As EventArgs) Handles WithoutSelectStatementButton.Click

        TextBoxWhere1.Text = ""
        TextBoxWhere1.SelectStatement = _selectStatementForStrings
        TextBoxWhere1.DataType = DataTypes.String
        TextBoxWhere1.Separator = Nothing
        TextBoxWhere1.ColumnName = "supplier_name"

        TextBoxWhere1.CreateWhereStatement()

        If TextBoxWhere1.IsValid Then
            DataGridView1.DataSource = _dataOperations.PopulateDataDataGridView(TextBoxWhere1.Statement)
        Else
            DataGridView1.DataSource = Nothing
            MessageBox.Show("Not configured correctly")
        End If

    End Sub
    Private Sub BadSelectStatementButton_Click(sender As Object, e As EventArgs) Handles BadSelectStatementButton.Click

        TextBoxWhere1.Text = "SELECT id,supplier_name,city,[state] FROM WhereInSimple"
        TextBoxWhere1.SelectStatement = TextBoxWhere1.Text
        TextBoxWhere1.DataType = DataTypes.String
        TextBoxWhere1.Separator = ","c
        TextBoxWhere1.ColumnName = "supplier_name"

        TextBoxWhere1.CreateWhereStatement()

        If TextBoxWhere1.IsValid Then
            DataGridView1.DataSource = _dataOperations.PopulateDataDataGridView(TextBoxWhere1.Statement)

        Else
            DataGridView1.DataSource = Nothing
            MessageBox.Show("Not configured correctly")
        End If

    End Sub
    Private Sub ValidWithNoMatchesButton_Click(sender As Object, e As EventArgs) Handles ValidWithNoMatchesButton.Click

        TextBoxWhere1.Text = "Starbucks,Clarks,Bad Foods"
        TextBoxWhere1.SelectStatement = _selectStatementForStrings
        TextBoxWhere1.DataType = DataTypes.String
        TextBoxWhere1.Separator = ","c
        TextBoxWhere1.ColumnName = "supplier_name"

        TextBoxWhere1.CreateWhereStatement()

        If TextBoxWhere1.IsValid Then
            DataGridView1.DataSource = _dataOperations.PopulateDataDataGridView(TextBoxWhere1.Statement)
            If DataGridView1.Rows.Count = 1 AndAlso CType(DataGridView1.DataSource, DataTable).Rows.Count = 0 Then
                MessageBox.Show($"No matches for column {TextBoxWhere1.ColumnName} using{Environment.NewLine}{TextBoxWhere1.Where}")
            End If
        Else
            DataGridView1.DataSource = Nothing
        End If

    End Sub
    Private Sub ValidDateTimeButton_Click(sender As Object, e As EventArgs) Handles ValidDateTimeButton.Click

        TextBoxWhere1.Text = "06-05-2017,06-03-2017,06-01-2017"
        TextBoxWhere1.DataType = DataTypes.Datetime2
        TextBoxWhere1.SelectStatement = _selectStatementForDateTime
        TextBoxWhere1.Separator = ","c
        TextBoxWhere1.ColumnName = "some_date"

        TextBoxWhere1.CreateWhereStatement()

        If TextBoxWhere1.IsValid Then
            DataGridView1.DataSource = _dataOperations.PopulateDataDataGridView(TextBoxWhere1.Statement)
            If DataGridView1.Rows.Count = 1 AndAlso CType(DataGridView1.DataSource, DataTable).Rows.Count = 0 Then
                MessageBox.Show($"No matches for column {TextBoxWhere1.ColumnName} using{Environment.NewLine}{TextBoxWhere1.Where}")
            End If
        Else
            DataGridView1.DataSource = Nothing
        End If

    End Sub
    Private Sub ValidIntegersButton_Click(sender As Object, e As EventArgs) Handles ValidIntegersButton.Click

        TextBoxWhere1.Text = "100|500|900"
        TextBoxWhere1.DataType = DataTypes.Integer
        TextBoxWhere1.SelectStatement = _selectStatementForDateTime
        TextBoxWhere1.Separator = "|"c
        TextBoxWhere1.ColumnName = "supplier_id"

        TextBoxWhere1.CreateWhereStatement()

        If TextBoxWhere1.IsValid Then
            DataGridView1.DataSource = _dataOperations.PopulateDataDataGridView(TextBoxWhere1.Statement)
            If DataGridView1.Rows.Count = 1 AndAlso CType(DataGridView1.DataSource, DataTable).Rows.Count = 0 Then
                MessageBox.Show($"No matches for column {TextBoxWhere1.ColumnName} using{Environment.NewLine}{TextBoxWhere1.Where}")
            End If
        Else
            DataGridView1.DataSource = Nothing
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCueText(TextBoxWhere1, "Enter valid SQL")
    End Sub
End Class
