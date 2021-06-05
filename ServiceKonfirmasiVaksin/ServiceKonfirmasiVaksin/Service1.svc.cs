using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceKonfirmasiVaksin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public void InsertLaporan(Data_Pasien obj)
        {
            PasienContext va = new PasienContext();
            va.data_Pasiens.Add(obj);
            va.SaveChanges();
        }
        public IEnumerable<Data_Pasien> GetPasien()
        {
            List<Data_Pasien> list = new List<Data_Pasien>();
            PasienContext va = new PasienContext();
            list = va.data_Pasiens.ToList();
            return list;
        }
    }
}
