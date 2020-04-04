using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneBook.WebUI.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Lütfen bu alanı doldurunuz")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Lütfen bu alanı doldurunuz")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}