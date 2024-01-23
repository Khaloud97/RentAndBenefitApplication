using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RentAndBenefitApplication.DAL.Model
{
  public class ApplicationUser : IdentityUser
    {
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public int Phone { get; set; }

        [MaxLength(50)]
        public string City { get; set; }
   

        public double Latitude { get; set; } // User's latitude
        public double Longitude { get; set; } // User's longitude
                                              // Other properties if needed
    }

}
