using efcore_practice.Models;
using efcore_practice.Repositories;

namespace efcore_practice.Services;

public class studentservices
{
    public async Task displayStudents(studentrepo studentrepo)
    {
        var studentsList = await studentrepo.GetAllAsync();
        Console.WriteLine("-------students list-------");
        foreach (var student in studentsList)
        {
            Console.WriteLine($"studentId:-{student.StudentsId}\n" +
                              $"studentName:-{student.StudentName}\n" +
                              $"bloodGroup:-{student.BloodGroup}\n" +
                              $"DOB:-{student.DateOfBirth}");
        }
    }
}