using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Domain
{
    public class Comment:Post
    {
        #region constructor
        public Comment(string description) : base(description)
        {

        } 
        #endregion
    }
}
