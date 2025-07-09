//written by conan starting 4/16/2025 CS 4485

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("attendancerecord")]
public class AttendanceRecord
{
    [Key]
    public int AttendanceId { get; set; }

    public int StudentID { get; set; }
    public int ClassId { get; set; }
    public TimeSpan ArrivalTime { get; set; }
    public bool IsPresent { get; set; }
    public bool IsExcused { get; set; }
    public DateTime ClassDate { get; set; }
    public string CurrentIP { get; set; }

    public Student Student { get; set; }  

}
