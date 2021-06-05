using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace ServiceCekDataNik
{
    public class PendudukContext : DbContext
    {
        public DbSet<Data_Penduduk> Data_Penduduks { get; set; }
        public PendudukContext() : base("PendudukDataCS")
        {

        }
    }
}