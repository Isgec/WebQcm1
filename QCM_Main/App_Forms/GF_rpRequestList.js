<script type="text/javascript"> 
var script_vrReports = {
		ACEFProject_Selected: function(sender, e) {
		  var Prefix = sender._element.id.replace('FProject','');
		  var F_FProject = $get(sender._element.id);
		  var F_FProject_Display = $get(sender._element.id + '_Display');
		  var retval = e.get_value();
		  var p = retval.split('|');
		  F_FProject.value = p[0];
		  F_FProject_Display.innerHTML = e.get_text();
		},
		ACEFProject_Populating: function(sender,e) {
		  var p = sender.get_element();
		  var Prefix = sender._element.id.replace('FProject','');
		  p.style.backgroundImage  = 'url(../../images/loader.gif)';
		  p.style.backgroundRepeat= 'no-repeat';
		  p.style.backgroundPosition = 'right';
		  sender._contextKey = '';
		},
		ACEFProject_Populated: function(sender,e) {
		  var p = sender.get_element();
		  p.style.backgroundImage  = 'none';
		},
		ACETProject_Selected: function(sender, e) {
		  var Prefix = sender._element.id.replace('TProject','');
		  var F_TProject = $get(sender._element.id);
		  var F_TProject_Display = $get(sender._element.id + '_Display');
		  var retval = e.get_value();
		  var p = retval.split('|');
		  F_TProject.value = p[0];
		  F_TProject_Display.innerHTML = e.get_text();
		},
		ACETProject_Populating: function(sender,e) {
		  var p = sender.get_element();
		  var Prefix = sender._element.id.replace('TProject','');
		  p.style.backgroundImage  = 'url(../../images/loader.gif)';
		  p.style.backgroundRepeat= 'no-repeat';
		  p.style.backgroundPosition = 'right';
		  sender._contextKey = '';
		},
		ACETProject_Populated: function(sender,e) {
		  var p = sender.get_element();
		  p.style.backgroundImage  = 'none';
		},
		ACEFSupplier_Selected: function(sender, e) {
		  var Prefix = sender._element.id.replace('FSupplier','');
		  var F_FSupplier = $get(sender._element.id);
		  var F_FSupplier_Display = $get(sender._element.id + '_Display');
		  var retval = e.get_value();
		  var p = retval.split('|');
		  F_FSupplier.value = p[0];
		  F_FSupplier_Display.innerHTML = e.get_text();
		},
		ACEFSupplier_Populating: function(sender,e) {
		  var p = sender.get_element();
		  var Prefix = sender._element.id.replace('FSupplier','');
		  p.style.backgroundImage  = 'url(../../images/loader.gif)';
		  p.style.backgroundRepeat= 'no-repeat';
		  p.style.backgroundPosition = 'right';
		  sender._contextKey = '';
		},
		ACEFSupplier_Populated: function(sender,e) {
		  var p = sender.get_element();
		  p.style.backgroundImage  = 'none';
		},
		ACETSupplier_Selected: function(sender, e) {
		  var Prefix = sender._element.id.replace('TSupplier','');
		  var F_TSupplier = $get(sender._element.id);
		  var F_TSupplier_Display = $get(sender._element.id + '_Display');
		  var retval = e.get_value();
		  var p = retval.split('|');
		  F_TSupplier.value = p[0];
		  F_TSupplier_Display.innerHTML = e.get_text();
		},
		ACETSupplier_Populating: function(sender,e) {
		  var p = sender.get_element();
		  var Prefix = sender._element.id.replace('TSupplier','');
		  p.style.backgroundImage  = 'url(../../images/loader.gif)';
		  p.style.backgroundRepeat= 'no-repeat';
		  p.style.backgroundPosition = 'right';
		  sender._contextKey = '';
		},
		ACETSupplier_Populated: function(sender,e) {
		  var p = sender.get_element();
		  p.style.backgroundImage  = 'none';
		},
		ACEFUser_Selected: function(sender, e) {
		  var Prefix = sender._element.id.replace('FUser','');
		  var F_FUser = $get(sender._element.id);
		  var F_FUser_Display = $get(sender._element.id + '_Display');
		  var retval = e.get_value();
		  var p = retval.split('|');
		  F_FUser.value = p[0];
		  F_FUser_Display.innerHTML = e.get_text();
		},
		ACEFUser_Populating: function(sender,e) {
		  var p = sender.get_element();
		  var Prefix = sender._element.id.replace('FUser','');
		  p.style.backgroundImage  = 'url(../../images/loader.gif)';
		  p.style.backgroundRepeat= 'no-repeat';
		  p.style.backgroundPosition = 'right';
		  sender._contextKey = '';
		},
		ACEFUser_Populated: function(sender,e) {
		  var p = sender.get_element();
		  p.style.backgroundImage  = 'none';
		},
		ACETUser_Selected: function(sender, e) {
		  var Prefix = sender._element.id.replace('TUser','');
		  var F_TUser = $get(sender._element.id);
		  var F_TUser_Display = $get(sender._element.id + '_Display');
		  var retval = e.get_value();
		  var p = retval.split('|');
		  F_TUser.value = p[0];
		  F_TUser_Display.innerHTML = e.get_text();
		},
		ACETUser_Populating: function(sender,e) {
		  var p = sender.get_element();
		  var Prefix = sender._element.id.replace('TUser','');
		  p.style.backgroundImage  = 'url(../../images/loader.gif)';
		  p.style.backgroundRepeat= 'no-repeat';
		  p.style.backgroundPosition = 'right';
		  sender._contextKey = '';
		},
		ACETUser_Populated: function(sender,e) {
		  var p = sender.get_element();
		  p.style.backgroundImage  = 'none';
		},
		validate_FProject: function(sender) {
		  var Prefix = sender.id.replace('FProject','');
		  this.validated_FK_VR_Reports_FProjectID_main = true;
		  this.validate_FK_VR_Reports_FProjectID(sender,Prefix);
		  },
		validate_TProject: function(sender) {
		  var Prefix = sender.id.replace('TProject','');
		  this.validated_FK_VR_Reports_TProjectID_main = true;
		  this.validate_FK_VR_Reports_TProjectID(sender,Prefix);
		  },
		validate_FSupplier: function(sender) {
		  var Prefix = sender.id.replace('FSupplier','');
		  this.validated_FK_VR_Reports_FSupplier_main = true;
		  this.validate_FK_VR_Reports_FSupplier(sender,Prefix);
		  },
		validate_TSupplier: function(sender) {
		  var Prefix = sender.id.replace('TSupplier','');
		  this.validated_FK_VR_Reports_TSupplier_main = true;
		  this.validate_FK_VR_Reports_TSupplier(sender,Prefix);
		  },
		validate_FUser: function(sender) {
		  var Prefix = sender.id.replace('FUser','');
		  this.validated_FK_VR_Reports_FUser_main = true;
		  this.validate_FK_VR_Reports_FUser(sender,Prefix);
		  },
		validate_TUser: function(sender) {
		  var Prefix = sender.id.replace('TUser','');
		  this.validated_FK_VR_Reports_TUser_main = true;
		  this.validate_FK_VR_Reports_TUser(sender,Prefix);
		  },
		validate_FK_VR_Reports_FUser: function(o,Prefix) {
		  var value = o.id;
		  var FUser = $get(Prefix + 'FUser');
		  if(FUser.value==''){
		    if(this.validated_FK_VR_Reports_FUser_main){
		      var o_d = $get(Prefix + 'FUser' + '_Display');
		      try{o_d.innerHTML = '';}catch(ex){}
		    }
		    return true;
		  }
		  value = value + ',' + FUser.value ;
		    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
		    o.style.backgroundRepeat= 'no-repeat';
		    o.style.backgroundPosition = 'right';
		    PageMethods.validate_FK_VR_Reports_FUser(value, this.validated_FK_VR_Reports_FUser);
		  },
		validated_FK_VR_Reports_FUser_main: false,
		validated_FK_VR_Reports_FUser: function(result) {
		  var p = result.split('|');
		  var o = $get(p[1]);
		  if(script_vrReports.validated_FK_VR_Reports_FUser_main){
		    var o_d = $get(p[1]+'_Display');
		    try{o_d.innerHTML = p[2];}catch(ex){}
		  }
		  o.style.backgroundImage  = 'none';
		  if(p[0]=='1'){
		    o.value='';
		    o.focus();
		  }
		},
		validate_FK_VR_Reports_TUser: function(o,Prefix) {
		  var value = o.id;
		  var TUser = $get(Prefix + 'TUser');
		  if(TUser.value==''){
		    if(this.validated_FK_VR_Reports_TUser_main){
		      var o_d = $get(Prefix + 'TUser' + '_Display');
		      try{o_d.innerHTML = '';}catch(ex){}
		    }
		    return true;
		  }
		  value = value + ',' + TUser.value ;
		    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
		    o.style.backgroundRepeat= 'no-repeat';
		    o.style.backgroundPosition = 'right';
		    PageMethods.validate_FK_VR_Reports_TUser(value, this.validated_FK_VR_Reports_TUser);
		  },
		validated_FK_VR_Reports_TUser_main: false,
		validated_FK_VR_Reports_TUser: function(result) {
		  var p = result.split('|');
		  var o = $get(p[1]);
		  if(script_vrReports.validated_FK_VR_Reports_TUser_main){
		    var o_d = $get(p[1]+'_Display');
		    try{o_d.innerHTML = p[2];}catch(ex){}
		  }
		  o.style.backgroundImage  = 'none';
		  if(p[0]=='1'){
		    o.value='';
		    o.focus();
		  }
		},
		validate_FK_VR_Reports_FProjectID: function(o,Prefix) {
		  var value = o.id;
		  var FProject = $get(Prefix + 'FProject');
		  if(FProject.value==''){
		    if(this.validated_FK_VR_Reports_FProjectID_main){
		      var o_d = $get(Prefix + 'FProject' + '_Display');
		      try{o_d.innerHTML = '';}catch(ex){}
		    }
		    return true;
		  }
		  value = value + ',' + FProject.value ;
		    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
		    o.style.backgroundRepeat= 'no-repeat';
		    o.style.backgroundPosition = 'right';
		    PageMethods.validate_FK_VR_Reports_FProjectID(value, this.validated_FK_VR_Reports_FProjectID);
		  },
		validated_FK_VR_Reports_FProjectID_main: false,
		validated_FK_VR_Reports_FProjectID: function(result) {
		  var p = result.split('|');
		  var o = $get(p[1]);
		  if(script_vrReports.validated_FK_VR_Reports_FProjectID_main){
		    var o_d = $get(p[1]+'_Display');
		    try{o_d.innerHTML = p[2];}catch(ex){}
		  }
		  o.style.backgroundImage  = 'none';
		  if(p[0]=='1'){
		    o.value='';
		    o.focus();
		  }
		},
		validate_FK_VR_Reports_TProjectID: function(o,Prefix) {
		  var value = o.id;
		  var TProject = $get(Prefix + 'TProject');
		  if(TProject.value==''){
		    if(this.validated_FK_VR_Reports_TProjectID_main){
		      var o_d = $get(Prefix + 'TProject' + '_Display');
		      try{o_d.innerHTML = '';}catch(ex){}
		    }
		    return true;
		  }
		  value = value + ',' + TProject.value ;
		    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
		    o.style.backgroundRepeat= 'no-repeat';
		    o.style.backgroundPosition = 'right';
		    PageMethods.validate_FK_VR_Reports_TProjectID(value, this.validated_FK_VR_Reports_TProjectID);
		  },
		validated_FK_VR_Reports_TProjectID_main: false,
		validated_FK_VR_Reports_TProjectID: function(result) {
		  var p = result.split('|');
		  var o = $get(p[1]);
		  if(script_vrReports.validated_FK_VR_Reports_TProjectID_main){
		    var o_d = $get(p[1]+'_Display');
		    try{o_d.innerHTML = p[2];}catch(ex){}
		  }
		  o.style.backgroundImage  = 'none';
		  if(p[0]=='1'){
		    o.value='';
		    o.focus();
		  }
		},
		validate_FK_VR_Reports_FSupplier: function(o,Prefix) {
		  var value = o.id;
		  var FSupplier = $get(Prefix + 'FSupplier');
		  if(FSupplier.value==''){
		    if(this.validated_FK_VR_Reports_FSupplier_main){
		      var o_d = $get(Prefix + 'FSupplier' + '_Display');
		      try{o_d.innerHTML = '';}catch(ex){}
		    }
		    return true;
		  }
		  value = value + ',' + FSupplier.value ;
		    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
		    o.style.backgroundRepeat= 'no-repeat';
		    o.style.backgroundPosition = 'right';
		    PageMethods.validate_FK_VR_Reports_FSupplier(value, this.validated_FK_VR_Reports_FSupplier);
		  },
		validated_FK_VR_Reports_FSupplier_main: false,
		validated_FK_VR_Reports_FSupplier: function(result) {
		  var p = result.split('|');
		  var o = $get(p[1]);
		  if(script_vrReports.validated_FK_VR_Reports_FSupplier_main){
		    var o_d = $get(p[1]+'_Display');
		    try{o_d.innerHTML = p[2];}catch(ex){}
		  }
		  o.style.backgroundImage  = 'none';
		  if(p[0]=='1'){
		    o.value='';
		    o.focus();
		  }
		},
		validate_FK_VR_Reports_TSupplier: function(o,Prefix) {
		  var value = o.id;
		  var TSupplier = $get(Prefix + 'TSupplier');
		  if(TSupplier.value==''){
		    if(this.validated_FK_VR_Reports_TSupplier_main){
		      var o_d = $get(Prefix + 'TSupplier' + '_Display');
		      try{o_d.innerHTML = '';}catch(ex){}
		    }
		    return true;
		  }
		  value = value + ',' + TSupplier.value ;
		    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
		    o.style.backgroundRepeat= 'no-repeat';
		    o.style.backgroundPosition = 'right';
		    PageMethods.validate_FK_VR_Reports_TSupplier(value, this.validated_FK_VR_Reports_TSupplier);
		  },
		validated_FK_VR_Reports_TSupplier_main: false,
		validated_FK_VR_Reports_TSupplier: function(result) {
		  var p = result.split('|');
		  var o = $get(p[1]);
		  if(script_vrReports.validated_FK_VR_Reports_TSupplier_main){
		    var o_d = $get(p[1]+'_Display');
		    try{o_d.innerHTML = p[2];}catch(ex){}
		  }
		  o.style.backgroundImage  = 'none';
		  if(p[0]=='1'){
		    o.value='';
		    o.focus();
		  }
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
		validate_RegionID: function(sender) {
		  var Prefix = sender.id.replace('RegionID','');
		  this.validated_FK_QCM_Requests_RegionID_main = true;
		  this.validate_FK_QCM_Requests_RegionID(sender,Prefix);
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
		  if(script_vrReports.validated_FK_QCM_Requests_RegionID_main){
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
