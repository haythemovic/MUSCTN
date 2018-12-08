using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSCTN.Domain.entities
{
   public class Article
    {


        public int Id { get; set; }

        public DateTime CreationDate = DateTime.Now;
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        
        public string Description { get; set; }




    }
}
