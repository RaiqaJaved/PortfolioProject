using System.ComponentModel.DataAnnotations;

namespace Portfolioo.Model
{
    public class Skills
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "please Enter Your Percentge")]
        public int Percentage { get; set; }
    }
}
