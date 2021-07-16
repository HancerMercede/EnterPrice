using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterPrice.Entities
{
    public class Asigment
    {
        public int Id { get; set; }
        public virtual Building Building  { get; set; }
        public int BuildingId { get; set; }
        public virtual Worker Worker { get; set; }
        public int WorkerId { get; set; }
        public DateTime StartDate { get; set; }
        public int Days { get; set; }
    }
}
