using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class UpdateContactModel : PageModel
    {
        AppDbContext db;
        public Contact contact{ get; set; }
        public UpdateContactModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            contact = db.tbl_Contact.Find(Id);
        }
        public IActionResult OnPost(Contact contact)
        {
            db.tbl_Contact.Update(contact);
            db.SaveChanges();
            return RedirectToPage("ShowContact");
        }
    }
}
