namespace Infrastructure.MQ.AzureMQ
{
    public interface IMessagePublisher
    {
        public Task Publish<T>(T message);

        public Task Publish(string raw);
    }
}