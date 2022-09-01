using System;
using Microsoft.EntityFrameworkCore;
namespace MobilePhoneStore.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public virtual DbSet<Mobile> Mobiles { get; set; }
    }
}
