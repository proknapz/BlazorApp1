using System;
using System.ComponentModel.DataAnnotations;

public class QuizSession
{
    [Key] // Marks this property as the primary key
    public int Id { get; set; } // Primary Key, non-nullable by default in EF Core

    [Required] // Ensures SessionDate cannot be null
    public DateTime SessionDate { get; set; } // Stores the date and time of the session
    
    [Required] // Ensures IsActive cannot be null
    public bool IsActive { get; set; } // Indicates whether the session is active

    [Required] // Ensures StartTime cannot be null
    public DateTime StartTime { get; set; } // Stores the session's start time
    
    [Required] // Ensures EndTime cannot be null
    public DateTime EndTime { get; set; } // Stores the session's end time
}