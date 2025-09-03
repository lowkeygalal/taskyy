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
    internal class Classroom_Configurations : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            builder.HasKey(C=>C.ClassroomId);
            builder.Property(C => C.ClassroomId).UseIdentityColumn();
            builder.Property(C => C.Building).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(C => C.RoomNumber).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(C => C.Capacity).IsRequired();
            builder.HasCheckConstraint("CheckPositive", "Capacity > 0");




        }
    }
}
