function searchrecept(){
    $('#ingredients').html('');
    var input = $('#inputveld').val();
    $.get('https://797018ed-47c8-4ebe-8bde-b8cf9586d45e-bluemix.cloudant.com/recipes_simple/_design/views/_view/recipeSearch?key="' + input + '"' , function(data){
        var recipe = data.rows[0].value;
       
        $('#title').text(input);

        recipe.forEach(ingredient => {
            $('#ingredients').append('<li>' + ingredient + '</li>');
        });
    });
}






