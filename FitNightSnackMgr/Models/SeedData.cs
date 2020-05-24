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
                // Look for any Admin.
                if (!context.Admin.Any())
                {
                    context.Admin.AddRange(
                        new Admin() { LoginAccount = "admin", AdminName = "刘德华", PassWord = "112233", CreateTime = DateTime.Now, Permissions = 0 },
                        new Admin() { LoginAccount = "worker1", AdminName = "蔡徐坤", PassWord = "112233", CreateTime = DateTime.Now, Permissions = 1 },
                        new Admin() { LoginAccount = "worker2", AdminName = "罗志祥", PassWord = "112233", CreateTime = DateTime.Now, Permissions = 1 }
             );
                    context.SaveChanges();
                }


                // Look for any User.
                if (!context.User.Any())
                {
                    context.User.AddRange(
                       new User() { UserAccount = "666666666", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-405",UserName="小刘",Status=1},
                        new User() { UserAccount = "77777777777", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-406", UserName = "小需", Status = 1 },
                         new User() { UserAccount = "888888", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-407", UserName = "小白" , Status = 0 },
                          new User() { UserAccount = "899999", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-408", UserName = "小黑" , Status = 0 },
                           new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六" , Status = 1 },
                            new User() { UserAccount = "2222222", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-410", UserName = "小五" , Status = 0 }
             );
                    context.SaveChanges();
                }


            }
        }
    }
}
