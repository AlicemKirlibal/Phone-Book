using Microsoft.AspNet.Identity.EntityFramework;
using PhoneBook.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBook.WebUI.Identity
{
    public class IdentityDataContext:IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext():base("phonebookDb")
        {
          
        }
    }
}