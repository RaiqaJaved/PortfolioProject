using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages
{
    public class IndexModel : PageModel
    {
        AppDbContext db;
        public Profile profile { get; set; }
        public Facts facts { get; set; }
        public List<Skills> skills { get; set; }
        public  List<Education> educations { get; set; }
        public List<Experince> experinces { get; set; }
        public List<services> services { get; set; }
        public Contact contact { get; set; }
        public IndexModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            profile = db.tbl_Profile.FirstOrDefault();
            facts = db.tbl_Facts.FirstOrDefault();
            skills = db.tbl_Skills.ToList();
            educations=db.tbl_Education.ToList();
            experinces=db.tbl_Experince.ToList();
            services=db.tbl_Services.ToList();
              
            
        }
        public IActionResult OnPost(Contact contact) 
        {
            db.tbl_Contact.Add(contact);
            db.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
