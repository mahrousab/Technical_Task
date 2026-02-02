using Microsoft.AspNetCore.Mvc;
using Technical_Task.Data;
using Technical_Task.IService;
using Technical_Task.Models;

namespace Technical_Task.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index() => View(_userService.GetAllUsers());
        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid) 
            {
                user.CreationDate = DateTime.Now; 
                _userService.CreateUser(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        [HttpGet]
        public IActionResult Edit(int id) { 

            var user = _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.UpdateUser(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _userService.DeleteUser(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
