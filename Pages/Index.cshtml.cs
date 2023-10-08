using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages
{
    public class IndexModel : PageModel
    {
        AppDbContext db;
        public Profile profile { get; set; }
        public Facts facts { get; set; }
        public List<Skills> skills { get; set; }
        public IndexModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            profile = db.tbl_Profile.FirstOrDefault();
            facts = db.tbl_Facts.FirstOrDefault();
            skills = db.tbl_Skills.ToList();
        }
    }
}
