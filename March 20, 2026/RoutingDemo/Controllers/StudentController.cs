using Microsoft.AspNetCore.Mvc;
using RoutingDemo.Models;
namespace RoutingDemo.Controllers
{
    public class StudentController : Controller
    {
        List<Student> studlist = new List<Student>()
        {
            new Student{Id=101,Name="Kiran",Class="class4"},
            new Student{Id=102,Name="mohan",Class="class5"},
            new Student{Id=103,Name="nitika",Class="class9"},
        };
        [Route("studs")]
        public IActionResult GetAllStudents()
        {
            return View(studlist);
        }

        [Route("studs/{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = studlist.FirstOrDefault(x => x.Id == id);
            return View(student);
        }

        [Route("studsfew")]
        public IActionResult fewcolumns()
        {
            var fewcolumns = studlist.Select(x => new
            {
                Class = x.Class,
                Name = x.Name,


            });

            return View(fewcolumns);
        }
    }
}
