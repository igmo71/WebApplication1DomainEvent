namespace WebApplication1DomainEvent.DomainEvents
{
    public abstract class DomainEvenHandler<T> : IDomainEventHandler<T> where T : IDomainEvent
    {
        public abstract Task HandleAsync(T domainEvent);

        public virtual async Task HandleAsync(IDomainEvent domainEvent)
        {
            await HandleAsync((T)domainEvent);
        }
    }
}
