using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.Drawing;
using System.Drawing.Imaging;


//adicionado referência para MessagingToolkit.QRCode

namespace WebApplication2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap img =  encoder.Encode("www.teste.com.br");
            var path = Server.MapPath("~/Content/images/");
            img.Save(path +"imgQrCode.jpg", ImageFormat.Jpeg);
            return View();
        }
    }
}