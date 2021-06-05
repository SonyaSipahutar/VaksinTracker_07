using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceRegistrasiVaksin
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<VaksinData> GetVaksin();
        [OperationContract]
        void InsertVaksin(VaksinData obj);
        [OperationContract]
        void UpdateVaksin(VaksinData obj);
        [OperationContract]
        void DeleteVaksin(string id);
        [OperationContract]
        VaksinData GetDataById(string id);
        [OperationContract]
        void GetData();
    }
    [DataContract]
    public class VaksinData
    {
        [DataMember]
        [Key]
        [Required]
        public string no_register { get; set; }
        [DataMember]
        [Required]
        public System.DateTime tanggal_dibuat { get; set; }
    }
}
