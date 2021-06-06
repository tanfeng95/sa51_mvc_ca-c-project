using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorWshop.Data;
using RazorWshop.Models;

namespace RazorWshop.Controllers
{
    public class LogoutController : Controller
    {
        private readonly Team5_Db db;

        public LogoutController(Team5_Db db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            string sessionId = HttpContext.Request.Cookies["sessionId"];
            db.Sessions.Remove(new Session()
            {
                Id = sessionId
            });

            // ask browser to remove the user's sessionId
            // the next time the browser will not send us any
            // sessionId for this user
            HttpContext.Response.Cookies.Delete("sessionId");

            // direct user back to our default gallery
            return RedirectToAction("Index", "Gallery");
        }
    }
}
