const express = require('express')
const app = express()

app.get('/', (req,res)=> {
  res.sendFile(__dirname + '/client/index.html');
})

app.get("")

app.listen(8080, () => console.log('Server ready'))
