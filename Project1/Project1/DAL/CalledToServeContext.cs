using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project1.Models;
using System.Data.Entity;

namespace Project1.DAL
{
    public class CalledToServeContext : DbContext
    {
        public CalledToServeContext() : base("CalledToServeContext")
        {

        }

        public DbSet<Missions> Mission { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<MissionQuestions> MissionQuestion { get; set; }
    }
}