using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurent.Dto
{
    public class OrderReadDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string CreatedDateTime { get; set; }
        public string servedDateTime { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
        public bool ReadyToServe { get; set; }
        public bool IsActive { get; set; }
    }
}
