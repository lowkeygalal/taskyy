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
    internal class Department_Configurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(C => C.DepartmentId);
            builder.Property(C => C.DepartmentId).UseIdentityColumn();
            builder.Property(C => C.Name).HasColumnType("nvarchar(200)").IsRequired();
            builder.HasIndex(C => C.Name).IsUnique();
            builder.Property(C => C.OfficeLocation).HasColumnType("nvarchar(100)").IsRequired(false);





            builder.HasMany(C=>C.NavInstructor).WithOne(X=>X.NavDepartment)
                .HasForeignKey(P=>P.DepartmentId);
            builder.HasMany(C=>C.NavCourse).WithOne(X=>X.NavDepartment)
                .HasForeignKey(P=>P.DepartmentId);
            builder.HasOne(C=>C.NavHeadOfDepartment).WithOne(X=>X.NavHeadOfDepartment)
                .HasForeignKey<Department>(P=>P.HeadOfDepartmentId).IsRequired(false);

        }
    }
}
