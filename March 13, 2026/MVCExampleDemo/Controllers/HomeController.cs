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

        public IActionResult Details(int id)
        {
            var employee = emplist.FirstOrDefault(e => e.EmployeeID == id);
            if(employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        public IActionResult searchemp(int empid)
        {
            Employee emp = (from e1 in emplist where e1.EmployeeID == empid select e1).FirstOrDefault();
            return View(emp);
        }

        List<Dept> deptlist = new List<Dept>()
     {
         new Dept{DeptID=10,DeptName="Sales"},
         new Dept{DeptID=20,DeptName="HR"},
         new Dept{DeptID=30,DeptName="Software"}
     };

        public IActionResult mixedobjectpassing(int empid)
        {
            var query1 = deptlist.ToList();
            Employee emp = emplist.Where(x => x.EmployeeID == empid).FirstOrDefault();
            var query2 = emp;
            EmpdeptViewModel obj = new EmpdeptViewModel()
            {
                deptlist= query1,
                emp = query2,
                date=DateTime.Now,
            };
            return View(obj);
        }
        List<Employee> emplist = new List<Employee>()
        {
            new Employee{EmployeeID=101, EmpName="samiya", Salary=3400, ImageUrl="/Images/bibek_face (1).jpg", DeptID=30},
            new Employee{EmployeeID=102, EmpName="samia", Salary=5400, ImageUrl="/Images/bibek_face2.jpg",DeptID=20},
            new Employee{EmployeeID=103, EmpName="sam", Salary=2400, ImageUrl="/Images/extracted_face.jpg",DeptID=10},
            new Employee{EmployeeID=104, EmpName="sami", Salary=9400, ImageUrl="/Images/extracted_face_0.jpg",DeptID=10},


        };

        public IActionResult collectionofdepts()
        {
            return View(deptlist);
        }

        public IActionResult EmpsInDept(int deptid)
        {
            var employees = emplist.Where(e => e.DeptID == deptid).ToList();
            return View(employees);
            //return View();
        }

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
