const express = require("express")
const bp = require("body-parser")
const mysql = require("mysql")

const app = express();
app.use(bp.urlencoded({extended:false}))
app.use(bp.json())

const pool = mysql.createPool({
    connectionLimit :10, 
    host            : "localhost",
    user            : "root",
    password        : "",
    database        : "reisapi"  //specifieer db die je gebruikt
})

app.get("/",(req,res)=>{
    res.sendStatus(200)
   //res.send("ok")
})

app.post("/trips",(req,res)=>{
    const newTrip = req.body;
    console.log(newTrip)
    pool.getConnection( (err,connection) =>{//om naar pool te connecteren
        if(err)
            throw err
        let str = `INSERT INTO trips (bestemming) values("${newTrip.bestemming}")`
        console.log(str)
        connection.query(str,(err,rows)=>{ //je krijgt een error of rijen terug
            connection.release() //return to the connection pool
            if(!err)
                res.send(rows)
            else
                console.log(err)
        })
    })      
})

app.post("/trips/:tripid",(req,res)=>{
    const newKost = req.body;
    console.log(newKost)
    pool.getConnection( (err,connection) =>{//om naar pool te connecteren
        if(err)
            throw err
        let str = `INSERT INTO kosten (beschrijving, prijs, tripid) values("${newKost.beschrijving}", ${newKost.prijs}, ${req.params.tripid})`
        console.log(str)
        connection.query(str,(err,rows)=>{ //je krijgt een error of rijen terug
            connection.release() //return to the connection pool
            if(!err)
                res.send(rows)
            else
                console.log(err)
        })
    })      
})

app.get("/trips",(req,res)=>{
    pool.getConnection( (err,connection) =>{//om naar pool te connecteren
        if(err)
            throw err
        connection.query("SELECT * FROM `trips`",(err,rows)=>{ //je krijgt een error of rijen terug
            connection.release() //return to the connection pool
            if(!err)
                res.send(rows)
            else
                console.log(err)
        })
    })      
})

app.get("/kosten",(req,res)=>{
    pool.getConnection( (err,connection) =>{//om naar pool te connecteren
        if(err)
            throw err
        connection.query("SELECT * FROM `kosten`",(err,rows)=>{ //je krijgt een error of rijen terug
            connection.release() //return to the conneciton pool
            if(!err)
                res.send(rows)
            else
                console.log(err)
        })
    })      
})

app.get("/trips/:tripid",(req,res)=>{
    pool.getConnection( (err,connection) =>{//om naar pool te connecteren
        if(err)
            throw err
        connection.query(`SELECT sum(prijs) as totaal_van_${req.params.tripid} FROM kosten where tripid = '${req.params.tripid}'`,(err,rows)=>{ //je krijgt een error of rijen terug
            connection.release() //return to the conneciton pool
            if(!err)
                res.send(rows)
            else
                console.log(err)
        })
    })      
})

app.listen(3000,err=>{
    if(err)
        console.log(err);
    console.log("running 3000");
})

