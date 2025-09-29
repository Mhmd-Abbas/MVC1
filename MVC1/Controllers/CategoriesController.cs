using Microsoft.AspNetCore.Mvc;
using MVC1.Data;

namespace MVC1.Controllers
{
	public class CategoriesController : Controller
	{
		AppicationDbContext context = new AppicationDbContext();
		public ViewResult GetAll()
		{
			var categories = context.Categories.ToList();
			return View("index",categories);
		}

		public ViewResult Details(int id) {
			var category = context.Categories.Find(id);
			return View("Details", category);
		}
	}
}
