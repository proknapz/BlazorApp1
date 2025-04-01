using System;
using System.ComponentModel.DataAnnotations;

public class QuizQuestion
{
    [Key] // Marks this property as the primary key
    public int Id { get; set; } // Primary Key, non-nullable by default in EF Core
    
    [Required] // Ensures QuestionText cannot be null
    public string QuestionText { get; set; } // Non-nullable question text
    
    [Required] // Ensures CorrectAnswer cannot be null
    public int CorrectAnswer { get; set; } // Stores the index or ID of the correct answer
    
    [Required] // Ensures OptionA cannot be null
    [StringLength(255)] // Maximum length of 255 characters for OptionA
    public string OptionA { get; set; } // Non-nullable option A
    
    [Required] // Ensures OptionB cannot be null
    [StringLength(255)] // Maximum length of 255 characters for OptionB
    public string OptionB { get; set; } // Non-nullable option B
    
    [Required] // Ensures OptionC cannot be null
    [StringLength(255)] // Maximum length of 255 characters for OptionC
    public string OptionC { get; set; } // Non-nullable option C
    
    [Required] // Ensures OptionD cannot be null
    [StringLength(255)] // Maximum length of 255 characters for OptionD
    public string OptionD { get; set; } // Non-nullable option D
}