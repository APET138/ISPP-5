// Функции, относящиеся к Qplayer'у
var isIE = (navigator.appName == "Microsoft Internet Explorer");
var testProps = new String("");
var score, completionStatus;
var aQplayerId = [];
var APIWrapperFlag = false;
var APIWrapperPath = "";
var APIWrapperPathInitial = "";
var APIWrapperIntervalId;
//сколько попыток найти APIWrapper надо делать в директории APIWrapperPath
var APIWrapperRetryCount = 20;
var APIWrapperRetryCountSlow = 200;
//на сколько уровней вверх подниматься
var APIWrapperUpDir = 1;
//
var _APIWrapperUpDir = APIWrapperUpDir;
var findAPI;
var _APIWrapperRetryCount = APIWrapperRetryCount;
var fastSearchFlag = true;
//
var sCMIMode = "";
//
function Qplayer(targetId, playerId, playerName, playerPath, questionXML, playerWidth, playerHeight)
{
    //
    var targetNode = document.getElementById(targetId);
    var _playerPath = (playerPath.length > 0) ? (playerPath + ((playerPath.charAt(playerPath.length - 1) != '/') ? ("/") : (""))) : ("");
    var questionPlayer = _playerPath + playerName;
    //document[playerId+'_DoFSCommand'] = _DoFSCommand;
    window[playerId + '_DoFSCommand'] = _DoFSCommand;
    //
    aQplayerId.push({playerId:playerId, targetNode:targetNode, questionPlayer:questionPlayer, questionPlayerInitial:questionPlayer, playerName:playerName, playerId:playerId, questionXML:questionXML, playerWidth:playerWidth, playerHeight:playerHeight});
    //
    if (!APIWrapperFlag) {
        APIWrapperFlag = true;
        APIWrapperPath = APIWrapperPathInitial = _playerPath;
    }
    //
    setQplayerObject(aQplayerId[aQplayerId.length-1]);
}
//
//
function setQplayerObject(obj){
    var s = "";
    if (isIE) {
        s += "<object classid=\"clsid:D27CDB6E-AE6D-11cf-96B8-444553540000\" codebase=\"http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0\"";
        s += " width=\"" + obj.playerWidth + "\" height=\"" + obj.playerHeight + "\" id=\"" + obj.playerId + "\" align=\"\">";
        //
        s += "<param name=\"movie\" value=\"" + obj.questionPlayer + "\"/>";
        s += "<param name=\"Play\" value=\"-1\"/>";
        s += "<param name=\"Loop\" value=\"-1\"/>";
        s += "<param name=\"Quality\" value=\"High\"/>";
        s += "<param name=\"SAlign\" value=\"\"/>";
        s += "<param name=\"Menu\" value=\"1\"/>";
        s += "<param name=\"Base\" value=\"\"/>";
        s += "<param name=\"Scale\" value=\"ShowAll\"/>";
        s += "<param name=\"DeviceFont\" value=\"0\"/>";
        s += "<param name=\"EmbedMovie\" value=\"0\"/>";
	s += "<param name=\"allowScriptAccess\" value=\"always\"/>";
        s += "<param name=\"FlashVars\" value=\"isInHTML=true&theTaskXMLText_JS=<VARS src=\'" + obj.questionXML + "\' testStyle=\'basic\'/>\"/>";
        //
        s += "</object>";
        s += "<script for=\"" + obj.playerId + "\" event=\"FSCommand(command,args)\">" + obj.playerId + "_DoFSCommand(command,args,\"" + obj.playerId + "\");</script>";
	obj.targetNode.innerHTML = s;
    } else {
	var sSrc = obj.questionPlayer + "?isInHTML=true&theTaskXMLText_JS=<VARS src='" + obj.questionXML + "' testStyle='basic'/>";
	//
        s += "<object classid=\"clsid:D27CDB6E-AE6D-11cf-96B8-444553540000\" codebase=\"http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0\"";
        s += " width=\"" + obj.playerWidth + "\" height=\"" + obj.playerHeight + "\" id=\"" + obj.playerId + "\" align=\"\">";
        s += "<embed ";
        s += "quality=\"high\" bgcolor=\"#ffffff\" width=\"" + obj.playerWidth + "\" height=\"" + obj.playerHeight + "\" name=\"" + obj.playerId + "\" id=\"" + obj.playerId + "Embed\" ";
        s += "align=\"middle\" allowScriptAccess=\"always\" type=\"application/x-shockwave-flash\" pluginspage=\"http://www.macromedia.com/go/getflashplayer\"/>";
        s += "</object>";
	//сначала без src
	obj.targetNode.innerHTML = s;
	//потом src через DOM (для SCORM-плеера)
	obj.targetNode.firstChild.firstChild.setAttribute("src", sSrc);	
    }
}
//
//
function setVar(obj, varName, varValue) {
    var flag = false;
    if (obj.intervalCount++ > 20000) {
        clearInterval(obj.intervalId);
        flag = true;
    }
    obj.SetVariable(varName, varValue);
    var x = obj.GetVariable(varName);
    if ((varValue == undefined) || (x == varValue)) {
        clearInterval(obj.intervalId);
        flag = true;
    }
    if(flag && (varName != "_root.finishPlayer")){
        if(sCMIMode == "review"){
            theObj.intervalCount = -1;
            clearInterval(theObj.intervalId);
            theObj.intervalId = setInterval("setVar(theObj, '_root.finishPlayer', 'true');", 50);
        }
    }
}
//
//
function _DoFSCommand(command, args, id) {
    if (command == "saveTestProps") {
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
        sProps = new String(getDataValue("cmi.suspend_data"));
        theObj = window.document.getElementById((isIE) ? (id) : (id + "Embed"));
        if (theObj) {
            theObj.intervalCount = -1;
            if (theObj.intervalCount == -1) {
                //если настройки безопасности не запрещают доступ к объекту
                clearInterval(theObj.intervalId);
                theObj.intervalId = setInterval("setVar(theObj, '_root.testProps',sProps);", 50);
            }
        }
    } else if (command == "saveTestPropsAndCommit") {
        _DoFSCommand("saveTestProps", args, id);
        //the state of the controls and global variables
        setDataValue("cmi.suspend_data", testProps);
        setDataValue("cmi.score.scaled", ((score*1.0)/100).toFixed(7));
        setDataValue("cmi.completion_status", completionStatus);
        commitData();
    }
}
//
//
function fCheckAPIWrapper() {
    if (typeof findAPI == 'function') {
        clearInterval(APIWrapperIntervalId);
        initialize();
        var i, l = aQplayerId.length;
        for (i = 0; i < l; i++) {
            _DoFSCommand('loadTestProps', '', aQplayerId[i].playerId);
        }
    } else if (_APIWrapperRetryCount-- <= 0) {
        clearInterval(APIWrapperIntervalId);
	var i, l = aQplayerId.length;
        if (_APIWrapperUpDir-- > 0) {
            APIWrapperPath = "../" + APIWrapperPath;
            for (i = 0; i < l; i++) {
                aQplayerId[i].questionPlayer = "../" + aQplayerId[i].questionPlayer;
                setQplayerObject(aQplayerId[i]);
            }
            initAPIWrapper();
        }else{
		if(fastSearchFlag){
			//по-быстрому не нашли, считаем, что соединение медленное и ищем снова
			fastSearchFlag = false;
			APIWrapperPath = APIWrapperPathInitial;
			_APIWrapperUpDir = APIWrapperUpDir;
			APIWrapperRetryCount = APIWrapperRetryCountSlow;
			for (i = 0; i < l; i++) {
                		aQplayerId[i].questionPlayer = aQplayerId[i].questionPlayerInitial;
                		setQplayerObject(aQplayerId[i]);
            		}
			initAPIWrapper();
		}
	}
    }
}
//
//
function fGetCMIMode(){
   if (typeof findAPI == 'function') {
        sCMIMode = new String(getDataValue("cmi.mode"));
   }
}
//
//
function initAPIWrapper() {
    APIWrapperFlag = true;
    var wrpEl = document.createElement("script");
    wrpEl.setAttribute("src", APIWrapperPath + "APIWrapper.js");
    document.body.appendChild(wrpEl);
    APIWrapperIntervalId = setInterval("fCheckAPIWrapper()", 50);
    _APIWrapperRetryCount = APIWrapperRetryCount;
    fCheckAPIWrapper();
}
//
//
function fOnLoad() {
    initAPIWrapper();
    fGetCMIMode();
}
//
function fOnUnLoad() {
    terminate();
}
//
if(parent["_DoFSCommand"] && (parent["_DoFSCommand"] != _DoFSCommand)){
	_DoFSCommand = parent["_DoFSCommand"];
}
if(parent["setVar"]){
	var setVar = parent["setVar"];
}
if(parent["setDataValue"]){
	var initAPIWrapper = function(){return;};
	var setDataValue = function(arg1,arg2){};
}
if(parent["commitData"]){
	var commitData = function(){};
}
if(parent["terminate"]){
	var terminate = function(){};
}
//
//
window.onload = fOnLoad;
window.onunload = fOnUnLoad;
