using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace GladVinduer.Controllers
{
    public class MasterController : RenderMvcController
    {
        // GET: Master
        public ActionResult Index()
        {
            return View();
        }
    }
}