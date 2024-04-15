var IS_IE=(navigator.appName=="Microsoft Internet Explorer");
var randomShift = ((new Date()).getTime() % 1000)*0.001;
//Общеупотребительные функции
//
var aMonth_eng = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
//
function $(id) {
	return document.getElementById(id);
}
//
function preImg(a) {
	var d=document;
	if (d.images) {
		if (!d.imgArr) {
			d.imgArr=new Array();
		}
		var i,j=d.imgArr.length;
		for (i=0; i<a.length; i++) {
			if (a[i].indexOf("#")!=0) {
				d.imgArr[j]=new Image();
				d.imgArr[j++].src=a[i];
			}
		}
	}
}
//
function showLayer(id, flag) {
	var objLayer = $(id);
	if (objLayer==null) {
		return;
	}
	objLayer.style.visibility = (flag)?("visible"):("hidden");
}
//
function replaceTagVar(objNode, tagName, attrName, attrValue, sReplace){
	var a = objNode.getElementsByTagName(tagName);
	var i, nodeTmp;
	if(a.length>0){
		for(i=0; i<a.length; i++){
			if((a[i].attributes != null) && (a[i].attributes[attrName] != undefined) && (a[i].attributes[attrName].value == attrValue)){
				nodeTmp = objNode.ownerDocument.createTextNode(sReplace);
				a[i].parentNode.insertBefore(nodeTmp, a[i]);
				a[i].parentNode.removeChild(a[i]);
				i--;
			}
		}

	}
	
}
//
function replaceSymbol(sWhere, sWhat, sWith) {
	var sNew = new String(sWhere), i = sNew.indexOf(sWhat), l = sWhat.length;
	while (i != -1) {
		sNew = sNew.slice(0, i)+sWith+sNew.slice(i+l);
		i = sNew.indexOf(sWhat, i+l);
	}
	return sNew;
}
//
function evalPx(v){
	var s = String(v), i = s.toLowerCase().indexOf("px");
	if(i==-1){
		i = s.toLowerCase().indexOf("pt");
	}
	return Number((i!=-1) ? (s.slice(0,i)) : (s));
}
//
function secondsToHMS(tSeconds){
	var t = Number(tSeconds), hr, mn, sec;
	sec = t % 60;
	t = Math.round((t-sec)/60);
	mn = t % 60;
	hr = Math.round((t-mn)/60);
	return String(hr)+":"+((mn<10)?("0"):(""))+String(mn)+":"+((sec<10)?("0"):(""))+String(sec);
}

