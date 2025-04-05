using Microsoft.AspNetCore.Mvc;
using Northwind.EntityModels;
using Northwind.Mvc.Models;

namespace Northwind.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly NorthwindDatabaseContext db;

        public CategoryController(NorthwindDatabaseContext northwindDatabase)
        {
            db = northwindDatabase;
        }
        public IActionResult Index()
        {
            var obj = db.Categories.ToList();
            return View(obj);
        }
        public IActionResult Details(int id)
        {
            var obj = db.Categories.FirstOrDefault(x => x.CategoryId == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
    }
}
