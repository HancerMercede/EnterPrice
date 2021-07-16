using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterPrice.Entities
{
    public class Building
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string Cuality { get; set; }
        public string Category { get; set; }
    }
}
