using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowLight.Domain.ViewModels
{
    public class CommentEditViewModel
    {
        [Required(ErrorMessage = "Description cannot be empty.")]
        [DisplayName("Description")]
        public string Comment { get; set; }
    }
}
