using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StackoverflowLight.Domain;
using StackoverflowLight.Domain.Repositories;
using StackoverflowLight.Models;

namespace StackoverflowLight.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuestionRepository questionRepo;

        public HomeController(IQuestionRepository questionRepository)
        {
            this.questionRepo = questionRepository;
        }

        public IActionResult Index()
        {
            ICollection<Question> questions = questionRepo.GetAllQuestions().OrderBy(q => q.Upvotes).ToList();

            return View(questions);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
