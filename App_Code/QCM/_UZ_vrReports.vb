Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.VR
	Partial Public Class vrReports
		Private _RegionID As String = ""
		Private _QCM_Regions12_RegionName As String = ""
		Public Property QCM_Regions12_RegionName() As String
			Get
				Return _QCM_Regions12_RegionName
			End Get
			Set(ByVal value As String)
				_QCM_Regions12_RegionName = value
			End Set
		End Property
		Public Property RegionID() As String
			Get
				Return _RegionID
			End Get
			Set(ByVal value As String)
				_RegionID = value
			End Set
		End Property
		Public Function GetColor() As System.Drawing.Color
			Dim mRet As System.Drawing.Color = Drawing.Color.Blue
			Return mRet
		End Function
		Public Function GetVisible() As Boolean
			Dim mRet As Boolean = True
			Return mRet
		End Function
		Public Function GetEnable() As Boolean
			Dim mRet As Boolean = True
			Return mRet
		End Function
		Private _DivisionID As String = ""
		Private _OutOfContract As Boolean = False
		Public Property OutOfContract() As Boolean
			Get
				Return _OutOfContract
			End Get
			Set(ByVal value As Boolean)
				_OutOfContract = value
			End Set
		End Property
		Public Property DivisionID() As String
			Get
				Return _DivisionID
			End Get
			Set(ByVal value As String)
				_DivisionID = value
			End Set
		End Property
	End Class
End Namespace
