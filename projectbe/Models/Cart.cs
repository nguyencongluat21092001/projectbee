using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectbe.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }

    }
}

