// npm modules
var express = require('express');
var bodyParser = require('body-parser');

var app = express();
var router = express.Router();

// middleware
app.use(bodyParser.json())
app.use("/",router)

// pokemon lijst 
const pokemons = 
[
    {
        id: 1,
        name: "Bulbasaur",
        type : [
          "Grass",
          "Poison"
        ]
    },
    {
        id: 2,
        name: "Ivysaur",
        type: [
          "Grass",
          "Poison"
        ]
          
    },
      {
        id: 3,
        name:  "Venusaur",
        type: [
          "Grass",
          "Poison"
        ]
      }
]


router.route('/api/pokemons')
.get((req, res) => {
    res.send(pokemons)
})

.post((req, res) => {
    console.log(req.body)
    pokemons.push(req.body)
    res.send(req.body)
})

.delete((req, res) => {
    console.log(req.body)
    pokemons.pop(req.body)
    res.send(req.body)
})

router.route("/api/pokemons/:id")

.get((req, res) => {
    var id = req.params.id;
    console.log(pokemons[id])
    res.send(pokemons[id-1])
})

.delete((req, res) => {
    const id = req.params.id
    const indexPokemon = pokemons.findIndex(pokemon => pokemon.id == id);

    if(indexPokemon > -1) 
        pokemons.splice(indexPokemon, 1);

    res.send(pokemons)
})

app.listen(8080, function(){
    console.log('listening on http://localhost:8080/api/pokemons')
})