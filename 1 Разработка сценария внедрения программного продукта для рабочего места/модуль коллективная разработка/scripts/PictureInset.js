function zoomImg(obj, r, origin){
	if(obj.flagZoomed){
		obj.style.width = String(obj.oldWidth)+"px";
		obj.style.height = String(obj.oldHeight)+"px";
		if((origin != undefined) && (obj.parentNode != null) && (obj.parentNode.scrollLeft != null) && (obj.parentNode.scrollTop != null)){
			obj.parentNode.scrollLeft = 0;
			obj.parentNode.scrollTop = 0;
			obj.parentNode.style.overflow = "hidden";
		}
		obj.flagZoomed = false;
	}else{
		obj.oldWidth = obj.clientWidth;
		obj.oldHeight = obj.clientHeight;
		obj.style.width = String(Math.floor(obj.oldWidth*r))+"px";
		obj.style.height = String(Math.floor(obj.oldHeight*r))+"px";
		if((origin != undefined) && (obj.parentNode != null) && (obj.parentNode.scrollLeft != null) && (obj.parentNode.scrollTop != null)){
			obj.parentNode.style.overflow = "auto";
			switch(String(origin).slice(0,1).toUpperCase()){
			case "C":
				obj.parentNode.scrollLeft = Math.floor((obj.oldWidth*r-obj.parentNode.clientWidth)/2);
				break;
			case "L":
				obj.parentNode.scrollLeft = 0;
				break;
			case "R":
				obj.parentNode.scrollLeft = Math.floor(obj.oldWidth*r-obj.parentNode.clientWidth);
				break;
			}

			switch(String(origin).slice(1,2).toUpperCase()){
			case "M":
				obj.parentNode.scrollTop = Math.floor((obj.oldHeight*r-obj.parentNode.clientHeight)/2);
				break;
			case "T":
				obj.parentNode.scrollTop = 0;
				break;
			case "B":
				obj.parentNode.scrollTop = Math.floor(obj.oldHeight*r-obj.parentNode.clientHeight);
				break;
			}
			
		}
		obj.flagZoomed = true;
	}
}
//
function zoomSwf(obj, r, iconIn, iconOut) {
	var swtTagName = (navigator.appName.indexOf("Microsoft") != -1)?("object"):("embed");
	var swf = obj.parentNode.parentNode.getElementsByTagName(swtTagName)[0];
	var a = obj.getElementsByTagName('img');
	if(a.length>0){
		var icon = a[0];
		var sSrc = replaceSymbol(icon.src, "\\", "/");
		var i = sSrc.lastIndexOf("/");
		icon.src = sSrc.slice(0, i+1)+(((obj.flagZoomed!=true))?(iconOut):(iconIn));
	}
	//
	if(obj.flagZoomed){
		swf.width = String(obj.oldWidth)+"px";
		swf.height = String(obj.oldHeight)+"px";
		obj.flagZoomed = false;
	}else{
		obj.oldWidth = evalPx(swf.width);
		obj.oldHeight = evalPx(swf.height);
		swf.width = String(Math.floor(obj.oldWidth*r))+"px";
		swf.height = String(Math.floor(obj.oldHeight*r))+"px";
		obj.flagZoomed = true;
	}
}