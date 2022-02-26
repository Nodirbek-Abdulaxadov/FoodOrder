using System;
using FoodOrder.WebSite.Areas.Identity.Data;
using FoodOrder.WebSite.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FoodOrder.WebSite.Areas.Identity.IdentityHostingStartup))]
namespace FoodOrder.WebSite.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FoodOrderWebSiteContext>(options =>
                    options.UseNpgsql(
                        context.Configuration.GetConnectionString("PostgreDB")));

                services.AddDefaultIdentity<FoodOrderWebSiteUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<FoodOrderWebSiteContext>();
            });
        }
    }
}