using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class AddExperinceModel : PageModel
    {
        AppDbContext db;
        public Experince experince { get; set; }
        public AddExperinceModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Experince experince)
        {
            db.tbl_Experince.Add(experince);
            db.SaveChanges();
            return RedirectToPage("ShowExperince");
        }
    }
}
