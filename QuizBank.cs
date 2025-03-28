using System;
using System.ComponentModel.DataAnnotations;

public class QuizBank
{
    [Key] // Marks this property as the primary key
    public int Id { get; set; } // Primary Key, non-nullable by default in EF Core
    
    [Required] // Ensures BankName cannot be null
    [StringLength(200)] // Maximum length of 200 characters for BankName
    public string BankName { get; set; } // Non-nullable Bank Name
}