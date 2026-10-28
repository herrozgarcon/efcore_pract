using efcore_practice.Data;
using efcore_practice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace efcore_practice.Repositories;

public class studentrepo
{
    private readonly   AppDbContext _context;
    
    public studentrepo(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Students>> GetAllAsync()
    {
        return await _context.Students.ToListAsync();
    }

    public async Task AddAsync(Students student)
    {
        await _context.Students.AddAsync(student);
        await _context.SaveChangesAsync();
    }
}