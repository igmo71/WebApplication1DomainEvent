namespace WebApplication1DomainEvent.DomainEvents.Order
{
    public class OrderCreatedEvent : IDomainEvent
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }

        public OrderCreatedEvent(Guid id)
        {
            Id = id;
            Timestamp = DateTime.Now;
        }
    }
}
