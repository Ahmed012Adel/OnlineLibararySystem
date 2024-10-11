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
    internal class BookConfiguration : BaseConfiguration<Book>
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            base.Configure(builder);

            builder.Property(B=>B.ISBN)
                .ValueGeneratedOnAdd()
                .IsRequired();
        }

    }
}
