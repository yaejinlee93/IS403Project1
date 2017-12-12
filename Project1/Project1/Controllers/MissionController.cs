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
                ViewBag.missionClimate = "Moist";
                ViewBag.missionReligion = "Christianity, Buddhism";
                ViewBag.missionFlag = "Flag of South Korea";
                ViewBag.missionImage = "/Content/images/korea.png";
            }
            else if(mission == "Russia Rostov-na-Donu")
            {
                ViewBag.missionPresident = "President Miner";
                ViewBag.missionAddress = "per Semashko 117 V Rostov - na - Donu Rostov oblast 344018";
                ViewBag.missionLanguage = "Russian";
                ViewBag.missionClimate = "Humid Continental Climate";
                ViewBag.missionReligion = "Russian Orthodox";
                ViewBag.missionFlag = "Flag of Russia (three stripes)";
                ViewBag.missionImage = "/Content/images/russia.png";
            }
            else if(mission == "Ohio Cincinnati")
            {
                ViewBag.missionPresident = "President Porter";
                ViewBag.missionAddress = "4610 N Bend Rd Cincinnati, Ohio United States of America";
                ViewBag.missionLanguage = "English";
                ViewBag.missionClimate = "Humid hot summer, humid cold winters";
                ViewBag.missionReligion = "Christianity";
                ViewBag.missionFlag = "State Flag of Ohio";
                ViewBag.missionImage = "/Content/images/ohio.png";
            }

            var questions = new List<string>();
            var answers = new List<string>();
            questions.Add("What blessings did you receive from serving a mission?");
            answers.Add("COUNTLESS blessings. I will share just two: 1. My conversion was deepened as I was able to help others become converted. My testimony has become knowledge and it’s unshakable. 2. Half way through my mission, I was directed to transfer to BYU for school. Since arriving at school, I have met the young man that I am going to be sealed to for time and eternity. I don’t know if I would have met him without serving a mission.");
            questions.Add("What was a crazy experience?");
            answers.Add("We had a return appointment with a kid we met on the streets in the projects. We were already running late and when we got there. When we got off the bus, there were cops and news vans all over. Come to find out the kid we had an appointment with was standing next to his buddy when there was a drive by shooting and it hit his buddy. If we weren’t late, we would have been right there when it happened.");
            questions.Add("What was a spiritual experience?");
            answers.Add("When you feel you are merely a vessel to bring the Spirit into others homes and the Holy Ghost is witnessing with you. Despite whatever challenges, the investigator can’t deny it in that moment and you’re all amazed at how strong God’s presence is. No matter what challenges they face in the future, they can’t deny that day! They all committed to baptism that day, after months of being taught, mom pulled out the calendar to look at a date. From that point on they kept commitments! The dad said, “You have been begging us to read for months. We finally did it and it feels great.” He became a different man and father. For the first time in months, there was no yelling when we walked up to their trailer and the Spirit was already there when we arrived because they had been preparing.");
            ViewBag.questions = questions;
            ViewBag.answers = answers;
            string demoid = "#demo";
            ViewBag.demoid = demoid;
            string demo = "demo";
            ViewBag.demo = demo;
            ViewBag.combined = "";

            return View();
        }

        [Authorize]
        public ActionResult ViewFAQ(string mission)
        {
            IEnumerable<MissionQuestions> faq = null;
            if(mission != null || mission != "")
            {
                faq = db.Database.SqlQuery<MissionQuestions>("SELECT * FROM MissionQuestions WHERE missionName = '" + mission + "';");
            }
            return View(faq);
        }
    }
}