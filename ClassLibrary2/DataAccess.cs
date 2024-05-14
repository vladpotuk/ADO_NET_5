using Microsoft.EntityFrameworkCore;
using ADO_NET_4.Models;
using System.Collections.Generic;
using System.Xml;

namespace ADO_NET_4.DataAccess
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<MyEntity> MyEntities { get; set; }
    }
}
