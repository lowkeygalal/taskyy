using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using taskyy.Models;

namespace taskyy.Configurations
{
    internal class Exam_Configurations : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasKey(C=>C.ExamId);
            builder.Property(C => C.ExamId).UseIdentityColumn();
            builder.Property(C => C.ExamDate).HasColumnType("datetime").IsRequired();
            builder.Property(C => C.Type).HasColumnType("nvarchar(50)").IsRequired();
            builder.HasCheckConstraint("CK_Exam_Type","[Type] IN (N'Midterm', N'Final')");

        }
    }
}
