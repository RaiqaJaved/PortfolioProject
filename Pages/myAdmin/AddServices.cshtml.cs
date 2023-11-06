using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class AddServicesModel : PageModel
    {
            AppDbContext db;
            public services services{ get; set; }
            public AddServicesModel(AppDbContext _db)
            {
                db = _db;
            }
            public void OnGet()
            {
            }
            public IActionResult OnPost(services services)
            {
            if(ModelState.IsValid)
            {
                db.tbl_Services.Add(services);
                db.SaveChanges();
                return RedirectToPage("ShowServices");

            }
            return Page();
            }
    }
    }

