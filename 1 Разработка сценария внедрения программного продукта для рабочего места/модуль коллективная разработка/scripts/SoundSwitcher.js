var soundSwitcherId = "soundSwitcher";
var soundSwitcherObj;
//какие звуки надо будет загрузить
var aSoundSwitcherSounds = [];
var aSoundSwitcherButtons = [];
//
var windowVolumeControl;
var documentVolumeControl;
var imgVolumeControl;
var imgVolumeSrc;
var xMinVolumeControl;
var xMaxVolumeControl;
var volumeDrag;
var dx;
var currX;
var currY;
//
function initSoundSwitcher(sId){
	if(sId != undefined){
		soundSwitcherId = String(sId);
	}
	var objDiv = $("divSound");
	//
	var s = "<body><object classid=\"clsid:D27CDB6E-AE6D-11cf-96B8-444553540000\" id=\""+soundSwitcherId+"\" width=\"1\" height=\"1\"";
	s += " codebase=\"http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab\">";
	s += " <param name=\"movie\" value=\"../modelers/SoundControl.swf\" />";
	s += " <param name=\"quality\" value=\"high\" />";
	s += " <param name=\"bgcolor\" value=\"#FFFFFF\" />";
	s += " <param name=\"allowScriptAccess\" value=\"always\" />";
	s += " <embed src=\"../modelers/SoundControl.swf\" quality=\"high\" bgcolor=\"#FFFFFF\"";
	s += " width=\"1\" height=\"1\" name=\""+soundSwitcherId+"\" id=\""+soundSwitcherId+"Embed\" align=\"middle\"";
	s += " play=\"true\" loop=\"false\" quality=\"high\" allowScriptAccess=\"always\"";
	s += " type=\"application/x-shockwave-flash\" pluginspage=\"http://www.macromedia.com/go/getflashplayer\"></embed></object></body>";

	objDiv.innerHTML = s;
}
//
function onSoundSwitcherState(){
	var sMsg = onSoundSwitcherState.arguments[0];
	switch(String(sMsg).toUpperCase()){
	case "READY":
		soundSwitcherObj = document.getElementById((navigator.appName == "Microsoft Internet Explorer") ? (soundSwitcherId) : (soundSwitcherId + "Embed"));
		initVolumeControl();
		//загружаем звуки, которые ждут загрузки
		var i, obj, l = aSoundSwitcherSounds.length;
		for(i=0; i<l; i++){
			obj = aSoundSwitcherSounds[i];
			addSound(obj.src, obj.id, obj.priority);
		}
		break;
	case "LOADED":
		var sId = onSoundSwitcherState.arguments[1], i;
		for(i=0; (i<aSoundSwitcherSounds.length) && (aSoundSwitcherSounds[i].id != sId); i++){
		}
		if(i<aSoundSwitcherSounds.length){
			var obj = aSoundSwitcherSounds[i];
			if(obj.imgId != null){
				var img = obj.objFrame.getElementById(obj.imgId);
				if(img != null){
					img.style.visibility = "visible";
				}
			}
		}
		break;
	case "SOUNDCOMPLETE":
		var sId = onSoundSwitcherState.arguments[1];
		var i;
		for(i=0; i<aSoundSwitcherButtons.length; i++){
			if(aSoundSwitcherButtons[i].soundId == sId){
				var obj = aSoundSwitcherButtons[i];
				setImgSrc(obj.objFrame, obj.imgId, obj.imgName+"_off_out");
				aSoundSwitcherButtons.splice(i--, 1);
			}
		}
		break;
	default:
	}

}
//////////////////////////////////////////////////////////////кнопка "звук описания модуля" SB=SoundButton/////////////////// 
function overSB(objFrame, imgId, soundId, sName){
	if(getState(soundId) == null){
		return;
	}
	//sName – без _over, _down
	setImgSrc(objFrame, imgId, (getState(soundId)=="play")?(sName+"_on_over"):(sName+"_off_over"));
}
function outSB(objFrame, imgId, soundId, sName){
	if(getState(soundId) == null){
		return;
	}
	//sName – без _over, _down
	setImgSrc(objFrame, imgId, (getState(soundId)=="play")?(sName+"_on_out"):(sName+"_off_out"));
}
function upSB(objFrame, imgId, soundId, sName){
	if(getState(soundId) == null){
		return;
	}
	var i;
	if(getState(soundId)=="play"){
		stopSound(soundId);
		for(i=0; i<aSoundSwitcherButtons.length; i++){
			if(aSoundSwitcherButtons[i].imgId == imgId){
				aSoundSwitcherButtons.splice(i--, 1);
			}
		}
	}else{
		playSound(soundId);
		//imgName – имя картинки без _down и без расширения
		aSoundSwitcherButtons.push({imgId:imgId, soundId:soundId, imgName:sName, objFrame:objFrame});
	}
	setImgSrc(objFrame, imgId, (getState(soundId)=="play") ? (sName+"_on_over") : (sName+"_off_over"));
}
function downSB(objFrame, imgId, soundId, sName){
	if(getState(soundId) == null){
		return;
	}
	setImgSrc(objFrame, imgId, sName+"_on_over");
}
///////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
function addSound(src, sId, sPriority){
	try{
		soundSwitcherObj.addSound(src, sId, sPriority);
	}catch(err){
	}
}
//
function removeSound(sId){
	try{
		soundSwitcherObj.removeSound(sId);
	}catch(err){
	}
}
//
function playSound(sId, vOffset){
	try{
		soundSwitcherObj.playSound(sId, vOffset);
	}catch(err){
	}
}
//
function stopSound(sId){
	try{
		soundSwitcherObj.stopSound(sId);
	}catch(err){
	}
}
//
function stopSoundArray(a){
	var i;
	for(i=0; i<a.length; i++){
		try{
			soundSwitcherObj.stopSound(a[i]);
		}catch(err){
		}
	}
}
//
function pauseSound(sId){
	try{
		soundSwitcherObj.pauseSound(sId);
	}catch(err){
	}
}
//
function muteSound(sId, flag){
	var i = findVideoById(sId);
	if(i != -1){
		try{
			aVideosLoaded[i].obj.mute(flag);
		}catch(err){
		}
	}
	i = findVideoToLoadById(sId);
	if(i != -1){
		aVideosToLoad[i].mute = flag;
	}
	try{
		soundSwitcherObj.muteSound(sId, flag);
	}catch(err){
	}
}
//
function muteAll(flag){
	var i, a = aVideosLoaded, l = a.length;
	for(i=0;i<l;i++){
		try{
			a[i].obj.setMute(flag);
		}catch(err){
		}
	}
	a = aVideosToLoad;
	l = a.length;
	for(i=0;i<l;i++){
		a[i].mute = flag;
	}
	try{
		soundSwitcherObj.muteAll(flag);
	}catch(err){
	}
}
//
function setVolume(sId, v){
	var i = findVideoById(sId);
	if(i != -1){
		try{
			aVideosLoaded[i].obj.setVolume(v);
		}catch(err){
		}
	}
	i = findVideoToLoadById(sId);
	if(i != -1){
		aVideosToLoad[i].volume = v;
	}
	try{
		soundSwitcherObj.setVolume(sId, v);
	}catch(err){
	}
}
function getVolume(sId){
	var i = findVideoById(sId);
	if(i != -1){
		try{
			return aVideosLoaded[i].obj.getVolume();
		}catch(err){
			return 0;
		}
	}
	//
	i = findVideoToLoadById(sId);
	if(i != -1){
		return aVideosToLoad[i].volume;
	}
	//
	try{
		return soundSwitcherObj.getVolume(sId);
	}catch(err){
		return 0;
	}
}
//
function setVolumeMultiplier(v){
	var i, a = aVideosLoaded, l = a.length;
	for(i=0;i<l;i++){
		try{
			a[i].obj.setVolumeMultiplier(v);
		}catch(err){
		}
	}
	a = aVideosToLoad;
	l = a.length;
	for(i=0;i<l;i++){
		a[i].volumeMultiplier = v;
	}
	try{
		soundSwitcherObj.setVolumeMultiplier(v);
	}catch(err){
	}
}
function getVolumeMultiplier(){
	try{
		return soundSwitcherObj.getVolumeMultiplier();
	}catch(err){
		return 1;
	}
}
//
function setVolumeAll(v){
	var i, a = aVideosLoaded, l = a.length;
	for(i=0;i<l;i++){
		try{
			a[i].obj.setVolumeMultiplier(1);
			a[i].obj.setVolume(v);
		}catch(err){
		}
	}
	a = aVideosToLoad;
	l = a.length;
	for(i=0;i<l;i++){
		a[i].volumeMultiplier = 1;
		a[i].volume = v;
	}
	try{
		soundSwitcherObj.setVolumeAll(v);
	}catch(err){
	}
}
//
function setPause(sId, flag){
	var i = findVideoById(sId);
	if(i != -1){
		try{
			aVideosLoaded[i].obj.setPause(flag);
		}catch(err){
		}
	}
	//
	i = findVideoToLoadById(sId);
	if(i != -1){
		aVideosToLoad[i].pause = flag;
	}
}
function getPause(sId){
	var i = findVideoById(sId);
	if(i != -1){
		try{
			return aVideosLoaded[i].obj.getPause();
		}catch(err){
			return false;
		}
	}
	//
	i = findVideoToLoadById(sId);
	if(i != -1){
		return aVideosToLoad[i].pause;
	}
	return false;
}
//
function getState(sId){
	var i = findVideoById(sId);
	if(i != -1){
		try{
			return aVideosLoaded[i].obj.getState();
		}catch(err){
		}
	}
	try{
		return soundSwitcherObj.getState(sId);
	}catch(err){
		return undefined;
	}
}
//
function setPosition(sId, v){
	var i = findVideoById(sId);
	if(i != -1){
		if(aVideosLoaded[i].metaData == null){
			aVideosLoaded[i].position = v;
		}else{
			try{
				aVideosLoaded[i].obj.setPosition(v);
			}catch(err){
			}
		}
	}
	//
	i = findVideoToLoadById(sId);
	if(i != -1){
		aVideosToLoad[i].position = v;
	}
	try{
		soundSwitcherObj.setPosition(sId, v);
	}catch(err){
	}
}
function getPosition(sId){
	var i = findVideoById(sId);
	if(i != -1){
		try{
			return aVideosLoaded[i].obj.getPosition();
		}catch(err){
			return 0;
		}
	}
	i = findVideoToLoadById(sId);
	if(i != -1){
		return aVideosToLoad[i].position;
	}
	try{
		return soundSwitcherObj.getPosition(sId);
	}catch(err){
		return 0;
	}
}
////////////////////////////////////////////////////////////////////////Регулятор громкости//////////////////////////////
function docMouseMove(e){
	var win = windowVolumeControl;
	var img = imgVolumeControl;
	var flag = (e != null) && (e.clientX != undefined);
	if (volumeDrag){
		var xV = ((flag)?(dx+e.clientX):(dx + win.event.clientX));
		if(xV<xMinVolumeControl){
			xV = xMinVolumeControl;
		}else if(xV>xMaxVolumeControl){
			xV = xMaxVolumeControl;
		}
		img.style.left = xV;
		setVolumeMultiplier((xV-xMinVolumeControl)/(xMaxVolumeControl-xMinVolumeControl));
		//return нужно, чтобы событие происходило при нажатой кнопке мыши
		return false;
	}
}
//
function docMouseDown(e){
	var win = windowVolumeControl;
	var doc = documentVolumeControl;
	var img = imgVolumeControl;
	var flag = (e != null) && (e.clientX != undefined);
	var fobj = ((flag)?(e.target):(win.event.srcElement));
	var topelement = ((flag)?("HTML"):("BODY"));
	while ((fobj.tagName != topelement) && (fobj != img)){
		fobj = ((flag)?(fobj.parentNode):(fobj.parentElement));
  	}
	if (fobj == img){
    		volumeDrag = true;
		dx = parseInt(img.style.left+0) - ((flag)?(e.clientX):(win.event.clientX));
		doc.onmousemove=docMouseMove;
		setImgSrc(doc, img.id, imgVolumeSrc+"_down");
		return false;
 	}
}
//
function docMouseUp(e){
	volumeDrag = false;
	setImgSrc(documentVolumeControl, imgVolumeControl.id, imgVolumeSrc+"_out");
	documentVolumeControl.onmousemove = null;
}
//
function initVolumeControl(){
	if(imgVolumeControl.src==null){
		return;
	}
	var win = windowVolumeControl;
	var doc = documentVolumeControl;
	var img = imgVolumeControl;
	volumeDrag = false;
	xMinVolumeControl = 16;
	xMaxVolumeControl = evalPx(img.style.left);
	setVolumeMultiplier(1);
	doc.onmousedown=docMouseDown;
	doc.onmouseup=docMouseUp;
}