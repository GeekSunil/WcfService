using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ServiceHostProject
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host=new ServiceHost(typeof(WcfFirstService.MessageService)))
            {
                host.Open();
                Console.WriteLine("Message Service is working :" + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
