using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SE.Catalog.Models;
using System;

namespace SE.Catalog.Repository.Seeding
{
    public class PackageData
    {
        public static void Seed(EntityTypeBuilder<Package> modelBuilder)
        {
            modelBuilder.HasData(new Package
            {
                CreatedOn = DateTime.Now,
                HWVersion = "1.0.0.0",
                Id = 1,
                LastModified = DateTime.Now,
                Name = "Package 1",
                ProductId = "Product Id 1",
                ProductName = "Product Name 1",
                ProfileType = "Profile 1",
                Status = WorkFlowStatus.Pending,
                SWVersion = "1.0.0.0",
                UploadDate = DateTime.Now,                
                ProductFamilyId = 1,
                DeviceFamilyId = 1
            });

            modelBuilder.HasData(new Package
            {
                CreatedOn = DateTime.Now,                
                HWVersion = "1.0.0.0",
                Id = 1,
                LastModified = DateTime.Now,
                Name = "Package 2",                
                ProductId = "XX:X:XX:22",
                ProductName = "Product Name 2",
                ProfileType = "Profile 2",
                Status = WorkFlowStatus.Pending,
                SWVersion = "1.0.0.0",
                UploadDate = DateTime.Now,                
                ProductFamilyId = 1,
                DeviceFamilyId = 1
            });

            modelBuilder.HasData(new Package
            {
                CreatedOn = DateTime.Now,                
                HWVersion = "1.0.0.0",
                Id = 1,
                LastModified = DateTime.Now,
                Name = "Package 3",                
                ProductId = "XX:X:XX:33",
                ProductName = "Product Name 3",
                ProfileType = "Profile 3",
                Status = WorkFlowStatus.Pending,
                SWVersion = "1.0.0.0",
                UploadDate = DateTime.Now,                
                ProductFamilyId = 1,
                DeviceFamilyId = 1
            });
        }
    }
}
