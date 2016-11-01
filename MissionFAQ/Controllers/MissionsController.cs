using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionFAQ.Controllers
{
    public class MissionsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MapView()
        {
            return View();
        }
        public ActionResult MapView1()
        {
            return View();
        }
        public ActionResult MapView2()
        {
            return View();
        }
        public ActionResult MissionView(String MissionName)
        {
            switch (MissionName)
            {
                case "Busan, Korea":
                    ViewBag.MissionName = MissionName;
                    ViewBag.presidentname = "President Kenneth Barrow";
                    ViewBag.missionaddress = "Busan GuangDong Si";
                    ViewBag.language = "Korean";
                    ViewBag.climate = "temperate climate with four distinct seasons.";
                    ViewBag.dominantreligion = "Buddhism with about 23% of the population claiming that as opposed to nearly 45% who claim no religion.";
                    ViewBag.Flag = "KoreanFlag.bmp";
                    ViewBag.PresidentPic = "President Barrow.png";
                    ViewBag.ClimatePic = "Busan.jpg";
                    break;

                case "Anaheim, California":
                    ViewBag.MissionName = MissionName;
                    ViewBag.presidentname = "President Bradford Bowen";
                    ViewBag.missionaddress = "2500 N Bristol St, Santa Ana CA 92683";
                    ViewBag.language = "English/Vietnamese";
                    ViewBag.climate = "temperate climate with warm winters and hot summers.";
                    ViewBag.dominantreligion = "Catholicism with 28% claiming to be catholic.";
                    ViewBag.Flag = "CaliforniaFlag.bmp";
                    ViewBag.PresidentPic = "President Bradford Bowen.jpg";
                    ViewBag.ClimatePic = "Anaheim.bmp";
                    ViewBag.Lat = "33.835293" ;
                    ViewBag.Long = "-117.914504";
                    break;
                case "Veracruz, Mexico":
                    ViewBag.MissionName = MissionName;
                    ViewBag.presidentname = "President Trevino";
                    ViewBag.missionaddress = "27 altimirano entre primero de mayo y carranza Veracruz Mexico";
                    ViewBag.language = "Spanish";
                    ViewBag.climate = "generally warm and humid climate that is maintained because the warm waters of the Gulf of Mexico.";
                    ViewBag.dominantreligion = "Roman Catholic with an estimated 83% identifying as this religion.";
                    ViewBag.Flag = "MexicanFlag.bmp";
                    ViewBag.PresidentPic = "President Trevino.jpg";
                    ViewBag.ClimatePic = "Veracruz.jpg";
                    ViewBag.Lat = "19.173773";
                    ViewBag.Long = "-96134224";
                    
                    break;

            }
            return View("MissionView");
        }
    }
}