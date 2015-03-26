using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SharpieTwitHer.Models
{
    public class IndentityUserExtra
    {

        public int ID { get; set; }
        public virtual ApplicationUser User { get; set; }
        
    }

}