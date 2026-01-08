public class StudentService
{
    private readonly List<Student> _students = new List<Student>()
    {
        new Student(1,"Jane Doe", new DateOnly(2001, 5, 11)),
        new Student(2,"John Doe", new DateOnly(1993, 2, 3)),
        new Student(3, "John Smith", new DateOnly(2002, 8, 10)),
    };

    private readonly IReadOnlyList<Course> _courses = new List<Course>()
    {
        new Course(new CourseCode("CS101"), "Intro to C#", 10),
        new Course(new CourseCode("CS102"), "Object Oriented Programming with C#", 10),
        new Course(new CourseCode("DB100"), "Databases & SQL", 10),
        new Course(new CourseCode("DB102"), "Databases, NoSQL, SQL & Relations", 10),
        new Course(new CourseCode("FP101"), "Functional Programming in Haskell", 20),
        new Course(new CourseCode("OS101"), "Assembly Instructions & Operating Systems", 30)
    };

    private readonly IReadOnlyList<Enrollment> _enrollments = new List<Enrollment>()
    {
        new Enrollment(1, new CourseCode("CS101"), 'A'),
        new Enrollment(2, new CourseCode("CS102"), 'B'),
        new Enrollment(3, new CourseCode("DB102"), 'C')
    };

    /// <summary>
    /// Add a new student to the list of students
    /// </summary>
    /// <param name="student">A Student class object instance</param>
    public void AddStudent(Student student)
    {
        _students.Add(student);
    }
    /// <summary>
    /// Remove a specified student from the main student list.
    /// </summary>
    /// <param name="student">Student class object instance</param>
    public void RemoveStudent(Student student)
    {
        _students.Remove(student);
    }

    /// <summary>
    /// Get all available courses as a single collection.
    /// </summary>
    /// <returns>Course collection</returns>
    public IEnumerable<Course> GetCourses()
    {
        return _courses;
    }

    /// <summary>
    /// Get all the current enrollments.
    /// </summary>
    /// <returns>Enrollment collection</returns>
    public IEnumerable<Enrollment> GetEnrollments()
    {
        return _enrollments;
    }


    /// <summary>
    /// Print all the courses currently available
    /// </summary>
    public void PrintAvailableCourses()
    {
        foreach (var course in _courses)
        {
            Console.WriteLine(course);
        }
    }

    /// <summary>
    /// Find a student in the list, by matching on a name in the collection
    /// </summary>
    /// <param name="name">the name to match</param>
    public void FindStudendByName(string name)
    {
        var found = _students.FirstOrDefault(n => n.Name == name);
        Console.WriteLine($"Match found: {found}");
    }

    public void FindStudentById(int id)
    {
        var match = _students.FirstOrDefault(studentId => studentId.ID == id);
        Console.WriteLine($"Found student with ID: {match}. Name: {match!.Name}");
    }

    public void PrintStudentCard(Student student)
    {
        var card = _students.Select(s => new
        {
            student.ID,
            Name = student.Name,
            Birthday = student.DateOfBirth
        }).ToList();

        foreach (var c in card)
        {
            Console.WriteLine($"Student: {c}");
        }
    }
}