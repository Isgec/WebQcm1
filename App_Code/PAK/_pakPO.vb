Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.PAK
  <DataObject()> _
  Partial Public Class pakPO
    Private Shared _RecordCount As Integer
    Private _SerialNo As Int32 = 0
    Private _POConsignee As String = ""
    Private _POOtherDetails As String = ""
    Private _IssueReasonID As String = ""
    Private _PONumber As String = ""
    Private _PORevision As String = ""
    Private _PODate As String = ""
    Private _PODescription As String = ""
    Private _POTypeID As String = ""
    Private _SupplierID As String = ""
    Private _ProjectID As String = ""
    Private _BuyerID As String = ""
    Private _POStatusID As String = ""
    Private _ISGECRemarks As String = ""
    Private _SupplierRemarks As String = ""
    Private _IssuedBy As String = ""
    Private _IssuedOn As String = ""
    Private _ClosedBy As String = ""
    Private _ClosedOn As String = ""
    Private _DivisionID As String = ""
    Private _aspnet_Users1_UserFullName As String = ""
    Private _aspnet_Users2_UserFullName As String = ""
    Private _aspnet_Users3_UserFullName As String = ""
    Private _IDM_Projects4_Description As String = ""
    Private _PAK_Divisions5_Description As String = ""
    Private _PAK_POStatus6_Description As String = ""
    Private _PAK_POTypes7_Description As String = ""
    Private _PAK_Reasons8_Description As String = ""
    Private _VR_BusinessPartner9_BPName As String = ""
    Private _FK_PAK_PO_BuyerID As SIS.QCM.qcmUsers = Nothing
    Private _FK_PAK_PO_IssuedBy As SIS.QCM.qcmUsers = Nothing
    Private _FK_PAK_PO_ClosedBy As SIS.QCM.qcmUsers = Nothing
    Private _FK_PAK_PO_ProjectID As SIS.QCM.qcmProjects = Nothing
    Public Property POFOR As String = "PK"
    Public Property QCRequired As Boolean = False
    Public Property AcceptedBySupplier As Boolean = False
    Public Property AcceptedBySupplierOn As String = ""
    Public Property POWeight As Decimal = 0
    Public Property PortRequired As Boolean = False
    Public Property PortID As String = ""
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
    Public Property SerialNo() As Int32
      Get
        Return _SerialNo
      End Get
      Set(ByVal value As Int32)
        _SerialNo = value
      End Set
    End Property
    Public Property POConsignee() As String
      Get
        Return _POConsignee
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _POConsignee = ""
        Else
          _POConsignee = value
        End If
      End Set
    End Property
    Public Property POOtherDetails() As String
      Get
        Return _POOtherDetails
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _POOtherDetails = ""
        Else
          _POOtherDetails = value
        End If
      End Set
    End Property
    Public Property IssueReasonID() As String
      Get
        Return _IssueReasonID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _IssueReasonID = ""
        Else
          _IssueReasonID = value
        End If
      End Set
    End Property
    Public Property PONumber() As String
      Get
        Return _PONumber
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _PONumber = ""
        Else
          _PONumber = value
        End If
      End Set
    End Property
    Public Property PORevision() As String
      Get
        Return _PORevision
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _PORevision = ""
        Else
          _PORevision = value
        End If
      End Set
    End Property
    Public Property PODate() As String
      Get
        If Not _PODate = String.Empty Then
          Return Convert.ToDateTime(_PODate).ToString("dd/MM/yyyy")
        End If
        Return _PODate
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _PODate = ""
        Else
          _PODate = value
        End If
      End Set
    End Property
    Public Property PODescription() As String
      Get
        Return _PODescription
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _PODescription = ""
        Else
          _PODescription = value
        End If
      End Set
    End Property
    Public Property POTypeID() As String
      Get
        Return _POTypeID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _POTypeID = ""
        Else
          _POTypeID = value
        End If
      End Set
    End Property
    Public Property SupplierID() As String
      Get
        Return _SupplierID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _SupplierID = ""
        Else
          _SupplierID = value
        End If
      End Set
    End Property
    Public Property ProjectID() As String
      Get
        Return _ProjectID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ProjectID = ""
        Else
          _ProjectID = value
        End If
      End Set
    End Property
    Public Property BuyerID() As String
      Get
        Return _BuyerID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _BuyerID = ""
        Else
          _BuyerID = value
        End If
      End Set
    End Property
    Public Property POStatusID() As String
      Get
        Return _POStatusID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _POStatusID = ""
        Else
          _POStatusID = value
        End If
      End Set
    End Property
    Public Property ISGECRemarks() As String
      Get
        Return _ISGECRemarks
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ISGECRemarks = ""
        Else
          _ISGECRemarks = value
        End If
      End Set
    End Property
    Public Property SupplierRemarks() As String
      Get
        Return _SupplierRemarks
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _SupplierRemarks = ""
        Else
          _SupplierRemarks = value
        End If
      End Set
    End Property
    Public Property IssuedBy() As String
      Get
        Return _IssuedBy
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _IssuedBy = ""
        Else
          _IssuedBy = value
        End If
      End Set
    End Property
    Public Property IssuedOn() As String
      Get
        If Not _IssuedOn = String.Empty Then
          Return Convert.ToDateTime(_IssuedOn).ToString("dd/MM/yyyy")
        End If
        Return _IssuedOn
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _IssuedOn = ""
        Else
          _IssuedOn = value
        End If
      End Set
    End Property
    Public Property ClosedBy() As String
      Get
        Return _ClosedBy
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ClosedBy = ""
        Else
          _ClosedBy = value
        End If
      End Set
    End Property
    Public Property ClosedOn() As String
      Get
        If Not _ClosedOn = String.Empty Then
          Return Convert.ToDateTime(_ClosedOn).ToString("dd/MM/yyyy")
        End If
        Return _ClosedOn
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ClosedOn = ""
        Else
          _ClosedOn = value
        End If
      End Set
    End Property
    Public Property DivisionID() As String
      Get
        Return _DivisionID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _DivisionID = ""
        Else
          _DivisionID = value
        End If
      End Set
    End Property
    Public Property aspnet_Users1_UserFullName() As String
      Get
        Return _aspnet_Users1_UserFullName
      End Get
      Set(ByVal value As String)
        _aspnet_Users1_UserFullName = value
      End Set
    End Property
    Public Property aspnet_Users2_UserFullName() As String
      Get
        Return _aspnet_Users2_UserFullName
      End Get
      Set(ByVal value As String)
        _aspnet_Users2_UserFullName = value
      End Set
    End Property
    Public Property aspnet_Users3_UserFullName() As String
      Get
        Return _aspnet_Users3_UserFullName
      End Get
      Set(ByVal value As String)
        _aspnet_Users3_UserFullName = value
      End Set
    End Property
    Public Property IDM_Projects4_Description() As String
      Get
        Return _IDM_Projects4_Description
      End Get
      Set(ByVal value As String)
        _IDM_Projects4_Description = value
      End Set
    End Property
    Public Property PAK_Divisions5_Description() As String
      Get
        Return _PAK_Divisions5_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _PAK_Divisions5_Description = ""
        Else
          _PAK_Divisions5_Description = value
        End If
      End Set
    End Property
    Public Property PAK_POStatus6_Description() As String
      Get
        Return _PAK_POStatus6_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _PAK_POStatus6_Description = ""
        Else
          _PAK_POStatus6_Description = value
        End If
      End Set
    End Property
    Public Property PAK_POTypes7_Description() As String
      Get
        Return _PAK_POTypes7_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _PAK_POTypes7_Description = ""
        Else
          _PAK_POTypes7_Description = value
        End If
      End Set
    End Property
    Public Property PAK_Reasons8_Description() As String
      Get
        Return _PAK_Reasons8_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _PAK_Reasons8_Description = ""
        Else
          _PAK_Reasons8_Description = value
        End If
      End Set
    End Property
    Public Property VR_BusinessPartner9_BPName() As String
      Get
        Return _VR_BusinessPartner9_BPName
      End Get
      Set(ByVal value As String)
        _VR_BusinessPartner9_BPName = value
      End Set
    End Property
    Public ReadOnly Property DisplayField() As String
      Get
        Return "" & _PODescription.ToString.PadRight(100, " ")
      End Get
    End Property
    Public ReadOnly Property PrimaryKey() As String
      Get
        Return _SerialNo
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
    Public Class PKpakPO
      Private _SerialNo As Int32 = 0
      Public Property SerialNo() As Int32
        Get
          Return _SerialNo
        End Get
        Set(ByVal value As Int32)
          _SerialNo = value
        End Set
      End Property
    End Class
    Public ReadOnly Property FK_PAK_PO_BuyerID() As SIS.QCM.qcmUsers
      Get
        If _FK_PAK_PO_BuyerID Is Nothing Then
          _FK_PAK_PO_BuyerID = SIS.QCM.qcmUsers.qcmUsersGetByID(_BuyerID)
        End If
        Return _FK_PAK_PO_BuyerID
      End Get
    End Property
    Public ReadOnly Property FK_PAK_PO_IssuedBy() As SIS.QCM.qcmUsers
      Get
        If _FK_PAK_PO_IssuedBy Is Nothing Then
          _FK_PAK_PO_IssuedBy = SIS.QCM.qcmUsers.qcmUsersGetByID(_IssuedBy)
        End If
        Return _FK_PAK_PO_IssuedBy
      End Get
    End Property
    Public ReadOnly Property FK_PAK_PO_ClosedBy() As SIS.QCM.qcmUsers
      Get
        If _FK_PAK_PO_ClosedBy Is Nothing Then
          _FK_PAK_PO_ClosedBy = SIS.QCM.qcmUsers.qcmUsersGetByID(_ClosedBy)
        End If
        Return _FK_PAK_PO_ClosedBy
      End Get
    End Property
    Public ReadOnly Property FK_PAK_PO_ProjectID() As SIS.QCM.qcmProjects
      Get
        If _FK_PAK_PO_ProjectID Is Nothing Then
          _FK_PAK_PO_ProjectID = SIS.QCM.qcmProjects.qcmProjectsGetByID(_ProjectID)
        End If
        Return _FK_PAK_PO_ProjectID
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function pakPOGetByID(ByVal SerialNo As Int32) As SIS.PAK.pakPO
      Dim Results As SIS.PAK.pakPO = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sppakPOSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SerialNo", SqlDbType.Int, SerialNo.ToString.Length, SerialNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.PAK.pakPO(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function pakPOGetByID(ByVal SerialNo As Int32, ByVal Filter_POTypeID As Int32, ByVal Filter_SupplierID As String, ByVal Filter_ProjectID As String, ByVal Filter_BuyerID As String, ByVal Filter_POStatusID As Int32, ByVal Filter_IssuedBy As String) As SIS.PAK.pakPO
      Return pakPOGetByID(SerialNo)
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
