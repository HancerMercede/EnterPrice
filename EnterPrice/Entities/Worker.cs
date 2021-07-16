using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterPrice.Entities
{
    public class Worker
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public double SalaryPerHour { get; set; }
        public string Job { get; set; }
        public virtual SuperVisor SuperVisor { get; set; }
        public int SuperVisorId { get; set; }
    }
}
