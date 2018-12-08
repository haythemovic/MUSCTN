using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSCTN.Domain.entities
{
    public class Secteur
    {

        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string SecteurName { get; set; }
        public string Local { get; set; }
        public DateTime FoundationDate { get; set; }
        public virtual ICollection<User> Membres { get; set; }

    }
}
