using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class Add_EducationModel : PageModel
    {
        AppDbContext db;
        public Education education { get; set; }
        public Add_EducationModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Education education)
        {
            db.tbl_Education.Add(education);
            db.SaveChanges();
            return RedirectToPage("ShowEducation");
        }
    }
}
