using Acme.Client.Web.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Acme.Client.Web.Controllers
{
    [LayoutInjector("_Layout")]
    public class DocumentController : BaseController
    {
        // GET: Document
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadDocument() 
        {
            if (Request.Files.Count > 0)
            {
                //  Get all files from Request object  
                HttpFileCollectionBase files = Request.Files;
                for (int i = 0; i < files.Count; i++)
                {
                    //string path = AppDomain.CurrentDomain.BaseDirectory + "Uploads/";  
                    //string filename = Path.GetFileName(Request.Files[i].FileName);  

                    HttpPostedFileBase file = files[i];
                    string fname;

                    // Checking for Internet Explorer  
                    if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                    {
                        string[] testfiles = file.FileName.Split(new char[] { '\\' });
                        fname = testfiles[testfiles.Length - 1];
                    }
                    else
                    {
                        fname = file.FileName;
                    }

                    // Get the complete folder path and store the file inside it.  
                    fname = Path.Combine(Server.MapPath("~/Uploads/"), fname);
                    file.SaveAs(fname);
                }  
                return Json("File Uploaded Successfully!");
            }
            else
            {
                return Json("No files selected.");
            }
             
        }
    }
}