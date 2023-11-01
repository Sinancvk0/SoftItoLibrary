using Data;
using Data.Abstract;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SoftItoLibraryProject.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser _user;
        private readonly AppDbContext _context;

        public UserController(IUser user, AppDbContext context)
        {
            _user = user;
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users
                .Include(user => user.Adrress).ThenInclude(adrress => adrress.District).ThenInclude(district => district.City)
                .ThenInclude(city => city.Country)
                .ToList(); 

            return View(users);
        }
        [HttpGet]
        public IActionResult AddUser()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddUser(User user ,Adrress adrress)
        {
            _context.Users.Add(user);
            _context.Adrresses.Add(adrress);
            return RedirectToAction("Index");

     
        }


    }
}
