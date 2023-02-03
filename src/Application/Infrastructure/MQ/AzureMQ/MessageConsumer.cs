using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System.Text;

namespace Infrastructure.MQ.AzureMQ
{
    public class MessageConsumer<T> : BackgroundService, IMessageConsumer where T : class
    {
        private readonly ISubscriptionClient client;

        public MessageConsumer(ISubscriptionClient client)
        {
            this.client = client;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //TODO defin topics
            client.RegisterMessageHandler(async (msg, token) => {
                var message = JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(msg.Body));

                Console.WriteLine(message);

                await client.CompleteAsync(msg.SystemProperties.LockToken);
            }, new MessageHandlerOptions(atgs=> Task.CompletedTask));

            return Task.CompletedTask;
        }
    }
}
