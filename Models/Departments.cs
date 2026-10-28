namespace efcore_practice.Models;

public class Departments
{
    public int DepartmentsId { get; set; }
    public string? DeptName { get; set; } =string.Empty;
    public string? Location { get; set; }
    public bool  IsActive { get; set; }
    
}