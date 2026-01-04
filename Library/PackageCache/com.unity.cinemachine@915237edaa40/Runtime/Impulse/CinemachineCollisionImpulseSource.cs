var awa = awa || {};
awa.isInitialized = false;
awa.verbosityLevels = {
    NONE: 0, ERROR: 1, WARNING: 2, INFORMATION: 3
};
awa.behavior = {
    UNDEFINED: 0, NAVIGATIONBACK: 1, NAVIGATION: 2, NAVIGATIONFORWARD: 3, APPLY: 4, REMOVE: 5, SORT: 6, EXPAND: 7, REDUCE: 8, CONTEXTMENU: 9, TAB: 10, COPY: 11, EXPERIMENTATION: 12, PRINT: 13, SHOW: 14, HIDE: 15, MAXIMIZE: 16, MINIMIZE: 17, BACKBUTTON: 18, STARTPROCESS: 20, PROCESSCHECKPOINT: 21, COMPLETEPROCESS: 22, SCENARIOCANCEL: 23, DOWNLOADCOMMIT: 40, DOWNLOAD: 41, SEARCHAUTOCOMPLETE: 60, SEARCH: 61, SEARCHINITIATE: 62, TEXTBOXINPUT: 63, PURCHASE: 80, ADDTOCART: 81, VIEWCART: 82, ADDWISHLIST: 83, FINDSTORE: 84, CHECKOUT: 85, REMOVEFROMCART: 86, PURCHASECOMPLETE: 87, VIEWCHECKOUTPAGE: 88, VIEWCARTPAGE: 89, VIEWPDP: 90, UPDATEITEMQUANTITY: 91, INTENTTOBUY: 92, PUSHTOINSTALL: 93, SIGNIN: 100, SIGNOUT: 101, SOCIALSHARE: 120, SOCIALLIKE: 121, SOCIALREPLY: 122, CALL: 123, EMAIL: 124, COMMUNITY: 125, VOTE: 140, SURVEYINITIATE: 141, SURVEYCOMPLETE: 142, REPORTAPPLICATION: 143, REPORTREVIEW: 144, SURVEYCHECKPOINT: 145, CONTACT: 160, REGISTRATIONINITIATE: 161, REGISTRATIONCOMPLETE: 162, CANCELSUBSCRIPTION: 163, RENEWSUBSCRIPTION: 164, CHANGESUBSCRIPTION: 165, REGISTRATIONCHECKPOINT: 166, CHATINITIATE: 180, CHATEND: 181, TRIALSIGNUP: 200, TRIALINITIATE: 201, PARTNERREFERRAL: 220, VIDEOSTART: 240, VIDEOPAUSE: 241, VIDEOCONTINUE: 242, VIDEOCHECKPOINT: 243, VIDEOJUMP: 244, VIDEOCOMPLETE: 245, VIDEOBUFFERING: 246, VIDEOERROR: 247, VIDEOMUTE: 248, VIDEOUNMUTE: 249, VIDEOFULLSCREEN: 250, VIDEOUNFULLSCREEN: 251, VIDEOREPLAY: 252, VIDEOPLAYERLOAD: 253, VIDEOPLAYERCLICK: 254, VIDEOVOLUMECONTROL: 255, VIDEOAUDIOTRACKCONTROL: 256, VIDEOCLOSEDCAPTIONCONTROL: 257, VIDEOCLOSEDCAPTIONSTYLE: 258, VIDEORESOLUTIONCONTROL: 259, VIRTUALEVENTJOIN: 260, VIRTUALEVENTEND: 261, IMPRESSION: 280, CLICK: 281, RICHMEDIACOMPLETE: 282, ADBUFFERING: 283, ADERROR: 284, ADSTART: 285, ADCOMPLETE: 286, ADSKIP: 287, ADTIMEOUT: 288, OTHER: 300
};
awa.behaviorKeys = [];
for (var behaviorKey in awa.behavior)
{
    awa.behaviorKeys.push(behaviorKey)
}
awa.actionType = {
    CLICKLEFT: "CL", CLICKRIGHT: "CR", CLICKMIDDLE: "CM", SCROLL: "S", ZOOM: "Z", RESIZE: "R", KEYBOARDENTER: "KE", KEYBOARDSPACE: "KS", GAMEPADA: "CGA", GAMEPADMENU: "CGM", OTHER: "O"
};
awa.cookie = (function()
{
    function getCookieKeyValue(cookieName, keyName)
    {
        var cookie = getCookie(cookieName);
        if (cookie && keyName)
        {
            for (var u = cookie.split("&"), r = 0; r < u.length; r++)
            {
                var keyvalue = u[r].split("=");
                if (keyvalue[0] && keyName.toLowerCase() === keyvalue[0].toLowerCase())
                {
                    return keyvalue[1]
                }
            }
        }
        return undefined
    }
    function getCookie(name, valuePrefix)
    {
        var allcookies = document.cookie.split(";");
        for (var i = 0; i < allcookies.length; i++)
        {
            var cookie = allcookies[i];
            while (cookie.charAt(0) === " ")
            {
                cookie = cookie.substring(1)
            }
            var parts = cookie.split("=");
            var cookieName = decode(parts.shift());
            if (cookieName === name && parts[0].indexOf(valuePrefix) == (awa.utils.isValueAssigned(valuePrefix) ? 0 : -1))
            {
                return decode(parts.join("="))
            }
        }
        return undefined
    }
    function getAllCookies()
    {
        var allCookiesArray = document.cookie.split(";");
        var allCookiesObject = {};
        for (var i = 0; i < allCookiesArray.length; i++)
        {
            var cookie = allCookiesArray[i];
            while (cookie.charAt(0) === " ")
            {
                cookie = cookie.substring(1)
            }
            var parts = cookie.split("=");
            var cookieName = decode(parts.shift());
            if ((cookieName != "MSFPC") || (cookieName === "MSFPC" && parts[0].indexOf("GUID") == (awa.utils.isValueAssigned("GUID") ? 0 : -1)))
            {
                allCookiesObject[cookieName] = decode(parts.join("="))
            }
        }
        return allCookiesObject
    }
    function decode(inputString)
    {
        var value = decodeURIComponent(inputString.replace("/\+/g", " "));
        if (value.indexOf("\"") === 0)
        {
            value = value.slice(1, -1).replace(/\\"/g, "\"").replace(/\\\\/g, "\\")
        }
        return value
    }
    function setCookie(name, value, days)
    {
        var expires;
        if (days)
        {
            var date = new Date;
            date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
            expires = "; expires=" + date.toUTCString()
        }
        else
        {
            expires = ""
        }
        window.document.cookie = name + "=" + value + expires + "; path=/;"
    }
    function deleteCookie(name)
    {
        setCookie(name, "", -1)
    }
    return {
            getCookie: getCookie, getCookieKeyValue: getCookieKeyValue, getAllCookies: getAllCookies, setCookie: setCookie, deleteCookie: deleteCookie
        }
})();
awa.cv = (function()
{
    var UNINITIALIZED_CV = "";
    var base = UNINITIALIZED_CV;
    var currentElement = 0;
    var eventTag = "cV";
    var header = "MS-CV";
    var base64CharSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
    var cv1Constants = {};
    cv1Constants.maxCorrelationVectorLength = 63;
    cv1Constants.baseLength = 16;
    cv1Constants.validationPattern = new RegExp("^[" + base64CharSet + "]{" + cv1Constants.baseLength.toString() + "}(.[0-9]+)+$");
    var cv2Constants = {};
    cv2Constants.maxCorrelationVectorLength = 127;
    cv2Constants.baseLength = 22;
    cv2Constants.validationPattern = new RegExp("^[" + base64CharSet + "]{" + cv2Constants.baseLength.toString() + "}(.[0-9]+)+$");
    var currentCvConstants = cv2Constants;
    var cvVersionAtLatestValidityCheck = 2;
    function isInit()
    {
        return isValid(storedCv())
    }
    function storedCv()
    {
        return base.concat(".", currentElement.toString())
    }
    function getValue()
    {
        var value = storedCv();
        if (isValid(value))
        {
            return value
        }
    }
    function incrementExternal(externalCv)
    {
        if (isValid(externalCv))
        {
            var externalCvParts = externalCv.split(".");
            var numberOfCvParts = externalCvParts.length;
            externalCvParts[numberOfCvParts - 1] = (parseInt(externalCvParts[numberOfCvParts - 1], 10) + 1).toString();
            var incrementedCv = "";
            for (var i = 0; i < numberOfCvParts; i++)
            {
                incrementedCv += (externalCvParts[i]);
                if (i < (numberOfCvParts - 1))
                {
                    incrementedCv += "."
                }
            }
            var maxLength = (externalCvParts[0].length === cv2Constants.baseLength) ? cv2Constants.maxCorrelationVectorLength : cv1Constants.maxCorrelationVectorLength;
            if (incrementedCv.length <= maxLength)
            {
                return incrementedCv
            }
        }
    }
    function canExtend()
    {
        var currentCv = storedCv();
        if (isValid(currentCv))
        {
            return isLeqThanMaxCorrelationVectorLength(currentCv.length + 2)
        }
        return false
    }
    function canIncrement()
    {
        if (isValid(storedCv()))
        {
            return isLeqThanMaxCorrelati