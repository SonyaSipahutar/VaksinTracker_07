using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ServiceKonfirmasiVaksin
{
    public class PasienContext : DbContext
    {
        public DbSet<Data_Pasien> data_Pasiens { get; set; }
        public PasienContext() : base("PasienDataCS")
        {

        }
    }
}