//Таблица результатов
function getTotalCounts(aQuestion){
	var i, l = aQuestion.length;
	var totaltimerun = 0, sessiontimerun = 0, countattempted = 0, countcompleted = 0;
	var obj;
	for(i=0;i<l;i++){
		obj = aQuestion[i].sessionData;
		objProps = aQuestion[i].props;
		if((obj.status != "unknown") && (obj.status != "not attempted") && (objProps.progressweight>0) && (objProps.scoreweight>0)){
			countattempted++;
			if(obj.status == "completed"){
				countcompleted++;
			}
		}
		if(obj.duration>0){
			sessiontimerun += 1000*Math.floor(obj.duration/1000);
		}
		if(obj.totalDuration>0){
			totaltimerun += 1000*Math.floor(obj.totalDuration/1000);
		}
	}
	if(totalTime ==0){
		//если из SCORM пришёл 0
		totalTime = totaltimerun;
	}
	return {totaltimerun:(totaltimerun+sessiontimerun), sessiontimerun:sessiontimerun, countattempted:countattempted, countcompleted:countcompleted};
}
//
//
function makeResultsTable(sceneIframe, aQuestion){
	var objDoc = sceneIframe.contentWindow.document;
	var tagTable = objDoc.getElementById("results");
	var sReplace = (startDate != null)?(String(((startDate.getDate()<9)?("0"):(""))+startDate.getDate())+"."+String(((startDate.getMonth()<9)?("0"):("")) + (startDate.getMonth()+1))+"."+String(((startDate.getYear()<1000)?(1900):(0)) + startDate.getYear())):("-");
	replaceTagVar(tagTable, "tagvar", "prop", "date", sReplace);
	//
	var obj = getTotalCounts(aQuestion);	
	var totaltimerun = obj.totaltimerun;
	var countattempted = obj.countattempted;
	var countcompleted = obj.countcompleted;
	var sReplace = secondsToHMS(Math.floor(totaltimerun/1000));
	replaceTagVar(tagTable, "tagvar", "prop", "totaltimerun", sReplace);
	//
	var sessiontimerun = obj.sessiontimerun;
	var sReplace = secondsToHMS(Math.floor(sessiontimerun/1000));
	replaceTagVar(tagTable, "tagvar", "prop", "sessiontimerun", sReplace);
	//
	replaceTagVar(tagTable, "tagvar", "prop", "countattempted", String(countattempted));
	//
	replaceTagVar(tagTable, "tagvar", "prop", "countcompleted", String(countcompleted));
	//
	replaceTagVar(tagTable, "tagvar", "prop", "learnername", learnerName);
	//строки, относящиеся к отдельным вопросам модуля
	var aElement = objDoc.getElementsByTagName("*");
	var aTagSceneInfo = [];
	var n = aElement.length;
	var i;
	for(i=0;i<n;i++){
		if((aElement[i].attributes != undefined) && (aElement[i].attributes.name != undefined) && (aElement[i].attributes.name.value == "sceneinfo")){
			aTagSceneInfo.push(aElement[i]);
		}
	}
	if(aTagSceneInfo.length == 0){
		return;
	}
	var tagSceneInfo, flag, sIfStatus;
	n = aTagSceneInfo.length;
	//
	var j, l = aQuestion.length, objSessionData, objProps, currNode;
	//
	for(i=0;i<l;i++){
		objSessionData = aQuestion[i].sessionData;
		objProps = aQuestion[i].props;
		if(objProps.showinregister){
			flag = false;
			for(j=0;(j<n) && !flag;j++){
				tagSceneInfo = aTagSceneInfo[j];
				sIfStatus = (tagSceneInfo.attributes.ifstatus!=undefined)?(tagSceneInfo.attributes.ifstatus.value):(null);
				flag = (sIfStatus==null) || (sIfStatus.indexOf(objSessionData.status) != -1);
			}
			if(flag){
				currNode = tagSceneInfo.cloneNode(true);
				replaceTagVar(currNode, "tagvar", "prop", "title", objProps.caption);
				//
				if(objSessionData.timeFirstStart != undefined){
					objSessionData.sTimeStart = secondsToHMS(objSessionData.timeFirstStart.getHours()*3600+objSessionData.timeFirstStart.getMinutes()*60+objSessionData.timeFirstStart.getSeconds());
					replaceTagVar(currNode, "tagvar", "prop", "timestart", objSessionData.sTimeStart);
					objSessionData.sDateStart = String(objSessionData.timeFirstStart.getDate())+"."+String(objSessionData.timeFirstStart.getMonth()+1)+"."+String(objSessionData.timeFirstStart.getFullYear());
					replaceTagVar(currNode, "tagvar", "prop", "datestart", objSessionData.sDateStart);
				}
				//
				replaceTagVar(currNode, "tagvar", "prop", "timerun", secondsToHMS(Math.floor(objSessionData.duration/1000)));
				replaceTagVar(currNode, "tagvar", "prop", "attempts", (objProps.estimated)?(objSessionData.attempts):("–"));
				replaceTagVar(currNode, "tagvar", "prop", "visits", objSessionData.visits);
				//
				replaceTagVar(currNode, "tagvar", "prop", "bonus", (objProps.estimated)?(isNaN(objSessionData.score)?(0):(objSessionData.score)):("–"));
				replaceTagVar(currNode, "tagvar", "prop", "bonuspercent", (objProps.estimated)?(Math.round(100*(isNaN(objSessionData.score)?(0):(objSessionData.score)))+"%"):("–"));
				//
				tagSceneInfo.parentNode.insertBefore(currNode, tagSceneInfo);
			}
		}
	}
	for(i=0;i<n;i++){
		aTagSceneInfo[i].parentNode.removeChild(aTagSceneInfo[i]);
	}
	aTagSceneInfo.splice(0);
}
//
//
//
function updateSCORMValues(aQuestion){
	//
	if(!testFinished && (currentSceneNumber>0) && (currentSceneNumber <= aQuestion.length)){
		var currentTime = (new Date()).getTime();
		var obj = aQuestion[currentSceneNumber-1].sessionData;
		if(obj.timeStart != undefined){
			obj.duration += (currentTime-obj.timeStart);
		}
	}
	//
	var objCount = getTotalCounts(aQuestion);
	var totaltimerun = objCount.totaltimerun;
	var sessiontimerun = objCount.sessiontimerun;
	sessionTime = msecToHMS(sessiontimerun);
	var sTotalTime = msecToHMS(sessiontimerun+totalTime);
	//
	var score = 0;
	var i, n = aQuestion.length, obj, objProp, objSessionData;
	suspendData = "";
	for(i=0; i<n; i++){
		obj = aQuestion[i];
		objProps = obj.props;
		objSessionData = obj.sessionData;
		if(objProps.estimated && !isNaN(objSessionData.score)){
			score += objSessionData.score*objProps.scoreweight;
		}
		if(suspendData.length>0){
			suspendData += "<_step/>";
		}else{
			suspendData += "<propsofmodule ";
			suspendData += "csn=\""+currentSceneNumber+"\" ";
			if(startDate != null){
				suspendData += "sdt=\""+startDate.getTime()+"\" ";
			}
			if(testFinished){
				suspendData += "fin=\"true\" ";
			}
			suspendData += "/>";
		}
		suspendData += "<propsof"+String(i)+" ";
		//
		suspendData += "num=\""+String(i)+"\" ";
		//сохраняем свойства текущей сцены (возникшие при прохождении модуля)
		if(objSessionData.timeFirstStart != undefined){
			suspendData += "tfs=\""+objSessionData.timeFirstStart.getTime()+"\" ";
		}
		suspendData += "stt=\""+objSessionData.status+"\" ";
		suspendData += "drn=\""+(objSessionData.totalDuration+objSessionData.duration)+"\" ";
		if(!isNaN(objSessionData.score)){
			suspendData += "scr=\""+Number(objSessionData.score).toFixed(7)+"\" ";
		}
		suspendData += "atc=\""+objSessionData.attempts+"\" ";
		suspendData += "vsc=\""+objSessionData.visits+"\" ";
		suspendData += "/>";
		//
		if((objSessionData.testProps!=undefined) && (objSessionData.testProps.length>0)){
			suspendData+=objSessionData.testProps;
		}
	}
	//свойства решения (сколько раз его просматривали)
	if(objSolution.show){
		suspendData += "<_step/>";
		suspendData += "<propsofsolution ";
		suspendData += "vsc=\""+objSolution.visits+"\" ";
		suspendData += "/>";
	}
	//
	if(suspendData.length>0){
		//признак окончания
		suspendData+="<endsuspenddata/>";
	}
	score = score.toFixed(7);
	//
	if(isNaN(completionThreshold)){
		completionStatus = "unknown";
	}else{
		completionStatus = (progress>completionThreshold)?("completed"):("incomplete");
	}
	//
	//successStatus – без связи с completionStatus
	var successMeasure = ((Math.abs(scoreNorma)>=1E-5)?(Math.round(1E4*score)*1E-4):(progress));
	successStatus = (successMeasure>scaledPassingScore)?("passed"):("failed");
	//
	//
	//alert("progress_measure : "+progress.toFixed(7)+" score.scaled : "+score+" completion_status : "+completionStatus+" success_status : "+successStatus+" session_time : "+sessionTime+" total_time "+sTotalTime);
	//
	if(okSCORM && !savedSCORM && (noAPIFound == "false")){
		setDataValue("cmi.exit", (completionStatus=="completed")?("normal"):("suspend"));
		setDataValue("cmi.progress_measure", progress.toFixed(7));
		setDataValue("cmi.completion_status", completionStatus);
		setDataValue("cmi.session_time", sessionTime);
		//setDataValue("cmi.total_time", sTotalTime);
		if(moduleType == "k"){
			setDataValue("cmi.success_status", successStatus);
			setDataValue("cmi.score.scaled", score);
		}
		if(suspendData.length<64000){
			setDataValue("cmi.suspend_data", suspendData);
		}
		commitData();
		savedSCORM = true;
	}
}