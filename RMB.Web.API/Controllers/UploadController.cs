using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMB.Web.API.Extensions;

namespace RMB.Web.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Upload")]
    public class UploadController : Controller
    {
        [HttpPost]
        public void File(IFormFile file)
        {
            //if (file == null || file.Length == 0)
            //    return Content("file not selected");

            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot/Images",
                        file.FileName);

            //using (var stream = new FileStream(path, FileMode.Create))
            //{
            //    await file.CopyToAsync(stream);
            //}

            using (var stream = new FileStream(path, FileMode.Create))
            {
                Image img = Image.FromStream(file.OpenReadStream());
                var data = img.Resize(100, 100).ToByteArray();
                stream.Write(data,0,data.Length);
            }

           // return RedirectToAction("Files");
        }
    }
}