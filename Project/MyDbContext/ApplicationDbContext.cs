using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MyDbContext
{
	internal class ApplicationDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-V9TVRC4\\MSSQLS;Initial Catalog= database;Integrated Security=True; TrustServerCertificate=True;");

		}
		public DbSet<Employee> employee { get; set; }
		public DbSet<Department> department { get; set; }
	}
}
