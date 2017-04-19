using ContactMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactMVC.Dal
{
    public class ContactDal : DbContext
    {
        public DbSet<ContactMessage> ContactMessages{ get; set; }
    }
}