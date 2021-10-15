const bodyParser = require("body-parser");
const express = require("express")

const bp = require("body-parser")

const app = express();

app.use(bp.json())
app.use(bp.urlencoded({extended:true}))

let done =[];
let toDo = [];
toDo.push({
    "id": 1,
    "taak": "schoonmaken"
})
toDo.push({
    "id": 2,
    "taak": "leren"
})
app.get("/todo",(req,res)=>{

    res.send(toDo);

})

app.post("/todo", (req,res)=>{
    toDo.push(req.body)
    res.status(201).send("ok");
})

app.delete("/todo/:id",(req,res)=>{
    for (let i = 0; i < toDo.length; i++) {
        if (toDo[i].id == req.params.id) {
            done.push(toDo[i])
            toDo.splice(i,i+1)
        }  
    }
    res.status(201).send("ok");
})

app.get("/done", (req, res) => {
    res.send(done)
  })

app.listen(3000,()=>{
    console.log("up and running")
})
