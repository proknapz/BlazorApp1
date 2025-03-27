using System;
using System.ComponentModel.DataAnnotations;

public class Instructor
{
    [Key] // Marks this property as the primary key
    public int Id { get; set; } // Primary Key, non-nullable by default in EF Core
    
    [Required] // Ensures LastName cannot be null
    [StringLength(200)] // Maximum length of 200 characters for LastName
    public string LastName { get; set; } // Non-nullable Last Name
    
    [Required] // Ensures FirstName cannot be null
    [StringLength(200)] // Maximum length of 200 characters for FirstName
    public string FirstName { get; set; } // Non-nullable First Name
    
    [Required] // Ensures Password cannot be null
    [StringLength(200)] // Maximum length of 200 characters for Password
    public string Password { get; set; } // Non-nullable Password
}