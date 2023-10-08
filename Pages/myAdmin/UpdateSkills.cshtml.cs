using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class UpdateSkillsModel : PageModel
    {
        AppDbContext db;
        public Skills skills { get; set; }
        public UpdateSkillsModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            skills = db.tbl_Skills.Find(Id);
        }
        public IActionResult OnPost(Skills skills)
        {
            db.tbl_Skills.Update(skills);
            db.SaveChanges();
            return RedirectToPage("ShowSkills");
        }
    }
}

