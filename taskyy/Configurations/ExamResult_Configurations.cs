using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using taskyy.Models;

namespace taskyy.Configurations
{
    internal class ExamResult_Configurations : IEntityTypeConfiguration<ExamResult>
    {
        public void Configure(EntityTypeBuilder<ExamResult> builder)
        {
            builder.HasOne(C=>C.NavStudent).WithMany(X=>X.NavExamResult)
                .HasForeignKey(P=>P.StudentId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(C => C.NavExam).WithMany(X => X.NavExamResult)
               .HasForeignKey(P => P.ExamId).OnDelete(DeleteBehavior.NoAction);
            builder.HasKey(C => C.ExamResultId);
            builder.Property(C => C.ExamResultId).UseIdentityColumn();
            builder.Property(C => C.Score).HasColumnType("decimal(5,2)").IsRequired();










            builder.HasIndex(P => new {P.ExamId,P.StudentId}).IsUnique();


        }
    }
}
