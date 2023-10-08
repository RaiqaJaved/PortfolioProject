using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class UpdateSocialNetworksModel : PageModel
    {
        public void OnGet()
        {

        }
        AppDbContext db;
        public SocialNetworks socialNetworks { get; set; }
        public UpdateSocialNetworksModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            socialNetworks = db.tbl_SocialNetworks.Find(Id);
        }
        public IActionResult OnPost(SocialNetworks socialNetworks)
        {
            db.tbl_SocialNetworks.Update(socialNetworks);
            db.SaveChanges();
            return RedirectToPage("ShowSocialNetworks");
        }
    }
}
