Imports WindowsApplication2.Classes

Public Class Form1
    Private ReadOnly _dataOperations As DataOperations = New DataOperations
    Private ReadOnly BindingSource As New BindingSource
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContactTypesCheckedComboBox1.Items.AddRange(
            _dataOperations.ContactTypeList().Select(Function(data) data.ContactTitle).ToArray())

        DataGridView1.DataSource = BindingSource
    End Sub
    ''' <summary>
    ''' Using checked items in the combo box create a where in clause for contact type
    ''' for a SELECT statement using Customers and ContactType tables.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ReadFromDatabaseButton_Click(sender As Object, e As EventArgs) Handles ReadFromDatabaseButton.Click
        BindingSource.DataSource = Nothing

        If Not String.IsNullOrWhiteSpace(ContactTypesCheckedComboBox1.Text) Then

            Dim contactTypes = ContactTypesCheckedComboBox1.CheckedItems.Cast(Of String).ToList()
            BindingSource.DataSource = _dataOperations.ReadCustomersByContactType(contactTypes)

            If Not _dataOperations.IsSuccessFul Then
                MessageBox.Show(_dataOperations.LastExceptionMessage)
            End If

        Else
            MessageBox.Show("Must select at least one contact type")
        End If

    End Sub
    ''' <summary>
    ''' Clear checked Contact types
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ClearComboButton_Click(sender As Object, e As EventArgs) Handles ClearComboButton.Click
        For index As Integer = 0 To ContactTypesCheckedComboBox1.Items.Count - 1
            ContactTypesCheckedComboBox1.SetItemChecked(index, False)
        Next
    End Sub
End Class
