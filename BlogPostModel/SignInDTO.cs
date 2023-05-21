using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostModel
{
    public class SignInDTO
    {
        [Required(ErrorMessage = "Email is required.")]
        public string UserEmail { get; set; }
        [Required(ErrorMessage = "Password Required")]
        public string UserPassword { get; set; }
       
    }
}
