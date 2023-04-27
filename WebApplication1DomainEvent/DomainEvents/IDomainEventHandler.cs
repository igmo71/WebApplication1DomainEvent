namespace WebApplication1DomainEvent.DomainEvents
{
    public interface IDomainEventHandler<T>
    {
        Task HandleAsync(IDomainEvent domainEvent);
    }
}