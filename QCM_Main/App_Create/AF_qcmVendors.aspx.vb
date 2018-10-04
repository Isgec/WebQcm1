Partial Class AF_qcmVendors
  Inherits SIS.SYS.InsertBase
  Protected Sub FVqcmVendors_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmVendors.Init
    DataClassName = "AqcmVendors"
    SetFormView = FVqcmVendors
  End Sub
  Protected Sub TBLqcmVendors_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmVendors.Init
    SetToolBar = TBLqcmVendors
  End Sub
  Protected Sub FVqcmVendors_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmVendors.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmVendors = {"
		mStr = mStr & vbCrLf &	"validate_VendorID: function(o) {"
		mStr = mStr & vbCrLf &	"    this.validatePK_qcmVendors(o);"
		mStr = mStr & vbCrLf &	"  },"
		Dim ctlVendorID As TextBox = FVqcmVendors.FindControl("F_VendorID")
		mStr = mStr & vbCrLf &	"validatePK_qcmVendors: function(o) {"
		mStr = mStr & vbCrLf &	"  var value = o.id;"
		mStr = mStr & vbCrLf &	"  try{$get('ctl00_cph1_FVqcmVendors_L_ErrMsgqcmVendors').innerHTML = '';}catch(ex){}"
		mStr = mStr & vbCrLf &	"  var VendorID = $get('" & ctlVendorID.ClientID & "');"
		mStr = mStr & vbCrLf &	"  if(VendorID.value=='')"
		mStr = mStr & vbCrLf &	"    return true;"
		mStr = mStr & vbCrLf &	"  value = value + ',' + VendorID.value ;"
		mStr = mStr & vbCrLf &	"  o.style.backgroundImage  = 'url(../../images/pkloader.gif)';"
		mStr = mStr & vbCrLf &	"  o.style.backgroundRepeat= 'no-repeat';"
		mStr = mStr & vbCrLf &	"  o.style.backgroundPosition = 'right';"
		mStr = mStr & vbCrLf &	"  PageMethods.validatePK_qcmVendors(value, this.validatedPK_qcmVendors);"
		mStr = mStr & vbCrLf &	"},"
		mStr = mStr & vbCrLf &	"validatedPK_qcmVendors: function(result) {"
		mStr = mStr & vbCrLf &	"  var p = result.split('|');"
		mStr = mStr & vbCrLf &	"  var o = $get(p[1]);"
		mStr = mStr & vbCrLf &	"  o.style.backgroundImage  = 'none';"
		mStr = mStr & vbCrLf &	"  if(p[0]=='1'){"
		mStr = mStr & vbCrLf &	"    try{$get('ctl00_cph1_FVqcmVendors_L_ErrMsgqcmVendors').innerHTML = p[2];}catch(ex){}"
		mStr = mStr & vbCrLf &	"    o.value='';"
		mStr = mStr & vbCrLf &	"    o.focus();"
		mStr = mStr & vbCrLf &	"  }"
		mStr = mStr & vbCrLf &	"},"
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmVendors") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmVendors", mStr)
		End If
  End Sub
	<System.Web.Services.WebMethod()> _
  Public Shared Function validatePK_qcmVendors(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
		Dim VendorID As String = CType(aVal(1),String)
		Dim oVar As SIS.QCM.qcmVendors = SIS.QCM.qcmVendors.qcmVendorsGetByID(VendorID)
    If Not oVar Is Nothing Then
			mRet = "1|" & aVal(0) & "|Record allready exists." 
    End If
    Return mRet
  End Function
End Class
