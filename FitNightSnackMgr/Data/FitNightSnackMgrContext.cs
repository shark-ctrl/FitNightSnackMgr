using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FitNightSnackMgr.Models;

namespace FitNightSnackMgr.Data
{
    public class FitNightSnackMgrContext : DbContext
    {
        public FitNightSnackMgrContext (DbContextOptions<FitNightSnackMgrContext> options)
            : base(options)
        {
            
           
        }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<prepaidCard> prepaidCard { get; set; }

        public DbSet<ShoppingCart> ShoppingCart { get; set; }

        public DbSet<SnackCategory> SnackCategory { get; set; }

        public DbSet<SnackInfo> SnackInfo { get; set; }

        public DbSet<FitNightSnackMgr.Models.User> User { get; set; }


        public DbSet<Order>  Orders { get; set; }


    }
}
