//written by conan starting 4/16/2025 CS 4485
public class UserSessionService
{
    public Student LoggedInStudent { get; set; }

    public bool HasQuizAccess { get; set; } = false;

    public void Clear()
    {
        LoggedInStudent = null;
        HasQuizAccess = false;
    }
}
