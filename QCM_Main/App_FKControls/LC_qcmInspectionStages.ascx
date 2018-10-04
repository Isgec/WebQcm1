<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmInspectionStages.ascx.vb" Inherits="LC_qcmInspectionStages" %>
<script type="text/javascript">
  function validate_stage(o) {
    var a = $get('F_TotalRequestedQuantity');
    var b = $get('F_LotSize');
    var c = $get('RFVTotalRequestedQuantity');
    var d = $get('RFVLotSize');

    if (o.value == '1') {
      try { a.className = 'mytxt'; } catch (ex) { }
      try { a.disabled = false; } catch (ex) { }
      try { ValidatorEnable(c, true); } catch (ex) { }
      try { b.className = 'dmytxt'; } catch (ex) { }
      try { b.disabled = true; } catch (ex) { }
      try { ValidatorEnable(d, false); } catch (ex) { alert(ex.message); }
          } else {
      if (o.value == '2') {
        try { a.className = 'dmytxt'; } catch (ex) { }
        try { a.disabled = true; } catch (ex) { }
        try { ValidatorEnable(c, false); } catch (ex) { }
        try { b.className = 'mytxt'; } catch (ex) { }
        try { b.disabled = false; } catch (ex) { }
        try { ValidatorEnable(d, true); } catch (ex) { }
      } else {
        try { a.className = 'mytxt'; } catch (ex) { }
        try { a.disabled = false; } catch (ex) { }
        try { ValidatorEnable(c, true); } catch (ex) { }
          try { b.className = 'mytxt'; } catch (ex) { }
          try { b.disabled = false; } catch (ex) { }
          try { ValidatorEnable(d, true); } catch (ex) { }
        }
    }
  }
</script>
<asp:DropDownList 
  ID = "DDLqcmInspectionStages"
  DataSourceID = "OdsDdlqcmInspectionStages"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  onblur="validate_stage(this);"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmInspectionStages"
  Runat = "server" 
  ControlToValidate = "DDLqcmInspectionStages"
  Text = "Inspection Stages is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  ForeColor="Red"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlqcmInspectionStages"
  TypeName = "SIS.QCM.qcmInspectionStages"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmInspectionStagesSelectList"
  Runat="server" />
