const express = require("express")
const bp = require("body-parser")
const pool = require("./database")
const spelers = require("./routes/spelers")
const teams = require("./routes/teams")
const app = express()

app.use(bp.urlencoded({extended:false}))
app.use(bp.json())

app.use("/spelers",spelers)
app.use("/teams",teams)

app.get("/",(req,res)=>{
    res.sendFile(__dirname + "/www/index.html")
})

app.listen(3000,err=>{
    if(err)
        console.log(err)
    console.log("running #3000")
})