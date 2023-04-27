namespace WebApplication1DomainEvent.DomainEvents
{
    public class DomainEventService : IDomainEventService
    {
        private readonly IServiceProvider _serviceProvider;

        public DomainEventService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task PublishAsync<T>(T domainEvent) where T : IDomainEvent
        {
            var handlers = _serviceProvider.GetServices<IDomainEventHandler<T>>();
            foreach (var handler in handlers)
            {
                await handler.HandleAsync(domainEvent);
            }
        }
    }

}
