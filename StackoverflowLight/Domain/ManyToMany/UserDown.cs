using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Domain.ManyToMany
{
    public class UserDown
    {
        public int UserDownId { get; set; }
        public Post Post { get; set; }
        public AppUser User { get; set; }

        public UserDown()
        {

        }

        public UserDown(Post post, AppUser user)
        {
            this.Post = post;
            this.User = user;
        }
    }
}
