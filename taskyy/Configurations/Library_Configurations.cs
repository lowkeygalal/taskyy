using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using taskyy.Models;

namespace taskyy.Configurations
{
    internal class Library_Configurations : IEntityTypeConfiguration<Library>
    {
        public void Configure(EntityTypeBuilder<Library> builder)
        {
            builder.HasKey(C=>C.LibraryId);
            builder.Property(C => C.LibraryId).UseIdentityColumn();
            builder.Property(C => C.Name).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(C => C.Location).HasColumnType("nvarchar(200)").IsRequired();

            builder.HasMany(C => C.NavBook).WithOne(X=>X.NavLibrary)
                .HasForeignKey(P=>P.LibraryId).OnDelete(DeleteBehavior.NoAction);


        }
    }
}
