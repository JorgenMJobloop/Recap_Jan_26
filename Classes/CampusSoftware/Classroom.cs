/// <summary>
/// A "controller" class that uses the Student class model
/// </summary>
public class Classroom
{
    // private readonly field, that follows the proper naming convention
    private readonly List<Student> _students = new List<Student>();

    // add a new student
    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    // remove a student from the list
    public void RemoveStudent(Student student)
    {
        if (_students == null || _students.Count == 0)
        {
            Console.WriteLine("No students found in list.");
        }

        _students!.Remove(student);
    }

    /// <summary>
    /// remove a student from the list, using an indexer.
    /// </summary>
    /// <param name="index">the index of the student to remove</param>
    public void RemoveStudentAtIndex(int index)
    {
        if (_students == null || _students.Count == 0)
        {
            Console.WriteLine("No students found in list.");
        }
        _students!.RemoveAt(index);
    }

    public void RemoveStudentById(int id)
    {
        if (_students == null || _students.Count == 0)
        {
            Console.WriteLine("No students found in list.");
        }
        var studentId = _students!.Find(studentId => studentId.ID == id);

        _students.Remove(studentId!);
    }

    public void PrintStudents()
    {
        if (_students.Count == 0)
        {
            Console.WriteLine("No student found in list of students.");
        }
        foreach (var student in _students)
        {
            Console.WriteLine($"ID: {student.ID} Name: {student.Name}");
        }
    }

    /// <summary>
    /// Returns the collection, as an IEnumerable
    /// </summary>
    /// <returns>List of students</returns>
    public IEnumerable<Student> GetAllStudents()
    {
        return _students;
    }
}