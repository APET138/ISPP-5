var htmlDirectory;
//ссылка на загружаемый снаружи файл toc.xml
var externalDoc;
var sceneIframe;
var aQuestion;
var aNum; //массив номеров, если будет перемешивание вопросов
var loadingAllowed;
var sTitle;
var sTitleHTML;
var objSounds;
var objBackground;
//
var aQuestionAttribs = ["type", "showresponse", "scoreweight", "progressweight", "estimated", "optional", "showinregister", "estimatecorrect", "caption"];
//


var sTitlePrefix = "<html><head><meta http-equiv=\"content-type\" content=\"text/html; charset=UTF-8\"/><link rel=\"stylesheet\" href=\"../layout/style.css\" type=\"text/css\"/></head>";
sTitlePrefix += "<body><div id=\"divTitle\"><h1 class=\"title\">";
var sTitlePostfix = "</h1></div></body></html>";

//

var sVolumePrefix = "<div id=\"divVolume\" style=\"position:relative;overflow:hidden;width:150px;height:40px;\">";
var sVolumePrefix2 = "<img id=\"volume_top\" title=\"Громкость\" src=\"../layout/layout_img/vol_slider_out.png\" style=\"position:absolute; left:80px; top:7px; z-index:2;\"/>";
sVolumePrefix2 += "<img id=\"volume_top_line\" src=\"../layout/layout_img/vol_line.png\" style=\"position:absolute; left:24px; top:14px; z-index:1;\"/>";
sVolumePrefix2 += "<img id=\"volume_top_bg\" src=\"../layout/layout_img/vol_bg.png\" style=\"position:absolute; left:16px; top:2px; z-index:0;\"/>";
sVolumePrefix2 += "<img id=\"sound_top\" title=\"Звуковое описание модуля\" style=\"position:absolute;visibility:hidden;top:5px;left:98px;\" src='../layout/layout_img/vol_btn_off_out.png' onMouseOver='javascript:overSB(document, \"sound_top\", \"moduleInfo\", \"vol_btn\");' onMouseOut='javascript:outSB(document, \"sound_top\", \"moduleInfo\", \"vol_btn\");' onMouseUp='javascript:upSB(document, \"sound_top\", \"moduleInfo\", \"vol_btn\");' onMouseDown='javascript:downSB(document, \"sound_top\", \"moduleInfo\", \"vol_btn\");'/>";
var sVolumePostfix = "</div>";

