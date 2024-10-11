using Libarary.Domain.Common;
using Libarary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrustructure.Persistent.Data.Configuration
{
    internal class UserConfigurations : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(U => U.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(U => U.Email)
                .IsRequired();

            builder.Property(U => U.Password)
                .IsRequired();

            builder.Property(U => U.role)
                .HasConversion<string>()  // Converts the enum to a string in the database
            .HasColumnType("varchar(20)")
            .IsRequired();

            builder.Property(U=>U.UserStatus)
                    .HasConversion<string>()  // Converts the enum to a string in the database
                    .HasColumnType("varchar(20)")
                    .IsRequired();
        }
    }
}
