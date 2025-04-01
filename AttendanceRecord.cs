using System;
using System.ComponentModel.DataAnnotations;

public class AttendanceRecord
{
    [Key] // Marks this property as the primary key
    public int Id { get; set; } // Primary key, non-nullable by default in EF Core

    [Required] // Ensures ArrivalTime cannot be null
    public DateTime ArrivalTime { get; set; } // Stores the time the student arrived in class

    [Required] // Ensures IsPresent cannot be null
    public bool IsPresent { get; set; } // Indicates if the student is present

    [Required] // Ensures IsExcused cannot be null
    public bool IsExcused { get; set; } // Indicates if an absence is excused

    [Required] // Ensures ClassDate cannot be null
    public DateTime ClassDate { get; set; } // Stores the date of the class session

    [Required] // Ensures CurrentIp cannot be null
    [StringLength(200)] // Limits the maximum length to 200 characters
    public string CurrentIp { get; set; } // Stores the IP address associated with the student during class
}