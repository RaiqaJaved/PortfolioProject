using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class ShowSocialNetworksModel : PageModel
    {
        AppDbContext db;
        public List<SocialNetworks> socialNetworks { get; set; }
        public ShowSocialNetworksModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            socialNetworks = db.tbl_SocialNetworks.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var ItemToDel = db.tbl_SocialNetworks.Find(Id);
            db.tbl_SocialNetworks.Remove(ItemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowSocialNetworks");
        }
    }
}
