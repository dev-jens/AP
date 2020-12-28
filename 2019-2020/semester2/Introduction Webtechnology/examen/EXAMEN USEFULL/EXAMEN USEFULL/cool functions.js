

// standard GEt functions for API's 

function getFunctionName(sParameter) {
    let sUrl = sBaseUrl + sParameter;
    $.getJSON(sUrl)
      .done(function (oData) {
        $("#ID").html((oData.any));
        $("#ID").text(oData.any);
        $("#image").attr('src', (oData.id));
      })
      .fail(function (oError) {
        console.error(oError);
      });
  }


  // first letter Capital
  
  function capFirstChar(sText) {
    return sText[0].toUpperCase() + sText.slice(1);     //-->  $("#ID").html(capFirstChar(oData.));
  }


  // looping over an array 
  function getFunctionName(arrayId) {
    let emptyStr = "";
    arrayId.forEach(function (object) {
      sTypes += capFirstChar(object.any.any ) + ", ";
    });
    return sTypes.slice(0, -2);
  }


/*  <div class="card" style="width: 18rem;">
  <img class="card-img-top" src="..." alt="Card image cap">
  <div class="card-body">
    <h5 class="card-title">Card title</h5>
    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
    <a href="#" class="btn btn-primary">Go somewhere</a>
  </div>
</div> */