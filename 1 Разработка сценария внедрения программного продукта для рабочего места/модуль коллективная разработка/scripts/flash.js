function showFlaconMX(width, height, fname, swf, params) {
try {
	var str= '<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0" width="' + width + '" height="' + height + '" id="' + fname + '">';
  str+='<param name="movie" value="'+swf+'"></param>';
	str+='<param name="menu" value="false"/><param name="quality" value="high"/><param name="wmode" value="transparent"/>';
	if(params+''!='undefined') {str+=params;}
	str+='<embed menu="false" wmode="transparent" quality="high" bgcolor="#FFFFFF" type="application/x-shockwave-flash" pluginspage="http://www.macromedia.com/shockwave/download/index.cgi?P1_Prod_Version=ShockwaveFlash" src="'+swf+'"  width="' + width + '" height="' + height + '"></embed>';
	str+='</object>';
	return(str);
}catch(e){}
}

