using System;
using System.ComponentModel.DataAnnotations;

public class Class
{
    [Key] // Marks this property as the primary key
    public int Id { get; set; } // Primary key, non-nullable by default in EF Core

    [Required] // Ensures Classtime cannot be null
    public TimeSpan Classtime { get; set; } // Stores the duration or specific class time of the session

    [Required] // Ensures CourseName cannot be null
    [StringLength(200)] // Limits the maximum length to 200 characters for CourseName
    public string CourseName { get; set; } // Stores the name of the course being taught
    
    [Required] // Ensures StartDate cannot be null
    public DateTime StartDate { get; set; } // Stores the starting date and time of the class

    [Required] // Ensures EndDate cannot be null
    public DateTime EndDate { get; set; } // Stores the ending date and time of the class
}