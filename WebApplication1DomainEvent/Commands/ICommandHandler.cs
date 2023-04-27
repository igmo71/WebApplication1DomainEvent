namespace WebApplication1DomainEvent.Commands
{
    public interface ICommandHandler<TRequest, TResponse>
    {
        Task<TResponse> HandleAsync(TRequest request);
    }
}
