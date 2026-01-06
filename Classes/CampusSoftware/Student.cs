/// <summary>
/// A generic student class
/// </summary>
public class Student
{
    public int StudentId { get; }
    public string Name { get; }

    public Student(string name, int studentId)
    {
        StudentId = studentId;
        Name = name;
    }
}