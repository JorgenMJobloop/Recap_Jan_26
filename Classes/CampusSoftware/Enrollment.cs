public class Enrollment
{
    public int StudentId { get; }
    public CourseCode? Code { get; }
    public double Grade { get; }

    public Enrollment(int studentId, CourseCode code, double grade)
    {
        StudentId = studentId;
        Code = code;
        Grade = grade;
    }
}