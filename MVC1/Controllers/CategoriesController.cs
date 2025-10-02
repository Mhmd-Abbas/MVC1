using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC1.Data;
using MVC1.Models;

namespace MVC1.Controllers
{
	public class CategoriesController : Controller
	{
		AppicationDbContext context = new AppicationDbContext();
		public ViewResult Index()
		{
			var categories = context.Categories.ToList();
			return View("index",categories);
		}

		public ViewResult Details(int id) {
			var category = context.Categories.Find(id);
			return View("Details", category);
		}

        public ViewResult Create()
        {
            return View("Create", new Category {});
        }
        public IActionResult Store(Category request)
        {
			if (ModelState.IsValid)
			{
				context.Categories.Add(request);
				context.SaveChanges();
				return RedirectToAction("index");
			}

			return View("Create", request);
        }

		public RedirectToActionResult Delete(int id)
		{
			var category = context.Categories.Find(id);
			context.Categories.Remove(category);
			context.SaveChanges();
			var categories = context.Categories.ToList();
			return RedirectToAction("index");
		}

		public ViewResult Update(int id)
		{
			var category = context.Categories.Find(id);
			return View("Update", category);
		}

		public IActionResult Change(Category request)
		{
			
			if (ModelState.IsValid)
			{
				context.Entry(request).State = EntityState.Modified;
				context.SaveChanges();
				return RedirectToAction("index");
			}

			return View("Update", request);
		}
	}
}
