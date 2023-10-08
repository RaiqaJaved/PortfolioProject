using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class ShowSkillsModel : PageModel
    {
        AppDbContext db;
        public List<Skills> skills { get; set; }
        public ShowSkillsModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            skills = db.tbl_Skills.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var ItemToDel = db.tbl_Skills.Find(Id);
            db.tbl_Skills.Remove(ItemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowSkills");
        }
    }
}