//
var moduleType;
//результаты
var showResults = true;
//решение: flag==false, если показ явно запрещён в теге <module>
var objSolution = {show:false, flag:true, href:"solution.html", name:"Решение", visits:0};
//автоматический переход к следующему вопросу
var nextAuto = false;
//
var questionsCount;
//currentSceneNumber == 0 для стартовой страницы, если есть, == questionsCount+1
///////////////////////////////////////////
var currentSceneNumber = 1;
///////////////////////////////////////////
var prevSceneNumber; //для браузеров, в которых не происходит onLoad, prevSceneNumber устанавливается = currentSceneNumber в notifyOnLoad
//
//
//preloading of images
var imagesArray = new Array("vol_btn_off_out.png", "vol_btn_on_out.png", "vol_btn_on_over.png", "vol_btn_off_over.png","vol_slider_over.png", "vol_slider_out.png") ; 
var preloadArray = new Array(); 
for (var i = 0; i < imagesArray.length - 1; i++) { preloadArray[i] = new Image; preloadArray[i].src = "../layout/layout_img/"+imagesArray[i]; }
//
//
function parseQuestionsFile(){
	var firstNode;
	var showResponse;
	//
	sceneIframe=$("scene");
	//
	var s = replaceSymbol(document.URL,"\\","/");
	var i = s.lastIndexOf("/");
	questionsDirectory = s.slice(0, i+1)+"content/";
	//
	if((externalDoc.responseXML == null) || (externalDoc.responseXML.documentElement == null)){
		firstNode = parseXML(externalDoc.responseText).documentElement;
	}else{
		firstNode = externalDoc.responseXML.documentElement;
	}

	firstNode = (firstNode.nodeName.toUpperCase() == "HTML")? (firstNode.firstChild.nextSibling.firstChild) : (skipWhite(firstNode));
	//
	if(firstNode == null){
		return -1;
	}
	var titleNode, s;
	var currNode;
	moduleType = "i";
	sTitle = "";
	aQuestion = [];
	aNum = [];
	objSounds = {};
	objBackground = {};
	aSoundSwitcherSounds.splice(0);
	var sceneCounter = 0;
	//
	for(currNode = firstNode.firstChild; currNode != null; currNode = skipWhite(currNode.nextSibling)){
		if(currNode.nodeType == 1){
			switch(currNode.nodeName.toUpperCase()){
			case "TITLE":
				titleNode = currNode;
				s = xmlToString(titleNode, true);
				sTitle = s.slice(s.indexOf(">")+1, s.lastIndexOf("<"));
				break;
			case "A":
				var obj = {}, attribs = currNode.attributes;
				var attr = attribs.getNamedItem("href");
				var sAttr;
				if(attr != null){
					obj.href = replaceSymbol(attr.value,"\\","/");	
				}
				s = xmlToString(currNode, true);
				obj.name = s.slice(s.indexOf(">")+1, s.lastIndexOf("<"));
				//здесь хранятся набранные за сессию данные (оценки, времена, статусы)
				obj.sessionData = {duration:0, score:0, status:"unknown", visits:0, attempts:0, totalDuration:0};
				//свойства: тип (question, info, practice), обязательность (optional), отображать ли в таблице
				obj.props = {scoreweight:1, progressweight:1, type:"question", caption:"Сцена "+String(++sceneCounter), estimated:true, optional:false, showinregister:true, estimatecorrect:false, showresponse:showResponse};
				var n = aQuestionAttribs.length;
				for(i=0;i<n;i++){
					sAttr = aQuestionAttribs[i];
					attr = attribs.getNamedItem(sAttr);
					if(attr != null){
						switch(sAttr){
						case "scoreweight":
						case "progressweight":
							obj.props[sAttr] = Number(attr.value);
							break;
						case "type":
						case "caption":
							obj.props[sAttr] = String(attr.value);
							break;
						case "estimated":
						case "optional":
						case "showinregister":
						case "estimatecorrect":
						case "showresponse":
							obj.props[sAttr] = (String(attr.value).toLowerCase() == "true");
							break;
						default:;
						}
					}
				}
				//
				if(!obj.props.estimated){
					obj.props.scoreweight = 0;
				}
				if(obj.props.type != "question"){
					obj.props.scoreweight = 0;
					obj.props.estimated = false;
				}
				if(obj.props.optional){
					obj.props.scoreweight = 0;
					obj.props.progressweight = 0;
				}
				if(obj.props.type != "solution"){
					aQuestion.push(obj);
				}else{
					objSolution.show = objSolution.flag;
					objSolution.name = obj.name;
					objSolution.href = obj.href;
				}
				break;
			case "MODULE":
				var attribs = currNode.attributes;
				var attr = attribs.getNamedItem("type");
				if(attr != null){
					moduleType = String(attr.value).toLowerCase();
				}
				attr = attribs.getNamedItem("showresponse");
				if(attr != null){
					showResponse = (String(attr.value).toLowerCase() == "true");
				}else{
					switch(moduleType){
					case "k": showResponse = false; break;
					case "i":
					case "k": showResponse = true; break;
					default: showResponse = true;
					}
				}
				attr = attribs.getNamedItem("showresults");
				if(attr != null){
					showResults = (String(attr.value).toLowerCase() == "true");
				}else{
					switch(moduleType){
					case "k": showResults = true; break;
					case "i":
					case "k": showResults = false; break;
					default: showResults = false;
					}
				}
				attr = attribs.getNamedItem("showsolution");
				if(attr != null){
					objSolution.show = objSolution.flag = (String(attr.value).toLowerCase() == "true");
				}else{
					objSolution.show = false;
				}
				attr = attribs.getNamedItem("nextauto");
				if(attr != null){
					nextAuto = (String(attr.value).toLowerCase() == "true");
				}
				break;
			case "SOUND":
				var soundNode;
				for(soundNode = currNode.firstChild; soundNode != null; soundNode = skipWhite(soundNode.nextSibling)){
					if(soundNode.nodeType == 1){
						switch(soundNode.nodeName.toUpperCase()){
						case "MODULEINFO":
							s = xmlToString(soundNode, true);
							objSounds.moduleInfo = replaceSymbol(s.slice(s.indexOf(">")+1, s.lastIndexOf("<")),"\\","/");
							aSoundSwitcherSounds.push({id:"moduleInfo", src:"../media/audio/"+objSounds.moduleInfo, priority:"resuming", objFrame:document, imgId:"sound_top"});
							break;
						default:
						}
					}
				}
				break;
			case "LOGO":
				s = xmlToString(currNode, true);
				objBackground.logo = {src:"../layout/layout_img/"+replaceSymbol(s.slice(s.indexOf(">")+1, s.lastIndexOf("<")),"\\","/")};
				break;
			default:
			}
		}
	}
	//нормировка scoreWeight и progressWeight
	var sWNorma = 0, pWNorma = 0, objProps;
	for(i=0;i<aQuestion.length;i++){
		objProps = aQuestion[i].props;
		sWNorma += objProps.scoreweight;
		pWNorma += objProps.progressweight;
	}
	if(Math.abs(sWNorma)<1E-5){
		sWNorma = 1E-5;
	}
	if(Math.abs(pWNorma)<1E-5){
		pWNorma = 1E-5;
	}
	for(i=0;i<aQuestion.length;i++){
		objProps = aQuestion[i].props;
		objProps.scoreweight /= sWNorma;
		objProps.progressweight /= pWNorma;
	}
	scoreNorma = sWNorma;
	progressNorma = pWNorma;
	//
	questionsCount = aQuestion.length;
	//
	///////////////////////////////////////////// SCORM /////////////////////////////////////////////
	totalTime = 0;
	//
	if((noAPIFound == "false") && okSCORM){
		//если воспроизводим тест в SCORM-плеере
		fGetCMIMode();
		var errCode;
		//
		entrySCORM = getDataValue("cmi.entry");
		errCode = String(getLastErrorCode());
		if(errCode != "0"){
			entrySCORM = "";
		}
		//
		try{
			var scpsc = getDataValue("cmi.scaled_passing_score");
			errCode = String(getLastErrorCode());
			if(!isNaN(scpsc) && (errCode == "0")){
				scaledPassingScore = Number(scpsc);
			}
		}catch(err){
		}
		//
		learnerName = getDataValue("cmi.learner_name");
		errCode = String(getLastErrorCode());
		//
		var tt = getDataValue("cmi.total_time");
		errCode = String(getLastErrorCode());
		totalTime = ((tt != "") && (errCode == "0"))?(hmsToMsec(tt)):(0);
		//
		var ct = getDataValue("cmi.completion_threshold");
		errCode = String(getLastErrorCode());
		if(!isNaN(ct) && (errCode == "0")){
			completionThreshold = Number(ct);
		}
		//
		if(entrySCORM=="resume"){
			var pr = getDataValue("cmi.progress_measure");
			errCode = String(getLastErrorCode());
				if((errCode == "0") && !isNaN(pr)){
				progress = Number(pr);
			}else{
				setDataValue("cmi.progress_measure", 0);
			}
			suspendData = getDataValue("cmi.suspend_data");
			errCode = String(getLastErrorCode());
			//
			if(errCode == "0"){
				i = suspendData.indexOf("<endsuspenddata/>");
				j = suspendData.indexOf("<propsofmodule");
			}
		}else{
			progress = 0;
			setDataValue("cmi.progress_measure", 0);
			errCode = "403";
		}
		//suspendData были сохранены полностью
		if((errCode == "0") && (i == suspendData.length-String("<endsuspenddata/>").length) && (j != -1)){
			var jj = suspendData.indexOf(">", j)+1;
			var sPropsOfModule = suspendData.slice(j, jj);
			var propsXML = parseXML(sPropsOfModule);
			var objAttr = propsXML.documentElement.attributes, obj;
			//разбор общих для модуля свойств, возникших при его прохождении
			obj = objAttr.getNamedItem("fin");
			if(obj!=undefined){
				testFinished = (String(obj.value)=="true");
			}
			obj = objAttr.getNamedItem("csn");
			if((obj!=undefined) && !isNaN(obj.value)){
				currentSceneNumber = Number(obj.value);
			}
			obj = objAttr.getNamedItem("sdt");
			if((obj!=undefined) && !isNaN(obj.value)){
				if(startDate == null){
					startDate = new Date();
				}
				startDate.setTime(Number(obj.value));
			}
			var aTmp = suspendData.slice(jj,i).split("<_step/>"), i, l = aTmp.length, j, k;
			aSuspendData = [];
			for(i=0; i<l; i++){
				j = aTmp[i].indexOf("<propsofsolution");
				if(j!=-1){
					//свойства решения, возникшие при его просмотре (число просмотров)
					k = aTmp[i].indexOf("/>", j);
					var sPropsOfScene = aTmp[i].slice(j, k+2);
					propsXML = parseXML(sPropsOfScene);
					var objAttr = propsXML.firstChild.attributes;
					obj = objAttr.getNamedItem("vsc");
					if((obj!=undefined) && !isNaN(obj.value)){
						objSolution.visits = Number(obj.value);
					}
				}else{
					j = aTmp[i].indexOf("<propsof");
					if(j!=-1){
						k = aTmp[i].indexOf("/>", j);
						jj = Number(aTmp[i].slice(j+8, aTmp[i].indexOf(" ", j)));
						var sPropsOfScene = aTmp[i].slice(j, k+2);
						propsXML = parseXML(sPropsOfScene);
						//разбор атрибутов, описывающих свойства отдельных сцен, возникшие в процессе прохождения модуля
						//
						var objProps = {n:jj, s:aTmp[i].slice(k+2)};
						var objAttr = propsXML.firstChild.attributes;
						obj = objAttr.getNamedItem("num");
						if((obj!=undefined) && !isNaN(obj.value)){
							objProps.num = Number(obj.value);
						}else{
							objProps.num = i;
						}
						obj = objAttr.getNamedItem("tfs");
						if((obj!=undefined) && !isNaN(obj.value)){
							objProps.timeFirstStart = Number(obj.value);
						}
						obj = objAttr.getNamedItem("stt");
						if(obj!=undefined){
							objProps.status = String(obj.value);
						}
						obj = objAttr.getNamedItem("drn");
						if((obj!=undefined) && !isNaN(obj.value)){
							objProps.totalDuration = Number(obj.value);
						}
						obj = objAttr.getNamedItem("scr");
						if((obj!=undefined) && !isNaN(obj.value)){
							objProps.score = Number(obj.value);
						}
						obj = objAttr.getNamedItem("atc");
						if((obj!=undefined) && !isNaN(obj.value)){
							objProps.attempts = Number(obj.value);
						}
						obj = objAttr.getNamedItem("vsc");
						if((obj!=undefined) && !isNaN(obj.value)){
							objProps.visits = Number(obj.value);
						}
						aSuspendData.push(objProps);
					}
				}
			}
			aSuspendData.sort(function(a,b){return (a.n<b.n)?(-1):(1)});
			aTmp.splice(0);
			suspendData = "";
			//заполнить aNum
			for(i=0;i<aSuspendData.length;i++){
				aNum.push(aSuspendData[i].num);
			}
			//разложим suspendData по aQuestion
			for(i=0;i<aSuspendData.length;i++){
				var obj = aSuspendData[i];
				var objQuestion = aQuestion[obj.num];
				var objSessionData = objQuestion.sessionData;
				if(obj.timeFirstStart != undefined){
					objSessionData.timeFirstStart = new Date();
					objSessionData.timeFirstStart.setTime(obj.timeFirstStart);
				}
				if(obj.totalDuration != undefined){
					objSessionData.totalDuration = obj.totalDuration;
				}
				if(obj.score != undefined){
					objSessionData.score = obj.score;
				}
				if(obj.status != undefined){
					objSessionData.status = String(obj.status);
				}
				if(obj.visits != undefined){
					objSessionData.visits = obj.visits;
				}
				if(obj.attempts != undefined){
					objSessionData.attempts = obj.attempts;
				}
				if((obj.s != null) && (obj.s.length>0)){
					objSessionData.testProps = new String(obj.s);
				}
			}
			aSuspendData.slice(0);
		}else{
			suspendData = "";
			setDataValue("cmi.completion_status", "unknown");
		}
	}
	//
	return 0;
}
//
//
function initModule(){
	var s = replaceSymbol(document.URL,"\\","/");
	var i = s.lastIndexOf("/");
	htmlDirectory = s.slice(0, i+1);
	//
	okSCORM = initialize();
	//
	var parseResult = parseQuestionsFile();
	//
	if(parseResult != 0){
		return;
	}
	//
	$("title").innerHTML = sTitle;
	//
	$("volume").innerHTML = sVolumePrefix+ ((objSounds.moduleInfo==null)?(""):(sVolumePrefix2)) +sVolumePostfix;
	//
	windowVolumeControl = window;
	documentVolumeControl = document;
	imgVolumeControl = documentVolumeControl.getElementById("volume_top");
	imgVolumeSrc = "vol_slider";
	initSoundSwitcher("soundSwitcher");
	//
	startTime = (new Date()).getTime();
	if(startDate == null){
		startDate = new Date();
	}
	//
	loadingAllowed = true;
	if((currentSceneNumber>=1) && (currentSceneNumber<=aQuestion.length)){
		loadingAllowed = false;
		buildTocMenu(currentSceneNumber);
		sceneIframe.contentWindow.location.replace(htmlDirectory+aQuestion[currentSceneNumber-1].href);
	}else if(currentSceneNumber == aQuestion.length+1){
		buildTocMenu(aQuestion.length+1);
		loadQuestionNo(aQuestion.length+1);
	}else if(currentSceneNumber == aQuestion.length+2){
		loadingAllowed = false;
		buildTocMenu(currentSceneNumber);
		sceneIframe.contentWindow.location.replace(htmlDirectory+objSolution.href);
	}else{
		buildTocMenu(undefined);
		sceneIframe.contentWindow.document.body.style.backgroundColor = "transparent";
	}
	//
	if((objBackground.logo != null) && (objBackground.logo.src != null)){
		var obj = $("logo");
		obj.style.backgroundImage = "url("+objBackground.logo.src+")";
		obj.style.backgroundRepeat = "no-repeat";
	}
}
//