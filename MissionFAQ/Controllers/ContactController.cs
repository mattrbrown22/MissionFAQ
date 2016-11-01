using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionFAQ.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.DropDownValues = new SelectList(new[] { "I want to help Mission Accomplished :)", "I found a problem on your site :O", "I want to donate!" });
            return View();
        }
	}
}