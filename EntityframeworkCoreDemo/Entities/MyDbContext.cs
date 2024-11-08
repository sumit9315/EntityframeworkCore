using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
//using EntityFrameworkCoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityframeworkCoreDemo.Entities
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine,LogLevel.Information);
            //base.OnConfiguring(optionsBuilder);

            //Method1 to connect to db using hardcoding connection string
            //optionsBuilder.UseSqlServer("Server=ADMINRG-9LOHAID;Database=EfCoreDb;User Id=sa;Password=Silicon@7894;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer("Server=ADMINRG-9LOHAID;Database=EfCoreDb;Trusted_Connection=true;TrustServerCertificate=True");

            var configBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var configSection = configBuilder.GetSection("ConnectionStrings");

            var connectionString = configSection["SQLServerConnection"] ?? null;

            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Branch> Branches { get; set; }


    }
}
