using efcore_practice.Data;
using efcore_practice.Repositories;
using efcore_practice.Services;

using var context = new AppDbContext();

var deptrepo = new departmentrepo(context);
departmentservice deptobj = new departmentservice();

var studentrepo = new studentrepo(context);
studentservices studobj = new studentservices();

bool running = true;

while (running)
{
    Console.WriteLine("\n========== EF CORE PRACTICE ==========");
    Console.WriteLine("1. Display All Departments");
    Console.WriteLine("2. Display All Students");
    Console.WriteLine("3. Add Department");
    Console.WriteLine("4. Add Student");
    Console.WriteLine("5. Exit");
    Console.WriteLine("======================================");

    Console.Write("Enter your choice: ");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            await deptobj.displaydepartments(deptrepo);
            break;

        case "2":
            await studobj.displayStudents(studentrepo);
            break;

        case "3":
            await deptobj.adddepartment(deptrepo);
            break;

        case "4":
            await studobj.AddStudent(studentrepo);
            break;

        case "5":
            running = false;
            Console.WriteLine("Exiting application. Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid choice! Please enter a number between 1 and 5.");
            break;
    }
}