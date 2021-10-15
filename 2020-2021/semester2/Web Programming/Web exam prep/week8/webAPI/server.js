const express = require("express");
const app = express();

const bp = require("body-parser")
app.use(bp.json())
app.use(bp.urlencoded({extended:true}))

let trips = []

trips.push({
    "id":1,
    "naam":"jens",
    "kosten": []
})

trips.push({
    "id":2,
    "naam":"tokke",
    "kosten": []
})

app.get('/', (req,res)=>{

    res.send("oke")

})
app.get('/trips', (req,res)=>{

    res.send(trips)

})

app.get("/trips/:id", (req,res)=>{
    let trip = undefined;
    for (let i = 0; i < trips.length; i++) {
        if(trips[i].id == req.params.id)
        {
            trip = trips[i]
        }
    }
    res.send(trip)

})


app.post("/trips",(req,res)=>{
   
    for (let i = 0; i < trips.length; i++) {
        if(trips[i].id == req.body.id)
        {
           trips[i].kosten.push(req.body.kosten)
           console.log(trips[i])
        }
    }
    res.status(201).send("ok")
})

app.get("/trips/:id/kosten",()=>{

    let totaal = 0;
    for (let i = 0; i < trips.length; i++) {
        if (trips[i].id == req.params.id) {
            
            for (let j = 0; j < trips[i].kosten.length; j++) {
                
                
            }
        }
        
    }
})

app.listen(3000,()=>{
    console.log("up and running")
})
