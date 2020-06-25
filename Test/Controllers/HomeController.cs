using Test.Models;
using System.IO;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security.Cookies;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult GetGoogleDriveFiles()
        {
            return View(GoogleDriveFilesRepository.GetDriveFiles());
        }
        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            GoogleDriveFilesRepository.FileUpload(file);
            Session["Success"] = "Your File is Uploaded Successfully";
            return RedirectToAction("GetGoogleDriveFiles");
        }

    }
}