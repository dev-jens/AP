function getpicca(){
    $('#picture').addClass("invisible");
    $('#loader').removeClass("invisible");
    $.get("https://api.thecatapi.com/v1/images/search", function(data){
        $('#picture').attr("src", data[0].url);

        $('#picture').removeClass("invisible");
        $('#loader').addClass("invisible");

    });}