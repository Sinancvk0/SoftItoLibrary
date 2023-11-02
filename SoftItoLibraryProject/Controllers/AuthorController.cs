using Data;
using Microsoft.AspNetCore.Mvc;

namespace SoftItoLibraryProject.Controllers
{
	public class AuthorController : Controller
	{
		private readonly AppDbContext _context;

		public AuthorController(AppDbContext context)
		{
			_context = context;
		}

		public IActionResult GetAll()
		{
			var value=_context.Authors.ToList();
			return View(value);
		}
	}
}
