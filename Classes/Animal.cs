public class Animal : IAnimal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal made a sound!");
    }
}