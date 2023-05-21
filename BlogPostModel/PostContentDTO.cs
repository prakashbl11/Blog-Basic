using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostModel
{
    public class PostContentDTO
    {


        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the content.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Please enter the author name.")]
        public string Author { get; set; }
    }
}
