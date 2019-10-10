using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StackoverflowLight.Domain;
using StackoverflowLight.Domain.Repositories;

namespace StackoverflowLight.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionRepository questionRepo;
        private readonly SignInManager<IdentityUser> signInManager;

        public QuestionController(IQuestionRepository questionRepository, SignInManager<IdentityUser> signInManager)
        {
            this.questionRepo = questionRepository;
            this.signInManager = signInManager;
        }

        public IActionResult Index(int id)
        {
            Question question = questionRepo.GetQuestionById(id);
            return View(question);
        }
    }
}