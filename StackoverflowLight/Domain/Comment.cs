using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Domain
{
    public class Comment:Post
    {
        #region properties
        public int CommentId { get; set; }
        public Question Question { get; set; }
        #endregion
        #region constructor
        public Comment() : base("fill", "fill") { }
        public Comment(Question question,string description, string username) : base(description, username)
        {
            Question = question;
        } 
        #endregion
    }
}
