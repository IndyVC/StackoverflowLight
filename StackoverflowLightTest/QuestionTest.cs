using StackoverflowLight.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StackoverflowLightTest
{
    public class QuestionTest
    {

        private Question question1;
        private Question question2;
        private AppUser indy;
        private AppUser robbe;

        public QuestionTest()
        {
            indy = new AppUser("indy@hotmail.com");
            robbe = new AppUser("robbe@hotmail.com");
            question1 = new Question("title", "description", indy.UserName);
            question2 = new Question("title", "description", robbe.UserName);
        }

        [Fact]
        public void CreateQuestion_Success()
        {
            Assert.Equal(question1.Username, indy.UserName);
        }

        [Fact]
        public void AddComment_Success()
        {
            //Arrange
            Comment comment = new Comment(question1, "description", indy.UserName);
            //Act
            question1.Comments.Add(comment);
            //Assert
            Assert.Equal(1, question1.Comments.Count);
        }
    }
}
