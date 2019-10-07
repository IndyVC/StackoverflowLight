using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Domain
{
    public class User : IdentityUser
    {
        //small capitals: don't want to overwrite IdentityUser properties
        #region properties
        public string appUsername { get; set; }  
        #endregion
        #region constructor
        public User() {}

        public User(string username) : base(username)
        {
            this.appUsername = username;
        }
        #endregion
    }
}

