using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class AddSocialNetworksModel : PageModel
    {
        AppDbContext db;
        public SocialNetworks socialNetworks { get; set; }
        public AddSocialNetworksModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(SocialNetworks socialNetworks)
        {
            db.tbl_SocialNetworks.Add(socialNetworks);
            db.SaveChanges();
            return RedirectToPage("ShowSocialNetworks");
        }
    }
}
