using BulkyBookweb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookweb.Controllers
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
           IEnumerator<Category> objCategoryList=_db.Categories;
            return View(bjCategoryList);
        }
    }
}
