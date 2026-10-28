using efcore_practice.Data;
using efcore_practice.Repositories;
using efcore_practice.Services;

using var context = new AppDbContext();

var deptrepo = new departmentrepo(context);
departmentservice deptobj = new departmentservice();

var studentrepo = new studentrepo(context);
studentservices studobj = new studentservices();

/*
 * 


await studobj.displayStudents(studentrepo);
await deptobj.displaydepartments(deptrepo);
await deptobj.adddepartment(deptrepo);




 */


await studobj.AddStudent(studentrepo);




 
