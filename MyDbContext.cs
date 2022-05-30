using MauiApp2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2
{

    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            try
            {
                SQLitePCL.Batteries_V2.Init();

                this.Database.EnsureCreated();
            }
            catch (Exception ex)
            {

            }
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
