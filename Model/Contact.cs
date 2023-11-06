using System.ComponentModel.DataAnnotations;

namespace Portfolioo.Model
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "please Enter Your Name")]
        [EmailAddress(ErrorMessage = "please Enter Email")]
        public string Name { get; set; }

        [Required(ErrorMessage = "please Enter Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "please Enter Subect")]

        public string Subject { get; set; }
        [Required(ErrorMessage = "please Enter Message")]
        public string Message { get; set; }


    }
}
