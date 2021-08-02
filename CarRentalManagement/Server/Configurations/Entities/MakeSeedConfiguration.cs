using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                 new Make
                 {
                     Id = 1,
                     CreateBy = "System",
                     DateCreated = DateTime.Now,
                     DateUpdate = DateTime.Now,
                     Name = "Toyota",
                     UpdateBy = "System"
                 },
                 new Make
                 {
                     Id = 2,
                     CreateBy = "System",
                     DateCreated = DateTime.Now,
                     DateUpdate = DateTime.Now,
                     Name = "BMW",
                     UpdateBy = "System"
                 }
                 );
        }
    }
}
