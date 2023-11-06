using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class ShowMessagesModel : PageModel
    {
        AppDbContext db;
        public List<Contact> contacts { get; set; }
        public ShowMessagesModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            contacts = db.tbl_Contact.ToList();
        }
        public IActionResult OnGetDelete(int id)
        {
            var itemToDel = db.tbl_Contact.Find(id);
            db.tbl_Contact.Remove(itemToDel);
            db.SaveChanges();

            return RedirectToPage("ShowMessages");
        }
    }
}
