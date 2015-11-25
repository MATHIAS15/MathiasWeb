using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COREMODEL;

namespace MathiasWeb3.Controllers
{
    public class SettingsController : Controller
    {
        // GET: Settings
        public ActionResult Index()
        {
            USERS user = new USERS();

            return View();
        }
    }
}