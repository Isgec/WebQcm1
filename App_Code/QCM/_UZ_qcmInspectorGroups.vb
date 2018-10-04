Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCM
  Partial Public Class qcmInspectorGroups
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
    Public Shared Function UZ_qcmInspectorGroupsInsert(ByVal Record As SIS.QCM.qcmInspectorGroups) As SIS.QCM.qcmInspectorGroups
      Dim _Result As SIS.QCM.qcmInspectorGroups = qcmInspectorGroupsInsert(Record)
      Return _Result
    End Function
    Public Shared Function UZ_qcmInspectorGroupsUpdate(ByVal Record As SIS.QCM.qcmInspectorGroups) As SIS.QCM.qcmInspectorGroups
      Dim _Result As SIS.QCM.qcmInspectorGroups = qcmInspectorGroupsUpdate(Record)
      Return _Result
    End Function
		Public Shared Function UZ_qcmInspectorGroupsDelete(ByVal Record As SIS.QCM.qcmInspectorGroups) As Integer
			Dim _Result As Integer = qcmInspectorGroups.Delete(Record)
			Return _Result
		End Function
  End Class
End Namespace
