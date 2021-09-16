using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;
using MySql.Data.MySqlClient;
using CoffeeShopLabFixed.Models;

namespace CoffeeShopLabFixed.Models
{
    
        [Table("Products")]
        public class Product
        {
            [Key]
            public int productID { get; set; }
            public string productNAME { get; set; }
            public string productDESCRIPTION { get; set; }
            public string productPRICE { get; set; }
            public string productCATEGORY { get; set; }
        }
}
