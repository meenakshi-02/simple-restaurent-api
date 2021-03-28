using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace restaurent.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int FkCustomerId { get; set; }
        //nav
        public Customer Customer { get; set; }
        public int FkMenuItemId { get; set; }
        //nav
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }
        public string CreatedDateTime { get; set; }
        public string servedDateTime { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
        public bool ReadyToServe { get; set; }
        public bool IsActive { get; set; }

    }
}
