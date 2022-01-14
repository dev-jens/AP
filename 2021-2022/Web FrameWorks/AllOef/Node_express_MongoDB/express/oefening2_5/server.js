const bodyParser = require('body-parser');
const express = require('express');

const app = express();
var router = express.Router();
app.use(bodyParser.json())
app.use("/api",router);

let pokemons = 
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

router.route("/")
    .get((req, res) =>{
        res.send("ello mate go to api/pokemons")
    })


router.route("/pokemons")
    .get((req, res) =>{
        res.json(pokemons)
    })


router.route("/pokemons/:id")
.get((req, res) => {
  const id = req.params.id
  const indexPokemon = pokemons.findIndex(pokemon => pokemon.id == id);
  
  res.json(pokemons[indexPokemon])
})

.delete((req, res) => {
  const id = req.params.id
  const indexPokemon = pokemons.findIndex(pokemon => pokemon.id == id);

  if(indexPokemon > -1) 
      pokemons.splice(indexPokemon, 1);
    res.status(200).json({success : `pokemon with id ${req.params.id} is deleted successfully`})
})




app.listen(3000, ()=> {console.log("server running on http://localhost:3000")})