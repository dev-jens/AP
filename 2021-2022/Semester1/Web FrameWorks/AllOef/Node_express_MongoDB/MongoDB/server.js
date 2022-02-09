const bodyParser = require('body-parser');
const express = require('express');
const mongoClient = require('mongodb').MongoClient;


const app = express();
var router = express.Router();
app.use(bodyParser.json())
app.use("/api", router);

//const pokemons = require("./pokedex.json")

var db;
const url = 'mongodb+srv://Jens:wf123@webframeworkscluster.cnsks.mongodb.net/test';
const dbName = 'pokemonsDB'

mongoClient.connect(url, (err, client) => {
    if (err != null) {
        console.log(err.message);
        throw err;
    }
    db = client.db(dbName);
    console.log("conntect to mongodb: ");

})

router.route("/")
    .get((req, res) => {
        res.send("ello mate go to api/pokemons")
    })

router.route("/pokemons")
    .get((req, res) => {

        db.collection("pokemons").find().toArray(function (err, result) {
            res.json(result)
        })
        //res.json(pokemons)
    })
    .post((req, res) => {
        const pokemon = req.body;
        db.collection("pokemons").insertOne(pokemon, (err, result) =>{
            res.json(result)
        })
    })

router.route("/pokemons/:id")
    .get((req, res) => {
        const query = {
            id: req.params.id
        };
        //const indexPokemon = pokemons.findIndex(pokemon => pokemon.id == id);

        db.collection("pokemons").find(query).toArray(function (err, result) {
            console.log(query);
            console.log(result);
            res.json(result[0])
        })

        //res.json(pokemons[indexPokemon])
    })


    .delete((req, res) => {
        const query = {
            id: req.params.id   
        };
        db.collection("pokemons").deleteOne(query,(err, result) => {
            console.log(result)
        })
        res.status(200).sendStatus(200);
    })


// port

app.listen(3000, () => {
    console.log("server running on http://localhost:3000/api/pokemons")
})