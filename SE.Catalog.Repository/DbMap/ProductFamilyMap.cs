using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SE.Catalog.Models;
using SE.Catalog.Repository.Seeding;
using System;
using System.Collections.Generic;
using System.Text;

namespace SE.Catalog.Repository.DbMap
{
    public class ProductFamilyMap : IEntityTypeConfiguration<ProductFamily>
    {
        public void Configure(EntityTypeBuilder<ProductFamily> builder)
        {
            ProductFamilyData.Seed(builder);
        }
    }
}
