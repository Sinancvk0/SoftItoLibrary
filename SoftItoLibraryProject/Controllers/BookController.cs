using Data;
using Data.Abstract;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SoftItoLibraryProject.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IBook _book;

        public BookController(AppDbContext db, IBook book)
        {
            _context = db;
            _book = book;
        }

        public IActionResult GetAll()
        {
            var book =_context.Books.Include(book=>book.Categories).Include(book=>book.Authors).Include(book=>book.Publishers).ToList();    

            return View(book);  
        }

        
    }
}
