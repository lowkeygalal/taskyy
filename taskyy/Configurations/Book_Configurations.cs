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
    internal class Book_Configurations : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(C => C.BookId);
            builder.Property(C => C.BookId).UseIdentityColumn();
            builder.Property(C => C.Title).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(C => C.Author).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(C => C.ISBN).HasColumnType("nvarchar(20)").IsRequired();
            builder.HasIndex(C => C.ISBN).IsUnique();
        }
    }
}
