using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSCTN.Domain.entities
{
    public class Product
    {

        public int Id { get; set; }
        public virtual ICollection<string> ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Boolean Disponible { get; set; }
        public int nbProdDisp { get; set; }
        public int nbProdVendu { get; set; }
    }
}
