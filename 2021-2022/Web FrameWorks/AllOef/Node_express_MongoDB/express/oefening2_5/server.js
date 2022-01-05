const express = require('express');

const app = express();
var router = express.Router();
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
        res.send("ello mate go to /pokemons")
    })


    

router.route("/pokemons")
    .get((req, res) =>{
        res.json(pokemons)
    })




router.route("/pokemons/:id")
.get((req, res) => {
    res.json(pokemons[req.params.id-1])
})




app.listen(3000, ()=> {console.log("server running on http://localhost:3000")})