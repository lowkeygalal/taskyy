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
    internal class Enrollment_Configurations : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasOne(C => C.NavStudent).WithMany(X => X.NavEnrollment)
                .HasForeignKey(P => P.StudentId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(C => C.NavCourse).WithMany(X => X.NavEnrollment)
                .HasForeignKey(P => P.CourseId).OnDelete(DeleteBehavior.NoAction);
            builder.HasKey(C => C.EnrollmentId);
            builder.Property(C => C.EnrollmentId).UseIdentityColumn();
            builder.Property(C => C.Grade).HasColumnType("decimal(5,2)").IsRequired(false);













            builder.HasIndex(C=> new { C.StudentId, C.CourseId}).IsUnique();
        }
    }
}
