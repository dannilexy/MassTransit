using MassTransit;

namespace MassTransitConsumer.Consumers
{
    public class TestConsumer : IConsumer<SigningRequestCompletionMessageModel>
    {
        public Task Consume(ConsumeContext<SigningRequestCompletionMessageModel> context)
        {
            var message = context.Message;
            return Task.CompletedTask;
        }
    }
}
