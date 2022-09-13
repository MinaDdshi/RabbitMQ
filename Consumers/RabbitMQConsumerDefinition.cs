namespace Company.Consumers
{
    using MassTransit;

    public class RabbitMQConsumerDefinition :
        ConsumerDefinition<RabbitMQConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<RabbitMQConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}