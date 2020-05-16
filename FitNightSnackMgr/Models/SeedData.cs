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
                        new Admin() { LoginAccount = "admin",AdminName="刘德华", PassWord = "112233", CreateTime = DateTime.Now, Permissions = 0 },
                        new Admin() { LoginAccount = "worker1", AdminName = "蔡徐坤", PassWord = "112233", CreateTime = DateTime.Now, Permissions = 1 },
                        new Admin() { LoginAccount = "worker2", AdminName = "罗志祥", PassWord = "112233", CreateTime = DateTime.Now, Permissions = 1 }
             );
                    context.SaveChanges();
                }


            }
        }
    }
}
