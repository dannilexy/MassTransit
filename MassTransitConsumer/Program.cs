
using MassTransit;
using MassTransitConsumer.Consumers;
using MassTransitProducer.Consumers;

namespace MassTransitConsumer
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
            builder.Services.AddMassTransit(x =>
            {
                x.SetKebabCaseEndpointNameFormatter();

                //var entryAss = Assembly.GetEntryAssembly();
                //x.AddConsumers(entryAss);
                // elided...
                x.AddConsumer<ProductConsumer>();
                x.AddConsumer<TestConsumer>();

                x.UsingRabbitMq((context, cfg) =>
                {
                    cfg.Host("fly-01.rmq.cloudamqp.com", "pygypsvv", h =>
                    {
                        h.Username("pygypsvv");
                        h.Password("LBOKm0o8gWENmHw0zuVMMOVXDuOMS-am");
                    });

                    cfg.ConfigureEndpoints(context);
                });
            });

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