using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StackoverflowLight.Domain;
using System;


namespace StackoverflowLight.Data.Mappers
{
    public class UserMapper : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("appUsers");
            builder.Property(u => u.appUsername);
            
        }
    }
}
