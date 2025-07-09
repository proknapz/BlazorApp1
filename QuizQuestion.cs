//written by omar starting 4/16/2025 CS 4485
using System;
using System.ComponentModel.DataAnnotations;

public class QuizQuestion
{
    [Key]
    public int QuestionId { get; set; }

    public int QuizbankId { get; set; }

    [Required]
    public string QuestionText { get; set; }

    [Required]
    public int CorrectAns { get; set; }

    [Required]
    [StringLength(255)]
    public string OptionA { get; set; }

    [Required]
    [StringLength(255)]
    public string OptionB { get; set; }

    [Required]
    [StringLength(255)]
    public string OptionC { get; set; }

    [Required]
    [StringLength(255)]
    public string OptionD { get; set; }
}
