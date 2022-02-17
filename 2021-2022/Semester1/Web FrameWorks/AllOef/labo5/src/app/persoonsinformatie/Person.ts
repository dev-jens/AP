

export class Person{


    private firstname: string;
    private lastname: string;
    private birth : Date;

    constructor( Firstname: string,  Name: string,  Birth: Date) { 
        this.firstname = Firstname
        this.lastname = Name
        this.birth = Birth

    }

get FirstName() : string { 
    return this.firstname; 
}

get LastName() : string { 
    return this.lastname; 
}

get Birth() : Date {
    return this.birth;
}

}

