using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SE.Catalog.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SE.Catalog.Repository.Seeding
{
    public class ProductFamilyData
    {
        public static void Seed(EntityTypeBuilder<ProductFamily> modelBuilder)
        {
            modelBuilder.HasData(new ProductFamily
            {
                CreatedOn = DateTime.Now,
                Description = "Product Family description 1",
                Id = 1,
                LastModified = DateTime.Now,
                Name = "Product Family 1"
            });

            modelBuilder.HasData(new ProductFamily
            {
                CreatedOn = DateTime.Now,
                Description = "Product Family description 2",
                Id = 1,
                LastModified = DateTime.Now,
                Name = "Product Family 2"
            });
            modelBuilder.HasData(new ProductFamily
            {
                CreatedOn = DateTime.Now,
                Description = "Product Family description 3",
                Id = 1,
                LastModified = DateTime.Now,
                Name = "Product Family 3"
            });

        }
    }
}
