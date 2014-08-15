using Simple.ImageResizer;
using Simple.ImageResizer.MvcExtensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Book2hand.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Obsolete("ไม่สามารถ Crop ขนาดรูปได้ หรือกำหนดขนาดรูปใหม่ได้")]
        public string Thumbnail()
        {
            var w = 400;
            var h = 250;

            var path = Server.MapPath("~/Images/Nekima.jpg");

            System.Drawing.Image image = System.Drawing.Image.FromFile(path);
            byte[] imageByte = ImageToByteArraybyImageConverter(image);

            string base64 = Convert.ToBase64String(imageByte);

            return string.Format("data:image/png;base64,{0}", base64);
        }

        public FileResult Thumbnail2()
        {
            var w = 400;
            var h = 250;
            var filename = "Nekima.jpg";
            string filepath = Path.Combine(Server.MapPath("~/images"), filename);

            var resizer = new ImageResizer(filepath);
            var byteArray2 = resizer.Resize(400, 250, true, ImageEncoding.Png);

            return File(byteArray2, "image/png", "test.png");
        }

        public FileResult Thumbnail3()
        {
            var w = 400;
            var h = 250;

            var webClient = new WebClient();
            byte[] imageBytes = webClient.DownloadData("https://scontent-a-sin.xx.fbcdn.net/hphotos-xpa1/t1.0-9/10525577_585183238256684_8194723171280670862_n.jpg");

            var resizer = new ImageResizer(imageBytes);
            var byteArray2 = resizer.Resize(400, 250, true, ImageEncoding.Png);

            return File(byteArray2, "image/png", "test.png");
        }

        private static byte[] ImageToByteArraybyImageConverter(System.Drawing.Image image)
        {
            var imageConverter = new ImageConverter();
            byte[] imageByte = (byte[])imageConverter.ConvertTo(image, typeof(byte[]));
            return imageByte;
        }

    }
}