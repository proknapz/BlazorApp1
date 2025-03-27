using System;
using System.ComponentModel.DataAnnotations;

public class Student
{
    [Key] // Marks this property as the primary key
    public int Id { get; set; } // Primary Key, non-nullable by default in EF Core

    [Required] // Ensures UtdId cannot be null
    public int UtdId { get; set; } // Non-nullable UTD ID

    [Required] // Ensures Name cannot be null
    [StringLength(200)] // Maximum length of 200 characters for Name
    public string Name { get; set; } // Non-nullable Name
}
