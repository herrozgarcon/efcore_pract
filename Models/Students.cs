namespace efcore_practice.Models;

public class Students
{
    public int StudentsId { get; set; }
    public string? StudentName { get; set; } =string.Empty;
    public DateTime DateOfBirth { get; set; }
    public string? BloodGroup { get; set; } =string.Empty;
}