using Microsoft.EntityFrameworkCore;
using MVC1.Models;

namespace MVC1.Data
{
	public class AppicationDbContext:DbContext
	{
		public DbSet<Category> Categories { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=.;Database=MVC1;Trusted_Connection=True;TrustServerCertificate=True");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Category>().HasData(
				new Category { Id = 1, Name = "Tariq 1" },
				new Category { Id = 2, Name = "Tariq 2" },
				new Category { Id = 3, Name = "Tariq 3" }
				);
		}

	}
}
