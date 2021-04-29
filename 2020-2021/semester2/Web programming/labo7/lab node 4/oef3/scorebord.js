class scoreboard{
    constructor(_user,_score,_aantalsommen){
        this.score = _score;
        this.aantalsommen = _aantalsommen;
        this.user = _user;
    }

    print(){
        console.log(`Beste ${this.user.voornaam}, je behaalde : ${this.score} / ${this.aantalsommen}`);
    }
}

module.exports = scoreboard;