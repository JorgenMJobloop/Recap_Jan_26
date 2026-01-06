public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    public override string Species()
    {
        return "Feline";
    }
}