using Microsoft.AspNetCore.Mvc;
using OgrenciTakipWebApp.Models;
using OgrenciTakipWebApp.Repository;

namespace OgrenciTakipWebApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly Repository.BaseDbContext _baseDbContext;

        public StudentController(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
        }
        public IActionResult Index()
        {
            var students = _baseDbContext.Students.ToList();
            return View(students);

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {

            _baseDbContext.Add(student);

            _baseDbContext.SaveChanges();
            return RedirectToAction("Index", "Student");

        }

        public IActionResult Details(int id)
        {
            Student? student = _baseDbContext.Students.SingleOrDefault(x => x.Id == id);
            return View(student);

        }
        public IActionResult Login()
        {
            return View();
        }

    }
}
