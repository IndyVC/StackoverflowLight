using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Domain
{
    public abstract class Post
    {
        #region fields
        private string _description;
        #endregion

        #region properties
        public string Description {
            get {
                return this._description;
            }
            set {
                if (value == null || value.Length == 0)
                {
                    throw new ArgumentException("Description cannot be empty.");
                }
                else
                {
                    this._description = value;
                }
            }
        }
        public ISet<IdentityUser> UpvotedBy { get; set; }
        public ISet<IdentityUser> DownvotedBy { get; set; }
        public string Username { get; set; }
        #endregion

        #region constructor
        protected Post(string description, string username)
        {
            UpvotedBy = new HashSet<IdentityUser>();
            DownvotedBy = new HashSet<IdentityUser>();
            Description = description;
            Username = username;
        } 
        #endregion
    }
}
