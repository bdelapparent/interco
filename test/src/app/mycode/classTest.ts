class Person {
    first_name: string;
    last_name: string;
    age: number;

    greet() {
        console.log("Hello", this.first_name, this.last_name, this.age);
    }

    ageInYear(years: number): number {
        return this.age + years;
    }

    constructor(first_name: string, last_name: string, age: number){
       this.first_name = first_name;
       this.last_name = last_name;
       this.age = age;
    }
}
    // déclare une variable de type personne
    var p: Person = new Person('Max', 'DEUDEU', 29);

    //instancie un new Person
    //p = new Person();

    //donne un first_name
    //p.first_name = 'Max';

    //appel la méthode greet
    p.greet();

    //set un age
    //p.age = 6;

    //affiche un log de l'age
    //console.log(p.ageInYear(12));
