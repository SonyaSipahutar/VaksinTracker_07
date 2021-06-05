using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceCekDataNik
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public IEnumerable<Data_Penduduk> GetNik()
        {
            List<Data_Penduduk> list = new List<Data_Penduduk>();
            PendudukContext va = new PendudukContext();
            list = va.Data_Penduduks.ToList();
            return list;
        }
        public bool CekNik(string search)
        {
            List<Data_Penduduk> li = GetNik().ToList();
            if (!String.IsNullOrEmpty(search))
            {
                li = li.Where(n => n.nik.Contains(search)).Select(n => new Data_Penduduk
                {
                    id = n.id,
                    nik = n.nik,
                    nama = n.nama,
                    alamat = n.alamat,
                    jenis_kelamin = n.jenis_kelamin
                }).ToList();
                if (li.Any(n=>n.nik!=null))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

    }
}
