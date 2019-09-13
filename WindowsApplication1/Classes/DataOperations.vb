Namespace Classes
    ''' <summary>
    ''' Data methods for statements generated in custom TextBox.
    ''' BaseConnectionLibrary is a NuGet package.
    ''' </summary>
    Public Class DataOperations
        Inherits BaseConnectionLibrary.ConnectionClasses.SqlServerConnection
        Public Sub New()
            DefaultCatalog = "ForumExamples"
            DatabaseServer = "KARENS-PC"
        End Sub
        ''' <summary>
        ''' Get data from select statement created with custom TextBox
        ''' </summary>
        ''' <param name="pSelectStatement">Valid SELECT statement</param>
        ''' <returns>Populated DataTable or empty DataTable for runtime error</returns>
        Public Function PopulateDataDataGridView(pSelectStatement As String) As DataTable
            mHasException = False

            Dim dt As New DataTable

            Using cn As New SqlClient.SqlConnection With {.ConnectionString = ConnectionString}

                Using cmd As New SqlClient.SqlCommand With {.Connection = cn}
                    cmd.CommandText = pSelectStatement
                    cn.Open()
                    Try
                        dt.Load(cmd.ExecuteReader)
                    Catch ex As Exception
                        mHasException = True
                        mLastException = ex
                    End Try
                End Using
            End Using

            Return dt

        End Function
        ''' <summary>
        ''' Get table names using DefaultCatalog and DatabaseServer
        ''' set in the new constructor
        ''' </summary>
        ''' <returns>List of table names under DefaultCatalog</returns>
        Public Function TableNames() As List(Of String)
            Dim tableNameList As New List(Of String)

            Dim selectStatement =
                    <SQL>
                    SELECT   TABLE_NAME
                    FROM     INFORMATION_SCHEMA.TABLES
                    WHERE    TABLE_TYPE = 'BASE TABLE'
                             AND TABLE_NAME NOT IN ( '__MigrationHistory', 'sysdiagrams' )
                    ORDER BY TABLE_NAME;
                    </SQL>.Value


            Using cn As New SqlClient.SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd As New SqlClient.SqlCommand With {.Connection = cn, .CommandText = selectStatement}

                    cn.Open()

                    Try
                        Dim reader = cmd.ExecuteReader()
                        While reader.Read()
                            tableNameList.Add(reader.GetString(0))
                        End While
                    Catch ex As Exception
                        mHasException = True
                        mLastException = ex
                    End Try
                End Using
            End Using

            Return tableNameList

        End Function
        ''' <summary>
        ''' Get column names for table using DefaultCatalog and DatabaseServer
        ''' set in the new constructor
        ''' </summary>
        ''' <param name="pTableName">Existing table name</param>
        ''' <returns>List of column names for table</returns>
        Public Function ColumnNames(pTableName As String) As List(Of String)
            Dim columnNameList As New List(Of String)

            Dim selectStatement =
                    <SQL>
                        SELECT COLUMN_NAME 
                        FROM INFORMATION_SCHEMA.COLUMNS
                        WHERE TABLE_NAME = '<%= pTableName %>'
                    </SQL>.Value


            Using cn As New SqlClient.SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd As New SqlClient.SqlCommand With {.Connection = cn, .CommandText = selectStatement}

                    cn.Open()

                    Try
                        Dim reader = cmd.ExecuteReader()
                        While reader.Read()
                            columnNameList.Add(reader.GetString(0))
                        End While
                    Catch ex As Exception
                        mHasException = True
                        mLastException = ex
                    End Try
                End Using
            End Using

            Return columnNameList

        End Function
    End Class
End Namespace