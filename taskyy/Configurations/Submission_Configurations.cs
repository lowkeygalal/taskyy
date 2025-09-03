using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using taskyy.Models;

namespace taskyy.Configurations
{
    internal class Submission_Configurations : IEntityTypeConfiguration<Submission>
    {
        public void Configure(EntityTypeBuilder<Submission> builder)
        {
            builder.HasOne(C=>C.NavStudent).WithMany(X=>X.NavSubmission)
                .HasForeignKey(P=>P.StudentId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(C => C.NavAssignment).WithMany(X => X.NavSubmission)
                .HasForeignKey(P => P.AssignmentId).OnDelete(DeleteBehavior.NoAction);












            builder.HasKey(C => C.SubmissionId);
            builder.Property(C => C.SubmissionId).UseIdentityColumn();
            builder.Property(C => C.SubmissionDate).HasColumnType("datetime").IsRequired();
            builder.Property(C => C.Grade).HasColumnType("decimal(5,2)").IsRequired(false);










        }
    }
}
