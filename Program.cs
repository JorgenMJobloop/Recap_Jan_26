namespace Recap_Jan_26;

class Program
{
    static void Main(string[] args)
    {
        StudentService students = new StudentService();
        students.AddStudent(new Student(4, "Jane Smith", new DateOnly(1992, 10, 2)));
        students.PrintStudentCard();
        students.PrintAvailableCourses();
        students.FindStudendByName("Jane");
        students.FindStudentById(4);
    }
}