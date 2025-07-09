//written by omar starting 4/16/2025 CS 4485
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("student")] // Match exact MySQL table name
public class Student
{
    [Key]
    public int StudentId { get; set; }

    [Required]
    public string UtdId { get; set; }

    public string LastName { get; set; }

    public string FirstName { get; set; }

    [ForeignKey("Class")]
    public int ClassId { get; set; }

    [ForeignKey("Instructor")]
    public int InstructorId { get; set; }
}
