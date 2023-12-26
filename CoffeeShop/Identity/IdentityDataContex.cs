
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop.Identity
{
    public class IdentityDataContex:IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContex() : base("dataConnection")
        {
            //Database.SetInitializer(new IdentityInitializer());
        }
    }
}