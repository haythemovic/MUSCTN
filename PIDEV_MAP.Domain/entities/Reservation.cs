using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSCTN.Domain.entities
{
    public class Reservation
    {

        public int id;
        public Product prod { get; set; }
        public User usr { get; set; }
        public DateTime dat { get; set; }
        public string stat { get; set; }

    }
}
