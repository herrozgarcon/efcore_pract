using efcore_practice.Data;
using efcore_practice.Models;
using Microsoft.EntityFrameworkCore;

namespace efcore_practice.Repositories;

public class departmentrepo
{
    private readonly AppDbContext _context;

    public departmentrepo(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Departments>> GetAllAsync()
    {
        return await _context.Departments.ToListAsync();
    }

    public async Task Addasync(Departments department)
    {
        await _context.Departments.AddAsync(department);
        await _context.SaveChangesAsync();
    }
    
}