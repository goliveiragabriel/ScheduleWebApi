using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ScheduleWS.Models
{
    public class User
    {

        private String login;
        private String password;
        [Display(Name="User Login")]
        [Required]
        public String Login
        {
            get { return login; }
            set { login = value; }
        }
        [Display(Name = "User Password")]
        [Required]
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}