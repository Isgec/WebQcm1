Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCM
  Partial Public Class qcmEmployeeGroups
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
    Public Shared Function UZ_qcmEmployeeGroupsInsert(ByVal Record As SIS.QCM.qcmEmployeeGroups) As SIS.QCM.qcmEmployeeGroups
      Dim _Result As SIS.QCM.qcmEmployeeGroups = qcmEmployeeGroupsInsert(Record)
      Return _Result
    End Function
    Public Shared Function UZ_qcmEmployeeGroupsUpdate(ByVal Record As SIS.QCM.qcmEmployeeGroups) As SIS.QCM.qcmEmployeeGroups
      Dim _Result As SIS.QCM.qcmEmployeeGroups = qcmEmployeeGroupsUpdate(Record)
      Return _Result
    End Function
		Public Shared Function UZ_qcmEmployeeGroupsDelete(ByVal Record As SIS.QCM.qcmEmployeeGroups) As Integer
			Dim _Result As Integer = qcmEmployeeGroups.Delete(Record)
			Return _Result
		End Function
  End Class
End Namespace
