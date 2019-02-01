using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SE.Catalog.Models;
using SE.Catalog.Repository.Seeding;

namespace SE.Catalog.Repository.DbMap
{
    public class DeviceFamilyMap : IEntityTypeConfiguration<DeviceFamily>
    {
        public void Configure(EntityTypeBuilder<DeviceFamily> builder)
        {
            DeviceFamilyData.Seed(builder);
        }
    }
}
