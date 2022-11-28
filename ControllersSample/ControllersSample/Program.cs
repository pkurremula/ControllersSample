var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); //add all controller classes as services

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.UseRouting();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//});

app.MapControllers();

app.Run();
