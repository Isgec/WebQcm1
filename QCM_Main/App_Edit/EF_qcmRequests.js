<script type="text/javascript"> 
var script_erpPO = {
  validate_ERPPONumber: function(o) {                                                                     
    var value = o.id;                                                                                         
    try{$get('cph1_FVqcmRequests_L_ErrMsgqcmRequests').innerHTML = '';}catch(ex){}   
    if(o=='')                                                                                
      return true;                                                                                            
    value = value + ',' + o.value ;                                                                
    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';                                              
    o.style.backgroundRepeat= 'no-repeat';                                                                    
    o.style.backgroundPosition = 'right';                                                                     
    PageMethods.validate_ERPPONumber(value, this.validated_ERPPONumber);                              
  },                                                                                                          
  validated_ERPPONumber: function(result) {                                                               
    var p = result.split('|');                                                                                
    var o = $get(p[1]);                                                                                       
    o.style.backgroundImage  = 'none';                                                                        
    if(p[0]=='1'){                                                                                            
      try{$get('cph1_FVqcmRequests_L_ErrMsgqcmRequests').innerHTML = p[2];}catch(ex){}
      o.value='';                                                                                             
      o.focus();                                                                                              
    }
    else{
      var x = $get(o.id.replace('F_OrderNo','F_POWeight'));
      var y = $get(o.id.replace('F_OrderNo','F_SupplierID'));
      var z = $get(o.id.replace('F_OrderNo','F_ProjectID'));
      y.value=p[2];
      z.value=p[3];
      x.value=p[4];
    }                                                                                                         
  },        
  temp: function() {
  }
}
</script>
