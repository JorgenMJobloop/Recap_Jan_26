/// <summary>
/// A generic student class
/// </summary>
public class Student
{
    public int ID { get; }
    public string Name { get; }
    public DateOnly DateOfBirth { get; }

    public Student(int id, string name, DateOnly dateOfBirth)
    {
        ID = id;
        Name = name;
        DateOfBirth = dateOfBirth;
    }

    public override string ToString()
    {
        return $"${ID}: {Name} ({DateOfBirth:yyyy-MM-dd})";
    }
}