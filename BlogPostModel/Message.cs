using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostModel
{
    public class Message
    {

        public Guid Id { get; set; }
        [Required(ErrorMessage = "Subject is Required.")]

        public string Subject { get; set; }
        [Required(ErrorMessage = "Body is Required.")]

        public string Body { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        [Required(ErrorMessage = "Author is Required.")]

        public string Author { get; set; }
       public string Audience { get; set; }
        
    }
}
