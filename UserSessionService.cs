public class UserSessionService
{
    public Student LoggedInStudent { get; set; }

    // ✅ This flag controls access to /quiz
    public bool HasQuizAccess { get; set; } = false;

    public void Clear()
    {
        LoggedInStudent = null;
        HasQuizAccess = false;
    }
}
