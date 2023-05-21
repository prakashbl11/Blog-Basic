using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostModel
{
    public class SignUpDTO
    {
        [EmailAddress]
        [Required(ErrorMessage = "Email Address is Required")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string UserPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
