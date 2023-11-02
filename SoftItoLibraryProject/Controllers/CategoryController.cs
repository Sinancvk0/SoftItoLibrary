using Data;
using Data.EntityFramework;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace SoftItoLibraryProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
      
        public CategoryController(AppDbContext db)
        {
			_context = db;
       
        }

        public IActionResult GetAll()
        {
            var value= _context.Categories.ToList();
            return View(value);
        }
    }
}
