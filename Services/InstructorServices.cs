using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//Vishal Koundinya VRK200000
public class InstructorService
{
    private readonly ApplicationDbContext _context;

    // Injecting the DbContext through the constructor
    public InstructorService(ApplicationDbContext context)
    {
        _context = context;
    }

    // Add a new instructor asynchronously
    public async Task AddInstructorAsync(Instructor instructor)
    {
        // Add the instructor to the DbSet
        await _context.Instructors.AddAsync(instructor); // Use "Instructors" for the DbSet name
        await _context.SaveChangesAsync(); // Save changes to the database
    }

    // Get an instructor by ID asynchronously
    public async Task<Instructor> GetInstructorByIdAsync(int instructorId)
    {
        return await _context.Instructors
            .FirstOrDefaultAsync(i => i.InstructorId == instructorId); // Use "Instructors" for the DbSet name
    }

    // Get all instructors asynchronously
    public async Task<List<Instructor>> GetAllInstructorsAsync()
    {
        return await _context.Instructors
            .ToListAsync(); // Use "Instructors" for the DbSet name
    }

    // Update an instructor asynchronously
    public async Task UpdateInstructorAsync(Instructor instructor)
    {
        _context.Instructors.Update(instructor); // Use "Instructors" for the DbSet name
        await _context.SaveChangesAsync(); // Save changes to the database
    }

    // Delete an instructor asynchronously
    public async Task DeleteInstructorAsync(int instructorId)
    {
        var instructor = await _context.Instructors
            .FirstOrDefaultAsync(i => i.InstructorId == instructorId); // Use "Instructors" for the DbSet name
        if (instructor != null)
        {
            _context.Instructors.Remove(instructor); // Use "Instructors" for the DbSet name
            await _context.SaveChangesAsync(); // Save changes to the database
        }
    }

    // Optional: Method to get instructor by email (useful for authentication)
    public async Task<Instructor> GetInstructorByEmailAsync(string email)
    {
        return await _context.Instructors   
            .FirstOrDefaultAsync(i => i.Email == email);
    }
}

