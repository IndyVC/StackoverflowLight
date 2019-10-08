using Microsoft.EntityFrameworkCore;
using StackoverflowLight.Domain;
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

        public ICollection<Comment> GetAllComments()
        {
            return comments.ToList();
        }

        public Comment GetCommentById(int id)
        {
            return comments.Where(c => c.CommentId == id).FirstOrDefault();
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
