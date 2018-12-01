using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace InfoSys.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService _studentService;
        // GET: Student
        public StudentController()
        {
            _studentService = new StudentService();
        }

        public async Task<ActionResult> Index()
        {
            var students = await _studentService.GetStudents();
            return View(students);
        }
        public ActionResult AddStudent()
        {
            return View();
        }
        public ActionResult EditStudent()
        {
            return View();
        }
        public ActionResult DeleteStudent()
        {
            return RedirectToAction("Index");
        }
    }
}