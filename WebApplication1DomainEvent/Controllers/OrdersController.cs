using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1DomainEvent.DomainEvents;
using WebApplication1DomainEvent.DomainEvents.Order;

namespace WebApplication1DomainEvent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IDomainEventService _domainEventService;

        public OrdersController(IDomainEventService domainEventService)
        {
            _domainEventService = domainEventService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrderAsync()
        {
            var orderId = Guid.NewGuid();
            var orderCreatedEvent = new OrderCreatedEvent(orderId);
            await _domainEventService.PublishAsync(orderCreatedEvent);

            return Ok(orderCreatedEvent);
        }

        [HttpPut("{orderId}")]
        public async Task<IActionResult> UpdateOrderAsync(Guid orderId)
        {
            var orderUpdatedEvent = new OrderUpdatedEvent(orderId);
            await _domainEventService.PublishAsync(orderUpdatedEvent);

            return NoContent();
        }
    }
}
