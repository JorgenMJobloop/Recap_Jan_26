namespace Recap_Jan_26;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("John Doe", 35, ["Programming", "Gaming", "Skiing"]);
        string nameOfPerson = person.GetNameOfPerson();
        Console.WriteLine(nameOfPerson);
        person.IntroducePerson();
        Calculator calculator = new Calculator();

        person.Introduce();

        BankAccount account = new BankAccount();

        account.DepositFunds(25);
        double balance = account.AccountBalance;
        Console.WriteLine(balance * 5);
        double realBalance = account.GetCurrentBalance();
        Console.WriteLine(realBalance);

        // Example of inheritance & polymorphism
        Animal dog = new Dog();
        Animal cat = new Cat();
        Animal animal = new Animal();

        dog.MakeSound();
        cat.MakeSound();
        animal.MakeSound();

        double faculty = calculator.GetFaculty(5); // 120
        Console.WriteLine(faculty);
    }
}