using AB205.Models;
using Microsoft.AspNetCore.Mvc;

namespace AB205.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            Teacher teacher1 = new Teacher() { 
                Id = 1,
            Name = "Test",
            Email="Test@gmail.com",
            Description= "Test Test"
            };
            Teacher teacher2 = new Teacher()
            {
                Id = 2,
                Name = "Testi",
                Email = "nshiva@gmail.com",
                Description = "Helo"
            };

            List<Teacher> teachers = new List<Teacher> { teacher1, teacher2 };
            
            return View(teachers);
        }
    }
}
