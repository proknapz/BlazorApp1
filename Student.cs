using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("student")] // Match exact MySQL table name
public class Student
{

    public int StudentId { get; set; }


    public string UtdId { get; set; }


    public string NetId { get; set; }


    public string LastName { get; set; }


    public string FirstName { get; set; }


    public string Password { get; set; }
}


