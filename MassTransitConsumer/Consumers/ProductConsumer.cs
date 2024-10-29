using MassTransit;

namespace MassTransitProducer.Consumers
{
    public class ProductConsumer :
    IConsumer<Product>
    {
        public async Task Consume(ConsumeContext<Product> context)
        {
            var product = context.Message;
            await Task.CompletedTask;
        }
    }
}
