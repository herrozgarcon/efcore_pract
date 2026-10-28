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

    public async Task AddStudent(studentrepo studentrepo)
    {
        Students  student = new Students();
        Console.WriteLine("add student");
        Console.WriteLine("enter student name");
        student.StudentName = Console.ReadLine();
        Console.WriteLine("enter student bloodgroup");
        student.BloodGroup = Console.ReadLine();
        Console.WriteLine("enter student date of birth");
        student.DateOfBirth = DateTime.Parse(Console.ReadLine());

        await studentrepo.AddAsync(student);

    }
}