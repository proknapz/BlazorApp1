using System;
using System.ComponentModel.DataAnnotations;

public class StudentRecord
{
    [Key] // Marks this property as the primary key
    public int Id { get; set; } // Primary Key, non-nullable by default in EF Core

    [Required] // Ensures UtdId cannot be null
    public int UtdId { get; set; } // Stores the student's UTD ID (Non-nullable)

    [Required] // Ensures TotalAttend cannot be null
    public int TotalAttend { get; set; } // Stores the total number of attended classes

    [Required] // Ensures ExcusedAbsence cannot be null
    public int ExcusedAbsence { get; set; } // Stores the number of excused absences
}