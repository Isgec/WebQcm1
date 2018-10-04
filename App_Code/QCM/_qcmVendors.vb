Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCM
  <DataObject()> _
  Partial Public Class qcmVendors
    Private Shared _RecordCount As Integer
    Private _VendorID As String = ""
    Private _Description As String = ""
    Private _ContactPerson As String = ""
    Private _EmailID As String = ""
    Private _ContactNo As String = ""
    Private _Address1 As String = ""
    Private _Address2 As String = ""
    Private _Address3 As String = ""
    Private _Address4 As String = ""
    Private _ToEMailID As String = ""
    Private _CCEmailID As String = ""
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
    Public Property VendorID() As String
      Get
        Return _VendorID
      End Get
      Set(ByVal value As String)
        _VendorID = value
      End Set
    End Property
    Public Property Description() As String
      Get
        Return _Description
      End Get
      Set(ByVal value As String)
        _Description = value
      End Set
    End Property
    Public Property ContactPerson() As String
      Get
        Return _ContactPerson
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ContactPerson = ""
				 Else
					 _ContactPerson = value
			   End If
      End Set
    End Property
    Public Property EmailID() As String
      Get
        Return _EmailID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _EmailID = ""
				 Else
					 _EmailID = value
			   End If
      End Set
    End Property
    Public Property ContactNo() As String
      Get
        Return _ContactNo
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ContactNo = ""
				 Else
					 _ContactNo = value
			   End If
      End Set
    End Property
    Public Property Address1() As String
      Get
        Return _Address1
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _Address1 = ""
				 Else
					 _Address1 = value
			   End If
      End Set
    End Property
    Public Property Address2() As String
      Get
        Return _Address2
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _Address2 = ""
				 Else
					 _Address2 = value
			   End If
      End Set
    End Property
    Public Property Address3() As String
      Get
        Return _Address3
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _Address3 = ""
				 Else
					 _Address3 = value
			   End If
      End Set
    End Property
    Public Property Address4() As String
      Get
        Return _Address4
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _Address4 = ""
				 Else
					 _Address4 = value
			   End If
      End Set
    End Property
    Public Property ToEMailID() As String
      Get
        Return _ToEMailID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ToEMailID = ""
				 Else
					 _ToEMailID = value
			   End If
      End Set
    End Property
    Public Property CCEmailID() As String
      Get
        Return _CCEmailID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _CCEmailID = ""
				 Else
					 _CCEmailID = value
			   End If
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return "" & _Description.ToString.PadRight(50, " ")
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _VendorID
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
    Public Class PKqcmVendors
			Private _VendorID As String = ""
			Public Property VendorID() As String
				Get
					Return _VendorID
				End Get
				Set(ByVal value As String)
					_VendorID = value
				End Set
			End Property
    End Class
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmVendorsSelectList(ByVal OrderBy As String) As List(Of SIS.QCM.qcmVendors)
      Dim Results As List(Of SIS.QCM.qcmVendors) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmVendorsSelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmVendors)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmVendors(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmVendorsGetNewRecord() As SIS.QCM.qcmVendors
      Return New SIS.QCM.qcmVendors()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmVendorsGetByID(ByVal VendorID As String) As SIS.QCM.qcmVendors
      Dim Results As SIS.QCM.qcmVendors = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmVendorsSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VendorID",SqlDbType.NVarChar,VendorID.ToString.Length, VendorID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					If Reader.Read() Then
						Results = New SIS.QCM.qcmVendors(Reader)
					End If
					Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmVendorsSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal VendorID As String) As List(Of SIS.QCM.qcmVendors)
      Dim Results As List(Of SIS.QCM.qcmVendors) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "spqcmVendorsSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "spqcmVendorsSelectListFilteres"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_VendorID",SqlDbType.NVarChar,6, IIf(VendorID Is Nothing, String.Empty,VendorID))
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmVendors)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmVendors(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function qcmVendorsSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal VendorID As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmVendorsGetByID(ByVal VendorID As String, ByVal Filter_VendorID As String) As SIS.QCM.qcmVendors
      Return qcmVendorsGetByID(VendorID)
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function qcmVendorsInsert(ByVal Record As SIS.QCM.qcmVendors) As SIS.QCM.qcmVendors
      Dim _Rec As SIS.QCM.qcmVendors = SIS.QCM.qcmVendors.qcmVendorsGetNewRecord()
      With _Rec
        .VendorID = Record.VendorID
        .Description = Record.Description
        .ContactPerson = Record.ContactPerson
        .EmailID = Record.EmailID
        .ContactNo = Record.ContactNo
        .Address1 = Record.Address1
        .Address2 = Record.Address2
        .Address3 = Record.Address3
        .Address4 = Record.Address4
        .ToEMailID = Record.ToEMailID
        .CCEmailID = Record.CCEmailID
      End With
      Return SIS.QCM.qcmVendors.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.QCM.qcmVendors) As SIS.QCM.qcmVendors
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmVendorsInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VendorID", SqlDbType.NVarChar, 9, Record.VendorID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Description",SqlDbType.NVarChar,51, Record.Description)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ContactPerson",SqlDbType.NVarChar,51, Iif(Record.ContactPerson= "" ,Convert.DBNull, Record.ContactPerson))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmailID",SqlDbType.NVarChar,51, Iif(Record.EmailID= "" ,Convert.DBNull, Record.EmailID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ContactNo",SqlDbType.NVarChar,21, Iif(Record.ContactNo= "" ,Convert.DBNull, Record.ContactNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Address1",SqlDbType.NVarChar,61, Iif(Record.Address1= "" ,Convert.DBNull, Record.Address1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Address2",SqlDbType.NVarChar,61, Iif(Record.Address2= "" ,Convert.DBNull, Record.Address2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Address3",SqlDbType.NVarChar,61, Iif(Record.Address3= "" ,Convert.DBNull, Record.Address3))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Address4",SqlDbType.NVarChar,61, Iif(Record.Address4= "" ,Convert.DBNull, Record.Address4))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ToEMailID",SqlDbType.NVarChar,251, Iif(Record.ToEMailID= "" ,Convert.DBNull, Record.ToEMailID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CCEmailID",SqlDbType.NVarChar,251, Iif(Record.CCEmailID= "" ,Convert.DBNull, Record.CCEmailID))
          Cmd.Parameters.Add("@Return_VendorID", SqlDbType.NVarChar, 9)
          Cmd.Parameters("@Return_VendorID").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.VendorID = Cmd.Parameters("@Return_VendorID").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function qcmVendorsUpdate(ByVal Record As SIS.QCM.qcmVendors) As SIS.QCM.qcmVendors
      Dim _Rec As SIS.QCM.qcmVendors = SIS.QCM.qcmVendors.qcmVendorsGetByID(Record.VendorID)
      With _Rec
        .Description = Record.Description
        .ContactPerson = Record.ContactPerson
        .EmailID = Record.EmailID
        .ContactNo = Record.ContactNo
        .Address1 = Record.Address1
        .Address2 = Record.Address2
        .Address3 = Record.Address3
        .Address4 = Record.Address4
        .ToEMailID = Record.ToEMailID
        .CCEmailID = Record.CCEmailID
      End With
      Return SIS.QCM.qcmVendors.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.QCM.qcmVendors) As SIS.QCM.qcmVendors
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmVendorsUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_VendorID", SqlDbType.NVarChar, 9, Record.VendorID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VendorID", SqlDbType.NVarChar, 9, Record.VendorID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Description",SqlDbType.NVarChar,51, Record.Description)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ContactPerson",SqlDbType.NVarChar,51, Iif(Record.ContactPerson= "" ,Convert.DBNull, Record.ContactPerson))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmailID",SqlDbType.NVarChar,51, Iif(Record.EmailID= "" ,Convert.DBNull, Record.EmailID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ContactNo",SqlDbType.NVarChar,21, Iif(Record.ContactNo= "" ,Convert.DBNull, Record.ContactNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Address1",SqlDbType.NVarChar,61, Iif(Record.Address1= "" ,Convert.DBNull, Record.Address1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Address2",SqlDbType.NVarChar,61, Iif(Record.Address2= "" ,Convert.DBNull, Record.Address2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Address3",SqlDbType.NVarChar,61, Iif(Record.Address3= "" ,Convert.DBNull, Record.Address3))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Address4",SqlDbType.NVarChar,61, Iif(Record.Address4= "" ,Convert.DBNull, Record.Address4))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ToEMailID",SqlDbType.NVarChar,251, Iif(Record.ToEMailID= "" ,Convert.DBNull, Record.ToEMailID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CCEmailID",SqlDbType.NVarChar,251, Iif(Record.CCEmailID= "" ,Convert.DBNull, Record.CCEmailID))
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
		<DataObjectMethod(DataObjectMethodType.Delete, True)> _
		Public Shared Function Delete(ByVal Record As SIS.QCM.qcmVendors) As Int32
			Dim _Result As Integer = 0
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spqcmVendorsDelete"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_VendorID", SqlDbType.NVarChar, Record.VendorID.ToString.Length, Record.VendorID)
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
'		Autocomplete Method
		Public Shared Function SelectqcmVendorsAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
			Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spqcmVendorsAutoCompleteList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix),0,IIf(Prefix.ToLower=Prefix, 0, 1)))
					Results = New List(Of String)()
					Con.Open()
					Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					If Not Reader.HasRows Then
					  Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---".PadRight(50, " "),""))
					End If
					While (Reader.Read())
            Dim Tmp As SIS.QCM.qcmVendors = New SIS.QCM.qcmVendors(Reader)
					  Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem(Tmp.DisplayField, Tmp.PrimaryKey))
					End While
					Reader.Close()
				End Using
			End Using
			Return Results.ToArray
		End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      On Error Resume Next
      _VendorID = Ctype(Reader("VendorID"),String)
      _Description = Ctype(Reader("Description"),String)
      If Convert.IsDBNull(Reader("ContactPerson")) Then
        _ContactPerson = String.Empty
      Else
        _ContactPerson = Ctype(Reader("ContactPerson"), String)
      End If
      If Convert.IsDBNull(Reader("EmailID")) Then
        _EmailID = String.Empty
      Else
        _EmailID = Ctype(Reader("EmailID"), String)
      End If
      If Convert.IsDBNull(Reader("ContactNo")) Then
        _ContactNo = String.Empty
      Else
        _ContactNo = Ctype(Reader("ContactNo"), String)
      End If
      If Convert.IsDBNull(Reader("Address1")) Then
        _Address1 = String.Empty
      Else
        _Address1 = Ctype(Reader("Address1"), String)
      End If
      If Convert.IsDBNull(Reader("Address2")) Then
        _Address2 = String.Empty
      Else
        _Address2 = Ctype(Reader("Address2"), String)
      End If
      If Convert.IsDBNull(Reader("Address3")) Then
        _Address3 = String.Empty
      Else
        _Address3 = Ctype(Reader("Address3"), String)
      End If
      If Convert.IsDBNull(Reader("Address4")) Then
        _Address4 = String.Empty
      Else
        _Address4 = Ctype(Reader("Address4"), String)
      End If
      If Convert.IsDBNull(Reader("ToEMailID")) Then
        _ToEMailID = String.Empty
      Else
        _ToEMailID = Ctype(Reader("ToEMailID"), String)
      End If
      If Convert.IsDBNull(Reader("CCEmailID")) Then
        _CCEmailID = String.Empty
      Else
        _CCEmailID = Ctype(Reader("CCEmailID"), String)
      End If
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
