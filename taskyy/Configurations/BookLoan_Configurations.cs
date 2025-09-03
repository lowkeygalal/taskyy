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
    internal class BookLoan_Configurations : IEntityTypeConfiguration<BookLoan>
    {
        public void Configure(EntityTypeBuilder<BookLoan> builder)
        {
            builder.HasOne(C=>C.NavStudent).WithMany(X=>X.NavBookLoan)
                .HasForeignKey(P=>P.StudentId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(C => C.NavBook).WithMany(X => X.NavBookLoan)
                .HasForeignKey(P => P.BookId).OnDelete(DeleteBehavior.NoAction);
            builder.HasKey(C => C.LoanId);
            builder.Property(C => C.LoanId).UseIdentityColumn();
            builder.Property(C => C.LoanDate).HasColumnType("datetime").IsRequired();
            builder.Property(C => C.ReturnDate).HasColumnType("datetime").IsRequired(false);




        }
    }
}
