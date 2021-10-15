const express = require("express")
const uitslagen = require("../Service/UitslagService")
let router = express.Router()



router
    .route("/")
    .get((req,res)=>{
     res.send(uitslagen)
    
    })
router
    .route("/:uit/:thuis")
    .post((req,res)=>{
   
        for (let i = 0; i < uitslagen.length; i++) {
            if(uitslagen.scoreOut == req.params.uit &&uitslagen.scoreThuis == req.params.thuis)
            {
              res.send(uitslagen[i])
            }
        }
        res.status(201).send("ok")
    })
    

module.exports =uitslagen