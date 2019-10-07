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
                User user = new User("indyvancanegem@hotmail.com");
                context.Users.Add(user);
                context.SaveChanges();


            }
        }

    }
}
