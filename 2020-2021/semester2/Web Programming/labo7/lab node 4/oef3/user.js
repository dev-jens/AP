class user{

    constructor(){
        this._naam="";
        this._voornaam = "";
      
    }

    get naam(){
        return this._naam;
    }
    set naam(value){
        this._naam = value;
    }

    get voornaam(){
        return this._voornaam;
    }
    set voornaam(value){
        this._voornaam = value;
    }

}

module.exports =user;