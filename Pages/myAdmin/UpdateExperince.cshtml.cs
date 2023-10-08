using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class Update_ExperinceModel : PageModel
    {
        AppDbContext db;
        public Experince experince { get; set; }
        public Update_ExperinceModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            experince = db.tbl_Experince.Find(Id);
        }
        public IActionResult OnPost(Experince experince)
        {
            db.tbl_Experince.Update(experince);
            db.SaveChanges();
            return RedirectToPage("ShowExperince");
        }
    }
}
