const express = require("express")
let router = express.Router()
const pool = require("../database")

router
    .route("/")
    .get((req,res)=>{
        pool.getConnection( (err,connection)=>{

            if(err)
                throw err
            Getdata(connection,"select * from spelers",(rows)=>{
                res.send(rows)
            })               
    
        })

    })

router
    .route("/:id")
    .get((req,res)=>{
        const id = req.params.id;
        pool.getConnection( (err,connection)=>{

            if(err)
                throw err
            Getdata(connection,`select * from spelers where spelersnr = ${id}`,(rows)=>{
                res.send(rows)
            })  
        })
    })
    .delete((req,res)=>{
        const id = req.params.id;
        pool.getConnection( (err,connection)=>{

            if(err)
                throw err
            Getdata(connection,`delete from spelers where spelersnr = ${id}`,(rows)=>{
                res.send(rows)
            })  
        })
    })


function Getdata(connection, sql,callback){
    
    connection.query(sql, (err, rows)=>{    
        connection.release()
        if(err)
            console.log(err)
        else
            callback(rows)
    })
}

    module.exports = router