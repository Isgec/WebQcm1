Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.COM
  <DataObject()> _
  Partial Public Class comFinanceCompany
    Private Shared _RecordCount As Integer
    Private _FinanceCompany As String = ""
    Private _CompanyName As String = ""
    Private _LogisticCompany As String = ""
    Public ReadOnly Property ForeColor() As System.Drawing.Color
      Get
        Dim mRet As System.Drawing.Color = Drawing.Color.Blue
        Try
          mRet = GetColor()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Visible() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetVisible()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Enable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Property FinanceCompany() As String
      Get
        Return _FinanceCompany
      End Get
      Set(ByVal value As String)
        _FinanceCompany = value
      End Set
    End Property
    Public Property CompanyName() As String
      Get
        Return _CompanyName
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _CompanyName = ""
         Else
           _CompanyName = value
         End If
      End Set
    End Property
    Public Property LogisticCompany() As String
      Get
        Return _LogisticCompany
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _LogisticCompany = ""
         Else
           _LogisticCompany = value
         End If
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return "" & _CompanyName.ToString.PadRight(100, " ")
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _FinanceCompany
      End Get
    End Property
    Public Shared Property RecordCount() As Integer
      Get
        Return _RecordCount
      End Get
      Set(ByVal value As Integer)
        _RecordCount = value
      End Set
    End Property
    Public Class PKcomFinanceCompany
      Private _FinanceCompany As String = ""
      Public Property FinanceCompany() As String
        Get
          Return _FinanceCompany
        End Get
        Set(ByVal value As String)
          _FinanceCompany = value
        End Set
      End Property
    End Class
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function comFinanceCompanySelectList(ByVal OrderBy As String) As List(Of SIS.COM.comFinanceCompany)
      Dim Results As List(Of SIS.COM.comFinanceCompany) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetToolsConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spcomFinanceCompanySelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.COM.comFinanceCompany)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.COM.comFinanceCompany(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function comFinanceCompanyGetNewRecord() As SIS.COM.comFinanceCompany
      Return New SIS.COM.comFinanceCompany()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function comFinanceCompanyGetByID(ByVal FinanceCompany As String) As SIS.COM.comFinanceCompany
      Dim Results As SIS.COM.comFinanceCompany = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetToolsConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spcomFinanceCompanySelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FinanceCompany", SqlDbType.NVarChar, FinanceCompany.ToString.Length, FinanceCompany)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.COM.comFinanceCompany(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function comFinanceCompanySelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.COM.comFinanceCompany)
      Dim Results As List(Of SIS.COM.comFinanceCompany) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetToolsConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spcomFinanceCompanySelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spcomFinanceCompanySelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.COM.comFinanceCompany)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.COM.comFinanceCompany(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function comFinanceCompanySelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
    'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Insert, True)>
    Public Shared Function comFinanceCompanyInsert(ByVal Record As SIS.COM.comFinanceCompany) As SIS.COM.comFinanceCompany
      Dim _Rec As SIS.COM.comFinanceCompany = SIS.COM.comFinanceCompany.comFinanceCompanyGetNewRecord()
      With _Rec
        .FinanceCompany = Record.FinanceCompany
        .CompanyName = Record.CompanyName
        .LogisticCompany = Record.LogisticCompany
      End With
      Return SIS.COM.comFinanceCompany.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.COM.comFinanceCompany) As SIS.COM.comFinanceCompany
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetToolsConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spcomFinanceCompanyInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FinanceCompany", SqlDbType.NVarChar, 11, Record.FinanceCompany)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CompanyName", SqlDbType.NVarChar, 101, IIf(Record.CompanyName = "", Convert.DBNull, Record.CompanyName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LogisticCompany", SqlDbType.NVarChar, 11, IIf(Record.LogisticCompany = "", Convert.DBNull, Record.LogisticCompany))
          Cmd.Parameters.Add("@Return_FinanceCompany", SqlDbType.NVarChar, 11)
          Cmd.Parameters("@Return_FinanceCompany").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.FinanceCompany = Cmd.Parameters("@Return_FinanceCompany").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)>
    Public Shared Function comFinanceCompanyUpdate(ByVal Record As SIS.COM.comFinanceCompany) As SIS.COM.comFinanceCompany
      Dim _Rec As SIS.COM.comFinanceCompany = SIS.COM.comFinanceCompany.comFinanceCompanyGetByID(Record.FinanceCompany)
      With _Rec
        .CompanyName = Record.CompanyName
        .LogisticCompany = Record.LogisticCompany
      End With
      Return SIS.COM.comFinanceCompany.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.COM.comFinanceCompany) As SIS.COM.comFinanceCompany
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetToolsConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spcomFinanceCompanyUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_FinanceCompany", SqlDbType.NVarChar, 11, Record.FinanceCompany)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FinanceCompany", SqlDbType.NVarChar, 11, Record.FinanceCompany)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CompanyName", SqlDbType.NVarChar, 101, IIf(Record.CompanyName = "", Convert.DBNull, Record.CompanyName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LogisticCompany", SqlDbType.NVarChar, 11, IIf(Record.LogisticCompany = "", Convert.DBNull, Record.LogisticCompany))
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Delete, True)>
    Public Shared Function comFinanceCompanyDelete(ByVal Record As SIS.COM.comFinanceCompany) As Int32
      Dim _Result As Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetToolsConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spcomFinanceCompanyDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_FinanceCompany", SqlDbType.NVarChar, Record.FinanceCompany.ToString.Length, Record.FinanceCompany)
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return _RecordCount
    End Function
    '    Autocomplete Method
    Public Shared Function SelectcomFinanceCompanyAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
      Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetToolsConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spcomFinanceCompanyAutoCompleteList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix), 0, IIf(Prefix.ToLower = Prefix, 0, 1)))
          Results = New List(Of String)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Not Reader.HasRows Then
            Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---".PadRight(100, " "), ""))
          End If
          While (Reader.Read())
            Dim Tmp As SIS.COM.comFinanceCompany = New SIS.COM.comFinanceCompany(Reader)
            Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem(Tmp.DisplayField, Tmp.PrimaryKey))
          End While
          Reader.Close()
        End Using
      End Using
      Return Results.ToArray
    End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      Try
        For Each pi As System.Reflection.PropertyInfo In Me.GetType.GetProperties
          If pi.MemberType = Reflection.MemberTypes.Property Then
            Try
              Dim Found As Boolean = False
              For I As Integer = 0 To Reader.FieldCount - 1
                If Reader.GetName(I).ToLower = pi.Name.ToLower Then
                  Found = True
                  Exit For
                End If
              Next
              If Found Then
                If Convert.IsDBNull(Reader(pi.Name)) Then
                  Select Case Reader.GetDataTypeName(Reader.GetOrdinal(pi.Name))
                    Case "decimal"
                      CallByName(Me, pi.Name, CallType.Let, "0.00")
                    Case "bit"
                      CallByName(Me, pi.Name, CallType.Let, Boolean.FalseString)
                    Case Else
                      CallByName(Me, pi.Name, CallType.Let, String.Empty)
                  End Select
                Else
                  CallByName(Me, pi.Name, CallType.Let, Reader(pi.Name))
                End If
              End If
            Catch ex As Exception
            End Try
          End If
        Next
      Catch ex As Exception
      End Try
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
