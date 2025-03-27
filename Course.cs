using System;
using System.ComponentModel.DataAnnotations;

public class Course
{
    [Key] // Marks this property as the primary key
    public int Id { get; set; } // Primary Key, non-nullable by default in EF Core

    [Required] // Ensures ClassTime cannot be null
    public TimeSpan ClassTime { get; set; } // Represents time in hours and minutes

    [Required] // Ensures CourseName cannot be null
    [StringLength(200)] // Maximum length of 200 characters for CourseName
    public string CourseName { get; set; } // Non-nullable Course Name
    
    [Required] // Ensures StartDate cannot be null
    public DateTime StartDate { get; set; } // Represents the start date of the class
    
    [Required] // Ensures EndDate cannot be null
    public DateTime EndDate { get; set; } // Represents the end date of the class
}