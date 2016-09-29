using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CadnunsDev.NetIpFinder.MSMQTests.AplicationLogic.Contracts
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract(IsOneWay = true)]
        void Process(string data);
    }
}
