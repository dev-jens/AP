
var express = require('express')
var app = express()

app.use(express.static("views"))
app.use(express.static("public"))


app.listen(8080, ()=> { 
    console.log("listening on port http://localhost:8080")
})