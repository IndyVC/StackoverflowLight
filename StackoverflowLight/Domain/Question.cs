using System;
using System.Collections.Generic;


namespace StackoverflowLight.Domain
{
    public class Question : Post
    {
        #region fields
        private string _title;
        #endregion


        #region properties
        public string Title {
            get {
                return this._title;
            }
            set {
                if (value == null || value.Length == 0)
                {
                    throw new ArgumentException("Title cannot be empty.");
                }
                else
                {
                    this._title = value;
                }
            }
        }
        public ICollection<Comment> Comments { get; set; }
        #endregion
        #region construcor
        public Question(string description, string title) : base(description){
            this.Comments = new List<Comment>();
            this.Title = title;
        }
        #endregion
    }
}
