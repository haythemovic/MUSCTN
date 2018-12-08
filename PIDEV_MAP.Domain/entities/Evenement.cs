using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSCTN.Domain.entities
{
    public class Evenement
    {


        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<User> Users { get; set; }



    }
}
