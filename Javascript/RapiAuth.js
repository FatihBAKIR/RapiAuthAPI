function RapiAuth (key) {
    this.apiKey = key;
    this.Kontrol = function(token, kod) {
    	var adres = "http://auth.fatihbakir.net/v2/yeniAuth.php?api=" + this.apiKey + '&userToken=' + token + '&kod=' + kod;
    	var sonuc = GetSynchronousJSONResponse(adres);
    	sonuc = eval ("(" + sonuc + ")");
		return sonuc.result == "success";
    };
}

function GetSynchronousJSONResponse(url) {
    var xmlhttp = null;
    if (window.XMLHttpRequest)
        xmlhttp = new XMLHttpRequest();
    else if (window.ActiveXObject) {
        if (new ActiveXObject("Microsoft.XMLHTTP"))
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        else
            xmlhttp = new ActiveXObject("Msxml2.XMLHTTP");
    }
        // to be ensure non-cached version of response
    url = url + "&rnd=" + Math.random(); 
    
    xmlhttp.open("GET", url, false);//false means synchronous
    xmlhttp.setRequestHeader("Content-Type", "application/json; charset=utf-8");
    xmlhttp.send();
    var responseText = xmlhttp.responseText;
    return responseText;
}