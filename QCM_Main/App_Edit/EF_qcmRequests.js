<script type="text/javascript"> 
var script_qcmRequests = {
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
