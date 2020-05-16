using FitNightSnackMgr.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitNightSnackMgr.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FitNightSnackMgrContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FitNightSnackMgrContext>>()))
            {
                // Look for any movies.
                if (!context.Admin.Any())
                {
                    context.Admin.AddRange(
                        new Admin() { LoginAccount = "admin", PassWord = "112233", CreateTime = DateTime.Now }
             );
                    context.SaveChanges();
                }


            }
        }
    }
}
