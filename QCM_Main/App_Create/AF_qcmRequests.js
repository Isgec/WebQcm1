<script type="text/javascript"> 
var script_qcmRequests = {
		ACEProjectID_Selected: function(sender, e) {
		  var Prefix = sender._element.id.replace('ProjectID','');
		  var F_ProjectID = $get(sender._element.id);
		  var F_ProjectID_Display = $get(sender._element.id + '_Display');
		  var retval = e.get_value();
		  var p = retval.split('|');
		  F_ProjectID.value = p[0];
		  F_ProjectID_Display.innerHTML = e.get_text();
		},
		ACEProjectID_Populating: function(sender,e) {
		  var p = sender.get_element();
		  var Prefix = sender._element.id.replace('ProjectID','');
		  p.style.backgroundImage  = 'url(../../images/loader.gif)';
		  p.style.backgroundRepeat= 'no-repeat';
		  p.style.backgroundPosition = 'right';
		  sender._contextKey = '';
		},
		ACEProjectID_Populated: function(sender,e) {
		  var p = sender.get_element();
		  p.style.backgroundImage  = 'none';
		},
		ACESupplierID_Selected: function(sender, e) {
		  var Prefix = sender._element.id.replace('SupplierID','');
		  var F_SupplierID = $get(sender._element.id);
		  var F_SupplierID_Display = $get(sender._element.id + '_Display');
		  var retval = e.get_value();
		  var p = retval.split('|');
		  F_SupplierID.value = p[0];
		  F_SupplierID_Display.innerHTML = e.get_text();
		},
		ACESupplierID_Populating: function(sender,e) {
		  var p = sender.get_element();
		  var Prefix = sender._element.id.replace('SupplierID','');
		  p.style.backgroundImage  = 'url(../../images/loader.gif)';
		  p.style.backgroundRepeat= 'no-repeat';
		  p.style.backgroundPosition = 'right';
		  sender._contextKey = '';
		},
		ACESupplierID_Populated: function(sender,e) {
		  var p = sender.get_element();
		  p.style.backgroundImage  = 'none';
		},
		ACEReceivedBy_Selected: function(sender, e) {
		  var Prefix = sender._element.id.replace('ReceivedBy','');
		  var F_ReceivedBy = $get(sender._element.id);
		  var F_ReceivedBy_Display = $get(sender._element.id + '_Display');
		  var retval = e.get_value();
		  var p = retval.split('|');
		  F_ReceivedBy.value = p[0];
		  F_ReceivedBy_Display.innerHTML = e.get_text();
		},
		ACEReceivedBy_Populating: function(sender,e) {
		  var p = sender.get_element();
		  var Prefix = sender._element.id.replace('ReceivedBy','');
		  p.style.backgroundImage  = 'url(../../images/loader.gif)';
		  p.style.backgroundRepeat= 'no-repeat';
		  p.style.backgroundPosition = 'right';
		  sender._contextKey = '';
		},
		ACEReceivedBy_Populated: function(sender,e) {
		  var p = sender.get_element();
		  p.style.backgroundImage  = 'none';
		},
		ACERegionID_Selected: function(sender, e) {
		  var Prefix = sender._element.id.replace('RegionID','');
		  var F_RegionID = $get(sender._element.id);
		  var F_RegionID_Display = $get(sender._element.id + '_Display');
		  var retval = e.get_value();
		  var p = retval.split('|');
		  F_RegionID.value = p[0];
		  F_RegionID_Display.innerHTML = e.get_text();
		},
		ACERegionID_Populating: function(sender,e) {
		  var p = sender.get_element();
		  var Prefix = sender._element.id.replace('RegionID','');
		  p.style.backgroundImage  = 'url(../../images/loader.gif)';
		  p.style.backgroundRepeat= 'no-repeat';
		  p.style.backgroundPosition = 'right';
		  sender._contextKey = '';
		},
		ACERegionID_Populated: function(sender,e) {
		  var p = sender.get_element();
		  p.style.backgroundImage  = 'none';
		},
		validate_ProjectID: function(sender) {
		  var Prefix = sender.id.replace('ProjectID','');
		  this.validated_FK_QCM_Requests_ProjectID_main = true;
		  this.validate_FK_QCM_Requests_ProjectID(sender,Prefix);
		  },
		validate_SupplierID: function(sender) {
		  var Prefix = sender.id.replace('SupplierID','');
		  this.validated_FK_QCM_Requests_SupplierID_main = true;
		  this.validate_FK_QCM_Requests_SupplierID(sender,Prefix);
		  },
		validate_ReceivedBy: function(sender) {
		  var Prefix = sender.id.replace('ReceivedBy','');
		  this.validated_FK_QCM_Requests_ReceivedBy_main = true;
		  this.validate_FK_QCM_Requests_ReceivedBy(sender,Prefix);
		  },
		validate_RegionID: function(sender) {
		  var Prefix = sender.id.replace('RegionID','');
		  this.validated_FK_QCM_Requests_RegionID_main = true;
		  this.validate_FK_QCM_Requests_RegionID(sender,Prefix);
		  },
		validate_FK_QCM_Requests_ReceivedBy: function(o,Prefix) {
		  var value = o.id;
		  var ReceivedBy = $get(Prefix + 'ReceivedBy');
		  if(ReceivedBy.value==''){
		    if(this.validated_FK_QCM_Requests_ReceivedBy_main){
		      var o_d = $get(Prefix + 'ReceivedBy' + '_Display');
		      try{o_d.innerHTML = '';}catch(ex){}
		    }
		    return true;
		  }
		  value = value + ',' + ReceivedBy.value ;
		    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
		    o.style.backgroundRepeat= 'no-repeat';
		    o.style.backgroundPosition = 'right';
		    PageMethods.validate_FK_QCM_Requests_ReceivedBy(value, this.validated_FK_QCM_Requests_ReceivedBy);
		  },
		validated_FK_QCM_Requests_ReceivedBy_main: false,
		validated_FK_QCM_Requests_ReceivedBy: function(result) {
		  var p = result.split('|');
		  var o = $get(p[1]);
		  if(script_qcmRequests.validated_FK_QCM_Requests_ReceivedBy_main){
		    var o_d = $get(p[1]+'_Display');
		    try{o_d.innerHTML = p[2];}catch(ex){}
		  }
		  o.style.backgroundImage  = 'none';
		  if(p[0]=='1'){
		    o.value='';
		    o.focus();
		  }
		},
		validate_FK_QCM_Requests_ProjectID: function(o,Prefix) {
		  var value = o.id;
		  var ProjectID = $get(Prefix + 'ProjectID');
		  if(ProjectID.value==''){
		    if(this.validated_FK_QCM_Requests_ProjectID_main){
		      var o_d = $get(Prefix + 'ProjectID' + '_Display');
		      try{o_d.innerHTML = '';}catch(ex){}
		    }
		    return true;
		  }
		  value = value + ',' + ProjectID.value ;
		    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
		    o.style.backgroundRepeat= 'no-repeat';
		    o.style.backgroundPosition = 'right';
		    PageMethods.validate_FK_QCM_Requests_ProjectID(value, this.validated_FK_QCM_Requests_ProjectID);
		  },
		validated_FK_QCM_Requests_ProjectID_main: false,
		validated_FK_QCM_Requests_ProjectID: function(result) {
		  var p = result.split('|');
		  var o = $get(p[1]);
		  if(script_qcmRequests.validated_FK_QCM_Requests_ProjectID_main){
		    var o_d = $get(p[1]+'_Display');
		    try{o_d.innerHTML = p[2];}catch(ex){}
		  }
		  o.style.backgroundImage  = 'none';
		  if(p[0]=='1'){
		    o.value='';
		    o.focus();
		  }
		},
		validate_FK_QCM_Requests_SupplierID: function(o,Prefix) {
		  var value = o.id;
		  var SupplierID = $get(Prefix + 'SupplierID');
		  if(SupplierID.value==''){
		    if(this.validated_FK_QCM_Requests_SupplierID_main){
		      var o_d = $get(Prefix + 'SupplierID' + '_Display');
		      try{o_d.innerHTML = '';}catch(ex){}
		    }
		    return true;
		  }
		  value = value + ',' + SupplierID.value ;
		    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
		    o.style.backgroundRepeat= 'no-repeat';
		    o.style.backgroundPosition = 'right';
		    PageMethods.validate_FK_QCM_Requests_SupplierID(value, this.validated_FK_QCM_Requests_SupplierID);
		  },
		validated_FK_QCM_Requests_SupplierID_main: false,
		validated_FK_QCM_Requests_SupplierID: function(result) {
		  var p = result.split('|');
		  var o = $get(p[1]);
		  if(script_qcmRequests.validated_FK_QCM_Requests_SupplierID_main){
		    var o_d = $get(p[1]+'_Display');
		    try{o_d.innerHTML = p[2];}catch(ex){}
		  }
		  o.style.backgroundImage  = 'none';
		  if(p[0]=='1'){
		    o.value='';
		    o.focus();
		  }
		},
		validate_FK_QCM_Requests_RegionID: function(o,Prefix) {
		  var value = o.id;
		  var RegionID = $get(Prefix + 'RegionID');
		  if(RegionID.value==''){
		    if(this.validated_FK_QCM_Requests_RegionID_main){
		      var o_d = $get(Prefix + 'RegionID' + '_Display');
		      try{o_d.innerHTML = '';}catch(ex){}
		    }
		    return true;
		  }
		  value = value + ',' + RegionID.value ;
		    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
		    o.style.backgroundRepeat= 'no-repeat';
		    o.style.backgroundPosition = 'right';
		    PageMethods.validate_FK_QCM_Requests_RegionID(value, this.validated_FK_QCM_Requests_RegionID);
		  },
		validated_FK_QCM_Requests_RegionID_main: false,
		validated_FK_QCM_Requests_RegionID: function(result) {
		  var p = result.split('|');
		  var o = $get(p[1]);
		  if(script_qcmRequests.validated_FK_QCM_Requests_RegionID_main){
		    var o_d = $get(p[1]+'_Display');
		    try{o_d.innerHTML = p[2];}catch(ex){}
		  }
		  o.style.backgroundImage  = 'none';
		  if(p[0]=='1'){
		    o.value='';
		    o.focus();
		  }
		},
		temp: function() {
		}
		}
</script>
