using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class Show_FactsModel : PageModel
    {
        AppDbContext db;
        public List<Facts> facts{ get; set; }
        public Show_FactsModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            facts = db.tbl_Facts.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var ItemToDel = db.tbl_Facts.Find(Id);
            db.tbl_Facts.Remove(ItemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowFacts");
        }
    }
}
