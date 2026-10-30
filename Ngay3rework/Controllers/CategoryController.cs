using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ngay3rework.Data;

namespace Ngay3rework.Controllers
{
    public class CategoryController : Controller
    {
        public static List<Models.Category> categories => SeedData.Categories;

        // GET: CategoryController
        public ActionResult Index()
        {
            return View(categories);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Models.Category category)
        {
            int newId = categories.Any() ? categories.Max(c => c.id) + 1 : 1;
            
            categories.Add(category);
            return RedirectToAction(nameof(Index));
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit([FromRoute]int id)
        {
            var category = categories.FirstOrDefault(c => c.id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            var existingCategory = categories.FirstOrDefault(c => c.id == id);
            if (existingCategory == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                existingCategory.name = collection["name"];
                return RedirectToAction(nameof(Index));
            }
            return View(existingCategory);
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var category = categories.FirstOrDefault(c => c.id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: CategoryController/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed([FromRoute]int id)
        {
            var category = categories.FirstOrDefault(c => c.id == id);
            if (category == null)
            {
                return NotFound();
            }
            categories.Remove(category);
            return RedirectToAction(nameof(Index));
        }
    }
}
