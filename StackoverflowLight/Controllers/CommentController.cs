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
    public class CommentController : Controller
    {
        private readonly IQuestionRepository questionRepo;
        private readonly ICommentRepository commentRepo;
        private readonly UserManager<IdentityUser> userManager;

        public CommentController(IQuestionRepository questionRepository, ICommentRepository commentRepository, UserManager<IdentityUser> userManager)
        {
            this.questionRepo = questionRepository;
            this.commentRepo = commentRepository;
            this.userManager = userManager;
        }

        public IActionResult Create(int id)
        {
            ViewData["questionId"] = id;
            return View(new CommentEditViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(int id, CommentEditViewModel evm)
        {
            Question question = questionRepo.GetQuestionById(id);
            IdentityUser user = await userManager.GetUserAsync(HttpContext.User);
            Comment comment = new Comment(question, evm.Comment, user.UserName);
            question.Comments.Add(comment);
            commentRepo.SaveChanges();
            return RedirectToAction("Index", "Question", new { id = question.QuestionId });
        }
        public async Task<IActionResult> UpvoteAsync(int questionId,int commentId)
        {
            Question question = questionRepo.GetQuestionById(questionId);
            Comment comment = commentRepo.GetCommentById(commentId);
            IdentityUser user = await userManager.GetUserAsync(HttpContext.User);
            if (comment.DownvotedBy.Contains(user))
            {
                comment.DownvotedBy.Remove(user);
            }
            if (comment.UpvotedBy.Contains(user))
            {
                comment.UpvotedBy.Remove(user);
            }
            else
            {
                comment.UpvotedBy.Add(user);

            }
            commentRepo.UpdateComment(comment);
            commentRepo.SaveChanges();
            return RedirectToAction("Index", "Question", new { id = question.QuestionId });
        }

        public async Task<IActionResult> DownvoteAsync(int questionId, int commentId)
        {
            Question question = questionRepo.GetQuestionById(questionId);
            Comment comment = commentRepo.GetCommentById(commentId);
            IdentityUser user = await userManager.GetUserAsync(HttpContext.User);
            if (comment.UpvotedBy.Contains(user))
            {
                comment.UpvotedBy.Remove(user);
            }
            if (comment.DownvotedBy.Contains(user))
            {
                comment.DownvotedBy.Remove(user);
            }
            else
            {
                comment.DownvotedBy.Add(user);
            }
            commentRepo.UpdateComment(comment);
            commentRepo.SaveChanges();
            return RedirectToAction("Index", "Question", new { id = question.QuestionId });
        }



    }
}