using AB205.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace AB205.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
           GroupName group1 = new GroupName() { 
           Id = 1,
           GName = "AB205"
           };
            GroupName group2 = new GroupName() { 
           Id = 2,
           GName = "AB108"
           };

            List<GroupName> groups = new List<GroupName>() { group1, group2 };
            return View(groups);
          
        }
    }
}
