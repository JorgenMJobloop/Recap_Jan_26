public class Enrollment
{
    public int StudentId { get; }
    public CourseCode? Code { get; }
    public char? Grade { get; }

    public Enrollment(int studentId, CourseCode code, char grade)
    {
        StudentId = studentId;
        Code = code;
        Grade = grade;
    }
}