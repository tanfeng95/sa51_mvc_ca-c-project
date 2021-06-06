using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorWshop.Data;
using RazorWshop.Models;

namespace RazorWshop.Controllers
{
    public class GalleryController : Controller
    {
        private readonly Team5_Db db;

        public GalleryController(Team5_Db db)
        {
            this.db = db;
        }

        public IActionResult Index(string searchString)
        {
            string sessionId = Request.Cookies["sessionId"];
            ViewData["sessionId"] = sessionId;
            Session session = db.Sessions.FirstOrDefault(x => x.Id == sessionId);
            if (session != null)
            {
                int userid = session.UserId;
                ViewData["User"] = db.Users.FirstOrDefault(x => x.UserId == userid);
            }
            ViewData["Is_Search"] = "menu_hilite";
            ViewData["Products"] = db.Products.Where(s => (s.Name.Contains(searchString) || s.Description.Contains(searchString)) || searchString == null).ToList();



            return View();
        }
    }
}
