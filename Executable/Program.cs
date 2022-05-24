using Lessons.Delegates;
using Lessons.Models;

List<Employee> emp = new List<Employee>();
emp.Add(new Employee
{
    Id = 1,
    Name = "John Obi",
    Age = 5
});

emp.Add(new Employee
{
    Id = 2,
    Name = "Alex",
    Age = 89
});

emp.Add(new Employee
{
    Id = 3,
    Name = "Daniel Codes",
    Age = 7
});



var t = emp.MyWhereVersion(emp => emp.Id > 1);

foreach(Employee e in t)
{
    Console.WriteLine(e.Name);
}

