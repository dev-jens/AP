class Logger{

    error(foutcode){
        console.log(`error ${foutcode}`)
    }
    warning(bericht){
        console.log("warning" + bericht)
    }
    info(bericht){
        console.log(`info ${bericht}`)
    }

}

module.exports = Logger;