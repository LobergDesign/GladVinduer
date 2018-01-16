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
        public ActionResult simpleContact(SimpleFormModel model)
        {
           
            if (ModelState.IsValid)
            {
                string msgname = "msg" + DateTime.Now.ToString("yyMMddHHmm");
                var newmsg = Services.ContentService.CreateContent(msgname, CurrentPage.Id, "contactMessage", 0);
                newmsg.SetValue("contactFormName", model.Name);
                newmsg.SetValue("contactFormFirm", model.Firm);
                newmsg.SetValue("contactFormEmail", model.Email);
                newmsg.SetValue("contactFormMessage", model.Message);
                var status = Services.ContentService.SaveAndPublishWithStatus(newmsg);
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