//
function parseXML(txt){
	var xmlDoc;
	if (window.DOMParser) {
		parser=new DOMParser();
		xmlDoc=parser.parseFromString(txt,"text/xml");
	} else {
		//IE
		xmlDoc= new ActiveXObject("Msxml2.DOMDocument"/*"Microsoft.XMLDOM"*/);
		xmlDoc.async=false;
		xmlDoc.loadXML(txt);
	}
	return xmlDoc;
}
//
function randomCustom(){
	var v = Math.random()+randomShift;
	if(v>1){
		v -= 1;
	}
	return v;
}
//
function randomSelection(a, nSelect, shuffle){
	var aRes = [], aNum = [], i, l = a.length, n = l-nSelect, j;
	for(i=0; i<l; i++){
		aNum.push(i);
	}
	for(i=0; i<n; i++){
		j = Math.floor(randomCustom()*aNum.length);
		aNum.splice(j, 1);
	}
	if(shuffle){
		for (i=nSelect; i>1; i--) {
			j = Math.floor(i*randomCustom());
			aNum.push(aNum[j]);
			aNum.splice(j, 1);
		}
	}
	for(i=0; i<nSelect; i++){
		aRes.push(a[aNum[i]]);
	}
	return aRes;
}
//
//создание строкового представления атрибутов
function attribsToString(ats){
	var s = new String(), i, l = ats.length, atsi, j, sVal;
	for(i=0;i<l;i++){
		atsi = ats.item(i);
		if(atsi.value != "null"){
			sVal = new String(atsi.value);
			j = sVal.indexOf("&");
			while(j != -1){
				if(j != sVal.indexOf("&amp;", j)){
					sVal = sVal.substring(0,j)+"&amp;"+sVal.substring(j+1,sVal.length);
				}
				j = sVal.indexOf("&", j+1);			
			}
			s += " "+atsi.name+"=\""+sVal+"\"";
		}
	}
	return s;
}
//
//преобразование XMLNode в строчку
function xmlToString(node, deep, sClose){	
	var s = new String(), l;
	if(node == null){
		return sClose;
	}else{
		var nodeCurr = node;
		while(nodeCurr != null){
			if(nodeCurr.nodeType == 1){
				//пока без атрибутов
				s += "<"+nodeCurr.nodeName;
				s += attribsToString(nodeCurr.attributes);
				l = (nodeCurr.hasChildNodes())?(nodeCurr.childNodes.length):(0);
				if(l>0){
					s += ">"+xmlToString(nodeCurr.firstChild, true, "</"+nodeCurr.nodeName+">");
				}else{
					s += "/>";
				}
			}else if(nodeCurr.nodeType == 3){
				s += nodeCurr.nodeValue;
			}
			nodeCurr = nodeCurr.nextSibling;//skipWhite(nodeCurr.nextSibling);
			if(deep != true){
				break;
			}
			if((nodeCurr == null) && (sClose != undefined)){
				s += sClose;
			}
			//не выходить за пределы исходного узла
			if(sClose == undefined){
				break;
			}
		}
		return s;
	}
}
//преобразование XMLNode в нижний регистр
function xmlToLowerCase(node, allSiblings){
	var s, i, l, j, a, aTmp = [], la, attr, c;
	if(node == null){
		return;
	}else{
		var nodeCurr = node, nodePrev, nodeParent, stopNode = (allSiblings == true) ? (null) : (nodeCurr);
		while(nodeCurr != null){
			if(nodeCurr.getNodeType() == 1){
				l = (nodeCurr.hasChildNodes())?(nodeCurr.getChildNodes().length):(0);
				//
				nodeCurr.getOwnerDocument().renameNode(nodeCurr, null, String(nodeCurr.getNodeName()).toLowerCase());
				a = nodeCurr.getAttributes();
				la = a.length;
				for(j=0;j<la;j++){
					attr = a.item(j);
					aTmp.push({name:String(attr.getNodeName()), value:String(attr.getNodeValue())});
				}
				for(j=0;j<la;j++){
					nodeCurr.removeAttribute(aTmp[j].name);
					nodeCurr.setAttribute(aTmp[j].name.toLowerCase(), aTmp[j].value);
				}
				aTmp.splice(0);
				//
				if(l>0){
					xmlToLowerCase(nodeCurr.getFirstChild(), true);
				}
			}
			if(nodeCurr == stopNode){
				break;
			}
			nodeCurr = nodeCurr.getNextSibling();
		}
	}
}
//построение ассоциативного массива по id
function makeXMLIdMap(node, obj, sAttr0){
	var l, attr, oId = ((obj==undefined)?({}):(obj));
	var sAttr = ((sAttr0 == undefined)?("id"):(String(sAttr0)));
	if(node == null){
		return;
	}else{
		var nodeCurr = node, nodePrev, nodeParent;
		while(nodeCurr != null){
			if(nodeCurr.getNodeType() == 1){
				l = (nodeCurr.hasChildNodes())?(nodeCurr.getChildNodes().getLength()):(0);
				//
				attr = nodeCurr.getAttributes().getNamedItem(sAttr);
				if(attr != null){
					oId[attr.getNodeValue()] = nodeCurr;
				}
				//
				if(l>0){
					makeXMLIdMap(nodeCurr.getFirstChild(), oId, sAttr);
				}
			}
			//не выходить за пределы исходного узла
			nodeCurr = (obj == undefined) ? (null) : (nodeCurr.getNextSibling());
		}
	}
	return oId;
}
//
//удаление переносов и ненужных пробелов
function removeWhiteFromXML(node, r){
	var s, i, l, c, sSpace = " \n\r\t";
	if(node == null){
		return;
	}else{
		var nodeCurr = node, nodePrev, nodeParent;
		while(nodeCurr != null){
			if(nodeCurr.getNodeType() == 1){
				l = (nodeCurr.hasChildNodes())?(nodeCurr.getChildNodes().getLength()):(0);
				if(l>0){
					removeWhiteFromXML(nodeCurr.getFirstChild(), true);
				}
				nodeCurr = nodeCurr.getNextSibling();
			}else if(nodeCurr.getNodeType() == 3){
				// проверить на пробелы
				s = new String(nodeCurr.getNodeValue());
				l = s.length;
				for(i=0;i<l;i++){
					c = s.charAt(i);
					if(sSpace.indexOf(c) ==-1){
						break;
					}
				}
				if(i==l){
					nodeParent = nodeCurr.getParentNode();
					nodePrev = nodeCurr;
					nodeCurr = nodeCurr.getNextSibling();
					nodeParent.removeChild(nodePrev);
				}else{
					nodeCurr = nodeCurr.getNextSibling();
				}
			}else{
				nodeCurr = nodeCurr.getNextSibling();
			}
			//не выходить за пределы исходного узла
			if(r == undefined){
				break;
			}
		}
		return;
	}
}
//
function copyXML(srcDoc, destDoc){
	if(destDoc.getFirstChild() != null){
		destDoc.removeChild(destDoc.getFirstChild());
	}
	var srcNode, destNode = destDoc, newNode;
	//srcDoc может быть и узлом, и документом, различаем по наличию getDocType
	var srcIsADocument = (srcDoc.getDoctype != undefined), stopNode;
	//
	srcNode = (srcIsADocument) ? (srcDoc.getFirstChild()) : (srcDoc);
	stopNode = srcNode;
	//
	var a, i, l, attr;
	while(srcNode != null){
		if(srcNode.getNodeType() == 1){
			newNode = destDoc.createElement(String(srcNode.getNodeName()));
			a = srcNode.getAttributes();
			l = a.length;
			for(i=0;i<l;i++){
				attr = a.item(i);
				newNode.setAttribute(attr.getNodeName(), attr.getNodeValue());
			}
			//
			destNode.appendChild(newNode);
		}else if(srcNode.getNodeType() == 3){
			newNode = destDoc.createTextNode(String(srcNode.getNodeValue()));
			destNode.appendChild(newNode);
		}
		if(srcNode.getFirstChild() != null) {
			srcNode = srcNode.getFirstChild();
			destNode = newNode;
		} else if (srcNode.getNextSibling() != null) {
			srcNode = srcNode.getNextSibling();
		} else {
			srcNode = srcNode.getParentNode();
			destNode = destNode.getParentNode();
			while ((srcNode != null) && (srcNode != stopNode) && (srcNode.getNextSibling() == null)) {
				srcNode = srcNode.getParentNode();
				if(destNode != null){
					destNode = destNode.getParentNode();
				}
			}
			if ((srcNode != null) && (srcNode != stopNode)) {
				srcNode = srcNode.getNextSibling();
			}
		}
		if(srcNode == stopNode){
			break;
		}
	}
}
//
function skipWhite(obj){
	if ((obj != null) && (obj.nodeName == '#text')){
		obj = obj.nextSibling;
		skipWhite(obj);
	}
	return obj;
}
//
//
function setImgSrc(objFrame, sId, sName){
	var objImg = objFrame.getElementById(sId);
	var sSrc = replaceSymbol(objImg.src, "\\", "/");
	var i = sSrc.lastIndexOf("/"), j = sSrc.lastIndexOf(".");
	var sPath = sSrc.slice(0, i+1);
	var ext = sSrc.slice(j+1);
	objImg.src = sPath+sName+"."+ext;
}
//
function offsetPosition ( element ) {
    var offsetLeft = 0, offsetTop = 0;
    do{ 
        offsetLeft += element.offsetLeft
        offsetTop  += element.offsetTop;
    }   while ( element = element.offsetParent );
    return [ offsetLeft, offsetTop];
}