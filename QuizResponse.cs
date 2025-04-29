using System.ComponentModel.DataAnnotations;

public class QuizResponse
{
    [Key]
    public int ResponseId { get; set; }
    public int AttendanceId { get; set; }
    public int SessionId { get; set; }
    public string SelectedAnswer { get; set; }
}
