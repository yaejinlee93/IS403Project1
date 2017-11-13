using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSiteProject.Controllers
{
    public class MissionController : Controller
    {
        // GET: Mission
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Missions()
        {
            return View();
            //herro
        }

        public ActionResult ViewMission(string mission)
        {
            ViewBag.missionName = mission;
            if(mission == "Korea Daejeon")
            {
                ViewBag.missionPresident = "President Shin";
                ViewBag.missionAddress = "Korea Daejeon Mission, Daejeon PO Box 38, Daejeon - si, Chungcheong - namdo 300836, South Korea";
                ViewBag.missionLanguage = "Korean";
                ViewBag.missionClimate = "";
                ViewBag.missionReligion = "Christianity, Buddhism";
                ViewBag.missionFlag = "";
            }
            else if(mission == "Mission 2")
            {
                ViewBag.missionPresident = "";
                ViewBag.missionAddress = "";
                ViewBag.missionLanguage = "";
                ViewBag.missionClimate = "";
                ViewBag.missionReligion = "";
                ViewBag.missionFlag = "";
            }
            else if(mission == "Mission 3")
            {
                ViewBag.missionPresident = "";
                ViewBag.missionAddress = "";
                ViewBag.missionLanguage = "";
                ViewBag.missionClimate = "";
                ViewBag.missionReligion = "";
                ViewBag.missionFlag = "";
            }
            return View();
        }
    }
}