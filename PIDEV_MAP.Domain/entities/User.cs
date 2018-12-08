using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MUSCTN.Domain.entities
{
    public class User : IdentityUser<int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        public Boolean Motorisé { get; set; }
        public int age { get; set; }
        public int num_tel { get; set; }
        public Secteur MySecteur { get; set; }
        public string Localisation { get; set; }

        public string Link_fb { get; set; }
        public string Link_tw { get; set; }
        public string Link_ig { get; set; }

        public string Role { get; set; }
       // public DateTime CreationDate = DateTime.Now;

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User, int> manager)
        {
            // Note the authenticationType must match the one defined in
            // CookieAuthenticationOptions.AuthenticationType 
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here 
            return userIdentity;
        }
    }

    public class CustomUserLogin : IdentityUserLogin<int>
    {
        public int Id { get; set; }

    }
    public class CustomUserRole : IdentityUserRole<int>
    {
        public int Id { get; set; }
    }
    public class CustomUserClaim : IdentityUserClaim<int>
    {

    }

    public class CustomRole : IdentityRole<int, CustomUserRole>
    {
        public CustomRole() { }
        public CustomRole(string name) {
            Name = name;
        
}
    }


}
    

