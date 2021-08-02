using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ColourSeedConfiguration : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
                 new Colour
                 {
                     Id = 1,
                     CreateBy = "System",
                     DateCreated = DateTime.Now,
                     DateUpdate = DateTime.Now,
                     Name = "Black",
                     UpdateBy = "System"
                 },
                 new Colour
                 {
                     Id = 2,
                     CreateBy = "System",
                     DateCreated = DateTime.Now,
                     DateUpdate = DateTime.Now,
                     Name = "Blue",
                     UpdateBy = "System"
                 }
                 );
        }
    }
}
