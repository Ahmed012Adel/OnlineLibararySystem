using Libarary.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrustructure.Persistent.Data.Configuration
{
    internal class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(E=>E.Id).UseIdentityColumn();

            builder.Property(E => E.CreatedOn)
                .HasColumnType("DATE")
                .HasDefaultValueSql("GETDATE()");
            
            builder.Property(E => E.LastModifiedOn)
                .HasColumnType("DATE")
                .HasDefaultValueSql("GETDATE()");


        }
    }
}
