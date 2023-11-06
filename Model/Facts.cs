using System.ComponentModel.DataAnnotations;

namespace Portfolioo.Model
{
    public class Facts
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "please Enter Number Of Clients")]
        public int Clients { get; set; }

        [Required(ErrorMessage = "please Enter Number of Projects")]
        public string projects { get; set; }

        [Required(ErrorMessage = "please Enter Number of hours")]
        public int Hours { get; set; }

        [Required(ErrorMessage = "please Enter Number of HardWorkers")]
        public int HardWorkers { get; set; }
    }
}
