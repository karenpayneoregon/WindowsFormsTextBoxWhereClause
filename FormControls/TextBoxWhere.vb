Imports System.ComponentModel
Imports System.Windows.Forms


Public Enum DataTypes
    [String]
    [Integer]
    [Double]
    [Decimal]
    Datetime2
    [Date]
    [DateTimeOffSet]
End Enum
Public Class TextBoxWhere
    Inherits TextBox

    Public Sub New()
        Separator = ","c
    End Sub


    <Category("Data"), Description("Column type for property ColumnName")>
    Public Property DataType As DataTypes

    Private _InClause As String
    <Browsable(False)>
    Public ReadOnly Property Statement As String
        Get
            Return _InClause
        End Get
    End Property
    Private _Where As String
    Public ReadOnly Property Where As String
        Get
            Return _Where
        End Get
    End Property
    Private _IsValid As Boolean
    <Browsable(False)>
    Public ReadOnly Property IsValid As Boolean
        Get
            Return _IsValid
        End Get
    End Property

    <Category("Data"), Description("Column name in table")>
    Public Property ColumnName As String
    <Category("Data"), Description("Char separator in Text property to split on")>
    Public Property Separator As Char
    <Category("Data"), Description("Valid SQL SELECT with no WHERE clause")>
    Public Property SelectStatement As String
    ''' <summary>
    ''' Create a full SELECT statement with a WHERE IN clause
    ''' </summary>
    Public Sub CreateWhereStatement()

        If Not String.IsNullOrWhiteSpace(Text) AndAlso Not String.IsNullOrWhiteSpace(SelectStatement) Then

            If Not String.IsNullOrWhiteSpace(ColumnName) AndAlso Not Separator = vbNullChar Then

                Dim splitTokensArray As String() = Text.Split(Separator)

                Dim sb As New Text.StringBuilder
                Dim whereConcatenate = ""
                For Each item In splitTokensArray
                    Select Case DataType
                        Case DataTypes.String
                            sb.Append($"'{item.Replace("'", "''")}',")
                            whereConcatenate = $" WHERE {ColumnName} "
                        Case DataTypes.Integer, DataTypes.Double, DataTypes.Decimal
                            sb.Append($"{item},")
                            whereConcatenate = $" WHERE {ColumnName} "
                        Case DataTypes.Datetime2, DataTypes.Date
                            sb.Append($"'{item}',")
                            whereConcatenate = $" WHERE CAST({ColumnName} AS date) "
                        Case DataTypes.DateTimeOffSet
                            sb.Append($"'{item}',")
                            whereConcatenate = $" WHERE CAST({ColumnName} AS DATETIMEOFFSET(4))) "
                    End Select
                Next

                Dim joinedTokens As String = sb.ToString

                If joinedTokens.Last = "," Then
                    joinedTokens = joinedTokens.Substring(0, joinedTokens.Length - 1)
                End If

                Dim whereTokens = "(" & joinedTokens & ")"
                _Where = whereTokens

                _InClause = $"{SelectStatement} {whereConcatenate} IN " & whereTokens
                _IsValid = True

            Else
                _IsValid = False
            End If
        Else
            _IsValid = False
        End If
    End Sub
End Class