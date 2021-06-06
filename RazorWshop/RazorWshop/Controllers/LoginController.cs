using System;
using System.Collections.Generic;
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
    public class LoginController : Controller
    {
        //get the database and cartitems of guests
        private Team5_Db db;
        private CartItems cartitems;

        public LoginController(Team5_Db db, CartItems cartitems)
        {
            this.db = db;
            this.cartitems = cartitems;
        }

        public IActionResult Login()
        {
            ViewData["Is_Login"] = "menu_hilite";
            return View();
        }

        public IActionResult Authenticate(string username, string password)
        {
            User user = db.Users.FirstOrDefault(x => x.Username == username
            && x.Password == password);

            if (user == null)
            {
                ViewData["Is_Login"] = "menu_hilite";
                ViewData["errMsg"] = "no such user or incorrect password";
                return View("Login");
            }
            else
            {
                Session session = new Session()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserId = user.UserId,
                    Timestamp = DateTimeOffset.Now.ToUnixTimeSeconds()
                };
                db.Sessions.Add(session);
                db.SaveChanges();

                Response.Cookies.Append("sessionId", session.Id);

                string fakeUserId = HttpContext.Request.Cookies["cartItems"];//a cookie sent to recognize the guest who added to cart

                //If the user added something into the cart before login, the following steps will help to add into the table accordingly
                if (fakeUserId != null)
                {
                    List<Cart> carts = db.Carts.Where(x => x.UserId == session.UserId).ToList();

                    CartItem cartitem = cartitems.map[fakeUserId];
                    //get the cartitem added by the guest previously
                    //inside cartitem class is a list of KeyValuePair of <int,int> --> can refer to the cartitem class file for more information
                    //KeyValuePair is used to store the productid and quantity of each of the products.

                    foreach (KeyValuePair<int, int> keyValue in cartitem.item)
                    {
                        bool newItem = true;
                        foreach (Cart cart in carts)//loop through the user's database cart for each of the KeyValuePair
                        {
                            if (cart.ProductId == keyValue.Key)
                            {
                                newItem = false;
                            }
                        }
                        if (carts.Count() == 0 || newItem == true)//if its a new item or if the user's cart in database is empty
                        {
                            Cart item = new Cart //create the cart and save into the database accordingly
                            {
                                UserId = session.UserId,
                                ProductId = keyValue.Key,
                                Quantity = keyValue.Value
                            };
                            db.Add(item);
                            db.SaveChanges();
                        }
                        else //else if its not a new item
                        {
                            foreach (Cart item in carts) //update the quantity in the database accordingly
                            {
                                if (item.ProductId == keyValue.Key)
                                {
                                    item.Quantity = item.Quantity + keyValue.Value;
                                    db.SaveChanges();
                                }
                            }
                        }
                    }
                    HttpContext.Response.Cookies.Delete("cartItems"); //delete the cookie that was used to track the guest(fakeUserId)
                    return RedirectToAction("Cart", "Cart");
                }

                Response.Cookies.Append("username", username);
                return RedirectToAction("Index", "Gallery");
            }
        }
    }
}
