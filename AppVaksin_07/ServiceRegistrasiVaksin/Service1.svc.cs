using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceRegistrasiVaksin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        VaksinDBEntities vaksin_07 = new VaksinDBEntities();
        public bool InsertDataVaksin(Data_Vaksin dataVks)
        {
            
            Data_Vaksin newdataVaksin = new Data_Vaksin
            {
                no_register = dataVks.no_register,
                tanggal_dibuat = dataVks.tanggal_dibuat
            };
            vaksin_07.Data_Vaksin.Add(newdataVaksin);
            vaksin_07.SaveChanges();
            return true;

        }

        public bool UpdateDataVaksin(Data_Vaksin dataVks)
        {
           
            Data_Vaksin datavaksinlama = vaksin_07.Data_Vaksin.SingleOrDefault(x => x.no_register == dataVks.no_register);
            vaksin_07.SaveChanges();
            return true;
        }

        public bool DeleteDataVaksin(string dataVks)
        {
           
            Data_Vaksin datavaksinlama = vaksin_07.Data_Vaksin.SingleOrDefault(x => x.no_register == dataVks);
            vaksin_07.Data_Vaksin.Remove(datavaksinlama); ;
            return true;
        }

        List<Data_Vaksin> IService1.GetData_Vaksins()
        {
           
            var dataVaksin = from x in vaksin_07.Data_Vaksin select x;
            return dataVaksin.ToList<Data_Vaksin>();
        }
    }
}
