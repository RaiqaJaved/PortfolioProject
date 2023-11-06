using System.ComponentModel.DataAnnotations;

namespace Portfolioo.Model
{
    public class Experince
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "please Enter JobTittle")]
        public string JobTittle { get; set; }
        [Required(ErrorMessage = "please Enter Location")]
        public string Location { get; set; }
        [Required(ErrorMessage = "please Enter Start Year")]
        public string StartYear { get; set; }
        [Required(ErrorMessage = "please Enter End Year")]
        public string EndYear { get; set; }
        [Required(ErrorMessage = "please Enter Description")]
        public string Desc { get; set; }

    }
}
