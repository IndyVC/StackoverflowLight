using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StackoverflowLight.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Data.Mappers
{
    public class QuestionMapper : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Questions");
            builder.Property(t => t.Title);
            builder.Property(t => t.Description);


            builder.HasMany(q => q.Comments).WithOne(c => c.Question).IsRequired(false);
            builder.HasMany(q => q.Upvotes).WithOne(u => (Question)u.Post);
            builder.HasMany(q => q.Downvotes).WithOne(d => (Question)d.Post);
        }

       
    }
}
