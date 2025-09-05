using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        SchoolContext db = new SchoolContext();
        public IActionResult Index()
        {

            var res = db.students.ToList();
            return View(res);
        }
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Create(Student s)
        {
            db.students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return BadRequest();
            Student stu = db.students.FirstOrDefault(s => s.Id == id);
            if (stu == null)
                return NotFound();
            return View(stu);
        }

        public IActionResult Update(Student s)
        {
            db.students.Update(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
                return BadRequest();
            Student stu = db.students.FirstOrDefault(s => s.Id == id);
            if(stu == null)
                return NotFound();
            return View(stu);

        }
    }
}
