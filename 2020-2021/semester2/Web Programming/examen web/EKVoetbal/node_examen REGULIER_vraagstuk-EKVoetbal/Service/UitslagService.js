const Uitslag = require("./Uitslag")

const uitslagen = []

uitslagen.push(new Uitslag("Belgie","Griekenland",1,1))
uitslagen.push(new Uitslag("Belgie","Kroatie",1,0))
uitslagen.push(new Uitslag("Belgie","Rusland",3,1))
uitslagen.push(new Uitslag("Denemarken","Belgie",2,4))
uitslagen.push(new Uitslag("Finland","Belgie",0,3))

module.exports = uitslagen