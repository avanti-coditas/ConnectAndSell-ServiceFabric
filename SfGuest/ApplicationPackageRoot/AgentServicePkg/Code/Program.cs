using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace HostWCFEngine
{
    static class Program
    {
        internal static ServiceHost MyServiceHost;
        internal static ServiceHost MyServiceHost1;
        internal static ServiceHost MyServiceHost2;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            var service = new Service1();

            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[] 
            //{ 
            //    new Service1() 
            //};
            //ServiceBase.Run(ServicesToRun);

            if (MyServiceHost != null)
            {
                MyServiceHost.Close();
                MyServiceHost1.Close();
                MyServiceHost2.Close();
            }
            MyServiceHost1 = new ServiceHost(typeof(DatalinkService));
            MyServiceHost1.Open();

            MyServiceHost2 = new ServiceHost(typeof(ReportsRunner));
            MyServiceHost2.Open();

            MyServiceHost = new ServiceHost(typeof(WCFEngineService));
            MyServiceHost.Open();
            EngineService service = new EngineService();
            service.LoadEngineService();

            Console.WriteLine("Hello");
        }
    }
}
