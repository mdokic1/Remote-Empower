using System;
using DigitalNomads.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DigitalNomads.Areas.Identity.IdentityHostingStartup))]
namespace DigitalNomads.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CtrlAltDefeatDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CtrlAltDefeatDbContext")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<CtrlAltDefeatDbContext>();
            });
        }
    }
}