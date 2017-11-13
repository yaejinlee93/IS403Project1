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

            var questions = new List<string>();
            var answers = new List<string>();
            questions.Add("How difficult is this mission?");
            answers.Add("Medium difficulty. When I was serving, I jalfjkdfslkjdfalksjdflaksf . . .");
            questions.Add("Question 2");
            answers.Add("Lorem ipsum dolor sit amet, consectetur adipiscing elit. In eu augue in tellus imperdiet venenatis. Maecenas consectetur iaculis ligula, eu fermentum magna iaculis sed. Quisque semper ipsum sit amet lectus posuere finibus. Aliquam ac efficitur leo. Phasellus nec justo purus. Vivamus congue aliquet ligula, in hendrerit dolor semper quis. Nullam pulvinar vestibulum hendrerit. Sed fermentum est in dolor aliquam tempor. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Praesent molestie et ipsum id semper.");
            questions.Add("Question 3");
            answers.Add("Answer 3");
            ViewBag.questions = questions;
            ViewBag.answers = answers;
            string demoid = "#demo";
            ViewBag.demoid = demoid;
            string demo = "demo";
            ViewBag.demo = demo;
            ViewBag.combined = "";

            return View();
        }
    }
}