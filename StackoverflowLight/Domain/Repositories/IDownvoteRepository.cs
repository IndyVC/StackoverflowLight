using StackoverflowLight.Domain.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Domain.Repositories
{
    interface IDownvoteRepository
    {
        UserDown GetUserDown(int id);
        List<UserDown> GetAllUserDowns();
        void DeleteUserDown(UserDown downvote);
        void CreateUserDown(UserDown downvote);
        void UpdateUserDown(UserDown downvote);
        void SaveChanges();
    }
}
