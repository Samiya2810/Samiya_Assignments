using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCExampleDemo.Models;

namespace MVCExampleDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string sampledemo1()
        {
            return "samiya";
        }

        public string sampledemo2(int age, string name)
        {
            return "The name " + name + " and having age " + age;
        }

        public IActionResult sampledemo3()
        {
            int age = 22;
            string name = "samiya";
            ViewBag.Name = name;
            ViewBag.Age = age;
            ViewData["Message"] = "Welcome to Asp.net core language";
            ViewData["year"] = DateTime.Now.Year;
            return View();
        }

        Employee obj = new Employee()
        {
            EmployeeID = 101,
            EmpName = "samiya",
            Salary = 3400

        };

        
        List<Employee> emplist = new List<Employee>()
        {
            new Employee{EmployeeID=101, EmpName="samiya", Salary=3400, ImageUrl="/Images/bibek_face (1).jpg"},
            new Employee{EmployeeID=102, EmpName="samia", Salary=5400, ImageUrl="/Images/bibek_face2.jpg"},
            new Employee{EmployeeID=103, EmpName="sam", Salary=2400, ImageUrl="/Images/extracted_face.jpg"},
            new Employee{EmployeeID=104, EmpName="sami", Salary=9400, ImageUrl="/Images/extracted_face_0.jpg"},


        };

        public IActionResult collectionobjectpassing()
        {
            return View(emplist);
        }

        public IActionResult singleobjectpassing()
        {

            return View(obj);
        }


        public IActionResult display()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
