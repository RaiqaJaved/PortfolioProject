using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;
namespace Portfolioo.Pages.myAdmin
{
    public class ShowExperinceModel : PageModel
    {
        AppDbContext db;
        public List<Experince> experince { get; set; }
        public ShowExperinceModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            experince = db.tbl_Experince.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var ItemToDel = db.tbl_Experince.Find(Id);
            db.tbl_Experince.Remove(ItemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowExperince");
        }
    }
}
