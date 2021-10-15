const express = require("express");
const bp = require("body-parser");
const mysql = require("mysql");

const app = express();

app.use(bp.urlencoded({extended:false}))
app.use(bp.json())

const pool = mysql.createPool({
    connectionLimit:10,
    host:"localhost",
    user:"root",
    password:"",
    database:"tennis"
})

app.get("/spelers",(req,res)=>{
    
    pool.getConnection((err,connection)=>{
        
        connection.query("select * from spelers", (err,rows)=>{
            connection.release()
            if (err) {
                console.log(err)
            }else{
                res.send(rows)
            }
        })
    })
    
})

app.get("/spelers/:id", (req,res)=>{
    pool.getConnection((err,connection)=>{
        
        connection.query(`select * from spelers where SPELERSNR = ${req.params.id}`, (err,rows)=>{
            connection.release()
            if (err) {
                console.log(err)
            }else{
                res.send(rows)
            }
        })
    })
})


app.get("/teams",(req,res)=>{
    
    pool.getConnection((err,connection)=>{
        
        connection.query("select * from teams inner join spelers using (spelersnr)", (err,rows)=>{
            connection.release()
            if (err) {
                console.log(err)
            }else{
                res.send(rows)
            }
        })
    })
    
})

app.get("/teams",(req,res)=>{
    
    pool.getConnection((err,connection)=>{
        
        connection.query(`insert into teams values(${req.body.spelersnr},${req.body.teamnr},${req.body.divisie})`, (err,rows)=>{
            connection.release()
            if (err) {
                console.log(err)
            }else{
                res.send(rows)
            }
        })
    })
    
})

app.listen(3000,()=>{
    console.log("running")
})