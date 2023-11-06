using System.ComponentModel.DataAnnotations;

namespace Portfolioo.Model
{
    public class Testamonia
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "please Enter Your Designation")]
        public string Designaton { get; set; }

        [Required(ErrorMessage = "please Enter Your theTestamonial")]
        public string theTestamonia { get; set; }

        [Required(ErrorMessage = "please Enter Your Image")]
        public string Image{ get; set; }


    }
}
