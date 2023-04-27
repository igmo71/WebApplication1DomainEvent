namespace WebApplication1DomainEvent.DomainEvents.Order
{
    public class OrderUpdatedEventHandler : DomainEvenHandler<OrderUpdatedEvent>
    {
        public override Task HandleAsync(OrderUpdatedEvent domainEvent)
        {
            Console.WriteLine("Order updated");

            return Task.CompletedTask;
        }
    }
}
