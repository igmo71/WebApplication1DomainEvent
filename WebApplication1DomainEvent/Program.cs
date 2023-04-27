
using WebApplication1DomainEvent.DomainEvents;
using WebApplication1DomainEvent.DomainEvents.Order;

namespace WebApplication1DomainEvent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IDomainEventService, DomainEventService>();
            //builder.Services.AddScoped<IOrderCreatedEventHandler, OrderCreatedEventHandler>();
            builder.Services.AddTransient<IDomainEventHandler<OrderCreatedEvent>, OrderCreatedEventHandler>();
            builder.Services.AddTransient<IDomainEventHandler<OrderUpdatedEvent>, OrderUpdatedEventHandler>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}