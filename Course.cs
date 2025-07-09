//written by conan starting 4/16/2025 CS 4485
using System;
using System.ComponentModel.DataAnnotations;

public class Course
{
    [Key]
    public int Id { get; set; }

    [Required]
    public TimeSpan ClassTime { get; set; }

    [Required]
    [StringLength(200)]
    public string CourseName { get; set; }

    [Required]
    public DateTime StartDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }
}
