using StackoverflowLight.Domain.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Domain.Repositories
{
    interface IUpvoteRepository
    {
        UserUp GetUserUp(int id);
        List<UserUp> GetAllUserUps();
        void DeleteUserUp(UserUp upvote);
        void CreateUserUp(UserUp upvote);
        void UpdateUserUp(UserUp upvote);
        void SaveChanges();
    }
}
