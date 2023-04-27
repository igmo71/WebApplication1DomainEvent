namespace WebApplication1DomainEvent.DomainEvents
{
    public interface IDomainEventService
    {
        Task PublishAsync<T>(T domainEvent) where T: IDomainEvent;
    }
}