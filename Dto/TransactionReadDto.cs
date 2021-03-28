using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurent.Dto
{
    public class TransactionReadDto
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string DateTime { get; set; }
    }
}
