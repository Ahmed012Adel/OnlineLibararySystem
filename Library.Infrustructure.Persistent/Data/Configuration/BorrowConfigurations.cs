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
    internal class BorrowConfigurations : BaseConfiguration<Borrow>
    {
        public override void Configure(EntityTypeBuilder<Borrow> builder)
        {
            base.Configure(builder);
           
            builder.Property(B=>B.BorrowDate)
                .HasColumnType("Date")
                .IsRequired();

            builder.Property(B=>B.ReturnDate)
                .HasColumnType("Date")
                .IsRequired();

            builder.Property(b => b.Status)
            .HasConversion<string>()  // Converts the enum to a string in the database
            .HasColumnType("varchar(20)")
            .IsRequired();

            builder.HasOne(B => B.user)
                   .WithMany()
                   .HasForeignKey(b => b.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(B => B.Book)
                .WithMany()
                .HasForeignKey(B=>B.BookId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
