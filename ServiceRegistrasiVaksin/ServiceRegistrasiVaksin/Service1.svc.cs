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
        public void DeleteVaksin(string id)
        {
            VaksinContext va = new VaksinContext();
            var d = (from vaksin in va.VaksinDatas
                     where vaksin.no_register == id
                     select vaksin).First();
            va.VaksinDatas.Remove(d);
            va.SaveChanges();
        }

        public IEnumerable<VaksinData> GetVaksin()
        {
            List<VaksinData> list = new List<VaksinData>();
            VaksinContext va = new VaksinContext();
            list = va.VaksinDatas.ToList();
            return list;
        }

        public void InsertVaksin(VaksinData obj)
        {    try
            {
                VaksinContext va = new VaksinContext();
                va.VaksinDatas.Add(obj);
                va.SaveChanges();
            }
            catch(Exception Ex)
            {
                throw new FaultException(Ex.ToString());
            }
        }

        public void UpdateVaksin(VaksinData obj)
        {
            VaksinContext va = new VaksinContext();
            var u = (from vaksin in va.VaksinDatas
                     where vaksin.no_register == obj.no_register
                     select vaksin).First();
            u.tanggal_dibuat = obj.tanggal_dibuat;
            va.SaveChanges();
        }
        public VaksinData GetDataById(string id)
        {
            VaksinContext va = new VaksinContext();
            var d = (from vaksin in va.VaksinDatas
                     where vaksin.no_register == id
                     select vaksin).First();
           return d;
        }

        public void GetData()
        {
            VaksinContext va = new VaksinContext();
            var konek = va.VaksinDatas;
            
        }
    }
}
