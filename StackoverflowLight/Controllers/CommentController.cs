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
    public class CommentController : Controller
    {
        private readonly IQuestionRepository questionRepo;
        private readonly ICommentRepository commentRepo;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IAppUserRepository appUserRepo;

        public CommentController(IQuestionRepository questionRepository, ICommentRepository commentRepository, UserManager<IdentityUser> userManager, IAppUserRepository appUserRepository)
        {
            this.questionRepo = questionRepository;
            this.commentRepo = commentRepository;
            this.userManager = userManager;
            this.appUserRepo = appUserRepository;
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
            return RedirectToAction("Index", "Question", new { id = question.PostId });
        }
        public async Task<IActionResult> UpvoteAsync(int questionId,int commentId)
        {
            Question question = questionRepo.GetQuestionById(questionId);
            Comment comment = commentRepo.GetCommentById(commentId);
            AppUser user = await GetAppUser();
            if (DownvotesContains(question.Downvotes, user))
            {
                RemoveDownvote(user, comment);
            }
            if (UpvotesContains(question.Upvotes, user))
            {
                RemoveUpvote(user, comment);
            }
            else
            {
                comment.Upvotes.Add(new UserUp(question, user));

            }
            commentRepo.UpdateComment(comment);
            commentRepo.SaveChanges();
            return RedirectToAction("Index", "Question", new { id = question.PostId });
        }

        public async Task<IActionResult> DownvoteAsync(int questionId, int commentId)
        {
            Question question = questionRepo.GetQuestionById(questionId);
            Comment comment = commentRepo.GetCommentById(commentId);
            AppUser user = await GetAppUser();
            if (UpvotesContains(question.Upvotes, user))
            {
                RemoveUpvote(user, comment);
            }
            if (DownvotesContains(question.Downvotes, user))
            {
                RemoveDownvote(user, comment);
            }
            else
            {
                RemoveDownvote(user, comment);
            }
            commentRepo.UpdateComment(comment);
            commentRepo.SaveChanges();
            return RedirectToAction("Index", "Question", new { id = question.PostId });
        }

        private bool UpvotesContains(ICollection<UserUp> upvotes, AppUser user)
        {
            bool contains = false;
            foreach (var upvote in upvotes)
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
            foreach (var downvote in downvotes)
            {
                if (downvote.User == user)
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

        private void RemoveDownvote(AppUser user, Comment comment)
        {
            comment.Downvotes.ToList().ForEach(down =>
            {
                if (down.Post == comment && down.User == user)
                {
                    comment.Downvotes.Remove(down);
                    commentRepo.DeleteDownvote(down);
                    commentRepo.UpdateComment(comment);
                    commentRepo.SaveChanges();
                }
            });
        }

        private void RemoveUpvote(AppUser user, Comment comment)
        {
            comment.Upvotes.ToList().ForEach(up =>
            {
                if (up.Post == comment && up.User == user)
                {
                    comment.Upvotes.Remove(up);
                    commentRepo.DeleteUpvote(up);
                    commentRepo.UpdateComment(comment);
                    commentRepo.SaveChanges();
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