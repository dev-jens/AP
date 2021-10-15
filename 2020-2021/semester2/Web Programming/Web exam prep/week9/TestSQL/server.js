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
    database:"ekvoetbal"
})

app.get("/ploegen",(req,res)=>{
    
    pool.getConnection((err,connection)=>{
        
        connection.query("select * from ploegen", (err,rows)=>{
            connection.release()
            if (err) {
                console.log(err)
            }else{
                res.send(rows)
            }
        })
    })
    
})

app.get("/ploegen/:id", (req,res)=>{
    pool.getConnection((err,connection)=>{
        
        connection.query(`select * from ploegen where id = ${req.params.id}`, (err,rows)=>{
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
    console.log("running");
})