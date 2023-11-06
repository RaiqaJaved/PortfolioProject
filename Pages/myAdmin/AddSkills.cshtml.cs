using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class Add_SkillsModel : PageModel
    {
        AppDbContext db;
        public Skills skills { get; set; }
        public Add_SkillsModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Skills skills)
        {
            if(ModelState.IsValid)
            {
                db.tbl_Skills.Add(skills);
                db.SaveChanges();
                return RedirectToPage("ShowSkills");

            }
            return Page();
        }
    }
}
