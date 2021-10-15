const express =  require('express')
const bodyParser = require('body-parser')

const app = express();
const PORT = 5000;

// parse application/x-www-form-urlencoded
app.use(bodyParser.urlencoded({ extended: true }))

// parse application/json
app.use(bodyParser.json())

let trips = []

trips.push({
     "id" : 1,
     "naam" : "jens",
     "prijs" : [300,500,200]
})
trips.push({
    "id" : 2,
    "naam" : "burn-E",
    "prijs" : []
})
trips.push({
    "id" : 3,
    "naam" : "Vector",
    "prijs" : []
})


app.get('/', (req,res) => {
    res.send("server is running")
})

app.get("/trips", (req,res) => {
    res.send(trips)
})

app.get("/trips/:id", (req,res) => {
    let totalekost = 0;
    for (let i = 0; i < trips.length; i++) {
        if (trips[i].id == req.params.id) {
            
            for (let j = 0; j < trips[i].prijs.length; j++) {
                totalekost += trips[j].prijs
             
                console.log(trips[j].prijs)
                console.log('----------------------')
            }
            res.send("totale kost = " + totalekost)
        }
    }
   
})



app.post("/trips", (req,res) => {
    res.send(trips)
})

app.post("/trips/:id",(req,res) => {
    for (let i = 0; i < trips.length; i++) {
        if (trips[i].id == req.body.id) {
            res.send(trips[i])
        }
    }
})







app.listen(PORT, (err)=>{
    if (err) {
        console.log(err)
    }
    console.log(`server running on port ${PORT}`)
})
