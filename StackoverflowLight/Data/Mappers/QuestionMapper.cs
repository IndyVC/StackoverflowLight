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
            builder.HasKey(t => t.QuestionId);
            builder.Property(t => t.Title);
            builder.Property(t => t.Description);


            builder.HasMany(q => q.Comments).WithOne(c => c.Question).IsRequired(false);
            builder.HasMany(q => q.UpvotedBy);
            builder.HasMany(q => q.DownvotedBy);
        }

       
    }
}
