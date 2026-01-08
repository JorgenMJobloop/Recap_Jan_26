public class Course
{
    public CourseCode? Code { get; }
    public string? Title { get; }
    public int Credits { get; }

    public Course(CourseCode code, string title, int credits)
    {
        Code = code;
        Title = title;
        Credits = credits;
    }

    public override string ToString()
    {
        return $"{Code} - {Title} ({Credits} credits)";
    }
}