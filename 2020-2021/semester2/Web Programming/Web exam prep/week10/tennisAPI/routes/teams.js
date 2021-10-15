const express = require("express")
let router = express.Router()
const pool = require("../database")

router
    .route("/")
    //laat alle teams en kapitein zien
    .get((req,res)=>{
        pool.getConnection( (err,connection)=>{

            if(err)
                throw err
            Getdata(connection,"select * from teams inner join spelers using (spelersnr)",(rows)=>{
                res.send(rows)
            }) 
        })
    })
    //maak een nieuw team aan
    .post((req,res)=>{
        /*
        expected data = {teamnr:,spelersnr:,divisie:""}
        */
        let newTeam = req.body
        console.log(newTeam)
        pool.getConnection( (err,connection)=>{

            if(err)
                throw err
            Getdata(connection,`insert into teams(teamnr,spelersnr,divisie) values(${newTeam.teamnr},${newTeam.spelersnr},"${newTeam.divisie}")`,(rows)=>{
                res.send(rows)
            }) 
        })
    })

router
    .route("/:id")
     //update divisie van een team
    .put((req,res)=>{  
        const id = req.params.id;
        /*
        expected data = {teamnr:,spelersnr:,divisie:""}
        */
        let newTeam = req.body
        pool.getConnection( (err,connection)=>{

            if(err)
                throw err
            Getdata(connection,`update teams set divisie = "${newTeam.divisie}" where teamnr = ${id}`,(rows)=>{
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