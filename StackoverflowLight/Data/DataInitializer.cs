using Microsoft.AspNetCore.Identity;
using StackoverflowLight.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Data
{
    public class DataInitializer
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;

        public DataInitializer(ApplicationDbContext context, UserManager<IdentityUser> usermanager)
        {
            this.context = context;
            userManager = usermanager;
        }

        public async Task InitializeAsync()
        {
            context.Database.EnsureDeleted();
            if (context.Database.EnsureCreated())
            {
                IdentityUser user1 = new IdentityUser("indy@hotmail.com");
                await CreateUserAsync(user1, "P@ssword1111");
                AppUser appUser1 = new AppUser(user1.UserName);
                IdentityUser user2 = new IdentityUser("robbe@hotmail.com");
                await CreateUserAsync(user2, "P@ssword1111");
                AppUser appUser2 = new AppUser(user2.UserName);
                context.AppUsers.Add(appUser1);
                context.AppUsers.Add(appUser2);

                Question question1 = new Question("How to build stackoverflow?", "For a project, I need to build a forum with authentication. Which technology/language is best suited for the task?", user1.UserName);
                Comment comment1 = new Comment(question1, "I believe the best technology is to use ASP.NET MVC! It serves the best solutionfor authentication!", user2.UserName);
                context.Questions.Add(question1);
                context.Comments.Add(comment1);
                context.SaveChanges();

            }
        }

        private async Task CreateUserAsync(IdentityUser user, string password)
        {
            await userManager.CreateAsync(user, password);
        }

    }
}
