using Microsoft.EntityFrameworkCore;
using StackoverflowLight.Domain;
using StackoverflowLight.Domain.ManyToMany;
using StackoverflowLight.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Data.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDbContext context;
        private readonly DbSet<Comment> comments;

        public CommentRepository(ApplicationDbContext context)
        {
            this.context = context;
            comments = context.Comments;
        }

        public void CreateComment(Comment comment)
        {
            comments.Add(comment);
        }

        public void DeleteComment(Comment comment)
        {
            comments.Remove(comment);
        }

        public void DeleteDownvote(UserDown downvote)
        {
            context.Downvotes.Remove(downvote);
        }

        public void DeleteUpvote(UserUp upvote)
        {
            context.Upvotes.Remove(upvote);
        }

        public ICollection<Comment> GetAllComments()
        {
            return comments.Include(c=>c.Upvotes).ThenInclude(u => u.User).Include(c=>c.Downvotes).ThenInclude(u => u.User).ToList();
        }

        public Comment GetCommentById(int id)
        {
            return comments.Include(c => c.Upvotes).ThenInclude(u => u.User).Include(c => c.Downvotes).ThenInclude(u => u.User).FirstOrDefault(c => c.PostId == id);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void UpdateComment(Comment comment)
        {
            comments.Update(comment);
        }
    }
}
