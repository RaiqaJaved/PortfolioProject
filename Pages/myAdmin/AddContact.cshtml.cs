using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class AddContactModel : PageModel
    {
        AppDbContext db;
        public Contact contact { get; set; }
        public AddContactModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Contact.Add(contact);
                db.SaveChanges();
                return RedirectToPage("ShowContact");

            }
            return Page();    
        }
    }
}
