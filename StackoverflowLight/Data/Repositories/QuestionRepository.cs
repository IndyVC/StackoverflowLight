using Microsoft.EntityFrameworkCore;
using StackoverflowLight.Domain;
using StackoverflowLight.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Data.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly ApplicationDbContext context;
        private readonly DbSet<Question> questions;

        public QuestionRepository(ApplicationDbContext context)
        {
            this.context = context;
            questions = context.Questions;
        }
        public void CreateQuestion(Question question)
        {
            questions.Add(question);
        }

        public void DeleteQuestion(Question question)
        {
            questions.Remove(question);
        }

        public ICollection<Question> GetAllQuestions()
        {
            return questions.Include(q=>q.Comments).ToList();
        }

        public Question GetQuestionById(int id)
        {
            return questions.Include(q=>q.Comments).Where(q => q.QuestionId == id).FirstOrDefault();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void UpdateQuestion(Question question)
        {
            questions.Update(question);
        }
    }
}
