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
                            new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 }, new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 },
                            new User() { UserAccount = "11111111", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-409", UserName = "小六", Status = 1 },
                            new User() { UserAccount = "2222222", Password = "abc123132", Money = 100, Phone = "139139139", Address = "A4-410", UserName = "小五" , Status = 0 }
             );
                    context.SaveChanges();
                }


                // Look for any SnackCategory.
                if (!context.SnackCategory.Any())
                {
                    context.SnackCategory.AddRange(
                     
                        
                         new SnackCategory() { CategoryNum=1001,CategoryName="零食",Description="薯片，薯条，方便面等",Status=1},
                         new SnackCategory() { CategoryNum = 1002, CategoryName = "烧烤", Description = "微波炉现烤 热狗 骨肉相连等", Status = 0 }

                        );
                     
                    context.SaveChanges();
                }


                // Look for any SnackInfo.
                if (!context.SnackInfo.Any())
                {
                    SnackInfo[] snackInfos =new SnackInfo[100];
                    for (int i = 0; i < 100; i++)
                    {
                        SnackInfo snackInfo = new SnackInfo()
                        { 
                            ImgUrl = "/images/book2.jpg",
                            Name=$"精神beer{i}",
                            SnackNum=Convert.ToInt32("1002"+i),
                            CategoryId=1002,
                            DetailInfo="精神麻辣烫",
                            Price=100+i,
                            Status=1

                        };
                        snackInfos[i] = snackInfo;
                    }
                    context.SnackInfo.AddRange(snackInfos);

                    context.SaveChanges();
                }




                // Look for any SnackInfo.
                if (!context.Orders.Any())
                {
                    Order[] orders = new Order[100];
                    for (int i = 0; i < 100; i++)
                    {
                        Order temp_order = new Order()
                        {
                           OrderId=DateTime.Now.ToString($"yyyyMMddhhmmss{i}"),
                           Discount=1,
                           OrderDetail="beer*1 smock*3",
                           UserId=26,
                           TotalPrice=100+i,
                           Status=0,
                            CreateTime=DateTime.Now
                           

                        };
                        orders[i] = temp_order;
                    }
                    context.Orders.AddRange(orders);

                    context.SaveChanges();
                }





                // Look for any Card.
                if (!context.prepaidCard.Any())
                {

                    prepaidCard[] cards = new prepaidCard[100];
                    for (int i = 0; i < 100; i++)
                    {
                        prepaidCard card = new prepaidCard()
                        {
                          CardCode=$"ddaa{i}",
                          SecretKey=$"adassad{i}",
                          CardStatus=0,
                          Price=50,
                        UserAccount= "666666666"

                        };
                        cards[i] = card;
                    }
                    context.prepaidCard.AddRange(cards);

                    context.SaveChanges();
                }







            }
        }
    }
}
