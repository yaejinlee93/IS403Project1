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
        }

        public ActionResult ViewMission(string mission)
        {
            ViewBag.missionName = mission;
            if(mission == "Mission 1")
            {
                ViewBag.missionPresident = "";
                ViewBag.missionAddress = "";
                ViewBag.missionLanguage = "";
                ViewBag.missionClimate = "";
                ViewBag.missionReligion = "";
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