using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class Add_FactsModel : PageModel
    {
        AppDbContext db;
        public Facts facts{ get; set; }
        public Add_FactsModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Facts facts)
        {
            db.tbl_Facts.Add(facts);
            db.SaveChanges();
            return RedirectToPage("ShowFacts");
        }
    }
}
