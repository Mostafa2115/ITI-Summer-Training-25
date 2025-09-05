using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmentController : Controller
    {
        SchoolContext db = new SchoolContext();
        public IActionResult Index()
        {
            var res = db.departments.ToList();
            return View(res);
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Create(Department dept)
        {
            db.departments.Add(dept);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return BadRequest();
            Department dept = db.departments.FirstOrDefault(d => d.DeptId==id);
            if (dept == null)
                return NotFound();
            return View(dept);
        }

        public IActionResult Update(Department dept)
        {
            db.departments.Update(dept);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
                return BadRequest();
            Department dept = db.departments.FirstOrDefault(d => d.DeptId == id);
            if (dept == null)
                return NotFound();
            return View(dept);

        }
    }
}
