using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class ClassService
{
    private readonly ApplicationDbContext _context;

    // Injecting the DbContext through the constructor
    public ClassService(ApplicationDbContext context)
    {
        _context = context;
    }

    // Add a new class asynchronously
    public async Task AddClassAsync(Class newClass)
    {
        await _context.Classes.AddAsync(newClass);
        await _context.SaveChangesAsync();
    }

    // Get a class by ID asynchronously
    public async Task<Class> GetClassByIdAsync(int id)
    {
        return await _context.Classes.FirstOrDefaultAsync(c => c.Id == id);
    }

    // Get all classes asynchronously
    public async Task<List<Class>> GetAllClassesAsync()
    {
        return await _context.Classes.ToListAsync();
    }

    // Update a class asynchronously
    public async Task UpdateClassAsync(Class updatedClass)
    {
        _context.Classes.Update(updatedClass);
        await _context.SaveChangesAsync();
    }

    // Delete a class asynchronously
    public async Task DeleteClassAsync(int id)
    {
        var classToDelete = await _context.Classes.FirstOrDefaultAsync(c => c.Id == id);

        if (classToDelete != null)
        {
            _context.Classes.Remove(classToDelete);
            await _context.SaveChangesAsync();
        }
    }
}
