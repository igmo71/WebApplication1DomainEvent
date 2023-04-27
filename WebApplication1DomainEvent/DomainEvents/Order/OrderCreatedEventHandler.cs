namespace WebApplication1DomainEvent.DomainEvents.Order
{
    public class OrderCreatedEventHandler : DomainEvenHandler<OrderCreatedEvent>
    {
        public override Task HandleAsync(OrderCreatedEvent domainEvent)
        {
            Console.WriteLine("Order created");

            return Task.CompletedTask;
        }
    }
}