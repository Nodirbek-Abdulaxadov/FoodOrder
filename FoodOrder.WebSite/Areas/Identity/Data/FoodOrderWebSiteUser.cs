using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrder.Models;
using Microsoft.AspNetCore.Identity;

namespace FoodOrder.WebSite.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the FoodOrderWebSiteUser class
    public class FoodOrderWebSiteUser : IdentityUser
    {
        public List<Mahsulot> Korzinka { get; set; }
    }
}
