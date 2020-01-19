window.onload = function(){
	loadHeader();
	loadFooter();
}


function loadHeader(){
	var header = document.getElementById("header");
	load("../header.html", header)
}

function loadFooter(){
	var footer = document.getElementById("footer");
	load("../footer.html", footer)
}


function load(url, element)
{
    req = new XMLHttpRequest();
    req.open("GET", url, false);
    req.send(null);

    element.innerHTML = req.responseText; 
}