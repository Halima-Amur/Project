using Project.MyDbContext;

namespace Project
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			ApplicationDbContext context = new ApplicationDbContext();

		}
	}
}