using Microsoft.AspNetCore.Identity;
using StackoverflowLight.Domain.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Domain
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        public string UserName { get; set; }
        public ICollection<UserUp> Upvotes { get; set; }
        public ICollection<UserDown> Downvotes { get; set; }

        public AppUser() { }
        public AppUser(string username)
        {
            this.UserName = username;
            Upvotes = new List<UserUp>();
            Downvotes = new List<UserDown>();
        }
    }
}
