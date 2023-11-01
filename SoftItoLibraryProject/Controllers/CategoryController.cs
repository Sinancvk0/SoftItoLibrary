using Data;
using Data.EntityFramework;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace SoftItoLibraryProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
      
        public CategoryController(AppDbContext db)
        {
            _db = db;
       
        }

        public IActionResult GetAll()
        {
             var value=_db.Categories.ToList();
            return Json(value);
        }
    }
}
