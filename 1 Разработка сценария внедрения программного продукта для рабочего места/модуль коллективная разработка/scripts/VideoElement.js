var aVideosToLoad = [];
var aVideosLoaded = [];
var aVideoElements = [];
var videosToLoadIntervalId;
var videosToLoadInterval = 100;
//
var videosPositionIntervalId;
var videosPositionInterval = 250;
videosPositionIntervalId = window.setInterval("pollVideoPositions()", videosPositionInterval);
//для перемотки слайдером
var currentSlider;
var currentSliderControl;
var currentSliderObj;
var currentSliderXMin;
var currentSliderXMax;
//
//
function pollAVideosToLoad(){
	var i, a = aVideosToLoad, l = a.length, sState, flag;
	var j, aVEl = aVideoElements, n = aVEl.length, vEl;
	for(i=0; i<l; i++){
		if(!a[i].flagSwf){
			//надо получить ссылку на swf данного VideoElement'а
			for(j=0; j<n; j++){
				vEl = aVEl[j];
				if( vEl.ready && (vEl.id==a[i].id) && ((vEl.sceneNumber==currentSceneNumber) || (vEl.sceneNumber<0)) ){
					break;
				}
			}
			if(j<n){
				try{
					a[i].obj = getSwfVideoElement(a[i].objDocument, a[i].id);
				}catch(err){
				}
			}
			a[i].flagSwf = (a[i].obj != null);
		}
		if(a[i].flagSwf){
			//теперь есть ссылка на swf-объект соответствующего VideoElement'а. Загружаем flv
			try{
			flag = true;
				if(flag && a[i].obj && a[i].obj.ownerDocument){
					//произойдёт exception, если a[i].obj относится к другой сцене; flag -> false и a[i] удаляется
					flag = true;
				}
			}catch(err){
				flag = false;
			}
			//
			if(flag){
				try{
					sState = a[i].obj.getReadyState();
				}catch(err){
					sState = "not ready";
				}
				if((sState == "ready") && (a[i].nDelay-- <= 0)){
					try{
						a[i].obj.openVideo(a[i].id, a[i].src, a[i].width, a[i].height);
					}catch(err){
						sState = "failed";
					}
					if(sState == "ready"){
						var obj = {objDocument:a[i].objDocument, obj:a[i].obj, id:a[i].id};
						if(!isNaN(a[i].volume)){
							try{
								a[i].obj.setVolume(a[i].volume);
							}catch(err){
							}
						}
						if(a[i].mute){
							try{
								a[i].obj.setMute(a[i].mute);
							}catch(err){
							}
						}
						if(!isNaN(a[i].volumeMultiplier)){
							try{
								a[i].obj.setVolumeMultiplier(a[i].volumeMultiplier);
							}catch(err){
							}
						}
						if(a[i].pause){
							try{
								a[i].obj.setPause(a[i].pause);
							}catch(err){
							}
						}
						if(a[i].idControl != null){
							obj.idControl = a[i].idControl;
						}else{
							for(j=0; j<aVEl.length; j++){
								if(aVEl[j].id == a[i].id){
									if(aVEl[j].idControl != null){
										obj.idControl = aVEl[j].idControl;
									}
									break;
								}
							}
							//
						}
						if(a[i].position != undefined){
							obj.position = a[i].position;
						}
						aVideosLoaded.push(obj);
					}
					a.splice(i--, 1);
					l--;
				}
			}else{
				a.splice(i--, 1);
				l--;
			}
		}
		
	}
}
//
function pollVideoPositions(){
	//для позиционирования слайдеров
	var a = aVideosLoaded, i, l = a.length, r, flag, pos;
	for(i=0; i<l; i++){
		flag = true;
		try{
			pos = a[i].obj.getPosition();
		}catch(err){
			flag = false;
		}
		if(flag && ((currentSliderObj == null) || (a[i] != currentSliderObj)) && (a[i].idControl != null) && (a[i].metaData != null) && (a[i].metaData.duration>0)){
			r = pos/a[i].metaData.duration;
			setVideoControlState(a[i].objDocument, a[i].idControl, null, null, r);
		}
	}
}
//Перенесено в TocMenu.js, в обработчик onLoad для sceneIframe
//videosToLoadIntervalId = window.setInterval("pollAVideosToLoad()", 100);
//
function findVideoById(sId){
	var a = aVideosLoaded, i, l = a.length, sIdVideo = sId+"_VideoElement";
	for(i=0;(i<l) && (a[i].id != sIdVideo);i++){}
	return (i<l)?(i):(-1);
}
function findVideoToLoadById(sId){
	var a = aVideosToLoad, i, l = a.length, sIdVideo = sId+"_VideoElement";
	for(i=0;(i<l) && (a[i].id != sIdVideo);i++){
	}
	return (i<l)?(i):(-1);
}
//
function videoElement(objDocument, idNode, w, h, src, wSrc, hSrc){
	var objNode = objDocument.getElementById(idNode);
	var sId = String(idNode)+"_VideoElement";
	var sDiv = "<object wmode=\"transparent\"";
	sDiv += " classid=\"clsid:d27cdb6e-ae6d-11cf-96b8-444553540000\" codebase=\"http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=8,0,0,0\"";
	sDiv += " width=\""+String(w)+"\" height=\""+String(h)+"\" id=\""+String(sId)+"\">";
	sDiv += "<param name=\"movie\" value=\"../modelers/VideoElement.swf\" />";
	sDiv += "<param name=\"quality\" value=\"high\" />";
	sDiv += "<param name=\"Scale\" value=\"showAll\"/>";
	sDiv += "<param name=\"allowScriptAccess\" value=\"always\" />";
	sDiv += "<param name=\"FlashVars\" value=\"id="+String(sId)+"\" />";
	sDiv += "<EMBED src=\"../modelers/VideoElement.swf?id="+String(sId)+"\" quality=high id=\""+String(idNode)+"Embed"+"_VideoElement"+"\" ";
	sDiv += "WIDTH=\""+String(w)+"\" HEIGHT=\""+String(h)+"\" TYPE=\"application/x-shockwave-flash\" allowScriptAccess=\"always\" scale = \"showAll\" ";
	sDiv +=	"wmode=\"transparent\" PLUGINSPAGE=\"http://www.macromedia.com/go/getflashplayer\"></EMBED>";
	sDiv += "</object>";
	
	var i, aVEl = aVideoElements, vEl;
	//удалить из массивов, если остался там после F5
	for(i=0; i<aVEl.length; i++){
		vEl = aVEl[i];
		if((vEl.id==sId) && (vEl.sceneNumber==currentSceneNumber)){
			aVEl.splice(i--, 1);
		}
	}
	//
	i = findVideoById(idNode);
	if(i!=-1){
		aVideosLoaded.splice(i, 1);
	}
	i = findVideoToLoadById(idNode);
	if(i!=-1){
		aVideosToLoad.splice(i, 1);
	}

	aVideoElements.push({sceneNumber:currentSceneNumber, id:sId, ready:false});
	
	objNode.innerHTML = sDiv;
	if(src == undefined){
		return;
	}
	openVideo(objDocument, idNode, src, wSrc, hSrc);
}
//
function addVideoControl(objDocument, idNode, idControlNode){
	var objDiv = objDocument.getElementById(idNode);
	if(objDiv == null){
		return;
	}
	//где будет control
	var nodeDiv = objDocument.getElementById(idControlNode);

	var a = objDiv.getElementsByTagName("object");
	var attr = a[0].attributes.getNamedItem("width"), w;
	w = ((attr!=null) && !isNaN(attr.value)) ? (Number(attr.value)) : (220);
	//
	var xSliderMin = 55;
	var xSliderMax = xSliderMin+w-86;
	//
	var sDiv = "";
	sDiv += "<img id=\"imgVideoSlider\" title=\"Поиск\" src=\"../layout/layout_img/video_slider_out.png\" style=\"position:absolute; left:"+String(xSliderMin)+"px; top:7px; z-index:2;\"/>";
	sDiv += "<img id=\"imgVideoStop\" title=\"Остановка\" style=\"position:absolute;top:5px;left:28px; z-index:2;\" src=\"../layout/layout_img/stop_btn_out.png\" onMouseOver=\"javascript:parent.overVideoStop(document, this);\" onMouseOut=\"javascript:parent.outVideoStop(document, this);\" onMouseUp=\"javascript:parent.upVideoStop(document, this);\" onMouseDown=\"javascript:parent.downVideoStop(document, this);\"/>";
	sDiv += "<img id=\"imgVideoPlayPause\" title=\"Воспроизведение\" style=\"position:absolute;top:5px;left:2px; z-index:2;\" src=\"../layout/layout_img/play_btn_out.png\" onMouseOver=\"javascript:parent.overPB(document, this);\" onMouseOut=\"javascript:parent.outPB(document, this);\" onMouseUp=\"javascript:parent.upPB(document, this);\" onMouseDown=\"javascript:parent.downPB(document, this);\"/>";
	sDiv += "<img id=\"imgVideoLeftBg\" src=\"../layout/layout_img/video_left_bg.png\" style=\"position:absolute; left:0px; top:2px; z-index:0;\"/>";
	sDiv += "<img id=\"imgVideoMiddleBg\" src=\"../layout/layout_img/video_middle_bg.png\" style=\"position:absolute; left:10px; top:2px; width:"+String(w-20)+"px; height:28px; z-index:0;\"/>";
	sDiv += "<img id=\"imgVideoRightBg\" src=\"../layout/layout_img/video_right_bg.png\" style=\"position:absolute; left:"+String(w-10)+"px; top:2px; z-index:0;\"/>";
	sDiv += "<img id=\"imgVideoLine\" src=\"../layout/layout_img/video_line.png\" style=\"position:absolute; left:58px; top:14px; width:"+String(w-86)+"px; height:5px; z-index:1;\"/>";
	//table – для габаритов
	sDiv += "<table cellpadding=\"0\" style=\"border:none;\"><tr><td width=\""+String(w)+"\" height=\"32\"></td></tr></table>";

	//var nodeDiv = objDocument.createElement("div");

	nodeDiv.style.visibility = "hidden";
	nodeDiv.style.position = "relative";
	
	nodeDiv.overflow = "hidden";
	
	nodeDiv.width = String(w)+"px";
	nodeDiv.height = "32px";
	
	nodeDiv.visibility = "hidden";
	//
	nodeDiv.setAttribute("xSliderMin", xSliderMin);
	nodeDiv.setAttribute("xSliderMax", xSliderMax);
	//
	nodeDiv.innerHTML = sDiv;
	//objDiv.appendChild(nodeDiv);
	//
	i = findVideoById(idNode);
	if(i!=-1){
		aVideosLoaded[i].idControl = idControlNode;
	}
	i = findVideoToLoadById(idNode);
	if(i!=-1){
		aVideosToLoad[i].idControl = idControlNode;
	}else{
		var aVEl = aVideoElements, sId = idNode+"_VideoElement";
		for(i=0; i<aVEl.length; i++){
			if(aVEl[i].id == sId){
				aVEl[i].idControl = idControlNode;
				break;
			}
		}
	}
}
//
function getSwfVideoElement(objDocument, sId){
	var objElement = objDocument.getElementById(sId);
	if(navigator.appName != "Microsoft Internet Explorer"){
		var a = objElement.getElementsByTagName("embed");
		if(a.length>0){
			return a[0];
		}else{
			return null;
		}
	}else{
		return objElement;
	}
}
//
function updateAVideoElements(n){
	var i, aVEl = aVideoElements;
	for(i=0; i<aVEl.length; i++){
		//sceneNumber < 0 – для постоянных видеоэлементов
		if((aVEl[i].sceneNumber >= 0) && (aVEl[i].sceneNumber != n)){
			aVEl.splice(i--, 1);
		}
	}
}
//
function openVideo(objDocument, idNode, src, w, h){
	var sPath = objDocument.URL;
	//alert("openVideo : "+sId+" : "+sPath);
	sPath = replaceSymbol(sPath, "\\", "/");
	sPath = sPath.slice(0, sPath.lastIndexOf("/content/"))+"/media/video/"+src;
	//
	//загружаем с небольшой задержкой, иначе либо swf не готов, либо (под IE) не отображается загруженный flv-файл
	var sId = String(idNode+"_VideoElement");
	var i = findVideoToLoadById(idNode);
	if(i!=-1){
		aVideosToLoad.splice(i, 1);
	}
	//flagSwf=false, пока не добавили ссылку (obj) на swf VideoElement'а
	aVideosToLoad.push({objDocument:objDocument, flagSwf:false, obj:null, id:sId, src:sPath, width:w, height:h, volumeMultiplier:getVolumeMultiplier(), nDelay:1, pause:true});
}
//
function onVideoState(sId, sState){
	//alert("videoState : "+sState+" :: "+sId);
	var sStateL = String(sState).toLowerCase();
	switch(sStateL){
	case "ready":
		var i, aVEl = aVideoElements, l = aVEl.length, obj;
		for(i=0; i<l; i++){
			obj = aVEl[i];
			if((obj.id==sId) && ((obj.sceneNumber==currentSceneNumber) || (obj.sceneNumber<0))){
				//Пометим, что swf "сообщил" о себе
				obj.ready = true;
				break;
			}
		}
		return (i<l)?("ready"):("not found");
		break;
	case "start":
	case "end":
		var nodeId = sId.slice(0, sId.indexOf("_VideoElement"));
		var i = findVideoById(nodeId);
		if(i!=-1){
			switch(sStateL){
			case "start":
				try{
					if(aVideosLoaded[i].idControl != null){
						setVideoControlState(aVideosLoaded[i].objDocument, aVideosLoaded[i].idControl, "pause_btn_out.png", null, 0);
					}
				}catch(err){
				}
				break;
			case "end":
				try{
					aVideosLoaded[i].obj.setPause(true);
					if(aVideosLoaded[i].idControl != null){
						setVideoControlState(aVideosLoaded[i].objDocument, aVideosLoaded[i].idControl, "play_btn_out.png", null, 1);
					}			
				}catch(err){
				}
				break;
			default:;
			}		
		}
		break;
	default:
	}
}
//
function onMetaData(sId, objMetaData){
	var nodeId = sId.slice(0, sId.indexOf("_VideoElement"));
	var i = findVideoById(nodeId);
	if(i == -1){
		return;
	}
	//alert("onMetaData : "+sId+" : "+objMetaData);
	aVideosLoaded[i].metaData = objMetaData;

	if(aVideosLoaded[i].position != undefined){
		try{
			aVideosLoaded[i].obj.setPosition(aVideosLoaded[i].position);
			aVideosLoaded[i].position = undefined;
		}catch(err){
		}
	}else{
		try{
			aVideosLoaded[i].obj.setPosition(0);
		}catch(err){
		}
	}
	//активировать панель соотв. проигрывателя
	//
	if(aVideosLoaded[i].idControl != null){
		var objControl = aVideosLoaded[i].objDocument.getElementById(aVideosLoaded[i].idControl);
		objControl.style.visibility = "visible";
		var sState= aVideosLoaded[i].obj.getState();
		setVideoControlState(aVideosLoaded[i].objDocument, aVideosLoaded[i].idControl, ((sState=="pause")||(sState=="stop"))?("play_btn_out.png"):("pause_btn_out.png"), null, undefined);
		
	}
}
//
function findVideoByPB(objFrame, objImg){
	if((objImg == null) || (objImg.parentNode == null) || (objImg.parentNode.id == null)){
		return -1;
	}
	
	if(objImg.parentNode.id == null){
		return -1;
	}

	var idParent = String(objImg.parentNode.id), i, a = aVideosLoaded, l = a.length, nodeId;
	for(i=0; i<l; i++){
		if(a[i].idControl == idParent){
			nodeId = String(a[i].obj.id).slice(0, a[i].obj.id.indexOf("_VideoElement"));
			break;
		}
	}
	if(i==l){
		return -1;
	}
	
	return i;
}
//
function overVideoStop(objFrame, objImg){
	var obj, sState;
	var i = findVideoByPB(objFrame, objImg);
	if(i != -1){
		obj = aVideosLoaded[i].obj;
		try{
			sState= obj.getState();
		}catch(err){
			return;
		}
	}else{
		return;
	}
	setVideoControlState(aVideosLoaded[i].objDocument, aVideosLoaded[i].idControl, null, "stop_btn_over.png", undefined);
}
function outVideoStop(objFrame, objImg){	
	var obj, sState;
	var i = findVideoByPB(objFrame, objImg);
	if(i != -1){
		obj = aVideosLoaded[i].obj;
		try{
			sState= obj.getState();
		}catch(err){
			return;
		}
	}else{
		return;
	}
	setVideoControlState(aVideosLoaded[i].objDocument, aVideosLoaded[i].idControl, null, "stop_btn_out.png", undefined);
}
function upVideoStop(objFrame, objImg){	
	var obj, sState;
	var i = findVideoByPB(objFrame, objImg);
	if(i != -1){
		obj = aVideosLoaded[i].obj;
		try{
			sState= obj.getState();
		}catch(err){
			return;
		}
	}else{
		return;
	}
	obj.setPosition(0);
	obj.setPause(true);	
	setVideoControlState(aVideosLoaded[i].objDocument, aVideosLoaded[i].idControl, "play_btn_out.png", "stop_btn_out.png", 0);
}
function downVideoStop(objFrame, objImg){
	var obj, sState;
	var i = findVideoByPB(objFrame, objImg);
	if(i != -1){
		obj = aVideosLoaded[i].obj;
		try{
			sState= obj.getState();
		}catch(err){
			return;
		}
	}else{
		return;
	}
	setVideoControlState(aVideosLoaded[i].objDocument, aVideosLoaded[i].idControl, null, "stop_btn_down.png", undefined);
}
//
function overPB(objFrame, objImg){
	var obj, sState;
	var i = findVideoByPB(objFrame, objImg);
	if(i != -1){
		obj = aVideosLoaded[i].obj;
		try{
			sState= obj.getState();
		}catch(err){
			return;
		}
	}else{
		return;
	}
	if((sState != "play") && (sState != "pause") && (sState != "stop")){
		return;
	}	
	setVideoControlState(aVideosLoaded[i].objDocument, aVideosLoaded[i].idControl, ((sState=="pause")||(sState=="stop"))?("play_btn_over.png"):("pause_btn_over.png"), null, undefined);
}
function outPB(objFrame, objImg){	
	var obj, sState;
	var i = findVideoByPB(objFrame, objImg);
	if(i != -1){
		obj = aVideosLoaded[i].obj;
		try{
			sState= obj.getState();
		}catch(err){
			return;
		}
	}else{
		return;
	}
	if((sState != "play") && (sState != "pause") && (sState != "stop")){
		return;
	}
	setVideoControlState(aVideosLoaded[i].objDocument, aVideosLoaded[i].idControl, ((sState=="pause")||(sState=="stop"))?("play_btn_out.png"):("pause_btn_out.png"), null, undefined);
}
function upPB(objFrame, objImg){	
	var obj, sState;
	var i = findVideoByPB(objFrame, objImg);
	if(i != -1){
		obj = aVideosLoaded[i].obj;
		try{
			sState= obj.getState();
		}catch(err){
			return;
		}
	}else{
		return;
	}

	if((sState != "play") && (sState != "pause") && (sState != "stop")){
		return;
	}

	switch(sState){
	case "play":
		obj.setPause(true);
		break;
	case "stop":
		//obj.setPosition(0);
		obj.setPause(false);
		break;
	case "pause":
		obj.setPause(false);
		break;
	default:;
	}
	sState = obj.getState();
	var r= ((aVideosLoaded[i].metaData != null) && (aVideosLoaded[i].metaData.duration>0))?(aVideosLoaded[i].obj.getPosition()/aVideosLoaded[i].metaData.duration):(0);
	setVideoControlState(aVideosLoaded[i].objDocument, aVideosLoaded[i].idControl, (sState=="play") ? ("pause_btn_over.png") : ("play_btn_over.png"), null, r);
}
function downPB(objFrame, objImg){
	var obj, sState;
	var i = findVideoByPB(objFrame, objImg);
	if(i != -1){
		obj = aVideosLoaded[i].obj;
		try{
			sState= obj.getState();
		}catch(err){
			return;
		}
	}else{
		return;
	}
	if((sState != "play") && (sState != "pause") && (sState != "stop")){
		return;
	}
	//
}
function setVideoControlState(objDocument, controlId, playButtonState, stopButtonState, ratio){
	var objControl = objDocument.getElementById(controlId);
	if(objControl == null){
		return;
	}
	var i, a = objControl.getElementsByTagName("img"), l = a.length, attr, imgPlayPause, imgSlider, imgLine;
	for(i=0;i<l;i++){
		attr = a[i].attributes.getNamedItem("id");
		if(attr != null){
			switch(attr.value){
			case "imgVideoPlayPause":
				imgPlayPause = a[i];
				break;
			case "imgVideoStop":
				imgStop = a[i];
				break;
			case "imgVideoSlider":
				imgSlider = a[i];
				break;
			case "imgVideoLine":
				imgLine = a[i];
				break;
			default:;
			}
		}
	}
	if((imgPlayPause != null) && (playButtonState != null)){
		imgPlayPause.src = "../layout/layout_img/"+ playButtonState;
	}
	if((imgStop != null) && (stopButtonState != null)){
		imgStop.src = "../layout/layout_img/"+ stopButtonState;
	}
	if((imgLine != null) && (imgSlider != null) && !isNaN(ratio)){
		if(ratio<0){
			ratio=0;
		}else if(ratio>1){
			ratio=1;
		}
		var attr = objControl.attributes.getNamedItem("xSliderMin");
		var xMin = ((attr!=null) && !isNaN(attr.value)) ? (Number(attr.value)) : (xLeft);
		var xLeft = evalPx(imgLine.style.left);
		var lWidth = evalPx(imgLine.style.width);
		imgSlider.style.left = Math.floor(xMin+ratio*lWidth);
	}
	
}
//
function sliderMouseMove(e){
	var win = sceneIframe.contentWindow;
	var img = currentSlider;
	var flag = (e != null) && (e.clientX != undefined);
	if (currentSlider != null){
		var xV = ((flag)?(dx+e.clientX):(dx + win.event.clientX));
		//
		if(xV<currentSliderXMin){
			xV = currentSliderXMin;
		}else if(xV>currentSliderXMax){
			xV = currentSliderXMax;
		}
		img.style.left = xV+"px";
		//		
		currentSliderObj.obj.setPosition(currentSliderObj.metaData.duration*(xV-currentSliderXMin)/(currentSliderXMax-currentSliderXMin));
		//return нужно, чтобы событие происходило при нажатой кнопке мыши
		return false;
	}
}
function sliderMouseDown(e){
	var win = sceneIframe.contentWindow;
	var doc = sceneIframe.contentWindow.document;
	//
	var flag = (e != null) && (e.clientX != undefined);
	var fobj = ((flag)?(e.target):(win.event.srcElement));
	var topelement = ((flag)?("HTML"):("BODY"));
	while (fobj.tagName != topelement){
		if((fobj != null) && ((fobj.id == null) || ((fobj.id != "imgVideoSlider") && (fobj.id != "imgVideoLine")))){
			fobj = ((flag)?(fobj.parentNode):(fobj.parentElement));
		}else{
			break;
		}
  	}
	if ((fobj.id != null) && ((fobj.id == "imgVideoSlider") || (fobj.id == "imgVideoLine"))){
		var obj, sState;
		var i = findVideoByPB(sceneIframe, fobj);
		if(i != -1){
			obj = aVideosLoaded[i].obj;
			try{
				sState= obj.getState();
			}catch(err){
				return false;
			}
			obj.setPause(true);
			if(fobj.id == "imgVideoSlider"){
				currentSlider = fobj;
			}else{
				var node;
				for(node=fobj.parentNode.firstChild; (node!=null) && (node.id!="imgVideoSlider"); node=node.nextSibling){};
				if(node!=null){
					currentSlider = node;
					var objOffset = offsetPosition(node);
					currentSlider.style.left = String(evalPx(currentSlider.style.left)+ (((flag)?(e.clientX):(win.event.clientX))-objOffset[0])-currentSlider.offsetWidth/2)+"px";
				}else{
					return false;
				}
			}
			currentSliderControl = fobj.parentNode;
			//
			var attr = currentSliderControl.attributes.getNamedItem("xSliderMin");
			currentSliderXMin = ((attr != null) && !isNaN(attr.value)) ? (Number(attr.value)) : (undefined);
			//
			attr = currentSliderControl.attributes.getNamedItem("xSliderMax");
			currentSliderXMax = ((attr != null) && !isNaN(attr.value)) ? (Number(attr.value)) : (undefined);
			//
			currentSliderObj = aVideosLoaded[i];
			currentSliderObj.prevState = sState;
			currentSlider.src = "../layout/layout_img/video_slider_down.png";
			dx = parseInt(currentSlider.style.left+0) - ((flag)?(e.clientX):(win.event.clientX));
	
			if(isNaN(currentSliderXMin) || isNaN(currentSliderXMax)){
				currentSlider = null;
				currentSliderControl = null;
				currentSliderObj = null;
				return false;
			}
	
			doc.onmousemove=sliderMouseMove;
			if(fobj.id == "imgVideoLine"){
				sliderMouseMove(e);
			}
		}else{
			return false;
		}
	
		return false;
 	}
}
//
function sliderMouseUp(e){
	if(currentSliderObj != null){
		currentSlider.src = "../layout/layout_img/video_slider_out.png";
		if(currentSliderObj.prevState == "play"){
			currentSliderObj.obj.setPause(false);
		}
		currentSliderObj.prevState = null;
		//
		currentSlider = null;
		currentSliderControl = null;
		currentSliderObj = null;
	}
	pollVideoPositions();
	sceneIframe.contentWindow.document.onmousemove = null;
}
//
function initSliderControl(){
	var win = sceneIframe.contentWindow;
	var doc = sceneIframe.contentWindow.document;
	//
	doc.onmousedown=sliderMouseDown;
	doc.onmouseup=sliderMouseUp;
}