﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Domain.Repositories
{
    public interface IQuestionRepository
    {

        Question GetQuestionById(int id);
        ICollection<Question> GetAllQuestions();
        void CreateQuestion(Question question);
        void DeleteQuestion(Question question);
        void UpdateQuestion(Question question);
        void SaveChanges();
    }
}
