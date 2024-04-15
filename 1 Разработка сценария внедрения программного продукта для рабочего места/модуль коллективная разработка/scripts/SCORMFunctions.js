var startTime;
var moduleScore = 0;
var scoreNorma = 1;
var progressNorma = 1;
var sessionTime;
var learnerName = "";
var totalTime = 0;
var completionThreshold = 0.9999;
var completionStatus;
var successStatus;
var scaledPassingScore = 0.8;
var suspendData;
var entrySCORM = "";
var okSCORM = false;
var savedSCORM = false;
//
function msecToHMS(t){
	var ts = Math.round(t*0.001);
	var tMin = Math.floor(ts/60), tSec = ts%60, sZero = (tSec>9)?(""):("0");
	var vS = ts % 60;
	var vM = Math.round((ts - vS)/60) % 60;
	var vH = Math.round((ts - vM*60 - vS)/3600);
	return String("PT"+String(vH)+"H"+String(vM)+"M"+String(vS)+"S");
}
//
function hmsToMsec(s){
	var i, j, h, m, sec, slc = s.toLowerCase();
	i = slc.indexOf("pt");
	j = slc.indexOf("h");
	h = (j==-1)?(0):(Number(s.slice(i+2, j)));
	if(j!=-1){
		i = j;
	}else{
		i++;
	}
	j = slc.indexOf("m");
	m = (j==-1)?(0):(Number(s.slice(i+1, j)));
	if(j!=-1){
		i = j;
	}
	j = slc.indexOf("s");
	sec = Number(s.slice(i+1, j));
	return 1000*(3600*h+60*m+sec);
}