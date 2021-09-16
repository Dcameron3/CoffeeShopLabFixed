using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using CoffeeShopLabFixed.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace CoffeeShopLabFixed.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            MySqlConnection db = new MySqlConnection("Server=localhost;Database=coffeeshop;Uid=root;Password=abc123");
            List<Product> prods = db.GetAll<Product>().ToList();

            return View(prods);
        }
        public IActionResult Detail(int pr)
        {
            MySqlConnection db = new MySqlConnection("Server=localhost;Database=coffeeshop;Uid=root;Password=abc123");
            Product prod = db.Get<Product>(pr);
            return View(prod);
        }
    }
}
