using Microsoft.AspNet.Identity.EntityFramework;
using MUSCTN.Domain.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MUSCTN.Domain.entities.User;


namespace MUSCTN.Data
{
   public class MapContext : IdentityDbContext<User, CustomRole, int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {

        public MapContext():base("MUSCTN_DB")
        {
        }

        public new string[] Roles = { "Resource", "Applicant", "Customer" };
        public static MapContext Create()
        {
            return new MapContext();
        }

      
        //public DbSet<User> UserS { get; set; }

     






        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
 

        }

        }
}
