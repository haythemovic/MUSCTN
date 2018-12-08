using MUSCTN.Data;
using MUSCTN.Domain.entities;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV8MAP
{
     public class Program
    {
        static void Main(string[] args)
        {
           
           /* User u = new User()
            {
                LastName = "jebari",
                FirstName = "mayssa",
                Login="test",
                Password="pffffff",
                Address = "benarouss",
                DateOfBirth = new DateTime(0080, 10, 10),
                TelephoneNumber = "12584",
                ImageUrl = "url"
                
             
              
                
            };*/


            MapContext ctx  = new MapContext();
            //ctx.UserS.Add(u);



            ctx.SaveChanges();
            Console.WriteLine("Base Created with succes ");
            Console.ReadKey();
       


         
        }
    }
}
