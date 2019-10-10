using Microsoft.EntityFrameworkCore;
using StackoverflowLight.Domain;
using StackoverflowLight.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Data.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly ApplicationDbContext context;
        private readonly DbSet<AppUser> users;

        public AppUserRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.users = context.AppUsers;
        }
        public void CreateAppUser(AppUser user)
        {
            users.Add(user);
        }

        public void DeleteAppUser(AppUser user)
        {
            users.Remove(user);
        }

        public ICollection<AppUser> GetAllAppUsers()
        {
            return users.Include(u=>u.Upvotes).Include(u=>u.Downvotes).ToList();
        }

        public AppUser GetAppUserById(int id)
        {
            return users.Include(u => u.Upvotes).Include(u => u.Downvotes).Where(u => u.AppUserId == id).FirstOrDefault();
        }

        public AppUser GetAppUserByUserName(string username)
        {
            return users.Include(u => u.Upvotes).Include(u => u.Downvotes).Where(u => u.UserName == username).FirstOrDefault();

        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void UpdateAppUser(AppUser user)
        {
            users.Update(user);
        }
    }
}
