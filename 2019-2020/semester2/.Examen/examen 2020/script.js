var sBaseUrl = "https://rickandmortyapi.com/api/";

const queryString = window.location.search;
const urlParams = new URLSearchParams(queryString);
const charName = urlParams.get("charName");
const locName = urlParams.get("locName");
const epiID = urlParams.get("epiID");

if(charName != null){ getCharacterData(charName) }
if(locName != null) { getLocationData(locName) }
if(epiID != null) { getEpisode(epiID) }

/*Characters*/

function getCharacterData(sChar) {

    var sCat = "character/";

    $.get(sBaseUrl + sCat + "?name=" + sChar, function (data) {
        $("#character").html("");
        data.results.forEach(result => {
            var sImgUrl = result.image;
            var sName = result.name;
            var sStatus = result.status;
            var sGender = result.gender;
            var sSpecies = result.species;
            var sOrgin = result.orgin.name
            var sType = result.type;
            if (sType.length === 0) {
                sType = "No type";
            }
            var sLocation = result.location.name

            $("#character").append('<div class="card" style="width: 18rem; "> \
      <br/><img class="card-img-top" src=' + sImgUrl + ' alt="Card image cap"> \
      <div class="card-body"> \
      <h5 class="card-title">Name: ' + sName + ' </h5> \
      <p class="card-title"> Status: ' + sStatus + ' </p> \
      <p class="card-title"> Species: ' + sSpecies + ' </p> \
      <p class="card-title"> Gender: ' + sGender + ' </p> \
      <p class="card-title"> Type: ' + sType + ' </p> \
      <p class="card-title"> Location: ' + sLocation + ' </p> \
      <p class="card-title"> Location: ' + sOrgin + ' </p> \
      </div> \
    </div>')
        });
    });
}

function getCharacter() {
    var sChar = $("#characterName").val();
    if (sChar !== undefined) {
        getCharacterData(sChar);
    }
}

/*Locations*/

function getLocationData(sLocName) {

    var sCat = "location/";

    $.get(sBaseUrl + sCat + "?name=" + sLocName, function (oData) {
        var aResults = oData.results;
        $("#locationJumbotron").html("");
        aResults.forEach(result => {
            var sName = result.name;
            var sDimension = result.dimension;
            var sType = result.type;
            var sId = result.id

            $("#locationJumbotron").append('<div class="jumbotron"><h1>' + sName + '</h1>\
            <p class="lead">Type: ' + sType + '</p>\
            <p class="lead">Dimension: ' + sDimension + '</p>\
            </p>\
            </div>')

          
        });
    });
}

function getLocation() {
    var sLocName= $("#locationInput").val();
    if (sLocName !== undefined) {
        getLocationData(sLocName);
    }
}



/*Episodes*/

function getEpisode(sChar) {

    var sCat = "episode/";
    var sChar = $("#episodeID").val();

    var bIsnum = /^\d+$/.test(sChar);

    if (bIsnum) {
        $.get(sBaseUrl + sCat + sChar)
            .done((oData) => {
                $("#episode").html("")
                var sName = oData.name;
                var sEpisode = oData.episode;
                var sDate = oData.air_date;

                $("#episode").append('<div class="container"> \
                <div class="row">\
                <div class="col">\
                  Name: ' + sName + ' \
                </div>\
                <div class="col">\
                Air date: ' + sDate + ' \
                </div>\
                <div class="col">\
                Episode: ' + sEpisode + ' \
                </div>\
              </div>\
              </div>')
            })
            .fail((oError) => {
                alert("Something went wrong, check your spelling. If you are still not sure, check the console");
                console.log(oError);
            });
    } else {
        $.getJSON(sBaseUrl + sCat + "?name=" + sChar)
            .done((oData) => {
                var aResults = oData.results;
                $("#episode").html("")
                aResults.forEach(result => {
                    var sName = result.name;
                    var sEpisode = result.episode;
                    var sDate = result.air_date;

                    $("#episode").append('<div class="container"> \
                <div class="row">\
                <div class="col">\
                  Name: ' + sName + ' \
                </div>\
                <div class="col">\
                Air date: ' + sDate + ' \
                </div>\
                <div class="col">\
                Episode: ' + sEpisode + ' \
                </div>\
              </div>\
              </div>')
                });
            })
            .fail((oError) => {
                alert("Something went wrong, check your spelling. If you are still not sure, check the console");
                console.log(oError);
            });
    }
}




