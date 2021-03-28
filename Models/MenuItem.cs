using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurent.Models
{
    public class MenuItem
    {
        public MenuItem()
        {
            this.Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        //nav
        public ICollection<Order> Orders { get; set; }


    }
}
