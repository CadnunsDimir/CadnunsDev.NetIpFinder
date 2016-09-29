using CadnunsDev.NetIpFinder.MSMQTests.AplicationLogic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadnunsDev.NetIpFinder.MSMQTests.AplicationLogic.Implementation
{
    
    public class MsmqService : IService
    {
        public void Process(string data)
        {
            Console.WriteLine(string.Format("Process {0} at {1}", data, DateTime.Now));
        }
    }
}
