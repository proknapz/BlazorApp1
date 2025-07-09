//written by conan starting 4/16/2025 CS 4485
using System;
using System.ComponentModel.DataAnnotations;

public class StudentRecord
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int UtdId { get; set; }

    [Required]
    public int TotalAttend { get; set; }

    [Required]
    public int ExcusedAbsence { get; set; }
}
