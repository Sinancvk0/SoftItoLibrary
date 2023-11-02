using Data;
using Data.Abstract;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftItoLibraryProject.Models;
using System.Net;


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
       



    }
}
