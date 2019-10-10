using Microsoft.AspNetCore.Identity;
using StackoverflowLight.Domain.ManyToMany;
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
        public int PostId { get; set; }
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
        public IList<UserUp> Upvotes { get; set; }
        public IList<UserDown> Downvotes { get; set; }
        public string Username { get; set; }
        #endregion

        #region constructor
        protected Post(string description, string username)
        {
            Upvotes = new List<UserUp>();
            Downvotes = new List<UserDown>();
            Description = description;
            Username = username;
        } 
        #endregion
    }
}
