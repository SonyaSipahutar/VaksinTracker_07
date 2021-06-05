using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ServiceRegistrasiVaksin
{
    public class VaksinContext : DbContext
    {

        public DbSet<VaksinData> VaksinDatas { get; set; }
        public VaksinContext() : base("VaksinDataCS")
        {

        }
    }
}