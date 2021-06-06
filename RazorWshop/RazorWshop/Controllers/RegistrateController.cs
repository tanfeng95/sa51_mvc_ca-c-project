using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using CA_practice.Models;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RazorWshop.Data;
using RazorWshop.Models;
namespace RazorWshop.Controllers
{
    public class RegistrateController : Controller
    {
        private readonly Team5_Db db;

        public RegistrateController(Team5_Db db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Authenticate(string username, string NewPWD, string ConfirmedPWD)
        {
            User user = db.Users.FirstOrDefault(x => x.Username == username);
            if (user == null)
            {
                if (NewPWD == ConfirmedPWD)
                {
                    User users = new User()
                    {
                        Username = username,
                        Password = NewPWD,
                    };
                    db.Add(users);
                    db.SaveChanges();
                    return RedirectToAction("Login", "Login");
                }
                else
                {
                    ViewData["errMsg"] = "Please enter a consistent password";
                    return View("Index");
                }
            }
            else
            {
                ViewData["errMsg"] = "user has existed";
                return View("Index");
            }

           
        }
    }
    
}