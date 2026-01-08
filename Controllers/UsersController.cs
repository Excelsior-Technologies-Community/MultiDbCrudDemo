using Microsoft.AspNetCore.Mvc;
using MultiDbCrudDemo.Data;
using MultiDbCrudDemo.Models;

namespace MultiDbCrudDemo.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserDbContext _db;

        public UsersController(UserDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Users.ToList());
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var user = _db.Users.Find(id);
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            _db.Users.Update(user);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var user = _db.Users.Find(id);
            if (user != null)
            {
                _db.Users.Remove(user);
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
