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
    internal class Student_Configurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne(C => C.NavDepartmentId).WithMany(X=>X.NavStudent)
                .HasForeignKey(P=>P.DepartmentId).OnDelete(DeleteBehavior.NoAction);









            builder.HasKey(C => C.StudentId);
            builder.Property(C=>C.StudentId).UseIdentityColumn();
            builder.Property(C => C.FullName).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(C => C.Email).HasColumnType("nvarchar(150)").IsRequired();
            builder.HasIndex(C => C.Email).IsUnique();
            builder.Property(C => C.Phone).HasColumnType("nvarchar(20)").IsRequired(false);
            builder.Property(C => C.BirthDate).HasColumnType("date").IsRequired();
            builder.Property(C => C.Address).HasColumnType("nvarchar(300)").IsRequired(false);




        }
    }
}
