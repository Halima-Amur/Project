using Project.Models;
using Project.MyDbContext;
using System.Security.Cryptography;

namespace Project
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			using ApplicationDbContext context = new ApplicationDbContext();
			Employee employee1 = new Employee() { Name = "Ahmed", Age = 23, Salary = 55555 } ;
			Employee employee2 = new Employee() { Name = "Haima", Age = 25, Salary = 3333 };
			context.employee.Add(employee1);
			context.employee.Add(employee2);
            Console.WriteLine(employee1.Id);
			context.SaveChanges();

			var emp = (from e in context.employee
					   where e.Id == 1
					   select e ).FirstOrDefault();
			emp.Name = "Mahmoud";
			context.employee.Update(emp);
		
            Console.WriteLine(emp?.Name ?? "NA");
			context.SaveChanges();
			//context.employee.Remove(emp);


		}
	}
}