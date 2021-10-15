const express = require('express')
const app = express()
const bp = require("body-parser")
const uitslagroute = require("./Routes/uitslagen")


app.use(bp.urlencoded({ extended:false}))
app.use(bp.json())
app.use("/uitslag",uitslagroute)


app.listen(process.env.PORT || 3000, () => console.log('server ready'))