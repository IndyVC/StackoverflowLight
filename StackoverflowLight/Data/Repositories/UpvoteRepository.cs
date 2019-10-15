using Microsoft.EntityFrameworkCore;
using StackoverflowLight.Domain.ManyToMany;
using StackoverflowLight.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Data.Repositories
{
    public class UpvoteRepository : IUpvoteRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<UserUp> upvotes;

        public UpvoteRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.upvotes = context.Upvotes;
        }

        public void CreateUserUp(UserUp upvote)
        {
            upvotes.Add(upvote);
        }

        public void DeleteUserUp(UserUp upvote)
        {
            upvotes.Remove(upvote);
        }

        public List<UserUp> GetAllUserUps()
        {
            return upvotes.Include(u => u.Post).Include(u => u.User).ToList();
        }

        public UserUp GetUserUp(int id)
        {
            return upvotes.Include(u => u.Post).Include(u => u.User).FirstOrDefault(u => u.UserUpId == id);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void UpdateUserUp(UserUp upvote)
        {
            upvotes.Update(upvote);
        }
    }
}
