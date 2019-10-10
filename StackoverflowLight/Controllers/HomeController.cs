using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StackoverflowLight.Domain;
using StackoverflowLight.Domain.Repositories;
using StackoverflowLight.Models;

namespace StackoverflowLight.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuestionRepository questionRepo;
        private readonly UserManager<IdentityUser> userManager;

        public HomeController(IQuestionRepository questionRepository, UserManager<IdentityUser> userManager)
        {
            this.questionRepo = questionRepository;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            ICollection<Question> questions = questionRepo.GetAllQuestions().OrderByDescending(q => q.UpvotedBy.Count).ToList();

            return View(questions);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
