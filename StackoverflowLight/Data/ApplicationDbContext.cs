﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StackoverflowLight.Data.Mappers;
using StackoverflowLight.Domain;
using StackoverflowLight.Domain.ManyToMany;

namespace StackoverflowLight.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<UserUp> Upvotes { get; set; }
        public DbSet<UserDown> Downvotes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new QuestionMapper());
            builder.ApplyConfiguration(new CommentMapper());
            builder.ApplyConfiguration(new UserUpMapper());
            builder.ApplyConfiguration(new UserDownMapper());
        }

    }
}
