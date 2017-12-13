using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [Required(ErrorMessage = "Please enter a value")]
        public int userID { get; set; }

        [Required(ErrorMessage = "Please enter a value")]
        public String userEmail { get; set; }

        [Required(ErrorMessage = "Please enter a value")]
        public String userPassword { get; set; }

        [Required(ErrorMessage = "Please enter a value")]
        public String userFirstName { get; set; }

        [Required(ErrorMessage = "Please enter a value")]
        public String userLastName { get; set; }
    }
}