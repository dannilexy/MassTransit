using MassTransit;

namespace MassTransitProducer.Consumers
{
    public interface IConsumers<in TMessage> :
    IConsumer
    where TMessage : class
    {
        Task Consume(ConsumeContext<TMessage> context);
    }
}
