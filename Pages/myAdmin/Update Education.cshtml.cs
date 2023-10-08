using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class UpdateEducationModel : PageModel
    {
        AppDbContext db;
        public Education education{ get; set; }
        public UpdateEducationModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            var ItemToUpdate  = db.tbl_Education.Find(Id);
            education = ItemToUpdate;
        }
        public IActionResult OnPost(Education education)
        {
            db.tbl_Education.Update(education);
            db.SaveChanges();
            return RedirectToPage("ShowEducation");
        }
    }
}
