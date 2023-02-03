using Microsoft.Azure.ServiceBus;
using System.Text;

namespace Infrastructure.MQ.AzureMQ
{
    public class MessagePublisher : IMessagePublisher
    {
        public IQueueClient QueueClient { get; }

        public MessagePublisher(IQueueClient queueClient)
        {
            QueueClient = queueClient;
        }


        public Task Publish<T>(T message)
        {
            //TODO implement generic publish

            throw new NotImplementedException();
        }

        public async Task Publish(string raw)
        {
           var message = new Message(Encoding.UTF8.GetBytes(raw));
            
           await QueueClient.SendAsync(message);
        }
    }
}
