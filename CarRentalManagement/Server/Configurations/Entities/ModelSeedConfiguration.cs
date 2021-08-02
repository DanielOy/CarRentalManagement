using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                 new Model
                 {
                     Id = 1,
                     CreateBy = "System",
                     DateCreated = DateTime.Now,
                     DateUpdate = DateTime.Now,
                     Name = "Prius",
                     UpdateBy = "System"
                 },
                 new Model
                 {
                     Id = 2,
                     CreateBy = "System",
                     DateCreated = DateTime.Now,
                     DateUpdate = DateTime.Now,
                     Name = "Vitz",
                     UpdateBy = "System"
                 },
                  new Model
                  {
                      Id = 3,
                      CreateBy = "System",
                      DateCreated = DateTime.Now,
                      DateUpdate = DateTime.Now,
                      Name = "3 Series",
                      UpdateBy = "System"
                  },
                 new Model
                 {
                     Id = 4,
                     CreateBy = "System",
                     DateCreated = DateTime.Now,
                     DateUpdate = DateTime.Now,
                     Name = "X5",
                     UpdateBy = "System"
                 }
                 );
        }
    }
}
