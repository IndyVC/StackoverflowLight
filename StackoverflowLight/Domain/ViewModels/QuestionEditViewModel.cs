using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Domain.ViewModels
{
    public class QuestionEditViewModel
    {
        [Required(ErrorMessage ="Title cannot be empty.")]
        [DisplayName("Title")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Description cannot be empty.")]
        [DisplayName("Description")]
        public string Description { get; set; }
        
        public QuestionEditViewModel() { }
        public QuestionEditViewModel(Question question)
        {
            this.Title = question.Title;
            this.Description = question.Description;
        }
    }
}
