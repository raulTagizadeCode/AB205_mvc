using AB205.Models;
using Microsoft.AspNetCore.Mvc;

namespace AB205.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
          Student student1 = new Student()
          {
              Id = 1,
              Name = "Raul",
              Email = "raultagizade9@gmail.com"
              
          };
            Student student2 = new Student()
            {
                Id = 2,
                Name = "fikret",
                Email = "fikret@gmail.com"

            };
            List<Student> students = new List<Student>() { student1, student2 };

            return View(students);
        }
    }
}
