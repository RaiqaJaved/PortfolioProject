using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class ShowServicesModel : PageModel
    {
        AppDbContext db;
        public List<services> services { get; set; }
        public ShowServicesModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            services = db.tbl_Services.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var ItemToDel = db.tbl_Services.Find(Id);
            db.tbl_Services.Remove(ItemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowServices");
        }
    }
}

