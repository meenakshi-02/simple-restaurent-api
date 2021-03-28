using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace restaurent.Models
{
    public class Customer
    {
        public int Id { get; set; }      
        public string Name { get; set; }
        public string Phone { get; set; }
        //nav
        public Order Order { get; set; }
        public Transaction Transaction { get; set; }

    }
}
