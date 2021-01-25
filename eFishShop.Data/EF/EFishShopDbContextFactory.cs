using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eFishShop.Data.EF
{
    public class EFishShopDbContextFactory : IDesignTimeDbContextFactory<eFishShopDbContext>
    {
        eFishShopDbContext IDesignTimeDbContextFactory<eFishShopDbContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("eFishShop");

            var optionsBuilder = new DbContextOptionsBuilder<eFishShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new eFishShopDbContext(optionsBuilder.Options);
        }
    }
}
