using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class StudentService
{
    private readonly ApplicationDbContext _context;

    // Injecting the DbContext through the constructor
    public StudentService(ApplicationDbContext context)
    {
        _context = context;
    }

    // Add a new student asynchronously
    public async Task AddStudentAsync(Student student)
    {
        // Add the student to the DbSet
        await _context.Students.AddAsync(student); // Use "Students" for the DbSet name
        await _context.SaveChangesAsync(); // Save changes to the database
    }

    // Get a student by ID asynchronously
    public async Task<Student> GetStudentByIdAsync(int id)
    {
        return await _context.Students
            .FirstOrDefaultAsync(s => s.Id == id); // Use "Students" for the DbSet name
    }

    // Get all students asynchronously
    public async Task<List<Student>> GetAllStudentsAsync()
    {
        return await _context.Students
            .ToListAsync(); // Use "Students" for the DbSet name
    }

    // Update a student asynchronously
    public async Task UpdateStudentAsync(Student student)
    {
        _context.Students.Update(student); // Use "Students" for the DbSet name
        await _context.SaveChangesAsync(); // Save changes to the database
    }

    // Delete a student asynchronously
    public async Task DeleteStudentAsync(int id)
    {
        var student = await _context.Students
            .FirstOrDefaultAsync(s => s.Id == id); // Use "Students" for the DbSet name

        if (student != null)
        {
            _context.Students.Remove(student); // Use "Students" for the DbSet name
            await _context.SaveChangesAsync(); // Save changes to the database
        }
    }
}
