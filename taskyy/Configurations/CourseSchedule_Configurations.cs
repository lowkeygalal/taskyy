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
    internal class CourseSchedule_Configurations : IEntityTypeConfiguration<CourseSchedule>
    {
        public void Configure(EntityTypeBuilder<CourseSchedule> builder)
        {
            builder.HasOne(C=>C.NavInstructor).WithMany(X=>X.NavCourseSchedule)
                .HasForeignKey(P=>P.InstructorId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(C=>C.NavCourse).WithMany(X=>X.NavCourseSchedule)
                .HasForeignKey(P=>P.CourseId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(C=>C.NavClassroom).WithMany(X=>X.NavCourseSchedule)
                .HasForeignKey(P=>P.ClassroomId).OnDelete(DeleteBehavior.NoAction);
           builder.HasKey(C=>C.ScheduleId);
            builder.Property(C => C.ScheduleId).UseIdentityColumn();
            builder.Property(C => C.DayOfWeek).HasColumnType("nvarchar(20)").IsRequired() ;
            builder.Property(C => C.StartTime).HasColumnType("time").IsRequired();
            builder.Property(C => C.EndTime).HasColumnType("time").IsRequired();











        }
    }
}
