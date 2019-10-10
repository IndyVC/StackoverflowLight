using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Domain.Repositories
{
    public interface IAppUserRepository
    {
        AppUser GetAppUserById(int id);
        ICollection<AppUser> GetAllAppUsers();
        void CreateAppUser(AppUser user);
        void DeleteAppUser(AppUser user);
        void UpdateAppUser(AppUser user);
        AppUser GetAppUserByUserName(string username);
        void SaveChanges();
    }
}
