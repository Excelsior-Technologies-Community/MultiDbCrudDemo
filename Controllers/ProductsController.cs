using Microsoft.AspNetCore.Mvc;
using MultiDbCrudDemo.Data;
using MultiDbCrudDemo.Models;

namespace MultiDbCrudDemo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductDbContext _db;

        public ProductsController(ProductDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Products.ToList());
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var product = _db.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _db.Products.Update(product);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var product = _db.Products.Find(id);
            if (product != null)
            {
                _db.Products.Remove(product);
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
