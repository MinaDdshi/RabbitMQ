namespace Company.Consumers
{
    using System.Threading.Tasks;
    using MassTransit;
    using Contracts;
    using Microsoft.Extensions.Logging;

    public class RabbitMQConsumer :
        IConsumer<Message>
    {
        readonly ILogger<RabbitMQConsumer> _logger;

        public RabbitMQConsumer(ILogger<RabbitMQConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<Message> context)
        {
            _logger.LogInformation("Received Text: {Text}", context.Message.Text);

            return Task.CompletedTask;
        }
    }
}