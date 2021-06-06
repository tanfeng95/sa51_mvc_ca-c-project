using CA_practice.Models;
using RazorWshop.Data;
using RazorWshop.Entity;
using System;

namespace RazorWshop.Models
{
    public class ActivationC
    {
        public static void addActivationCode(Cart cart, Team5_Db db)
        {
            for (int i = 0; i < cart.Quantity; i++)
            {
                OrderDetail order = new OrderDetail
                {
                    ActivationCode = Guid.NewGuid().ToString().Substring(3, 15),
                    UserId = cart.UserId,
                    ProductId = cart.ProductId,
                    PurchaseDate = DateTime.Now
                };

                db.Add(order);
                db.SaveChanges();
            }

            return;
        }
    }
}
