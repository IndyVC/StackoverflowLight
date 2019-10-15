using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StackoverflowLight.Domain.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Data.Mappers
{
    public class UserDownMapper : IEntityTypeConfiguration<UserDown>
    {
        public void Configure(EntityTypeBuilder<UserDown> builder)
        {
            builder.ToTable("Downvotes");
            builder.HasKey(t => t.UserDownId);
            builder.HasOne(t => t.Post).WithMany(p => p.Downvotes);
            builder.HasOne(t => t.User).WithMany(p => p.Downvotes);
        }
    }
}
