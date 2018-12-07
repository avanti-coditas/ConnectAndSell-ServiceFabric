using System.ServiceModel;
using System.ServiceProcess;
using AppCommon;
using CasReportsImpl;
using WcfEngineService;

namespace HostWCFEngine
{
    public partial class Service1 : ServiceBase
    {
        internal static ServiceHost MyServiceHost;
        internal static ServiceHost MyServiceHost1;
        internal static ServiceHost MyServiceHost2;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // NOTE: Don't add any try catch here, let windows handle stuff. Why reinvent:)
            if (MyServiceHost != null)
            {
                MyServiceHost.Close();
                MyServiceHost1.Close();
                MyServiceHost2.Close();
            }
            MyServiceHost1 = new ServiceHost(typeof (DatalinkService));
            MyServiceHost1.Open();

            MyServiceHost2 = new ServiceHost(typeof (ReportsRunner));
            MyServiceHost2.Open();

            MyServiceHost = new ServiceHost(typeof (WCFEngineService));
            MyServiceHost.Open();
            EngineService service = new EngineService();
            service.LoadEngineService();
        }

        protected override void OnStop()
        {
            if (MyServiceHost != null)
            {
                Globals.Engine.Dispose();
                MyServiceHost.Close();
                MyServiceHost1.Close();
                MyServiceHost2.Close();
                MyServiceHost = null;
                MyServiceHost1 = null;
                MyServiceHost2 = null;
            }
        }
    }
}
