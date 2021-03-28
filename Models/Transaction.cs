using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurent.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int FkCustomerId { get; set; }
        //nav
        public Customer Customer { get; set; }
        public int Price { get; set; }
        public string DateTime { get; set; }
       
    }
}
