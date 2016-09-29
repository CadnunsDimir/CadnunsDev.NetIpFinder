using CadnunsDev.NetIpFinder.MSMQTests.AplicationLogic.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CadnunsDev.NetIpFinder.MSMQTests
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(MsmqService));
        }
    }
}
