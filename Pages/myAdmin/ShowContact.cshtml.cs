using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class ShowContactModel : PageModel
    {
        AppDbContext db;
        public List<Contact> contact { get; set; }
        public ShowContactModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            contact = db.tbl_Contact.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var ItemToDel = db.tbl_Contact.Find(Id);
            db.tbl_Contact.Remove(ItemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowContact");
        }
    }
}

