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
    internal class Instructors_Configurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(C=>C.InstructorId);
            builder.Property(C => C.InstructorId).UseIdentityColumn();
            builder.Property(C => C.FullName).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(C => C.Email).HasColumnType("nvarchar(150)").IsRequired();
            builder.HasIndex(C => C.Email).IsUnique();
            builder.Property(C => C.Phone).HasColumnType("nvarchar(20)").IsRequired(false);
            builder.Property(C => C.HireDate).HasColumnType("date").IsRequired();


        }
    }
}
