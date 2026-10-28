
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
    
    
    
}