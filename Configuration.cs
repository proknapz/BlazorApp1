//written by conan starting 4/10/2025 CS 4485

using System;
using System.ComponentModel.DataAnnotations;

public class Configuration
{
    [Key]
    public int Id { get; set; }
    
    [Required] 
    [StringLength(200)] 
    public string DataBaseLocation { get; set; }
    
    [Required]
    [StringLength(200)] 
    public string DataBaseName { get; set; } 
    
    [Required] 
    public int QuizDuration { get; set; }
    
    [Required]
    [StringLength(200)] 
    public string CurrentClassPassword { get; set; }
}