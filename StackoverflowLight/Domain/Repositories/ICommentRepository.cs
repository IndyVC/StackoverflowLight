using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Domain.Repositories
{
    public interface ICommentRepository
    {
        Comment GetCommentById(int id);
        ICollection<Comment> GetAllComments();
        void CreateComment(Comment comment);
        void DeleteComment(Comment comment);
        void UpdateComment(Comment comment);
        void SaveChanges();
    }
}
