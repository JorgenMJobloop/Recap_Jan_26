public class Animal : IAnimal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal made a sound!");
    }

    public virtual string Species()
    {
        return "Animal";
    }
}