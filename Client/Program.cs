using ServiceContracts;
using Microsoft.ServiceFabric.Services.Client;
using Microsoft.ServiceFabric.Services.Communication.Client;
using Microsoft.ServiceFabric.Services.Communication.Wcf;
using Microsoft.ServiceFabric.Services.Communication.Wcf.Client;
using System;
using System.ServiceModel.Channels;

namespace Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create binding
            Binding binding = WcfUtility.CreateTcpClientBinding();

            // Create a partition resolver
            IServicePartitionResolver partitionResolver = ServicePartitionResolver.GetDefault();

            ServicePartitionResolver servicePartitionResolver = new ServicePartitionResolver();

            // create a  WcfCommunicationClientFactory object.
            var wcfClientFactory = new WcfCommunicationClientFactory<IWCFEngineService>
                (clientBinding: binding, servicePartitionResolver: servicePartitionResolver);

            Uri ServiceUri = new Uri("net.tcp://localhost:443/");
          
            var agentServiceCommunicationClient = new WcfCommunicationClient(
                            wcfClientFactory,
                            ServiceUri,
                            ServicePartitionKey.Singleton);

            //
            // Call the service to perform the operation.
            //
            try
            {
                var result = agentServiceCommunicationClient.InvokeWithRetry(
                                client => client.Channel.DoCommandLineLogin("Username", "Pasword", "AppName", "Appversion", "Dotnetversion", "TimeZoneId", "ChannelId", true));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadKey();
        }
    }

    public class WcfCommunicationClient : ServicePartitionClient<WcfCommunicationClient<IWCFEngineService>>
    {
        public WcfCommunicationClient(ICommunicationClientFactory<WcfCommunicationClient<IWCFEngineService>> communicationClientFactory, Uri serviceUri, ServicePartitionKey partitionKey = null, TargetReplicaSelector targetReplicaSelector = TargetReplicaSelector.Default, string listenerName = null, OperationRetrySettings retrySettings = null)
            : base(communicationClientFactory, serviceUri, partitionKey, targetReplicaSelector, listenerName, retrySettings)
        {
        }
    }
}
