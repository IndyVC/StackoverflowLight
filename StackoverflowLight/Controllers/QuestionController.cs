using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StackoverflowLight.Domain;
using StackoverflowLight.Domain.Repositories;
using StackoverflowLight.Domain.ViewModels;

namespace StackoverflowLight.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionRepository questionRepo;
        private readonly UserManager<IdentityUser> userManager;

        public QuestionController(IQuestionRepository questionRepository, UserManager<IdentityUser> userManager)
        {
            this.questionRepo = questionRepository;
            this.userManager = userManager;
        }

        public IActionResult Index(int id)
        {
            Question question = questionRepo.GetQuestionById(id);
            return View(question);
        }

        public IActionResult Create()
        {
            return View(new QuestionEditViewModel());

        }
        [HttpPost]
        public async Task<IActionResult> Create(QuestionEditViewModel evm)
        {
            IdentityUser user = await userManager.GetUserAsync(HttpContext.User);
            Question question = new Question(evm.Title, evm.Description, user.UserName);
            questionRepo.CreateQuestion(question);
            questionRepo.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> UpvoteAsync(int id)
        {
            IdentityUser user = await userManager.GetUserAsync(HttpContext.User);
            ICollection<Question> questions = questionRepo.GetAllQuestions().OrderBy(q => q.UpvotedBy.Count).ToList();
            Question question = questions.Where(q => q.QuestionId == id).FirstOrDefault();
            if (question.DownvotedBy.Contains(user))
            {
                question.DownvotedBy.Remove(user);
            }
            if (question.UpvotedBy.Contains(user))
            {
                question.UpvotedBy.Remove(user);
            }
            else
            {
                question.UpvotedBy.Add(user);

            }
            questionRepo.UpdateQuestion(question);
            questionRepo.SaveChanges();
            return View(nameof(Index), question);

        }

        public async Task<IActionResult> DownvoteAsync(int id)
        {
            ICollection<Question> questions = questionRepo.GetAllQuestions().OrderBy(q => q.UpvotedBy.Count).ToList();
            Question question = questions.Where(q => q.QuestionId == id).FirstOrDefault();
            IdentityUser user = await userManager.GetUserAsync(HttpContext.User);
            if (question.UpvotedBy.Contains(user))
            {
                question.UpvotedBy.Remove(user);
            }
            if (question.DownvotedBy.Contains(user))
            {
                question.DownvotedBy.Remove(user);
            }
            else
            {
                question.DownvotedBy.Add(user);
            }
            questionRepo.UpdateQuestion(question);
            questionRepo.SaveChanges();
            return View(nameof(Index), question);

        }
    }
}