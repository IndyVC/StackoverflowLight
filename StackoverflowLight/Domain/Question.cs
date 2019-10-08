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
        public int QuestionId { get; set; }
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
        public Question() : base("", "") { }
        public Question(string title,string description, string username) : base(description, username){
            this.Comments = new List<Comment>();
            this.Title = title;
        }
        #endregion
    }
}
