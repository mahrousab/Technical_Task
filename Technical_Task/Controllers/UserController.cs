using Microsoft.AspNetCore.Mvc;
using Technical_Task.Data;
using Technical_Task.Models;

namespace Technical_Task.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index() =>
            View(_context.users.ToList());
        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public  IActionResult Create(User user)
        {
            if (ModelState.IsValid) 
            {
                user.CreationDate = DateTime.Now;
                _context.users.Add(user);
                 _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        [HttpGet]
        public IActionResult Edit(int id) =>
            View(_context.users.Find(id));

        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                _context.users.Update(user); 
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
        public IActionResult Delete(int id)
        {
            var user = _context.users.Find(id);
            if (user != null)
            {
                 _context.users.Remove(user); 
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
