Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCMCT
  <DataObject()> _
  Partial Public Class qcmctRequest
    Private Shared _RecordCount As Integer
    Private _QCRequestNo As Int32 = 0
    Private _SerialNo As Int32 = 0
    Private _PONumber As String = ""
    Private _ItemReference As String = ""
    Private _ActivityID As String = ""
    Private _ItemUnit As String = ""
    Private _Activity2Desc As String = ""
    Private _Activity3Desc As String = ""
    Private _Activity4Desc As String = ""
    Private _Handle As String = ""
    Private _ProgressPercent As String = "0.0000"
    Private _Quantity As String = "0.0000"
    Private _PercentOfQuantity As String = "0.0000"
    Private _PartialOrFull As String = ""
    Private _NotSelectedList As String = ""
    Private _SelectedList As String = ""
    Private _Product As String = ""
    Private _Project As String = ""
    Private _GridLineStatus As String = ""
    Private _InspectionStageiD As String = ""
    Private _IrefWeight As String = "0.0000"
    Private _ProgressWeight As String = "0.0000"
    Private _QCM_InspectionStages1_Description As String = ""
    Private _FK_QCM_CT_Request_InspectionStageID As SIS.QCM.qcmInspectionStages = Nothing
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
    Public Property QCRequestNo() As Int32
      Get
        Return _QCRequestNo
      End Get
      Set(ByVal value As Int32)
        _QCRequestNo = value
      End Set
    End Property
    Public Property SerialNo() As Int32
      Get
        Return _SerialNo
      End Get
      Set(ByVal value As Int32)
        _SerialNo = value
      End Set
    End Property
    Public Property PONumber() As String
      Get
        Return _PONumber
      End Get
      Set(ByVal value As String)
        _PONumber = value
      End Set
    End Property
    Public Property ItemReference() As String
      Get
        Return _ItemReference
      End Get
      Set(ByVal value As String)
        _ItemReference = value
      End Set
    End Property
    Public Property ActivityID() As String
      Get
        Return _ActivityID
      End Get
      Set(ByVal value As String)
        _ActivityID = value
      End Set
    End Property
    Public Property ItemUnit() As String
      Get
        Return _ItemUnit
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ItemUnit = ""
         Else
           _ItemUnit = value
         End If
      End Set
    End Property
    Public Property Activity2Desc() As String
      Get
        Return _Activity2Desc
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Activity2Desc = ""
         Else
           _Activity2Desc = value
         End If
      End Set
    End Property
    Public Property Activity3Desc() As String
      Get
        Return _Activity3Desc
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Activity3Desc = ""
         Else
           _Activity3Desc = value
         End If
      End Set
    End Property
    Public Property Activity4Desc() As String
      Get
        Return _Activity4Desc
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Activity4Desc = ""
         Else
           _Activity4Desc = value
         End If
      End Set
    End Property
    Public Property Handle() As String
      Get
        Return _Handle
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Handle = ""
         Else
           _Handle = value
         End If
      End Set
    End Property
    Public Property ProgressPercent() As String
      Get
        Return _ProgressPercent
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _ProgressPercent = "0.0000"
        Else
           _ProgressPercent = value
         End If
      End Set
    End Property
    Public Property Quantity() As String
      Get
        Return _Quantity
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _Quantity = "0.0000"
        Else
           _Quantity = value
         End If
      End Set
    End Property
    Public Property PercentOfQuantity() As String
      Get
        Return _PercentOfQuantity
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _PercentOfQuantity = "0.0000"
        Else
           _PercentOfQuantity = value
         End If
      End Set
    End Property
    Public Property PartialOrFull() As String
      Get
        Return _PartialOrFull
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _PartialOrFull = ""
         Else
           _PartialOrFull = value
         End If
      End Set
    End Property
    Public Property NotSelectedList() As String
      Get
        Return _NotSelectedList
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _NotSelectedList = ""
         Else
           _NotSelectedList = value
         End If
      End Set
    End Property
    Public Property SelectedList() As String
      Get
        Return _SelectedList
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SelectedList = ""
         Else
           _SelectedList = value
         End If
      End Set
    End Property
    Public Property Product() As String
      Get
        Return _Product
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Product = ""
         Else
           _Product = value
         End If
      End Set
    End Property
    Public Property Project() As String
      Get
        Return _Project
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Project = ""
         Else
           _Project = value
         End If
      End Set
    End Property
    Public Property GridLineStatus() As String
      Get
        Return _GridLineStatus
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _GridLineStatus = ""
         Else
           _GridLineStatus = value
         End If
      End Set
    End Property
    Public Property InspectionStageiD() As String
      Get
        Return _InspectionStageiD
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _InspectionStageiD = ""
         Else
           _InspectionStageiD = value
         End If
      End Set
    End Property
    Public Property IrefWeight() As String
      Get
        Return _IrefWeight
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _IrefWeight = "0.0000"
        Else
           _IrefWeight = value
         End If
      End Set
    End Property
    Public Property ProgressWeight() As String
      Get
        Return _ProgressWeight
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _ProgressWeight = "0.0000"
        Else
           _ProgressWeight = value
         End If
      End Set
    End Property
    Public Property QCM_InspectionStages1_Description() As String
      Get
        Return _QCM_InspectionStages1_Description
      End Get
      Set(ByVal value As String)
        _QCM_InspectionStages1_Description = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return ""
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _QCRequestNo & "|" & _SerialNo & "|" & _PONumber & "|" & _ItemReference & "|" & _ActivityID
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
    Public Class PKqcmctRequest
      Private _QCRequestNo As Int32 = 0
      Private _SerialNo As Int32 = 0
      Private _PONumber As String = ""
      Private _ItemReference As String = ""
      Private _ActivityID As String = ""
      Public Property QCRequestNo() As Int32
        Get
          Return _QCRequestNo
        End Get
        Set(ByVal value As Int32)
          _QCRequestNo = value
        End Set
      End Property
      Public Property SerialNo() As Int32
        Get
          Return _SerialNo
        End Get
        Set(ByVal value As Int32)
          _SerialNo = value
        End Set
      End Property
      Public Property PONumber() As String
        Get
          Return _PONumber
        End Get
        Set(ByVal value As String)
          _PONumber = value
        End Set
      End Property
      Public Property ItemReference() As String
        Get
          Return _ItemReference
        End Get
        Set(ByVal value As String)
          _ItemReference = value
        End Set
      End Property
      Public Property ActivityID() As String
        Get
          Return _ActivityID
        End Get
        Set(ByVal value As String)
          _ActivityID = value
        End Set
      End Property
    End Class
    Public ReadOnly Property FK_QCM_CT_Request_InspectionStageID() As SIS.QCM.qcmInspectionStages
      Get
        If _FK_QCM_CT_Request_InspectionStageID Is Nothing Then
          _FK_QCM_CT_Request_InspectionStageID = SIS.QCM.qcmInspectionStages.qcmInspectionStagesGetByID(_InspectionStageiD)
        End If
        Return _FK_QCM_CT_Request_InspectionStageID
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmctRequestGetNewRecord() As SIS.QCMCT.qcmctRequest
      Return New SIS.QCMCT.qcmctRequest()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmctRequestGetByID(ByVal QCRequestNo As Int32, ByVal SerialNo As Int32, ByVal PONumber As String, ByVal ItemReference As String, ByVal ActivityID As String) As SIS.QCMCT.qcmctRequest
      Dim Results As SIS.QCMCT.qcmctRequest = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmctRequestSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QCRequestNo",SqlDbType.Int,QCRequestNo.ToString.Length, QCRequestNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SerialNo",SqlDbType.Int,SerialNo.ToString.Length, SerialNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PONumber",SqlDbType.NVarChar,PONumber.ToString.Length, PONumber)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ItemReference",SqlDbType.VarChar,ItemReference.ToString.Length, ItemReference)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActivityID",SqlDbType.VarChar,ActivityID.ToString.Length, ActivityID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.QCMCT.qcmctRequest(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmctRequestSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal QCRequestNo As Int32) As List(Of SIS.QCMCT.qcmctRequest)
      Dim Results As List(Of SIS.QCMCT.qcmctRequest) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spqcmctRequestSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spqcmctRequestSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_QCRequestNo",SqlDbType.Int,10, IIf(QCRequestNo = Nothing, 0,QCRequestNo))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCMCT.qcmctRequest)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCMCT.qcmctRequest(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function qcmctRequestSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal QCRequestNo As Int32) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmctRequestGetByID(ByVal QCRequestNo As Int32, ByVal SerialNo As Int32, ByVal PONumber As String, ByVal ItemReference As String, ByVal ActivityID As String, ByVal Filter_QCRequestNo As Int32) As SIS.QCMCT.qcmctRequest
      Return qcmctRequestGetByID(QCRequestNo, SerialNo, PONumber, ItemReference, ActivityID)
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function qcmctRequestInsert(ByVal Record As SIS.QCMCT.qcmctRequest) As SIS.QCMCT.qcmctRequest
      Dim _Rec As SIS.QCMCT.qcmctRequest = SIS.QCMCT.qcmctRequest.qcmctRequestGetNewRecord()
      With _Rec
        .QCRequestNo = Record.QCRequestNo
        .SerialNo = Record.SerialNo
        .PONumber = Record.PONumber
        .ItemReference = Record.ItemReference
        .ActivityID = Record.ActivityID
        .ItemUnit = Record.ItemUnit
        .Activity2Desc = Record.Activity2Desc
        .Activity3Desc = Record.Activity3Desc
        .Activity4Desc = Record.Activity4Desc
        .Handle = Record.Handle
        .ProgressPercent = Record.ProgressPercent
        .Quantity = Record.Quantity
        .PercentOfQuantity = Record.PercentOfQuantity
        .PartialOrFull = Record.PartialOrFull
        .NotSelectedList = Record.NotSelectedList
        .SelectedList = Record.SelectedList
        .Product = Record.Product
        .Project = Record.Project
        .GridLineStatus = Record.GridLineStatus
        .InspectionStageiD = Record.InspectionStageiD
        .IrefWeight = Record.IrefWeight
        .ProgressWeight = Record.ProgressWeight
      End With
      Return SIS.QCMCT.qcmctRequest.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.QCMCT.qcmctRequest) As SIS.QCMCT.qcmctRequest
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmctRequestInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QCRequestNo",SqlDbType.Int,11, Record.QCRequestNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SerialNo",SqlDbType.Int,11, Record.SerialNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PONumber",SqlDbType.NVarChar,10, Record.PONumber)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ItemReference",SqlDbType.VarChar,201, Record.ItemReference)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActivityID",SqlDbType.VarChar,10, Record.ActivityID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ItemUnit",SqlDbType.VarChar,21, Iif(Record.ItemUnit= "" ,Convert.DBNull, Record.ItemUnit))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Activity2Desc",SqlDbType.VarChar,151, Iif(Record.Activity2Desc= "" ,Convert.DBNull, Record.Activity2Desc))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Activity3Desc",SqlDbType.VarChar,151, Iif(Record.Activity3Desc= "" ,Convert.DBNull, Record.Activity3Desc))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Activity4Desc",SqlDbType.VarChar,151, Iif(Record.Activity4Desc= "" ,Convert.DBNull, Record.Activity4Desc))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Handle",SqlDbType.VarChar,51, Iif(Record.Handle= "" ,Convert.DBNull, Record.Handle))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProgressPercent", SqlDbType.Decimal, 23, IIf(Record.ProgressPercent = "", Convert.DBNull, Record.ProgressPercent))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Quantity",SqlDbType.Decimal,23, Iif(Record.Quantity= "" ,Convert.DBNull, Record.Quantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PercentOfQuantity",SqlDbType.Decimal,23, Iif(Record.PercentOfQuantity= "" ,Convert.DBNull, Record.PercentOfQuantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PartialOrFull",SqlDbType.VarChar,11, Iif(Record.PartialOrFull= "" ,Convert.DBNull, Record.PartialOrFull))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@NotSelectedList",SqlDbType.VarChar,501, Iif(Record.NotSelectedList= "" ,Convert.DBNull, Record.NotSelectedList))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SelectedList",SqlDbType.VarChar,501, Iif(Record.SelectedList= "" ,Convert.DBNull, Record.SelectedList))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Product",SqlDbType.VarChar,10, Iif(Record.Product= "" ,Convert.DBNull, Record.Product))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Project",SqlDbType.VarChar,10, Iif(Record.Project= "" ,Convert.DBNull, Record.Project))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@GridLineStatus",SqlDbType.Int,11, Iif(Record.GridLineStatus= "" ,Convert.DBNull, Record.GridLineStatus))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionStageiD",SqlDbType.Int,11, Iif(Record.InspectionStageiD= "" ,Convert.DBNull, Record.InspectionStageiD))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IrefWeight",SqlDbType.Decimal,23, Iif(Record.IrefWeight= "" ,Convert.DBNull, Record.IrefWeight))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProgressWeight",SqlDbType.Decimal,23, Iif(Record.ProgressWeight= "" ,Convert.DBNull, Record.ProgressWeight))
          Cmd.Parameters.Add("@Return_QCRequestNo", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_QCRequestNo").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_SerialNo", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_SerialNo").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_PONumber", SqlDbType.NVarChar, 10)
          Cmd.Parameters("@Return_PONumber").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_ItemReference", SqlDbType.VarChar, 201)
          Cmd.Parameters("@Return_ItemReference").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_ActivityID", SqlDbType.VarChar, 10)
          Cmd.Parameters("@Return_ActivityID").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.QCRequestNo = Cmd.Parameters("@Return_QCRequestNo").Value
          Record.SerialNo = Cmd.Parameters("@Return_SerialNo").Value
          Record.PONumber = Cmd.Parameters("@Return_PONumber").Value
          Record.ItemReference = Cmd.Parameters("@Return_ItemReference").Value
          Record.ActivityID = Cmd.Parameters("@Return_ActivityID").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function qcmctRequestUpdate(ByVal Record As SIS.QCMCT.qcmctRequest) As SIS.QCMCT.qcmctRequest
      Dim _Rec As SIS.QCMCT.qcmctRequest = SIS.QCMCT.qcmctRequest.qcmctRequestGetByID(Record.QCRequestNo, Record.SerialNo, Record.PONumber, Record.ItemReference, Record.ActivityID)
      With _Rec
        .ItemUnit = Record.ItemUnit
        .Activity2Desc = Record.Activity2Desc
        .Activity3Desc = Record.Activity3Desc
        .Activity4Desc = Record.Activity4Desc
        .Handle = Record.Handle
        .ProgressPercent = Record.ProgressPercent
        .Quantity = Record.Quantity
        .PercentOfQuantity = Record.PercentOfQuantity
        .PartialOrFull = Record.PartialOrFull
        .NotSelectedList = Record.NotSelectedList
        .SelectedList = Record.SelectedList
        .Product = Record.Product
        .Project = Record.Project
        .GridLineStatus = Record.GridLineStatus
        .InspectionStageiD = Record.InspectionStageiD
        .IrefWeight = Record.IrefWeight
        .ProgressWeight = Record.ProgressWeight
      End With
      Return SIS.QCMCT.qcmctRequest.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.QCMCT.qcmctRequest) As SIS.QCMCT.qcmctRequest
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmctRequestUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_QCRequestNo",SqlDbType.Int,11, Record.QCRequestNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_SerialNo",SqlDbType.Int,11, Record.SerialNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_PONumber",SqlDbType.NVarChar,10, Record.PONumber)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ItemReference",SqlDbType.VarChar,201, Record.ItemReference)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ActivityID",SqlDbType.VarChar,10, Record.ActivityID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QCRequestNo",SqlDbType.Int,11, Record.QCRequestNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SerialNo",SqlDbType.Int,11, Record.SerialNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PONumber",SqlDbType.NVarChar,10, Record.PONumber)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ItemReference",SqlDbType.VarChar,201, Record.ItemReference)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActivityID",SqlDbType.VarChar,10, Record.ActivityID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ItemUnit",SqlDbType.VarChar,21, Iif(Record.ItemUnit= "" ,Convert.DBNull, Record.ItemUnit))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Activity2Desc",SqlDbType.VarChar,151, Iif(Record.Activity2Desc= "" ,Convert.DBNull, Record.Activity2Desc))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Activity3Desc",SqlDbType.VarChar,151, Iif(Record.Activity3Desc= "" ,Convert.DBNull, Record.Activity3Desc))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Activity4Desc",SqlDbType.VarChar,151, Iif(Record.Activity4Desc= "" ,Convert.DBNull, Record.Activity4Desc))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Handle",SqlDbType.VarChar,51, Iif(Record.Handle= "" ,Convert.DBNull, Record.Handle))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProgressPercent", SqlDbType.Decimal, 23, IIf(Record.ProgressPercent = "", Convert.DBNull, Record.ProgressPercent))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Quantity",SqlDbType.Decimal,23, Iif(Record.Quantity= "" ,Convert.DBNull, Record.Quantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PercentOfQuantity",SqlDbType.Decimal,23, Iif(Record.PercentOfQuantity= "" ,Convert.DBNull, Record.PercentOfQuantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PartialOrFull",SqlDbType.VarChar,11, Iif(Record.PartialOrFull= "" ,Convert.DBNull, Record.PartialOrFull))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@NotSelectedList",SqlDbType.VarChar,501, Iif(Record.NotSelectedList= "" ,Convert.DBNull, Record.NotSelectedList))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SelectedList",SqlDbType.VarChar,501, Iif(Record.SelectedList= "" ,Convert.DBNull, Record.SelectedList))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Product",SqlDbType.VarChar,10, Iif(Record.Product= "" ,Convert.DBNull, Record.Product))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Project",SqlDbType.VarChar,10, Iif(Record.Project= "" ,Convert.DBNull, Record.Project))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@GridLineStatus",SqlDbType.Int,11, Iif(Record.GridLineStatus= "" ,Convert.DBNull, Record.GridLineStatus))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionStageiD",SqlDbType.Int,11, Iif(Record.InspectionStageiD= "" ,Convert.DBNull, Record.InspectionStageiD))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IrefWeight",SqlDbType.Decimal,23, Iif(Record.IrefWeight= "" ,Convert.DBNull, Record.IrefWeight))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProgressWeight",SqlDbType.Decimal,23, Iif(Record.ProgressWeight= "" ,Convert.DBNull, Record.ProgressWeight))
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
    Public Shared Function qcmctRequestDelete(ByVal Record As SIS.QCMCT.qcmctRequest) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmctRequestDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_QCRequestNo",SqlDbType.Int,Record.QCRequestNo.ToString.Length, Record.QCRequestNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_SerialNo",SqlDbType.Int,Record.SerialNo.ToString.Length, Record.SerialNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_PONumber",SqlDbType.NVarChar,Record.PONumber.ToString.Length, Record.PONumber)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ItemReference",SqlDbType.VarChar,Record.ItemReference.ToString.Length, Record.ItemReference)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ActivityID",SqlDbType.VarChar,Record.ActivityID.ToString.Length, Record.ActivityID)
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
