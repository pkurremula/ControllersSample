var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//middleware 1
app.Use(async (HttpContext context, RequestDelegate next) => {
   await context.Response.WriteAsync("Hello Prabhanjan");
   await next(context);
});

//middleware 2
app.Use(async (HttpContext context, RequestDelegate next) => {
    await context.Response.WriteAsync("\nHello Prabhanjan Prabhanjan");
    await next(context);
});

//middleware 3
app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("\nHello Prabhanjan Prabhanjan Prabhanjan");
});

app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("\nHello Prabhanjan Prabhanjan Prabhanjan");
});

app.Run();
