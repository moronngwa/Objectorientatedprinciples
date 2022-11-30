using Objectorientatedprinciples;

class Program { 

    static void Main(String[] args)
    {
        People Person1= new People("Malesela","Male","Black",27);
        People Person2 = new People("Thabo","Female","Black",19);
        People Person3 = new People("Martha","Female","Black",23);

        Console.WriteLine(Person1.name+ " " + Person1.Gender +" " + Person1.Race +" " + Person1.Age);
        Console.WriteLine(Person2.name + " " + Person2.Gender + " " + Person2.Race + " " + Person2.Age);
        Console.WriteLine(Person3.name + " " + Person3.Gender + " " + Person3.Race + " " + Person3.Age);

    }


}

