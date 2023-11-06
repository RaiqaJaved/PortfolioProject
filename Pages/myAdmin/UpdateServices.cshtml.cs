using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class UpdateServicesModel : PageModel
    {
        AppDbContext db;
        public services services { get; set; }
        public UpdateServicesModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            var ItemToUpdate = db.tbl_Services.Find(Id);
            services = ItemToUpdate;
        }
        public IActionResult OnPost(services services)
        {
            db.tbl_Services.Update(services);
            db.SaveChanges();
            return RedirectToPage("ShowServices");
        }
    }
}

