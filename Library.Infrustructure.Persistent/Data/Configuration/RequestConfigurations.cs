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
        internal class RequestConfigurations :BaseConfiguration<RequestBook>
        {
            public override void Configure(EntityTypeBuilder<RequestBook> builder)
            {
                base.Configure(builder);

                builder.Property(R=>R.status)
                        .HasConversion<string>()  // Converts the enum to a string in the database
                        .HasColumnType("varchar(20)")
                        .IsRequired();
        
            builder.HasOne(R => R.user)
                       .WithMany()
                       .HasForeignKey(r => r.UserId)
                       .OnDelete(DeleteBehavior.Cascade);
                  
                builder.HasOne(r => r.Book)
                    .WithMany()
                    .HasForeignKey(r => r.BookId)
                    .OnDelete(DeleteBehavior.Cascade);
            }
        }
    }
