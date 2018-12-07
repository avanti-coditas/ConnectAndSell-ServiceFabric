using System;
using System.Collections.Generic;
using System.Fabric;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Communication.Wcf.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;

namespace AgentService
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class AgentService : StatelessService
    {
        internal static ServiceHost MyServiceHost;
        internal static ServiceHost MyServiceHost1;
       // internal static ServiceHost MyServiceHost2;

        public AgentService(StatelessServiceContext context)
            : base(context)
        { }

        /// <summary>
        /// Optional override to create listeners (e.g., TCP, HTTP) for this service replica to handle client or user requests.
        /// </summary>
        /// <returns>A collection of listeners.</returns>
        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners()
        {
            //const int bufferSize = 512000; //500KB
            //NetTcpBinding binding = new NetTcpBinding(SecurityMode.None)
            //{
            //    SendTimeout = TimeSpan.FromSeconds(30),
            //    ReceiveTimeout = TimeSpan.FromSeconds(30),
            //    CloseTimeout = TimeSpan.FromSeconds(30),
            //    MaxConnections = 1000,
            //    MaxReceivedMessageSize = bufferSize,
            //    MaxBufferSize = bufferSize,
            //    MaxBufferPoolSize = bufferSize * Environment.ProcessorCount,
            //};

            //string uri = "net.tcp://localhost:443/";
            //ServiceInstanceListener listener = new ServiceInstanceListener(context =>
            //        new WcfCommunicationListener<IWCFEngineService>(context, new WCFEngineService(), binding, new EndpointAddress(uri))
            //    );

            //return new[] {
            //    listener
            //};
            return new ServiceInstanceListener[0];
        }

        ///// <summary>
        ///// This is the main entry point for your service instance.
        ///// </summary>
        ///// <param name="cancellationToken">Canceled when Service Fabric needs to shut down this service instance.</param>
        protected override async Task RunAsync(CancellationToken cancellationToken)
        {
            long iterations = 0;

            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();

                ServiceEventSource.Current.ServiceMessage(this.Context, "Working-{0}", ++iterations);

                await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
            }
        }
    }
}
