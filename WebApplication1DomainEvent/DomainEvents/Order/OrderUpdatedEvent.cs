namespace WebApplication1DomainEvent.DomainEvents.Order
{
    public class OrderUpdatedEvent: IDomainEvent
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }

        public OrderUpdatedEvent(Guid id)
        {
            Id = id;
            Timestamp = DateTime.Now;
        }
    }
}
