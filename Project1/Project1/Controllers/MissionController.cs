﻿using System;
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
                ViewBag.missionFlag = "Flag of South Korea";
                ViewBag.missionImage = "/Content/images/korea.png";
            }
            else if(mission == "Russia Rostov-na-Donu")
            {
                ViewBag.missionPresident = "President Miner";
                ViewBag.missionAddress = "";
                ViewBag.missionLanguage = "Russian";
                ViewBag.missionClimate = "Humid Continental Climate";
                ViewBag.missionReligion = "Russian Orthodox";
                ViewBag.missionFlag = "Flag of Russia (three stripes)";
                ViewBag.missionImage = "/Content/images/russia.png";
            }
            else if(mission == "Ohio Cincinnati")
            {
                ViewBag.missionPresident = "President Porter";
                ViewBag.missionAddress = "4610 N Bend Rd Cincinnati, Ohio 45211 - 1824 United States";
                ViewBag.missionLanguage = "English";
                ViewBag.missionClimate = "Humid hot summer, humid cold winters";
                ViewBag.missionReligion = "Christianity";
                ViewBag.missionFlag = "State Flag of Ohio";
                ViewBag.missionImage = "/Content/images/ohio.png";
            }
            return View();
        }
    }
}