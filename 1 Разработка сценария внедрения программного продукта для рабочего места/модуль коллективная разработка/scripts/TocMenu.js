var testFinished;
var testStarted;
var startDate;
var progress = 0;
//
var sCMIMode = "";
//
var objQplayer;
var idQplayer = "homeFlash";
var theObj;
var flagLoadTestProps = false;
var testProps;
var testPropsToLoad;
var completionStatus;//для отдельного вопроса
var score;//для отдельного вопроса
//
var sceneIntervalId;
//
//запрет на загрузку очередной сцены до тех пор, пока не загрузилась текущая
var loadingAllowed = true;
var qplayerReady = false;
//
// style=\"margin:0;padding:0;overflow-x:hidden;background:transparent;\"
//
var sMenuPrefix = "<html><head><meta http-equiv=\"content-type\" content=\"text/html; charset=UTF-8\"/></head><body>";
var sMenuPostfix = "</body></html>";
//
//no – номер текущего вопроса (от 1 до aQuestion.length), aQuestion.length+1 – таблица результатов, aQuestion.length+2 – решение, -1 – стартовая страница, если предусмотрена
//
function buildTocMenu(no){
	var sMenu;
	var i, n = aQuestion.length, flagEnabled;
	//
	sMenu = "<div class=\"toc-wrapper\" id=\"tocpanel\">";
	sMenu += "<div class=\"toc-sidepane\">";
        sMenu += "<div class=\"toc-box-top-left\">";
        sMenu += "<div class=\"toc-box-top-right\"></div>";
        sMenu += "</div>";
      	sMenu += "<div class=\"toc-box-main\">";
        sMenu += "<div class=\"toc-box-content\">";
        sMenu += "<ul class=\"toc-links\">";

	for(i=0;i<n;i++){
		if((i+1) == no){
			sMenu += "<li class=\"toc-link toc-linkcurrent\"><a>"+aQuestion[i].name;
			sMenu += "</a></li>";
		}else{
			if(testFinished){
				flagEnabled = true;
			}else if(moduleType == "k"){
				flagEnabled = ((no==undefined)&&(i==0)) || (i==no);
			}else{
				flagEnabled = true;
			}
			sMenu += "<li class=\"";
			sMenu += ((aQuestion[i].sessionData.visits>0)?("toc-link toc-visited"):("toc-link"));
			if(!flagEnabled){
				//доступны только текущий и следующий
				sMenu += " toc-disabled";
			}
			sMenu += "\"";
			if(flagEnabled){
				sMenu += " onClick=\"javascript:parent.loadQuestionNo.call(parent, "+String(i+1)+");\"";
			}
			sMenu += "><a>"+aQuestion[i].name;
			sMenu += "</a></li>";
		}
	}
	//ссылка на таблицу результатов
	if(showResults){
		if((n+1) == no){
			sMenu += "<li class=\"toc-link toc-linkcurrent toc-result\"><a>"+ ((testFinished)?("Результаты"):("Завершить")) +"</a></li>";
		}else{
			sMenu += "<li class=\"toc-link toc-result\" onClick=\"javascript:parent.loadQuestionNo.call(parent, "+String(n+1)+");\"><a>"+((testFinished)?("Результаты"):("Завершить"));
			sMenu += "</a></li>";
		}
	}
	if(objSolution.show){
		flagEnabled = ((testFinished||!showResults) || (moduleType != "k"));
		if((n+2) == no){
			sMenu += "<li class=\"toc-link toc-linkcurrent toc-result\"><a>"+ objSolution.name +"</a></li>";
		}else{
			sMenu += "<li class=\"";
			sMenu += ((objSolution.visits>0)?("toc-link toc-result toc-visited"):("toc-link toc-result"));
			if(!flagEnabled){
				sMenu += " toc-disabled";
			}
			sMenu += "\"";
			if(flagEnabled){
				sMenu += " onClick=\"javascript:parent.loadQuestionNo.call(parent, "+String(n+2)+");\"";
			}
			sMenu += "><a>"+objSolution.name;
			sMenu += "</a></li>";
		}
	}
        sMenu += "</ul>";
        sMenu += "</div>";
        sMenu += "</div>";
	sMenu += "</div>";
	sMenu += "</div>";
	//
	var objDoc = $("toc").contentWindow.document;
	//заполняем меню
	objDoc.body.innerHTML = sMenuPrefix+sMenu+sMenuPostfix;
	//

	objDoc.body.style.backgroundColor = "transparent";
	objDoc.body.style.overflowX = "hidden";
	objDoc.body.style.margin = "0px";
	objDoc.body.style.padding = "0px";
	//Применяем стили к меню
	var nodeLink = objDoc.createElement("link");
	nodeLink.rel = "stylesheet"; 
	nodeLink.type = "text/css"; 
	nodeLink.href = "../layout/style.css"; 
	objDoc.getElementsByTagName("head")[0].appendChild(nodeLink);
	//
	nodeLink = objDoc.createElement("link");
	nodeLink.rel = "stylesheet"; 
	nodeLink.type = "text/css"; 
	nodeLink.href = "../layout/tocmenu.css";
	objDoc.getElementsByTagName("head")[0].appendChild(nodeLink); 

}
//
function loadQuestionNo(no){
	prevSceneNumber = currentSceneNumber;
	if(!loadingAllowed || isNaN(no)){
		return;
	}
	//обновить свойства текущего вопроса
	if(!testFinished && (currentSceneNumber>0) && (currentSceneNumber <= aQuestion.length)){
		var currentTime = (new Date()).getTime();
		var obj = aQuestion[currentSceneNumber-1].sessionData;
		if(obj.timeStart != undefined){
			obj.duration += (currentTime-obj.timeStart);
		}
	}
	//
	if(videosToLoadIntervalId){
		window.clearInterval(videosToLoadIntervalId);
		videosToLoadIntervalId = undefined;
		updateAVideoElements(-1);
		var i, a = aVideosLoaded;
		for(i=0;i<a.length;i++){
			if(a[i].sceneNumber == currentSceneNumber){
				a.splice(i--, 1);
			}
		}
	}
	if(sceneIntervalId != undefined){
		window.clearInterval(sceneIntervalId);
		sceneIntervalId = undefined;
	}
	if(no<0){
		currentSceneNumber = 0;
		return;
	}
	if(no == (aQuestion.length+2)){
		//просмотр решения
		if(!testFinished){
			finishTest();
		}
		loadingAllowed = false;
		qplayerReady = false;
		sceneIframe.contentWindow.document.body.innerHTML = "";
		currentSceneNumber = no;
		sceneIframe.contentWindow.location.replace(htmlDirectory+objSolution.href);
	}else if(no == (aQuestion.length+1)){
		//завершить или просмотр результатов
		if(!testFinished){
			finishTest();
		}
		loadingAllowed = false;
		qplayerReady = false;
		sceneIframe.contentWindow.document.body.innerHTML = "";
		currentSceneNumber = no;
		sceneIframe.contentWindow.location.replace(htmlDirectory+"results.html");
	}else{
		loadingAllowed = false;
		qplayerReady = false;
		sceneIframe.contentWindow.document.body.innerHTML = "";
		currentSceneNumber = no;
		sceneIframe.contentWindow.location.replace(htmlDirectory+aQuestion[no-1].href);
		if(!testFinished && !testStarted){
			testStarted = true;
			startDate = new Date();
		}
		//sceneIntervalId = window.setInterval("checkIfSceneLoaded();", 500);
	}
	//
	buildTocMenu(no);
}
//
function loadNextQuestion(){
	if((showResults && (currentSceneNumber <= aQuestion.length)) || (currentSceneNumber < aQuestion.length)){
		loadQuestionNo(currentSceneNumber+1);
	}
}
//
function checkIfSceneLoaded(){
	var objDoc = sceneIframe.contentWindow.document;
	if(objDoc != null){
		var objBody = objDoc.getElementsByTagName("body")[0];
		if((objBody != null) || (prevSceneNumber == currentSceneNumber)){
			window.clearInterval(sceneIntervalId);
			sceneIntervalId = undefined;
			if(prevSceneNumber != currentSceneNumber){
				notifyOnLoad();
			}
		}
	}
}
//
function notifyOnLoad() {
	if(sceneIframe == null){
		return;
	}
	//Проверим, вызвано ли onLoad тем html-файлом сцены, который выбрали в меню или он открыт по ссылке в другой сцене
	//если не из меню, нужно вызвать функцию loadQuestionNo для загруженной страницы
	var sURL = replaceSymbol(sceneIframe.contentWindow.document.URL,"\\","/");
	var i, l = aQuestion.length, sn = -1;
	for(i=0;(i<l)&&((htmlDirectory+aQuestion[i].href) != sURL);i++){
	}
	if(i<l){
		sn = i+1;
	}else if((htmlDirectory+"results.html") == sURL){
		sn = l+1;
	}else if((htmlDirectory+objSolution.href) == sURL){
		sn = l+2;
	}
	if((sn >= 0) && (sn != currentSceneNumber)){
		loadingAllowed = true;
		loadQuestionNo(sn);
		return;
	}
	//
	if(videosToLoadIntervalId == undefined){
		videosToLoadIntervalId = window.setInterval("pollAVideosToLoad()", videosToLoadInterval);
	}
	if(sceneIntervalId != undefined){
		window.clearInterval(sceneIntervalId);
		sceneIntervalId = undefined;
	}
	initSliderControl();
	//
	prevSceneNumber = currentSceneNumber;
	loadingAllowed = true;
	flagLoadTestProps = false;
	objQplayer = undefined;
	//
	if (sceneIframe == undefined) {
		return;
	}
	var currentTime = (new Date()).getTime();
	if(currentSceneNumber == (aQuestion.length+2)){
		//показ решения
		objSolution.visits++;
	}else if(currentSceneNumber == (aQuestion.length+1)){
		//строить таблицу результатов
		makeResultsTable(sceneIframe, aQuestion);
	}else if((currentSceneNumber>0) && (currentSceneNumber <= aQuestion.length)){
		var obj = aQuestion[currentSceneNumber-1];
		var objSessionData = obj.sessionData;
		var objProps = obj.props;
		if(!testFinished){
			objSessionData.timeStart = currentTime;
			objSessionData.visits++;
			if(objSessionData.timeFirstStart == undefined){
				objSessionData.timeFirstStart = new Date();
				objSessionData.timeFirstStart.setTime(currentTime);
			}
			if((objProps.optional != true) && (objSessionData.visits == 1)){
				//увеличим прогресс, когда загрузили обязательный кадр
				progress += objProps.progressweight;
				if (okSCORM && (noAPIFound == "false")) {
					setDataValue("cmi.progress_measure", progress.toFixed(7));
				}
			}
			if(objSessionData.status == "unknown"){
				if(objProps.type == "question"){
					objSessionData.status = "not attempted";
				}else{
					//это информационный "вопрос", отвечать не надо
					objSessionData.status = "completed";
				}
			}
		}
		var objDoc = sceneIframe.contentWindow.document;
		objQplayer = objDoc.getElementById((navigator.appName == "Microsoft Internet Explorer") ? (idQplayer) : (idQplayer + "Embed"));
		//
		if (objQplayer != null) {
			if(!qplayerReady){
				loadingAllowed = false;
			}
			clearInterval(objQplayer.intervalId);
			if(objProps.showresponse != true){
				objQplayer.intervalId = window.setInterval("setVar(objQplayer, '_root.noResponse', 'true');", 50);
			}
			sceneIframe.contentWindow[objQplayer.id + "_DoFSCommand"] = _DoFSCommand;
			//
			//когда Qplayer – ready, загрузить сохранённые свойства
			flagLoadTestProps = true;
		}
	}
	var objDoc = sceneIframe.contentWindow.document;
	var objBody = objDoc.getElementsByTagName("body")[0];
	objBody.style.overflowX = "hidden";
	//
	//////////////////////////////////////////VIDEO//////////////////
	//
	if(sceneIframe.contentWindow.onVideoState == null){
		sceneIframe.contentWindow.onVideoState = onVideoState;
	}
	if(sceneIframe.contentWindow.onMetaData == null){
		sceneIframe.contentWindow.onMetaData = onMetaData;
	}
}
//
/////////////////////////////////////////////////////////////////////
//
function fGetCMIMode(){
   if (typeof findAPI == 'function') {
        sCMIMode = new String(getDataValue("cmi.mode"));
   }
}
//
function _DoFSCommand(command, args, id) {
	var obj = aQuestion[currentSceneNumber-1];
	//
	if (objQplayer != undefined) {
		theObj = sceneIframe.contentWindow.document.getElementById((navigator.appName == "Microsoft Internet Explorer") ? (idQplayer) : (idQplayer + "Embed"));
	}
	//
	if (command == "qplayerready") {
		qplayerReady = true;
		loadingAllowed = true;
		if (flagLoadTestProps) {
			_DoFSCommand("loadTestProps", "", idQplayer);
			flagLoadTestProps = false;
		}
	} else if (command == "saveTestProps") {
		if (testProps != undefined) {
			delete testProps;
		}
		testProps = new String(args);
		var i, params = testProps.slice(1, (i = testProps.indexOf("]") + 1) - 1);
		testProps = testProps.slice(i);
		var paramsArray = new Array();
		paramsArray = params.split(",");
		completionStatus = paramsArray[0];
		score = Number(paramsArray[1]);
		delete paramsArray;
	} else if (command == "loadTestProps") {
		if (qplayerReady && (objQplayer != undefined) && (obj.sessionData.testProps != undefined)) {
			try{
				theObj.intervalCount = -1;
				if (theObj.intervalCount == -1) {
					//если настройки безопасности не запрещают доступ к объекту theObj
					clearInterval(theObj.intervalId);
					testPropsToLoad = obj.sessionData.testProps;
					theObj.intervalId = window.setInterval("setVar(theObj, '_root.testProps', testPropsToLoad);", 50);
				}
			}catch(err){
			}
		}else if(testFinished){
			if(theObj != undefined){
				try {
					theObj.intervalCount = -1;
					theObj.intervalId = setInterval("setVar(theObj, '_root.finishPlayer', 'true');", 50);
				} catch (err) {
				}
			}
		}
	} else if (command == "saveTestPropsAndCommit") {
		if(testFinished){
			return;
		}
		_DoFSCommand("saveTestProps", args, id);
		//
		//the state of the controls and global variables
		obj.sessionData.testProps = new String(testProps);
		if (obj.sessionData.status != "completed") {
			obj.sessionData.attempts++;
		}
		obj.sessionData.status = completionStatus;
		obj.sessionData.score = ((score*1.0)/100).toFixed(7);
		if(nextAuto){
			loadNextQuestion();
		}
	}
}
//
function setVar(obj, varName, varValue) {
	var flag = false, x = undefined;
	try {
		if (obj.intervalCount++ > 200) {
			clearInterval(obj.intervalId);
			flag = true;
		}
	} catch (err) {
		return;
	}
	try {
		obj.SetVariable(varName, varValue);
		x = obj.GetVariable(varName);
	} catch (err) {
	}
	if ((varValue == undefined) || (x == varValue)) {
		clearInterval(obj.intervalId);
		flag = true;
		if ((varName=="_root.testProps") && ((sCMIMode == "review") || testFinished)) {
			setVar(theObj, "_root.finishPlayer", "true");
		}
	}
}
//
function finishTest(){
	if(!loadingAllowed){
		return;
	}
	var currentTime = (new Date()).getTime();
	if((currentSceneNumber>0) && (currentSceneNumber<=aQuestion.length)){
		var obj = aQuestion[currentSceneNumber-1].sessionData;
		if(obj.timeStart != undefined){
			obj.duration += (currentTime-obj.timeStart);
		}
	}
	testFinished = true;
	//theObj – глобальная переменная для Qplayer'а
	if(theObj != undefined){
		try {
			theObj.intervalCount = -1;
			theObj.intervalId = setInterval("setVar(theObj, '_root.finishPlayer', 'true');", 50);
		} catch (err) {
		}
	}
}