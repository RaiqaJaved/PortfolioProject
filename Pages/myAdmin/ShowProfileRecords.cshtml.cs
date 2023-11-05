using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;

namespace Portfolioo.Pages.myAdmin
{
    public class ShowProfileRecordsModel : PageModel
    {
        public Profile profile{ get; set; }
        AppDbContext db;
        IWebHostEnvironment env;
        public ShowProfileRecordsModel(AppDbContext _db, IWebHostEnvironment env)
        {
            db = _db;
            this.env = env;
        }
        public void OnGet()
        {
            profile = db.tbl_Profile.FirstOrDefault();
        }
        public IActionResult OnPost(Profile profile)
        {
            if (profile.Photo is null)
            {
                db.tbl_Profile.Update(profile);
                db.SaveChanges();
            }
            else
            {
                string ImageName = profile.Photo.FileName;
                DeleteFile(profile.Image);

                var FolderPath = Path.Combine(env.WebRootPath, "images");
                var ImagePath = Path.Combine(env.WebRootPath, ImageName);

                var myFileStream = new FileStream(ImagePath, FileMode.Create);
                profile.Photo.CopyTo(myFileStream);
                myFileStream.Dispose();

                profile.Image = ImageName;
                db.tbl_Profile.Update(profile);
                db.SaveChanges();
            }
            return RedirectToPage("ShowProfileRecord");
        }//closing of onpost
        private void DeleteFile(string oldImageName)
        {
            var FolderPath= Path.Combine(env.WebRootPath, "images");
            var ImagePath = Path.Combine(FolderPath,oldImageName);

            FileInfo fileInfo = new FileInfo(ImagePath);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
        }
    }

}
