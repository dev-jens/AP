const readlineSync = require('readline-sync');

class game{

    constructor(_aantalsommen , _getal){
        this.aantalSommen = _aantalSommen;
        this.getal = _getal;
        this.sommen = [];
        this.antwoorden = []
        this.score = 0;
    }
    
    get aantalSommen(){
        return this.aantalSommen;
    }
    set aantalSommen(value){
        this.aantalSommen = value;
    }

    get getal(){
        return this.getal;
    }
    set getal(value){
        this.getal = value;
    }

    setup(){
        for (let i = 0; i < this.aantalSommen; i++) {
            this.sommen[i] = `${i} + ${this.getal}`   
        }
    }
    play(){

        for (let i = 0; i < this.aantalSommen; i++) {
           this.antwoorden[i] = readlineSync.question(this.sommen[i] + "= " )
        }
    }

    check(){

        for (let i = 0; i < this.aantalSommen; i++) {
            if (eval(this.sommen[i] == this.antwoorden[i])) {
                this.score++;
            }    
        }
    }

}


module.exports = game;