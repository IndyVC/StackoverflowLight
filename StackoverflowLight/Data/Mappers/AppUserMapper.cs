using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StackoverflowLight.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Data.Mappers
{
    public class AppUserMapper : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");
            builder.HasKey(t => t.AppUserId);
            builder.Property(t => t.UserName);
            builder.HasMany(t => t.Upvotes).WithOne(u => u.User);
            builder.HasMany(t => t.Downvotes).WithOne(u => u.User);
        }
    }
}
