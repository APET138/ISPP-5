// Переменная для отладки. Во время отладки устанавливается в true для показа
// отладочной информации, в финальном варианте должна быть false
var _debug = false;

// локальные переменные, необходимые для SCORM API
var isAPIWrapperFound = true;
var apiHandle = null;
var findAPITries = 0;
var noAPIFound = "false";

/*******************************************************************************
* Функция поиска SCORM API в текущем фрейме (window) и во всех
* родительских (parent)
* Параметры:  объект window
* Возврвщает: объект SCORM API, если таковой нашелся, в противном случае null
*******************************************************************************/
function findAPI( win )
{
    while (win.API_1484_11==null && win.parent!=null && win.parent!=win)
    {
        findAPITries++;
        if ( findAPITries > 100 )
        {
            alert( "Не удалось найти реализацию SCORM API." );
            return null;
        }
        win = win.parent;
    }
    return win.API_1484_11;
}

/*******************************************************************************
* Функция возвращает SCORM API, если таковой нашелся в текущем фрейме (window),
* в каком либо из его родительских (parent), в окне opener, или его
* родительских. В противном случае возвращается null.
*******************************************************************************/
function getAPI()
{
   if ( apiHandle == null && noAPIFound == "false")
   {
       var theAPI = findAPI( window );
       if (theAPI==null && window.opener!=null && typeof(window.opener)!="undefined")
          theAPI = findAPI( window.opener );

       if (theAPI == null)
       {
//          alert( "Не удалось найти реализацию SCORM API." );
          noAPIFound = "true";
       }
       else
          apiHandle = theAPI;
   }
   return apiHandle;
}

/*******************************************************************************
* Данная функция вызывается для инициализации сессии. Функция должна вызываться
* до вызовов getDataValue, setDataValue, или terminate
* Возврвщает: "true", если процесс инициализации прошел успешно, в противном
*             случае - "false".
*******************************************************************************/
function initialize()
{
    var result = "false";
    var api = getAPI();
    if(api != null)
    {
        result = api.Initialize("");
        if ( result != "true" )
            displayErrorInfo(getLastErrorCode());
    }
    return result;
}

/*******************************************************************************
* Данная функция вызывается для завершения сессии. После ее вызова нельзя
* вызывать функции initialize, getDataValue или setDataValue
* Возврвщает: "true", если прошло успешно, в противном случае - "false".
*******************************************************************************/
function terminate()
{
    var result;
    var api = getAPI();
    if (api != null)
    {
        result = api.Terminate("");
        if ( result != "true" )
            displayErrorInfo(getLastErrorCode());
    }
    return result;
}

/*******************************************************************************
* Функция запрашивает у Системы значение модели данных. Может вызываться после
* вызова initialize, но до вызова terminate
* Параметры:  название элемента модели данных (напр. "cmi.learner_id")
* Возврвщает: значение запрашиваемых данных
*******************************************************************************/
function getDataValue(name)
{
    var result = "";
    var api = getAPI();
    if ( api != null )
    {
        result = api.GetValue(name);
        var errCode = getLastErrorCode();
        if (errCode != "0")
            displayErrorInfo(errCode);
    }
    return result;
}

/*******************************************************************************
* Функция сохраняет значение в модели данных, определенное значением name.
* Может вызываться после вызова initialize, но до вызова terminate.
* Параметры:  name - название элемента модели данных
*             value - сохраняемое значение
* Возврвщает: "true" - если успешно, "false" - при ошибке.
*******************************************************************************/
function setDataValue(name, value)
{
    var result = "false";
    var api = getAPI();
    if ( api != null )
    {
        result = api.SetValue( name, value );
        if ( result != "true" )
            displayErrorInfo(getLastErrorCode());
    }
    return result;
}
/*******************************************************************************
* Донная функция дает команду Системе на сохранение последних изменений.
* Может вызываться после вызова initialize, но до вызова terminate.
*******************************************************************************/
function commitData()
{
    var result = "false";
    var api = getAPI();
    if ( api != null )
    {
        result =  api.Commit("");
        if ( result != "true" )
            displayErrorInfo(getLastErrorCode());
    }
    return result;
}

/*******************************************************************************
* Функция возвращает код последней ошибки.
* Возврвщает: строку с кодом ошибки (возвращает "0" - если не было ошибки).
*******************************************************************************/
function getLastErrorCode()
{
    var api = getAPI();
    return (api==null?"":api.GetLastError());
}

/*******************************************************************************
* Вспомогательная функция для показа информации об ошибке (код ошибки, описание
* и диагностическую информацию)
* Параметры:  errCode - код ошибки
*******************************************************************************/
function displayErrorInfo(errCode)
{
    var errString, errDiagnostic;
    if ( _debug )
    {
        var api = getAPI();
        if ( api != null )
        {
            errString = api.GetErrorString(errCode);
            errDiagnostic = api.GetDiagnostic("");
        }
        alert( "ERROR: " + errCode + " - " + errString + "\n" +
                "DIAGNOSTIC: " + errDiagnostic );
    }
}