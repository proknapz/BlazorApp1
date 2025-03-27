using System;
using System.ComponentModel.DataAnnotations;

public class QuizResponse
{
    [Key] // Marks this property as the primary key
    public int Id { get; set; } // Primary Key, non-nullable by default in EF Core
    
    [Required] // Ensures SelectedAnswer cannot be null
    [StringLength(200)] // Maximum length of 200 characters for SelectedAnswer
    public string SelectedAnswer { get; set; } // Non-nullable selected answer
}