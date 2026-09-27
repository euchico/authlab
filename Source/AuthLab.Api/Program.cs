namespace AuthLab.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddOpenApi();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();

        app.MapGet("/api/public", () =>
        {
            return Results.Ok(new
            {
                message = "Endpoint Público"
            });
        });

        app.Run();
    }
}
