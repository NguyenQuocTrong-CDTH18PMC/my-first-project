using Microsoft.EntityFrameworkCore;
using ProjectCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCodeFirst.Data
{
    public class ShopgiayDBContext:DbContext
    {

        public ShopgiayDBContext(DbContextOptions<ShopgiayDBContext> options):base(options)
        {

        }


        public DbSet<Account> Accounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> Order_Details { get; set; }
    }
}
