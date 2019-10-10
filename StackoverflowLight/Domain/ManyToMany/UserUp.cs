using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Domain.ManyToMany
{
    public class UserUp
    {
        public int UserUpId { get; set; }
        public Post Post { get; set; }
        public AppUser User { get; set; }

        public UserUp()
        {

        }

        public UserUp(Post post, AppUser user)
        {
            this.Post = post;
            this.User = user;
        }
    }
}
