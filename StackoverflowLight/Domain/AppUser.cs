using Microsoft.AspNetCore.Identity;
using StackoverflowLight.Domain.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Domain
{
    public class AppUser:IdentityUser
    {
        public int AppUserId { get; set; }
        public override string UserName { get; set; }
        public ICollection<UserUp> Upvotes { get; set; }
        public ICollection<UserDown> Downvotes { get; set; }

        public AppUser() { }
        public AppUser(string username) : base(username)
        {
            Upvotes = new List<UserUp>();
            Downvotes = new List<UserDown>();
        }
    }
}
