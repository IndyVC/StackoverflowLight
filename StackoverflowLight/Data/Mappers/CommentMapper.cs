using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StackoverflowLight.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Data.Mappers
{
    public class CommentMapper : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");

            builder.Property(t => t.Description);
            builder.HasMany(q => q.Upvotes).WithOne(u=>(Comment)u.Post);
            builder.HasMany(q => q.Downvotes).WithOne(d=>(Comment)d.Post);

        }
    }
}
