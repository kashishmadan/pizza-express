using Microsoft.AspNetCore.Mvc;
using pizza_express_webapp.Data;
using pizza_express_webapp.Models;

namespace pizza_express_webapp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> categoryListObject = _db.Categories;
            return View(categoryListObject);
        }
    }
}
