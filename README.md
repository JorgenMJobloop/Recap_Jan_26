# Recap January 2026

## 

## 

![alt text](image.png)


## Example usage of the FileInfo class constructor
```cs
FileInfo info = new FileInfo("README.md");
Console.WriteLine(info.UnixFileMode);
```


# All examples from previous lectures
```cs
        Person person = new Person("John Doe", 35, ["Programming", "Gaming", "Skiing"]);
        string nameOfPerson = person.GetNameOfPerson();
        Console.WriteLine(nameOfPerson);
        person.IntroducePerson();
        Calculator calculator = new Calculator();
        Shape rectangle = new Rectangle(10, 15);
        Classroom bookings = new Classroom();
        StudentService studentService = new StudentService();

        studentService.FindStudendByName("Jane");

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
        Console.WriteLine(calculator.SubtractNumbers(3.2, 2));
        Console.WriteLine(rectangle.GetArea());
```