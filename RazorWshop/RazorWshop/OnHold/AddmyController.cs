/*using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorWshop.Data;
using RazorWshop.Models;

namespace RazorWshop.Controllers
{
    public class AddController : Controller
    {
        protected static readonly string connectionString = "Server = LAPTOP-SOVKQ9D5;" +
                                                              "Database = GDipSA51_MVC_CA;" +
                                                              "Integrated Security = true;";
        public static List<Product> ShowCart()
        {
            List<Product> proList = new List<Product>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"select * from Cart_User1";
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader read = comm.ExecuteReader();
                while (read.Read())
                {
                    Product pro = new Product()
                    {
                        User_id = (string)read["User_id"],
                        Barcode = (int)read["Barcode"],
                        Name = (string)read["Name"],
                        Description = (string)read["Description"],
                        Price = (int)read["Price"],
                        Image = (string)read["Image"],
                        Quantity = (int)read["Quantity"]
                    };
                    proList.Add(pro);
                }
                conn.Close();
            }
            return proList;
        }

        public static void Add()
        {
            List<Product> sample = DbCart.ShowCart();
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string sql = @"Insert into OrderDetail (User_id,Barcode,Order_date) values (@User_id,@Barcode,@Order_date)";
                SqlCommand command = new SqlCommand(sql, connect);
                for (int i = 0; i < sample.Count; i++)
                {
                    command.Parameters.AddWithValue("@User_id", sample[i].User_id);
                    command.Parameters.AddWithValue("@Barcode", sample[i].Barcode);
                    command.Parameters.AddWithValue("@Order_date", DateTime.Now);
                }

                var userid = 1;
                string sql1 = @"Delete from Cart_User1 where User_id = " + userid;
                SqlCommand command1 = new SqlCommand(sql1, connect);

                command.ExecuteNonQuery();
            }
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}*/
