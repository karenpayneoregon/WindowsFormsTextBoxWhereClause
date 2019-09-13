Imports BuilderLibrary
Imports DataProviderCommandHelpers

Namespace Classes
    ''' <summary>
    ''' Data methods for statements generated in custom TextBox.
    ''' BaseConnectionLibrary is a NuGet package.
    ''' </summary>
    Public Class DataOperations
        Inherits BaseConnectionLibrary.ConnectionClasses.SqlServerConnection
        Public Sub New()
            DefaultCatalog = "NorthWindAzureForInserts"
            DatabaseServer = "KARENS-PC"
        End Sub
        ''' <summary>
        ''' Get data 
        ''' </summary>
        ''' <param name="pContactTitleList">List of contact titles</param>
        ''' <returns>Populated DataTable or empty DataTable for runtime error</returns>
        Public Function ReadCustomersByContactType(pContactTitleList As List(Of String)) As DataTable

            mHasException = False

            ' field which the WHERE IN will use
            Dim parameterPrefix = "CT.ContactTitle"

            ' Base SELECT Statement
            Dim selectStatement =
                    <SQL>
                    SELECT C.CustomerIdentifier ,
                           C.CompanyName ,
                           C.ContactName ,
                           C.ContactTypeIdentifier ,
                           FORMAT(C.ModifiedDate, 'MM-dd-yyyy', 'en-US') AS ModifiedDate,
                           CT.ContactTitle
                    FROM   dbo.Customers AS C
                    INNER JOIN dbo.ContactType AS CT ON C.ContactTypeIdentifier = CT.ContactTypeIdentifier
	                WHERE <%= parameterPrefix %> IN ({0}) 
                    ORDER BY C.CompanyName
                    </SQL>.Value

            ' Builds the SELECT statement minus values
            Dim CommandText = BuildWhereInClause(selectStatement, parameterPrefix, pContactTitleList)

            Dim dt As New DataTable

            Using cn As New SqlClient.SqlConnection With {.ConnectionString = ConnectionString}

                Using cmd As New SqlClient.SqlCommand With {.Connection = cn}

                    cmd.CommandText = CommandText

                    '
                    ' Add values for command parameters
                    '
                    cmd.AddParamsToCommand(parameterPrefix, pContactTitleList)

                    Try
                        cn.Open()

                        dt.Load(cmd.ExecuteReader)
                        dt.Columns("ContactTypeIdentifier").ColumnMapping = MappingType.Hidden

                    Catch ex As Exception
                        mHasException = True
                        mLastException = ex
                    End Try

                End Using
            End Using

            Return dt

        End Function
        ''' <summary>
        ''' Get a list of all contact types
        ''' </summary>
        ''' <returns></returns>
        Public Function ContactTypeList() As List(Of ContactType)
            mHasException = False

            Dim contactTypes As New List(Of ContactType)

            Using cn As New SqlClient.SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd As New SqlClient.SqlCommand With {.Connection = cn}
                    cmd.CommandText = "SELECT ContactTypeIdentifier, ContactTitle FROM dbo.ContactType"

                    Try

                        cn.Open()
                        Dim reader = cmd.ExecuteReader()

                        While reader.Read()
                            contactTypes.Add(New ContactType() With
                                                {
                                                    .ContactTypeIdentifier = reader.GetInt32(0),
                                                    .ContactTitle = reader.GetString(1)
                                                })
                        End While

                    Catch ex As Exception
                        mHasException = True
                        mLastException = ex
                    End Try
                End Using
            End Using

            Return contactTypes

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

                    Try
                        cn.Open()
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