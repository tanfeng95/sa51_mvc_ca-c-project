using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RazorWshop.Models;

namespace RazorWshop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Gallery()
        {
            string[] imgs = {
                "photo-1593642632559-0c6d3fc62b89",
                "photo-1497366754035-f200968a6e72",
                "photo-1497366811353-6870744d04b2",
                "photo-1524758631624-e2822e304c36",
                "photo-1531973576160-7125cd663d86",
                "photo-1505409859467-3a796fd5798e"
            };

            string[] pdt_name =
            {
                ".NET Charts",
                ".NET PayPal",
                ".NET ML",
                ".NET Analytics",
                ".NET Logger",
                ".NET Numerics",
            };

            string[] descr =
{
                "Brings powerful charting capabilities to your .NET applications.",
                "Integerate you .NET apps with PayPal the easy way!",
                "Supercharged .NET machine learning libraries",
                "Performs data mining and analytics easily in .NET.",
                "Logs and aggregates events easily in your .NET appls.",
                "Powerful numerical methods for your .NET simulations.",
            };

            double[] p =
            {
                99, 
                69, 
                299,
                299,
                49, 
                199
            };

            ViewData["images"] = imgs;
            ViewData["url_prefix"] = "https://images.unsplash.com/";
            ViewData["url_postfix"] = "?w=350";
            ViewData["product_name"] = pdt_name;
            ViewData["price"] = p;
            ViewData["description"] = descr;
            ViewData["Is_Home"] = "menu_hilite";

            ViewData["sessionId"] = Request.Cookies["sessionId"];

            return View();
        }

        public IActionResult ViewCart()
        {
            string[] imgs = {
                "photo-1593642632559-0c6d3fc62b89",
                "photo-1497366754035-f200968a6e72",
                "photo-1497366811353-6870744d04b2"
            };

            string[] pdt_name =
            {
                ".NET Charts",
                ".NET PayPal",
                ".NET ML"
            };

            string[] descr =
{
                "Brings powerful charting capabilities to your .NET applications.",
                "Integerate you .NET apps with PayPal the easy way!",
                "Supercharged .NET machine learning libraries"
            };

            double[] p =
            {
                99,
                69,
                299
            };

            ViewData["images"] = imgs;
            ViewData["url_prefix"] = "https://images.unsplash.com/";
            ViewData["url_postfix"] = "?w=350";
            ViewData["product_name"] = pdt_name;
            ViewData["price"] = p;
            ViewData["description"] = descr;
            ViewData["Is_Home"] = "menu_hilite";

            return View();
        }

        public IActionResult MyPurchases()
        {
            string[] imgs = {
                "photo-1593642632559-0c6d3fc62b89",
                "photo-1497366754035-f200968a6e72",
                "photo-1497366811353-6870744d04b2"
            };

            string[] pdt_name =
            {
                ".NET Charts",
                ".NET PayPal",
                ".NET ML"
            };

            string[] descr =
            {
                "Brings powerful charting capabilities to your .NET applications.",
                "Integerate you .NET apps with PayPal the easy way!",
                "Supercharged .NET machine learning libraries"
            };

            string[] date =
            {
                "8 Apr 2019",
                "8 Apr 2019",
                "12 Dec 2018"
            };

            string[] ac =
            {
                "e2290-124-ggat-001,e2290-124-ggat-002",
                "e0101-212-abvc-003",
                "e1234-123-erog-001"
            };

            ViewData["images"] = imgs;
            ViewData["url_prefix"] = "https://images.unsplash.com/";
            ViewData["url_postfix"] = "?w=350";
            ViewData["product_name"] = pdt_name;
            ViewData["description"] = descr;
            ViewData["date"] = date;
            ViewData["activation_code"] = ac;
            ViewData["Is_Home"] = "menu_hilite";

            return View();
        }
    }
}
