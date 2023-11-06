using System.ComponentModel.DataAnnotations;

namespace Portfolioo.Model
{
    public class services
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "please Enter Tittle")]
        public string Tittle { get; set; }

        [Required(ErrorMessage = "please Enter Description")]
        public string Desc { get; set; }

        [Required(ErrorMessage = "please Enter Your IconName")]
        public string IconName { get; set; }

    }
}
