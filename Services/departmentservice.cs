
using efcore_practice.Models;
using efcore_practice.Repositories;

namespace efcore_practice.Services;

public class departmentservice
{
    
    public async Task displaydepartments(departmentrepo deptrepo)
    {
        var deptList = await deptrepo.GetAllAsync();

        Console.WriteLine("----- Department List -----");

        foreach (var department in deptList)
        {
            Console.WriteLine(
                $"{department.DepartmentsId} - {department.DeptName}");
        }
    }

    public async  Task adddepartment(departmentrepo departmentrepo)
    {
        Departments department=new Departments();
        
        Console.WriteLine("----- Add Department -----");
        Console.WriteLine("enter department name");
        department.DeptName = Console.ReadLine();
        Console.WriteLine("enter location");
        department.Location = Console.ReadLine();
        department.IsActive = true;

        await departmentrepo.Addasync(department);
        Console.WriteLine("Department inserted successfully!");
    }
    
    
    
}