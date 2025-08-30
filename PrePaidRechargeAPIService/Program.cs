using Serilog;
using PrePaidRechargeAPIService.PrePaidBussinessLogic.Interface;
using PrePaidRechargeAPIService.PrePaidBussinessLogic.PrePaidImpl;
using PrePaidRechargeAPIService.ClientService.Interface;
using PrePaidRechargeAPIService.ClientService.ClientImpl;

namespace PrePaidRechargeAPIService;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();
        builder.Services.AddSwaggerGen();
        builder.Services.AddTransient<IPrepaidBL,PrepaidBLImpl>();
        builder.Services.AddTransient<IClientService,PrePaidHttpClientImpl>();

        // Configure Serilog
        Log.Logger = new LoggerConfiguration()
        .WriteTo.Console() // Writes logs to the console
        .CreateLogger();

        builder.Host.UseSerilog();
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            //app.MapOpenApi();
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
