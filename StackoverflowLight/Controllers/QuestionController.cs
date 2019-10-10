using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StackoverflowLight.Domain;
using StackoverflowLight.Domain.ManyToMany;
using StackoverflowLight.Domain.Repositories;
using StackoverflowLight.Domain.ViewModels;

namespace StackoverflowLight.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionRepository questionRepo;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IAppUserRepository appUserRepo;

        public QuestionController(IQuestionRepository questionRepository, UserManager<IdentityUser> userManager, IAppUserRepository appUserRepository)
        {
            this.questionRepo = questionRepository;
            this.userManager = userManager;
            this.appUserRepo = appUserRepository;
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
            AppUser user = await GetAppUser();
            ICollection<Question> questions = questionRepo.GetAllQuestions().ToList();
            Question question = questions.Where(q => q.PostId == id).FirstOrDefault();
            if (DownvotesContains(question.Downvotes,user))
            {
                RemoveDownvote(user, question);
            }
            if (UpvotesContains(question.Upvotes,user))
            {
                RemoveUpvote(user, question);
            }
            else
            {
                question.Upvotes.Add(new UserUp(question, user));

            }
            questionRepo.UpdateQuestion(question);
            questionRepo.SaveChanges();
            return View(nameof(Index), question);

        }

  


        public async Task<IActionResult> DownvoteAsync(int id)
        {
            AppUser user = await GetAppUser();
            ICollection<Question> questions = questionRepo.GetAllQuestions().ToList();
            Question question = questions.Where(q => q.PostId == id).FirstOrDefault();
            
            if (UpvotesContains(question.Upvotes,user))
            {
                RemoveUpvote(user, question);
            }
            if (DownvotesContains(question.Downvotes,user))
            {
                RemoveDownvote(user, question);
            }
            else
            {
                RemoveDownvote(user, question);
            }
            questionRepo.UpdateQuestion(question);
            questionRepo.SaveChanges();
            return View(nameof(Index), question);

        }

        private bool UpvotesContains(ICollection<UserUp> upvotes,AppUser user)
        {
            bool contains = false;
            foreach(var upvote in upvotes)
            {
                if (upvote.User == user)
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

        private bool DownvotesContains(ICollection<UserDown> downvotes, AppUser user)
        {
            bool contains = false;
            foreach(var downvote in downvotes)
            {
                if (downvote.User == user)
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

        private void RemoveDownvote(AppUser user, Question question)
        {
            question.Downvotes.ToList().ForEach(down =>
            {
                if (down.Post == question && down.User == user)
                {
                    question.Downvotes.Remove(down);
                    questionRepo.DeleteDownvote(down);
                    questionRepo.UpdateQuestion(question);
                    questionRepo.SaveChanges();
                }
            });
        }

        private void RemoveUpvote(AppUser user, Question question)
        {
            question.Upvotes.ToList().ForEach(up =>
            {
                if (up.Post == question && up.User == user)
                {
                    question.Upvotes.Remove(up);
                    questionRepo.DeleteUpvote(up);
                    questionRepo.UpdateQuestion(question);
                    questionRepo.SaveChanges();
                }
            });
        }

        private async Task<AppUser> GetAppUser()
        {
            IdentityUser user = await userManager.GetUserAsync(HttpContext.User);
            AppUser appUser = appUserRepo.GetAppUserByUserName(user.UserName);
            return appUser;
        }

    }
}