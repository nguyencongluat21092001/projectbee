using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectbe.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public string Price { get; set; }
    }
}
