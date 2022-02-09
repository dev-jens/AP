/*
    Kopieer deze functies met zorg, 
    sommige functies zullen niet werken zonder dat je de bijhorende functies ook kopieert.
    Er staan ook 2 functies die dienen (grotendeels voor eigen gebruik) om de extra opgaves op te lossen.
    Als je ze niet begrijpt kan je ze best laten staan.
*/



// Geeft een string terug met kaarten.
// Eerste parameter = lijst met objecten.
function getCards(inputList) {
    let sCard = "";
    for (let i = 0; i < inputList.length; i++) {
        sCard += `
    <div class="card" style="width: 18rem;">
        <img id="image" src="${inputList[i].imageLink}" class="card-img-top" alt="...">
        <div class="card-body">
            <h5 class="card-title">${inputList[i].cardTitle}</h5>
            <p class="card-text">${inputList[i].cardText1}</p>
            <p class="card-text">${inputList[i].cardText2}</p>
            <p class="card-text">${inputList[i].cardText3}</p>
        </div>
        <ul id="${i}" class="list-group list-group-flush">${getList(inputList)}</ul>
    </div>`;
    }
    return sCard;
}
// Geeft een string terug met een lijst items van ingevoerde data.
// Eerste parameter = lijst met objecten.
function getList(inputList) {
    let sList = "";
    for (let i = 0; i < inputList.length; i++) {
        // Verander hier Pagina1.html naar pagina waar je naar moet verwijzen.
        sList += `<li class="list-group-item"><a id="anker${i}" href="./Pagina1.html" onclick="saveAnkerInfo">${inputList[i].itemName}</a></li>`;
    }
    return sList;
}

// Geeft input van input element
function getInput() {
    return $("#input").val();
}

// Kijkt of het ingevoerde input een ID is
// Return true indien input = integer.
function isId(input) {
    if(parseInt(input)){
        return true;
    }
    return false;
}

// Voegt image toe aan een ingevoerde ID
// input ID = ID van je element, link = de link van de foto
function addImage(id, link) {
    $("#" + id).attr('src', link);
}


/* EXTRA
Volgende 2 functies dienen namelijk om data te verzenden van 1 html pagina naar een andere. 
*/

/*
Je hoeft verder hier niets aan te passen buiten dat je ze moet kopieren naar pagina waar je ze nodig hebt.
Zo kan je dus de saveAnkerInfo methode dus gebruiken om de tekst van de ingedrukte link te bewaren in een globale variabele.
Deze methode wordt automatisch ingevoerd bij getList methode.
*/
// Saves info from <a> link in localstorage
function saveAnkerInfo(id) {
    var nameItem = document.getElementById(id).text;
    localStorage.setItem("clickedItem", nameItem);
}
/*
Deze methode word NIET automatisch ingevoerd, je moet ze manueel invoeren waar je ze nodig hebt.
Gebruik deze methode in de getJSON(url + input) methode. getAnkerInfo() vervangt dan input in dit geval.
--> getJSON(url + getAnkerInfo())
*/
// Returns the info from the localstorage
function getAnkerInfo() {
    return localStorage.getItem("clickedItem");
}


      