using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceRegistrasiVaksin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json)]

        [OperationContract]

        List<Data_Vaksin> GetData_Vaksins();

        [OperationContract]
        bool InsertDataVaksin(Data_Vaksin dataVks);

        [OperationContract]
        bool UpdateDataVaksin(Data_Vaksin dataVks);

        [OperationContract]
        bool DeleteDataVaksin(string dataVks);

        // TODO: Add your service operations here
    }

}
