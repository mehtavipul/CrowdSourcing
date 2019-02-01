using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SE.Catalog.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SE.Catalog.Repository.Seeding
{
    public class DeviceFamilyData
    {
        public static void Seed(EntityTypeBuilder<DeviceFamily> modelBuilder)
        {
            modelBuilder.HasData(new DeviceFamily
            {
                CreatedOn = DateTime.Now,
                Description = "Device Family 2 Description",
                Id = 1,
                LastModified = DateTime.Now,
                Name = "Device Family 2"
            });
            modelBuilder.HasData(new DeviceFamily
            {
                CreatedOn = DateTime.Now,
                Description = "Device Family 1 Description",
                Id = 1,
                LastModified = DateTime.Now,
                Name = "Device Family 1"
            });
            modelBuilder.HasData(new DeviceFamily
            {
                CreatedOn = DateTime.Now,
                Description = "Device Family 3 Description",
                Id = 1,
                LastModified = DateTime.Now,
                Name = "Device Family 3"
            });
        }
    }
}
