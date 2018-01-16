using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using GladVinduer.Models;

namespace GladVinduer.Controllers
{
    public class ContactPageController : SurfaceController
    {
        // GET: ServicePage
        public ActionResult simpleContact()
        {
            return PartialView("_SimpleContactFrom", new SimpleFormModel());
        }
        [HttpPost]
        public ActionResult simpleContact(SimpleFormModel sfm)
        {
            string msgname = "msg" + DateTime.Now.ToString("yyMMddHHmm");
            var newmsg = Services.ContentService.CreateContent(msgname, CurrentPage.Id, "contactMessage", 0);
            newmsg.SetValue("contactFormName", sfm.Name);
            newmsg.SetValue("contactFormEmail", sfm.Email);
            newmsg.SetValue("contactFormMessage", sfm.Message);
            var status = Services.ContentService.SaveAndPublishWithStatus(newmsg);
            if (status.Success)
            {
                TempData["success"] = true;
            }
            else
            {
                TempData["success"] = false;
            }
            return RedirectToCurrentUmbracoPage();
        }
    }
}