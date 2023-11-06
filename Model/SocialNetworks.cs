using System.ComponentModel.DataAnnotations;

namespace Portfolioo.Model
{
    public class SocialNetworks
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "please Enter Your Facebook Id")]
        public string Facebook { get; set; }

        [Required(ErrorMessage = "please Enter Your Twitter")]
        public string Twitter { get; set; }

        [Required(ErrorMessage = "please Enter Your LinkdIn")]
        public string LinkedIn { get; set; }

        [Required(ErrorMessage = "please Enter Your Instragram")]
        public string Instragram { get; set; }

        [Required(ErrorMessage = "please Enter Your skyp")]
        public string Skyp { get; set; }
    }
}
