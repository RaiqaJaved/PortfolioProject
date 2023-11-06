using System.ComponentModel.DataAnnotations;

namespace Portfolioo.Model
{
    public class Education
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="please Enter Degree")]
        [EmailAddress(ErrorMessage ="please Enter Email")]
        public string Degree { get; set; }

        [Required(ErrorMessage = "please Enter Start Year")]
        public string StartYear { get; set; }

        [Required(ErrorMessage = "please Enter End Year")]
        public string EndYear { get; set; }

        [Required(ErrorMessage = "please Enter Institute Name")]
        public string InstituteName { get; set; }

        [Required(ErrorMessage = "please Enter Description")]
        public string Desc{ get; set; }

    }
}
