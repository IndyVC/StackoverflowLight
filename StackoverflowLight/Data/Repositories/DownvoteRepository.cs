using Microsoft.EntityFrameworkCore;
using StackoverflowLight.Domain.ManyToMany;
using StackoverflowLight.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Data.Repositories
{
    public class DownvoteRepository : IDownvoteRepository
    {
        private readonly ApplicationDbContext context;
        private readonly DbSet<UserDown> downvotes;

        public DownvoteRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.downvotes = context.Downvotes;
        }

        public void CreateUserDown(UserDown downvote)
        {
            downvotes.Add(downvote);
        }

        public void DeleteUserDown(UserDown downvote)
        {
            downvotes.Remove(downvote);
        }

        public List<UserDown> GetAllUserDowns()
        {
            return downvotes.Include(d=>d.Post).Include(d=>d.User).ToList();
        }

        public UserDown GetUserDown(int id)
        {
            return downvotes.Include(d => d.Post).Include(d => d.User).FirstOrDefault(d => d.UserDownId == id);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void UpdateUserDown(UserDown downvote)
        {
            downvotes.Update(downvote);
        }
    }
}
