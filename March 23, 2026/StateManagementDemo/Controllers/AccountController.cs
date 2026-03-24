using Microsoft.AspNetCore.Mvc;
using StateManagementDemo.Models;
namespace StateManagementDemo.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //var cookieOptions = new CookieOptions
                //{
                //    Expires = DateTime.Now.AddMinutes(1) // set cookie
                //};

                //Response.Cookies.Append("UserName", model.Username, cookieOptions);

                HttpContext.Session.SetString("UserName", model.Username);

                return RedirectToAction("welcome");
            }

            return View(model);
        }

        public IActionResult Welcome()
        {

            var username = HttpContext.Session.GetString("Username");


            //if (Request.Cookies.ContainsKey("UserName"))
            //{
            //    string username = Request.Cookies["UserName"];
            //    ViewBag.Username = username;
            //}

            if (!String.IsNullOrEmpty(username))
            {
                ViewBag.UserName = username;
            }
           
            else
            {
                return RedirectToAction("Login");
            }
                return View();
        }

        [HttpPost]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("UserName");
            return RedirectToAction("Login");
        }
    }
}
