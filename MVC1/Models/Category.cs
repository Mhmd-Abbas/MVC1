using System.ComponentModel.DataAnnotations;

namespace MVC1.Models
{
	public class Category
	{
		public int Id { get; set; }

		[Required]
		[MinLength(3)]
		[MaxLength(20)]
		public string Name { get; set; }

		[Required]
		[MaxLength(100)]
		public string Description { get; set; }
	}
}
