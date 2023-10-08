using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolioo.Data;
using Portfolioo.Model;
using System.IO;

namespace Portfolioo.Pages.myAdmin
{
    public class ShowProfileRecordModel : PageModel
    {
        public Profile profile { get; set; }
        AppDbContext db;
        IWebHostEnvironment env;
        public ShowProfileRecordModel(AppDbContext _db,IWebHostEnvironment env)
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
                var ImagePath = Path.Combine(FolderPath, ImageName);

                var myFileStream = new FileStream(ImagePath, FileMode.Create);
                profile.Photo.CopyTo(myFileStream);
                myFileStream.Dispose();

                profile.Image = ImageName;
                db.tbl_Profile.Update(profile);
                db.SaveChanges();
            }
            return RedirectToPage("ShowProfileRecord");
        }
        //closing of onPost
        private void DeleteFile(String OldImageName)
        {
            var FolderPath = Path.Combine(env.WebRootPath, "images");
            var ImagePath = Path.Combine(FolderPath,OldImageName);

            FileInfo fileInfo = new FileInfo(ImagePath);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
        }
    }
}
