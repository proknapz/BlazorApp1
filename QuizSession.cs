//written by omar starting 4/16/2025 CS 4485
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("quizsession")]
public class QuizSession
{
    [Key]
    public int SessionId { get; set; }

    [Required]
    public int ClassId { get; set; }

    [Required]
    public int QuizbankId { get; set; }

    [Required]
    public DateTime SessionDate { get; set; }

    [Required]
    public bool IsActive { get; set; }

    [Required]
    public TimeOnly StartTime { get; set; }

    [Required]
    public TimeOnly EndTime { get; set; }

    [Required]
    public string Password { get; set; }
}
