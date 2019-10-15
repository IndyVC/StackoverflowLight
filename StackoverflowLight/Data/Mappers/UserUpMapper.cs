using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StackoverflowLight.Domain.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Data.Mappers
{
    public class UserUpMapper : IEntityTypeConfiguration<UserUp>
    {
        public void Configure(EntityTypeBuilder<UserUp> builder)
        {
            builder.ToTable("Upvotes");
            builder.HasKey(t => t.UserUpId);
            builder.HasOne(t => t.Post).WithMany(p => p.Upvotes);
            builder.HasOne(t => t.User).WithMany(u => u.Upvotes);
        }
    }
}
