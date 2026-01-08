/// <summary>
/// A generic student class
/// </summary>
public class Student
{
    public int StudentId { get; }
    public string Name { get; }

    public Student(int studentId, string name)
    {
        StudentId = studentId;
        Name = name;
    }
}