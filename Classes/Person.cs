public class Person
{
    // Fields
    public string Name { get; private set; }
    public int Age { get; private set; }
    public List<string> Hobbies { get; private set; }

    // Primary constructor
    public Person(string name, int age, List<string> hobbies)
    {
        Name = name;
        Age = age;
        Hobbies = hobbies;
    }

    // Methods
    public string GetNameOfPerson()
    {
        return Name;
    }

    public int GetPersonsAge()
    {
        return Age;
    }

    public string GetPersonsHobbies()
    {
        if (Hobbies == null || Hobbies.Count == 0)
        {
            return "No hobbies is listed for this person.";
        }
        return string.Join(", ", Hobbies);
    }

    public void IntroducePerson()
    {
        string values;
        if (Hobbies == null || Hobbies.Count == 0)
        {
            Console.WriteLine($"{Name} has no hobbies listed!");
        }
        if (Hobbies!.Count == 1)
        {
            values = Hobbies[0];
        }
        else
        {
            values = string.Join(", ", Hobbies.Take(Hobbies.Count - 1)) + " & " + Hobbies.Last();
        }
        Console.WriteLine($"{Name} is {Age} years old! And enjoys the following hobbies {values}");
    }

    public void Introduce()
    {
        Console.WriteLine($"{Name} is {Age} years old! And enjoys the following hobbies {GetPersonsHobbies()}");
    }
}