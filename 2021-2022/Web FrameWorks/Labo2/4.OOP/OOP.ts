export class Klant{

    public readonly name : string = "";
    public readonly jaar : number = 0;
    public readonly klant : number = 0;
    public readonly bestelNr : number  = 0;
    private checksum : number = 0;

    constructor(jaar : number,klant : number,bestelNr : number){

        this.jaar = jaar;
        this.klant = klant;
        this.bestelNr = bestelNr;

    }
    
    // // getter 
     get _checksum(): number {
         return this.checksum;
    }

     //setter
     set _checksum(value : number) {
         this.checksum = value;
     }
}



