using System;
using System.ComponentModel.DataAnnotations;

public class Configuration
{
    [Key] // Marks this property as the primary key
    public int Id { get; set; } // Primary Key, non-nullable by default in EF Core
    
    [Required] // Ensures DataBaseLocation cannot be null
    [StringLength(200)] // Limits the maximum length to 200 characters
    public string DataBaseLocation { get; set; } // Stores the database location path
    
    [Required] // Ensures DataBaseName cannot be null
    [StringLength(200)] // Limits the maximum length to 200 characters
    public string DataBaseName { get; set; } // Stores the database name
    
    [Required] // Ensures QuizDuration cannot be null
    public int QuizDuration { get; set; } // Stores the quiz duration in minutes
    
    [Required] // Ensures CurrentClassPassword cannot be null
    [StringLength(200)] // Limits the maximum length to 200 characters
    public string CurrentClassPassword { get; set; } // Stores the current class password
}