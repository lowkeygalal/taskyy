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
    internal class Assignment_Configurations : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.HasKey(C=>C.AssignmentId);
            builder.Property(C => C.AssignmentId).UseIdentityColumn();
            builder.Property(C => C.Title).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(C => C.Description).HasColumnType("nvarchar(max)").IsRequired(false);
            builder.Property(C => C.DueDate).HasColumnType("datetime").IsRequired();


        }
    }
}
