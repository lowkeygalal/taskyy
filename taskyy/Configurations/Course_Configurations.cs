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
    internal class Course_Configurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(C => C.CourseId);
            builder.Property(C => C.CourseId).UseIdentityColumn();
            builder.Property(C => C.Title).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(C => C.Credits).IsRequired();
            builder.HasCheckConstraint("CheckPositivity", "Credits > 0");


            builder.HasMany(C=>C.NavAssignment).WithOne(X=>X.NavCourse)
                .HasForeignKey(P=>P.CourseId);
            builder.HasMany(C=>C.NavExam).WithOne(X=>X.NavCourse)
                .HasForeignKey(P=>P.CourseId);

        }
    }
}
