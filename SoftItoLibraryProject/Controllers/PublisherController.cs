using Data;
using Microsoft.AspNetCore.Mvc;

namespace SoftItoLibraryProject.Controllers
{
    public class PublisherController : Controller
    {
        private readonly AppDbContext _context;

        public PublisherController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult GetAll()
        {
            var values=_context.Publishers.ToList();
            return View(values);
        }
    }
}
